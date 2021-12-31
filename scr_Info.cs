using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HXApiCS;

namespace HXApiTesterCS
{
    public partial class scr_Info : UserControl
    {

        /*

         * - 주요 기능 -
         * 축 선택
         * 축 별 파라메터 값 모니터링 및 값 저장하기
          
          
         - Register 값 가져오기
         1) HX 20 API
            * PM맵 값 가져오기
         * GetPMF(ADDRESS);
         * (반환 값은 DOUBLE형)
       
            * PU맵 값 가져오기 
         * GetPUF(ADDRESS);
         * (반환 값은 DOUBLE형임)
           
                   
         2) HX API                
            * PM맵 값 가져오기
         * HXApi.HXGetRegister64(HXMap.HX_PM, ADDRESS);
         * (반환 값은 DOUBLE형)
         
            * PU맵 값 가져오기
         * HXApi.HXGetRegister64(HXMap.HX_PU, ADDRESS);
         * (반환 값은 DOUBLE형)
          
         
         
         * - Register 값 저장하기
         1) HX 20 API          
            * PM맵 값 저장하기
         * SetPMF(ADDRESS, DOUBLE VALUE);
         * (DOUBLE형으로 저장할 값 넣기)
         
            * PU맵 값 저장하기
         * SetPUF(ADDRESS, DOUBLE VALUE);
         * (DOUBLE형으로 저장할 값 넣기)
                    
         
         2) HX API
            * PM맵 값 저장하기
         * HXApi.HXSetRegister64(HXMap.HX_PM, ADDRESS, DOUBLE VALUE);
         * (DOUBLE형으로 저장할 값 넣기)         

            * PU맵 값 저장하기                         
          * HXApi.HXSetRegister64(HXMap.HX_PU, ADDRESS, DOUBLE VALUE);
         * (DOUBLE형으로 저장할 값 넣기)         
       
         
         */

        const int HX_API = 1;
        const int HX_20API = 0;

        const int ZRN_ADDR = 1741;
        const int ZRN_DOG_ADDR = 1773;
        const int SOFT_LIMIT_ADDR = 3378;
        const int ABSO_POSADDR = 3410;
        const int JOG_MOVE_VEL_ADDR = 2;
        const int TARGET_MOVE_VEL = 66;
        const int STEP_MOVE_VEL = 34;
        const int ACCEL_ADDR = 561;
        const int HOME_VEL_ADDR = 1887;
        const int VEL_1ST_ADDR = 1919;
        const int VEL_2ND_ADDR = 1951;
        const int BAN_ADDR = 1805;
        const int RESET_ADDR = 8;

        int mConnType = -1;
        int mSelected_idx = -1;

        Hx20Api m_api_20;




        public scr_Info()
        {
            InitializeComponent();


            initControls();
        }
        

        public void setConnType(int type)
        {
            mConnType = type;

            updateSelectedIndex();
        }

        public void setApi_20(Hx20Api api)
        {
            m_api_20 = api;
        }

        private void initControls()
        {
            cmb_axis.SelectedIndex = 0;
        }
            


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_idx = cmb_axis.SelectedIndex;

            mSelected_idx = selected_idx;
            

            updateSelectedIndex();
        }


