using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HXApiCS;


namespace HXApiTesterCS
{
    /*
     * 
     * 
     * 
     화면 소개
          
     - HX 제어기에 연결하기
     * 
     * 1) HX 20 API
     *  Hx20Api.Initialize(0);
     *  Connect(CONNECT PORT, IP ADDRESS1, IP ADDRESS2, IP ADDRESS3, IP ADDRESS4, PORT);
     *  (Hx20Api 경우 initialize한 다음에 connect를 해줘야함)
     *  (CONNECT PORT 는 0임)
     *  (Initialize 반환값은 INT형으로 1아묜 정상 연결, 그 외 오류)
     *  (Connect 반환값은 BOOL형으로 TRUE면 연결 성공, FALSE면 연결 실패)
     
     * 2) HX API
     * HXApi.HXInitialize(COMTYPE, IP ADDRESS1, IP ADDRESS2, IP ADDRESS3, IP ADDRESS4, PORT);
     * (HXApi경우 initialize와 connect를 한꺼번에 실행함)
     * (반환 값은 INT형으로 1이면 연결 성공, 그 외 연결 실패)
      
        
      
     - 연결 확인하기
     * 
     * 1) HX 20 API
     * GetConnectState();
     * (반환 값은 BOOL형으로 TRUE인 경우 정상 연결중. FALSE면 연결X)
     * 
     * * 2)HXApi
     * HXApi.HXConnectState();
     * (반환 값은 INT형으로 1이면 정상 연결중. 그 외 오류)
       
     
      
     - 알람 메시지 API
     *
     * 1) HX 20 API 
     * GetAlarmCode(INT ARRAY);
     * (INT ARRAY 는 ALARM CODE를 담을 변수)
     
     * 2) HXApi
     * HXApi.HXGetString((int)HXMap.HX_STR_OPMSG, BYTE ARRAY);                    
     * (BYTE ARRAY는 메시지를 담을 변수)

  
     
     */



    public partial class Base_Form : Form
    {

        // 화면
        enum enScreen
        {
            BTN_MOTION
                , BTN_IO
                , BTN_NCLIST
                , BTN_64BIT_TEST

                , TOTAL
        }


        // 연결 API종류
        enum enConnType
        {
            DISCONNECT = -1
              , HX_20_API = 0
              , HX_API 
              , 

        }

        Dialog_Connection m_Dialog_Conn = new Dialog_Connection();


        // 2019-12-09
        // 64비트에서는 디자이너폼에서 유저컨트롤이 제대로 로드 안 됨
        // 코드에서 생성해야함
        scr_MapTest mScrMapTest = new scr_MapTest();
        scr_Info mScrInfor = new scr_Info();
        scr_IO mScrIO_x = new scr_IO();
        scr_IO mScrIO_y = new scr_IO();
        scr_Motion mScrMotion = new scr_Motion();
        scr_NCList mScrNCList = new scr_NCList();




        enConnType mConnType ;
        bool mIsConn = false;

        Hx20Api m_api_20;


        public Base_Form()
        {
            InitializeComponent();
            
            initControls();

            this.VisibleChanged += visibleChanged;
            m_Dialog_Conn.VisibleChanged += dialogVisibleChanged;
        }