        private void updateSelectedIndex()
        {
            if (mConnType < 0)
                return;
            
            if(mConnType == 0)
            {
                // 임의 원점
                int random = (int)m_api_20.GetPMF(ZRN_ADDR + mSelected_idx);
                if (random == 1)
                    cb_random.CheckState = CheckState.Checked;
                else
                    cb_random.CheckState = CheckState.Unchecked;


                // 원점 dog  사용
                int dog = (int)m_api_20.GetPMF(ZRN_DOG_ADDR + mSelected_idx);
                if (dog == 1)
                    cb_dog.CheckState = CheckState.Checked;
                else
                    cb_dog.CheckState = CheckState.Unchecked;


                // 소프트 리밋 사용 여부
                int soft = (int)m_api_20.GetPMF(SOFT_LIMIT_ADDR + mSelected_idx);
                if (soft == 1)
                    cb_ab_use.CheckState = CheckState.Checked;
                else
                    cb_ab_use.CheckState = CheckState.Unchecked;


                // absolute position min, max
                double ab_min = m_api_20.GetPMF(ABSO_POSADDR + mSelected_idx);
                setUpdateData(tb_ab_min, ab_min);

                double ab_max = m_api_20.GetPMF(ABSO_POSADDR + mSelected_idx * 2 + 1);
                setUpdateData(tb_ab_max, ab_max);


                // jog move vel
                double jog_vel = m_api_20.GetPUF(JOG_MOVE_VEL_ADDR + mSelected_idx);
                setUpdateData(tb_jog_vel, jog_vel);


                // targetpos move vel
                double target_vel = m_api_20.GetPUF(TARGET_MOVE_VEL + mSelected_idx);
                setUpdateData(tb_tar_vel, target_vel);


                // step move vel
                double step_vel = m_api_20.GetPUF(STEP_MOVE_VEL + mSelected_idx);
                setUpdateData(tb_step_vel, step_vel);


                // direction cw,ccw
                // 기능 없음



                // accel
                double accel = m_api_20.GetPMF(ACCEL_ADDR + mSelected_idx);
                setUpdateData(tb_homing_acc, accel);

                // vel
                double home_vel = m_api_20.GetPMF(HOME_VEL_ADDR + mSelected_idx);
                setUpdateData(tb_homing_vel, home_vel);

                // 1st vel
                double vel_1st = m_api_20.GetPMF(VEL_1ST_ADDR + mSelected_idx);
                setUpdateData(tb_homing_1st, vel_1st);

                // 2nd vel
                double vel_2nd = m_api_20.GetPMF(VEL_2ND_ADDR + mSelected_idx);
                setUpdateData(tb_homing_2nd, vel_2nd);

                // 금지영역
                double ban = m_api_20.GetPMF(BAN_ADDR + mSelected_idx);
                setUpdateData(tb_homing_ban, ban);


            }
            else if(mConnType ==1)
            {                

                // 임의 원점
                int random = (int)HXApi.HXGetRegister64(HXMap.HX_PM, ZRN_ADDR + mSelected_idx);
                if (random == 1)
                    cb_random.CheckState = CheckState.Checked;
                else
                    cb_random.CheckState = CheckState.Unchecked;


                // 원점 dog  사용
                int dog = (int)HXApi.HXGetRegister64(HXMap.HX_PM, ZRN_DOG_ADDR + mSelected_idx);
                if (dog == 1)
                    cb_dog.CheckState = CheckState.Checked;
                else
                    cb_dog.CheckState = CheckState.Unchecked;


                // 소프트 리밋 사용 여부
                int soft = (int)HXApi.HXGetRegister64(HXMap.HX_PM, SOFT_LIMIT_ADDR + mSelected_idx);
                if (soft == 1)
                    cb_ab_use.CheckState = CheckState.Checked;
                else
                    cb_ab_use.CheckState = CheckState.Unchecked;


                // absolute position min, max
                double ab_min = HXApi.HXGetRegister64(HXMap.HX_PM, ABSO_POSADDR + mSelected_idx);
                setUpdateData(tb_ab_min, ab_min);

                double ab_max = HXApi.HXGetRegister64(HXMap.HX_PM, ABSO_POSADDR + mSelected_idx * 2 + 1);
                setUpdateData(tb_ab_max, ab_max);


                // jog move vel
                double jog_vel = HXApi.HXGetRegister64(HXMap.HX_PU, JOG_MOVE_VEL_ADDR + mSelected_idx);
                setUpdateData(tb_jog_vel, jog_vel);


                // targetpos move vel
                double target_vel = HXApi.HXGetRegister64(HXMap.HX_PU, TARGET_MOVE_VEL + mSelected_idx);
                setUpdateData(tb_tar_vel, target_vel);


                // step move vel
                double step_vel = HXApi.HXGetRegister64(HXMap.HX_PU, STEP_MOVE_VEL + mSelected_idx);
                setUpdateData(tb_step_vel, step_vel);


                // direction cw,ccw
                // 기능 없음



                // accel
                double accel = HXApi.HXGetRegister64(HXMap.HX_PM, ACCEL_ADDR + mSelected_idx);
                setUpdateData(tb_homing_acc, accel);

                // vel
                double home_vel = HXApi.HXGetRegister64(HXMap.HX_PM, HOME_VEL_ADDR + mSelected_idx);
                setUpdateData(tb_homing_vel, home_vel);

                // 1st vel
                double vel_1st = HXApi.HXGetRegister64(HXMap.HX_PM, VEL_1ST_ADDR + mSelected_idx);
                setUpdateData(tb_homing_1st, vel_1st);

                // 2nd vel
                double vel_2nd = HXApi.HXGetRegister64(HXMap.HX_PM, VEL_2ND_ADDR + mSelected_idx);
                setUpdateData(tb_homing_2nd, vel_2nd);

                // 금지영역
                double ban = HXApi.HXGetRegister64(HXMap.HX_PM, BAN_ADDR + mSelected_idx);
                setUpdateData(tb_homing_ban, ban);




            }


        }



        private void setUpdateData(TextBox tb, double dval)
        {
            tb.Text = dval.ToString("F3");
        }





        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (mConnType < 0)
                return;


            if (mConnType ==0)
            {
                m_api_20.SetGB(RESET_ADDR, 0, true);
                System.Threading.Thread.Sleep(200);
                m_api_20.SetGB(RESET_ADDR, 0, false);

            }
            else if(mConnType ==1)
            {

                HXApi.HXSetBit(HXMap.HX_G, RESET_ADDR, 0, true);
                System.Threading.Thread.Sleep(200);
                HXApi.HXSetBit(HXMap.HX_G, RESET_ADDR, 0, false);
            }



        }
      

        private void tb_ab_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_ab_min.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(ABSO_POSADDR + mSelected_idx, d);

                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ABSO_POSADDR + mSelected_idx, d);
                }
            }
        }

        private void tb_ab_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_ab_max.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(ABSO_POSADDR + mSelected_idx * 2 + 1, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ABSO_POSADDR + mSelected_idx * 2 + 1, d);
                }
            }
        }

        private void tb_jog_vel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_jog_vel.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPUF(JOG_MOVE_VEL_ADDR + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PU, JOG_MOVE_VEL_ADDR + mSelected_idx, d);
                }
            }
        }

        private void tb_tar_vel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_tar_vel.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPUF(TARGET_MOVE_VEL + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PU, TARGET_MOVE_VEL + mSelected_idx, d);
                }
            }

        }

        private void tb_step_vel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_step_vel.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPUF(STEP_MOVE_VEL + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PU, STEP_MOVE_VEL + mSelected_idx, d);

                }
            }

        }

        private void tb_homing_acc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_homing_acc.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(ACCEL_ADDR + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ACCEL_ADDR + mSelected_idx, d);
                }
            }
        }

        private void tb_homing_1st_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_homing_1st.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(VEL_1ST_ADDR + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, VEL_1ST_ADDR + mSelected_idx, d);

                }
            }
        }

        private void tb_homing_vel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_homing_vel.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(HOME_VEL_ADDR + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, HOME_VEL_ADDR + mSelected_idx, d);
                }
            }

        }

        private void tb_homing_2nd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_homing_2nd.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(VEL_2ND_ADDR + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, VEL_2ND_ADDR + mSelected_idx, d);
                }
            }
        }

        private void tb_homing_ban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mConnType < 0)
                return;


            if (e.KeyChar == (char)13)
            {
                string text = tb_homing_ban.Text;
                double d = 0;
                double.TryParse(text, out d);

                if (mConnType == 0)
                {
                    m_api_20.SetPMF(BAN_ADDR + mSelected_idx, d);
                }
                else if (mConnType == 1)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, BAN_ADDR + mSelected_idx, d);
                }
            }
        }

        private void cb_random_CheckedChanged(object sender, EventArgs e)
        {
            CheckState check = cb_random.CheckState;

            if (mConnType < 0)
                return;


            if (mConnType == 0)
            {
                if (check == CheckState.Checked)
                {
                    m_api_20.SetPMF(ZRN_ADDR + mSelected_idx, 1);
                }
                else if (check == CheckState.Unchecked)
                {
                    m_api_20.SetPMF(ZRN_ADDR + mSelected_idx, 0);
                }

            }
            else if (mConnType == 1)
            {
                if (check == CheckState.Checked)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ZRN_ADDR + mSelected_idx, 1);
                }
                else if (check == CheckState.Unchecked)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ZRN_ADDR + mSelected_idx, 0);
                }
            }
        }

        private void cb_dog_CheckedChanged(object sender, EventArgs e)
        {
            CheckState check = cb_dog.CheckState;

            if (mConnType < 0)
                return;


            if (mConnType == 0)
            {
                if (check == CheckState.Checked)
                {
                    m_api_20.SetPMF(ZRN_DOG_ADDR + mSelected_idx, 1);
                }
                else if (check == CheckState.Unchecked)
                {
                    m_api_20.SetPMF(ZRN_DOG_ADDR + mSelected_idx, 0);
                }                
            }
            else if (mConnType == 1)
            {
                if (check == CheckState.Checked)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ZRN_DOG_ADDR + mSelected_idx, 1);

                }
                else if (check == CheckState.Unchecked)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, ZRN_DOG_ADDR + mSelected_idx, 0);
                }
            }
        }

        private void cb_ab_use_CheckedChanged(object sender, EventArgs e)
        {
            CheckState check = cb_ab_use.CheckState;

            if (mConnType < 0)
                return;


            if (mConnType == 0)
            {
                if (check == CheckState.Checked)
                {
                    m_api_20.SetPMF(SOFT_LIMIT_ADDR + mSelected_idx, 0);
                }
                else if (check == CheckState.Unchecked)
                {
                    m_api_20.SetPMF(SOFT_LIMIT_ADDR + mSelected_idx, 1);
                }                               
            }
            else if (mConnType == 1)
            {
                if (check == CheckState.Checked)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, SOFT_LIMIT_ADDR + mSelected_idx, 0);
                }
                else if (check == CheckState.Unchecked)
                {
                    HXApi.HXSetRegister64(HXMap.HX_PM, SOFT_LIMIT_ADDR + mSelected_idx, 1);
                }
            }
        }
    }

}