        private void visibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                timer.Start();
            }
        }



        private void initControls()
        {

            //2019-12-09
            mScrMapTest.Parent = this.panel_scr;
            mScrMapTest.Location = new Point(0, 0);

            mScrInfor.Parent = this.panel_scr;
            mScrInfor.Location = new Point(447, 0);

            mScrIO_x.Parent = this.panel_scr;
            mScrIO_x.Location = new Point(0, 0);

            mScrIO_y.Parent = this.panel_scr;
            mScrIO_y.Location = new Point(447, 0);

            mScrMotion.Parent = this.panel_scr;
            mScrMotion.Location = new Point(0,0);

            mScrNCList.Parent = this.panel_scr;
            mScrNCList.Location = new Point(0, 0);




            lb_title.Text = "Setup-Motion (Motion 5 Axis)";
            changeScreens((int)enScreen.BTN_MOTION);


            mScrIO_x.setMapName("X 0.");
            mScrIO_y.setMapName("Y 0.");

            mConnType = enConnType.DISCONNECT;
        
            
            // 연결 API 타입 정하기
            mConnType = enConnType.HX_20_API;
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // time update
            DateTime dt = DateTime.Now;

            lb_time.Text = dt.Year + "-" 
                + dt.Month + "-" 
                + dt.Day + "  "
                + dt.Hour.ToString("00") + ":"
                + dt.Minute.ToString("00") + ":"
                + dt.Second.ToString("00");



            // message update 
            if (!mIsConn)
                return;

            string msg = "";

            if (mConnType == enConnType.HX_API)
            {                              

                // OP 메시지 가져오기

                // 알람 메시지를 담아오는 변수                
                byte[] bmsg = new byte[255]; 

                // API사용으로 OP 메시지 가져오기
                HXApi.HXGetString((int)HXMap.HX_STR_OPMSG, bmsg);                
                
                // 메시지 인코딩하기
                msg = System.Text.Encoding.Default.GetString(bmsg);

                lb_message.Text = msg;


                // 연결상태 확인
                int value = HXApi.HXConnectState();
                if (value == 1)
                {
                    mIsConn = true;
                    setTextConnStatus(true);
                }
                else
                {
                    mIsConn = false;
                    setTextConnStatus(false);
                }


            }
            else if (mConnType == enConnType.HX_20_API)
            {
                // OP 메시지 가져오기
                int[] msg_arr = new int[255];
                m_api_20.GetAlarmCode(msg_arr);

                lb_message.Text = msg_arr[0].ToString();




                // 연결 상태 확인
                bool check = m_api_20.GetConnectState();
                if (check)
                {
                    mIsConn = true;
                    setTextConnStatus(true);
                }
                else
                {
                    mIsConn = false;
                    setTextConnStatus(false);
                }


            }


        }

        private void setTextConnStatus(bool check)
        {
            string text = lb_connect.Text;
            if (check)
            {
                if (text == "연결 됨")
                    return;

                lb_connect.Text = "연결 됨";
            }
            else
            {
                if (text == "연결 안 됨")
                    return;

                lb_connect.Text = "연결 안 됨";

            }
        }



        private void dialogVisibleChanged(object sender, EventArgs e)
        {
            if (m_Dialog_Conn.Visible)
                return;

            if (!m_Dialog_Conn.bOK)
                return;


            string ip_addr = m_Dialog_Conn.IP_Address;
            int port = m_Dialog_Conn.PORT_Number;

            int[] iArr = new int[4];
            string[] sArr = new string[4];
            sArr = ip_addr.Split('.');

            for(int i =0; i<4; i++)
            {
                int.TryParse(sArr[i], out iArr[i]);                
            }

            // 연결하기
            if (mConnType == enConnType.HX_API)
            {
                int check = HXApi.HXInitialize(0, iArr[0], iArr[1], iArr[2], iArr[3], port);
                if (check != 1)
                {
                    MessageBox.Show("연결에 실패했습니다.");
                    return;
                }
                else if (check == 1)
                {
                    MessageBox.Show("연결하였습니다.");
                    mIsConn = true;
                }
            }
            else if(mConnType == enConnType.HX_20_API)
            {
                int init =  Hx20Api.Initialize(0);

                if (init != 1)
                {
                    MessageBox.Show("이니셜라이즈에 실패했습니다.");
                    return;
                }                    

                m_api_20 = new Hx20Api();
                bool check = m_api_20.Connect(0, iArr[0], iArr[1], iArr[2], iArr[3], port);

                if (!check)
                {
                    MessageBox.Show("연결에 실패했습니다.");
                    return;
                }
                else if (check)
                {
                    mScrInfor.setApi_20(m_api_20);
                    mScrMotion.setApi_20(m_api_20);
                    mScrIO_x.setApi_20(m_api_20);
                    mScrIO_y.setApi_20(m_api_20);
                    mScrNCList.setApi_20(m_api_20);
                    mScrMapTest.setApi_20(m_api_20);

                    MessageBox.Show("연결하였습니다.");
                    mIsConn = true;
                }
            }
            


            int iConnType = -1;
            
            if(mConnType == enConnType.HX_API)
            {
                iConnType = 1;
            }
            else if(mConnType == enConnType.HX_20_API)
            {
                iConnType = 0;
            }

            mScrInfor.setConnType(iConnType);
            mScrMotion.setConnType(iConnType);
            mScrIO_x.setConnType(iConnType);
            mScrIO_y.setConnType(iConnType);
            mScrNCList.setConnType(iConnType);
            mScrMapTest.setConnType(iConnType);

            lb_connect.Text = "연결 됨";

        }


    

        private void changeScreens(int scr)
        {
            switch(scr)
            {
                case (int)enScreen.BTN_MOTION:
                    mScrMotion.Show();
                    mScrInfor.Show();
                    mScrIO_x.Hide();
                    mScrIO_y.Hide();
                    mScrNCList.Hide();
                    mScrMapTest.Hide();
                    break;

                case (int)enScreen.BTN_IO:
                    mScrMotion.Hide();
                    mScrInfor.Hide();
                    mScrIO_x.Show();
                    mScrIO_y.Show();
                    mScrNCList.Hide();
                    mScrMapTest.Hide();
                    break;

                case (int)enScreen.BTN_NCLIST:
                    mScrMotion.Hide();
                    mScrInfor.Hide();
                    mScrIO_x.Hide();
                    mScrIO_y.Hide();
                    mScrNCList.Show();
                    mScrMapTest.Hide();
                    break;


                case (int)enScreen.BTN_64BIT_TEST:
                    mScrMotion.Hide();
                    mScrInfor.Hide();
                    mScrIO_x.Hide();
                    mScrIO_y.Hide();
                    mScrNCList.Hide();
                    mScrMapTest.Show();

                    break;
            }
        }

        private void Base_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mIsConn)
                return;

            if (mConnType == enConnType.HX_API)
            {
                int check = HXApi.HXConnectState();
                if(check ==1)
                {
                    HXApi.HXTerminate();
                }
            }
            else if (mConnType == enConnType.HX_20_API)
            {
                bool bcheck = m_api_20.GetConnectState();
                if(bcheck)
                {
                    m_api_20.Disconnect();
                }
            }




        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (mIsConn)
                return;

            m_Dialog_Conn.ShowDialog();
        }

        private void btn_motion_Click(object sender, EventArgs e)
        {

            changeScreens((int)enScreen.BTN_MOTION);
        }

        private void btn_io_Click(object sender, EventArgs e)
        {

            changeScreens((int)enScreen.BTN_IO);
        }

        private void btn_nclist_Click(object sender, EventArgs e)
        {

            changeScreens((int)enScreen.BTN_NCLIST);
        }

        private void btn_maptest_Click(object sender, EventArgs e)
        {
            changeScreens((int)enScreen.BTN_64BIT_TEST);
        }


 
    }
}
