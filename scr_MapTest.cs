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
    public partial class scr_MapTest : UserControl
    {
        /*

         * - 주요 기능 -
         HX MAP에서 쓰는 맵에 값을 모니터링 및 저장하는 기능
            
         * GET(저장하기)버튼의 경우
         * 해당 MAP, ADDRESS, (BIT)에 해당되는 값을 모니터링할 수 있음
         * (PS맵의 경우 AXIS값을 기입해야함)
         
         
         * SET(저장하기)버튼의 경우
         * 해당 MAP, ADDRESS, (BIT)에 값을 저장한 후 일정 시간이 지난 후 저장이 제대로 되었나 확인하기 위해
         * 해당 맵에서 값을 가져와 모니터링할 수 있음
         * (PS맵의 경우 AXIS값을 기입해야함)
         
         */



        const int HX_API = 1;
        const int HX_20API = 0;

        const int SLEEP_TIME = 200;

        int mConnType = -1;

        Hx20Api m_api_20;


        public scr_MapTest()
        {
            InitializeComponent();
            initControls();
        }
        public void setConnType(int type)
        {
            mConnType = type;
        }
        public void setApi_20(Hx20Api api)
        {
            m_api_20 = api;
        }


        private void initControls()
        {
            addCmbItems(cmb_get_mapname);
            addCmbItems(cmb_set_mapname);
        }

        private void addCmbItems(ComboBox ctrl)
        {
            ctrl.Items.Add("HX_X");
            ctrl.Items.Add("HX_Y");
            ctrl.Items.Add("HX_G");
            ctrl.Items.Add("HX_F");

            ctrl.Items.Add("HX_PA");
            ctrl.Items.Add("HX_PI");
            ctrl.Items.Add("HX_PM");
            ctrl.Items.Add("HX_PP");
            ctrl.Items.Add("HX_PU");
            ctrl.Items.Add("HX_PS");
            ctrl.Items.Add("HX_SV");
            ctrl.Items.Add("HX_MGV");

            ctrl.Items.Add("HX_R");
            ctrl.Items.Add("HX_T");
            ctrl.Items.Add("HX_C");
            ctrl.Items.Add("HX_D");
            ctrl.Items.Add("HX_SN");
            ctrl.Items.Add("HX_MGN");
            ctrl.Items.Add("HX_STR_AXIS");
            ctrl.Items.Add("HX_STR_MACHINE");
            ctrl.Items.Add("HX_STR_SEQPROG");
            ctrl.Items.Add("HX_STR_ERRPROG");
            ctrl.Items.Add("HX_STR_NCPATH");
            ctrl.Items.Add("HX_STR_MAINPROG");
            ctrl.Items.Add("HX_STR_SUBPROG");
            ctrl.Items.Add("HX_STR_MDIPROG");
            ctrl.Items.Add("HX_DEVICE");
            ctrl.Items.Add("HX_STR_SYSPATH");
            ctrl.Items.Add("HX_STR_ALARMMSG");
            ctrl.Items.Add("HX_STR_OPMSG");
            ctrl.Items.Add("HX_STR_DATAPATH");
            ctrl.Items.Add("HX_STR_PLCFILE");
            ctrl.Items.Add("HX_STR_MAPFILE");
            ctrl.Items.Add("HX_STR_LANGUAGE");

        }

        private void btn_get_Click(object sender, EventArgs e)
        { 
            // map name, address, bit, axis 값 가져오기                       
            string mapname = cmb_get_mapname.Text;

            int iaddress = -1;
            int.TryParse(text_get_addr.Text, out iaddress);

            int ibit = -1;
            int.TryParse(text_get_bit.Text, out ibit);

            int iaxis = -1;
            int.TryParse(text_get_axis.Text, out iaxis);



            // GET해서 가져온 값 뿌리기
            // API 분리

            if (mConnType == 0)
            {
                getMethodByMapName_hx_api_20(mapname, iaddress, ibit, iaxis);
            }
            else if (mConnType == 1)
            {
                getMethodByMapName_hx_api(mapname, iaddress, ibit, iaxis);
            }

        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            // map name, address, bit, axis 값 가져오기
            string mapname = cmb_set_mapname.Text;

            int iaddress = -1;
            int.TryParse(text_set_address.Text, out iaddress);

            int ibit = -1;
            int.TryParse(text_set_bit.Text, out ibit);

            int iaxis = -1;
            int.TryParse(text_set_axis.Text, out iaxis);



            if (mConnType == 0)
            {
                setMethodByMapName_hx_api_20(mapname, iaddress, ibit, iaxis, text_set_value.Text);
            }
            else if (mConnType == 1)
            {
                setMethodByMapName_hx_api(mapname, iaddress, ibit, iaxis, text_set_value.Text);

            }

        }



















        private void getMethodByMapName_hx_api(string mapname, int iaddress, int ibit, int iaxis)
        {
            switch (mapname)
            {
                case "HX_X":
                    bool xval = HXApi.HXGetBit(HXMap.HX_X, iaddress, ibit);
                    showBitValue(text_get_value, xval);
                    break;
                case "HX_Y":
                    bool yval = HXApi.HXGetBit(HXMap.HX_Y, iaddress, ibit);
                    showBitValue(text_get_value, yval);
                    break;
                case "HX_G":
                    bool gval = HXApi.HXGetBit(HXMap.HX_G, iaddress, ibit);
                    showBitValue(text_get_value, gval);
                    break;
                case "HX_F":
                    bool fval = HXApi.HXGetBit(HXMap.HX_F, iaddress, ibit);
                    showBitValue(text_get_value, fval);
                    break;
                case "HX_PA":
                    double paval = HXApi.HXGetRegister64(HXMap.HX_PA, iaddress);
                    showRegValue(text_get_value, paval);
                    break;
                case "HX_PI":
                    double pival = HXApi.HXGetRegister64(HXMap.HX_PI, iaddress);
                    showRegValue(text_get_value, pival);
                    break;
                case "HX_PM":
                    double pmval = HXApi.HXGetRegister64(HXMap.HX_PM, iaddress);
                    showRegValue(text_get_value, pmval);
                    break;
                case "HX_PP":
                    double ppval = HXApi.HXGetRegister64(HXMap.HX_PP, iaddress);
                    showRegValue(text_get_value, ppval);
                    break;
                case "HX_PU":
                    double puval = HXApi.HXGetRegister64(HXMap.HX_PU, iaddress);
                    showRegValue(text_get_value, puval);
                    break;
                case "HX_PS":
                    double psval = HXApi.HXGetAxisParameter(iaxis, iaddress);
                    showRegValue(text_get_value, psval);
                    break;
                case "HX_SV":
                    double svval = HXApi.HXGetRegister64(HXMap.HX_SV, iaddress);
                    showRegValue(text_get_value, svval);
                    break;
                case "HX_MGV":
                    double mgvval = HXApi.HXGetRegister64(HXMap.HX_MGV, iaddress);
                    showRegValue(text_get_value, mgvval);
                    break;
                case "HX_R":
                    bool rval = HXApi.HXGetBit(HXMap.HX_R, iaddress, ibit);
                    showBitValue(text_get_value, rval);
                    break;
                case "HX_T":
                    double tval = HXApi.HXGetRegister64(HXMap.HX_T, iaddress);
                    showRegValue(text_get_value, tval);
                    break;
                case "HX_C":
                    double cval = HXApi.HXGetRegister64(HXMap.HX_C, iaddress);
                    showRegValue(text_get_value, cval);
                    break;
                case "HX_D":
                    double dval = HXApi.HXGetRegister64(HXMap.HX_D, iaddress);
                    showRegValue(text_get_value, dval);
                    break;
                case "HX_SN":
                    double snval = HXApi.HXGetRegister64(HXMap.HX_SN, iaddress);
                    showRegValue(text_get_value, snval);
                    break;
                case "HX_MGN":
                    double mgnval = HXApi.HXGetRegister64(HXMap.HX_MGN, iaddress);
                    showRegValue(text_get_value, mgnval);
                    break;
                case "HX_STR_AXIS":
                    string axisval = HXApi.HXGetString(HXMap.HX_STR_AXIS);
                    showStringValue(text_get_value, axisval);
                    break;
                case "HX_STR_MACHINE":
                    string machval = HXApi.HXGetString(HXMap.HX_STR_MACHINE);
                    showStringValue(text_get_value, machval);
                    break;
                case "HX_STR_SEQPROG":
                    string seqval = HXApi.HXGetString(HXMap.HX_STR_SEQPROG);
                    showStringValue(text_get_value, seqval);
                    break;
                case "HX_STR_ERRPROG":
                    string errval = HXApi.HXGetString(HXMap.HX_STR_ERRPROG);
                    showStringValue(text_get_value, errval);
                    break;
                case "HX_STR_NCPATH":
                    string ncval = HXApi.HXGetString(HXMap.HX_STR_NCPATH);
                    showStringValue(text_get_value, ncval);
                    break;
                case "HX_STR_MAINPROG":
                    string mainval = HXApi.HXGetString(HXMap.HX_STR_MAINPROG);
                    showStringValue(text_get_value, mainval);
                    break;
                case "HX_STR_SUBPROG":
                    string subval = HXApi.HXGetString(HXMap.HX_STR_SUBPROG);
                    showStringValue(text_get_value, subval);
                    break;
                case "HX_STR_MDIPROG":
                    string mdival = HXApi.HXGetString(HXMap.HX_STR_MDIPROG);
                    showStringValue(text_get_value, mdival);
                    break;
                case "HX_DEVICE":
                    string devival = HXApi.HXGetString(HXMap.HX_DEVICE);
                    showStringValue(text_get_value, devival);
                    break;
                case "HX_STR_SYSPATH":
                    string sysval = HXApi.HXGetString(HXMap.HX_STR_SYSPATH);
                    showStringValue(text_get_value, sysval);
                    break;
                case "HX_STR_ALARMMSG":
                    string alarmval = HXApi.HXGetString(HXMap.HX_STR_ALARMMSG);
                    showStringValue(text_get_value, alarmval);
                    break;
                case "HX_STR_OPMSG":
                    string opval = HXApi.HXGetString(HXMap.HX_STR_OPMSG);
                    showStringValue(text_get_value, opval);
                    break;
                case "HX_STR_DATAPATH":
                    string dataval = HXApi.HXGetString(HXMap.HX_STR_DATAPATH);
                    showStringValue(text_get_value, dataval);
                    break;
                case "HX_STR_PLCFILE":
                    string plcval = HXApi.HXGetString(HXMap.HX_STR_PLCFILE);
                    showStringValue(text_get_value, plcval);
                    break;
                case "HX_STR_MAPFILE":
                    string mapval = HXApi.HXGetString(HXMap.HX_STR_MAPFILE);
                    showStringValue(text_get_value, mapval);
                    break;
                case "HX_STR_LANGUAGE":
                    string lanval = HXApi.HXGetString(HXMap.HX_STR_LANGUAGE);
                    showStringValue(text_get_value, lanval);
                    break;


            }

        }

        private void getMethodByMapName_hx_api_20(string mapname, int iaddress, int ibit, int iaxis)
        {
            switch (mapname)
            {
                case "HX_X":
                    bool xval = m_api_20.GetBit(HxMap.HX_X, iaddress, ibit);
                    showBitValue(text_get_value, xval);
                    break;
                case "HX_Y":
                    bool yval = m_api_20.GetBit(HxMap.HX_Y, iaddress, ibit);
                    showBitValue(text_get_value, yval);
                    break;
                case "HX_G":
                    bool gval = m_api_20.GetBit(HxMap.HX_G, iaddress, ibit);
                    showBitValue(text_get_value, gval);
                    break;
                case "HX_F":
                    bool fval = m_api_20.GetBit(HxMap.HX_F, iaddress, ibit);
                    showBitValue(text_get_value, fval);
                    break;
                case "HX_PA":
                    double paval = m_api_20.GetReg64(HxMap.HX_PA, iaddress);
                    showRegValue(text_get_value, paval);
                    break;
                case "HX_PI":
                    double pival = m_api_20.GetReg64(HxMap.HX_PI, iaddress);
                    showRegValue(text_get_value, pival);
                    break;
                case "HX_PM":
                    double pmval = m_api_20.GetReg64(HxMap.HX_PM, iaddress);
                    showRegValue(text_get_value, pmval);
                    break;
                case "HX_PP":
                    double ppval = m_api_20.GetReg64(HxMap.HX_PP, iaddress);
                    showRegValue(text_get_value, ppval);
                    break;
                case "HX_PU":
                    double puval = m_api_20.GetReg64(HxMap.HX_PU, iaddress);
                    showRegValue(text_get_value, puval);
                    break;
                case "HX_PS":
                    double psval = m_api_20.GetPSF(iaxis, iaddress);
                    showRegValue(text_get_value, psval);
                    break;
                case "HX_SV":
                    double svval = m_api_20.GetReg64(HxMap.HX_SV, iaddress);
                    showRegValue(text_get_value, svval);
                    break;
                case "HX_MGV":
                    double mgvval = m_api_20.GetReg64(HxMap.HX_MGV, iaddress);
                    showRegValue(text_get_value, mgvval);
                    break;
                case "HX_R":
                    bool rval = m_api_20.GetBit(HxMap.HX_R, iaddress, ibit);
                    showBitValue(text_get_value, rval);
                    break;
                case "HX_T":
                    double tval = m_api_20.GetReg32(HxMap.HX_T, iaddress);
                    showRegValue(text_get_value, tval);
                    break;
                case "HX_C":
                    double cval = m_api_20.GetReg32(HxMap.HX_C, iaddress); ;
                    showRegValue(text_get_value, cval);
                    break;
                case "HX_D":
                    double dval = m_api_20.GetReg32(HxMap.HX_D, iaddress);
                    showRegValue(text_get_value, dval);
                    break;
                case "HX_SN":
                    double snval = m_api_20.GetReg64(HxMap.HX_SN, iaddress);
                    showRegValue(text_get_value, snval);
                    break;
                case "HX_MGN":
                    double mgnval = m_api_20.GetReg64(HxMap.HX_MGN, iaddress);
                    showRegValue(text_get_value, mgnval);
                    break;
                case "HX_STR_AXIS":
                    string axisval = m_api_20.GetString(HXMap.HX_STR_AXIS);
                    showStringValue(text_get_value, axisval);
                    break;
                case "HX_STR_MACHINE":
                    string machval = m_api_20.GetString(HXMap.HX_STR_MACHINE);
                    showStringValue(text_get_value, machval);
                    break;
                case "HX_STR_SEQPROG":
                    string seqval = m_api_20.GetString(HXMap.HX_STR_SEQPROG);
                    showStringValue(text_get_value, seqval);
                    break;
                case "HX_STR_ERRPROG":
                    string errval = m_api_20.GetString(HXMap.HX_STR_ERRPROG);
                    showStringValue(text_get_value, errval);
                    break;
                case "HX_STR_NCPATH":
                    string ncval = m_api_20.GetString(HXMap.HX_STR_NCPATH);
                    showStringValue(text_get_value, ncval);
                    break;
                case "HX_STR_MAINPROG":
                    string mainval = m_api_20.GetString(HXMap.HX_STR_MAINPROG);
                    showStringValue(text_get_value, mainval);
                    break;
                case "HX_STR_SUBPROG":
                    string subval = m_api_20.GetString(HXMap.HX_STR_SUBPROG);
                    showStringValue(text_get_value, subval);
                    break;
                case "HX_STR_MDIPROG":
                    string mdival = m_api_20.GetString(HXMap.HX_STR_MDIPROG);
                    showStringValue(text_get_value, mdival);
                    break;
                case "HX_DEVICE":
                    string devival = m_api_20.GetString(HXMap.HX_DEVICE);
                    showStringValue(text_get_value, devival);
                    break;
                case "HX_STR_SYSPATH":
                    string sysval = m_api_20.GetString(HXMap.HX_STR_SYSPATH);
                    showStringValue(text_get_value, sysval);
                    break;
                case "HX_STR_ALARMMSG":
                    string alarmval = m_api_20.GetString(HXMap.HX_STR_ALARMMSG);
                    showStringValue(text_get_value, alarmval);
                    break;
                case "HX_STR_OPMSG":
                    string opval = m_api_20.GetString(HXMap.HX_STR_OPMSG);
                    showStringValue(text_get_value, opval);
                    break;
                case "HX_STR_DATAPATH":
                    string dataval = m_api_20.GetString(HXMap.HX_STR_DATAPATH);
                    showStringValue(text_get_value, dataval);
                    break;
                case "HX_STR_PLCFILE":
                    string plcval = m_api_20.GetString(HXMap.HX_STR_PLCFILE);
                    showStringValue(text_get_value, plcval);
                    break;
                case "HX_STR_MAPFILE":
                    string mapval = m_api_20.GetString(HXMap.HX_STR_MAPFILE);
                    showStringValue(text_get_value, mapval);
                    break;
                case "HX_STR_LANGUAGE":
                    string lanval = m_api_20.GetString(HXMap.HX_STR_LANGUAGE);
                    showStringValue(text_get_value, lanval);
                    break;

            }
        }









        private void setMethodByMapName_hx_api(string mapname, int iaddress, int ibit, int iaxis, string value)
        {
            bool bval = false;
            if ((value == "1") || (value == "true") || (value == "TRUE") || (value == "True"))
                bval = true;
            else
                bval = false;


            double dval = 0;
            double.TryParse(value, out dval);

            int ival = 0;
            int.TryParse(value, out ival);


            switch (mapname)
            {
                case "HX_X":
                    HXApi.HXSetBit(HXMap.HX_X, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool xval = HXApi.HXGetBit(HXMap.HX_X, iaddress, ibit);
                    showBitValue(text_set_checkValue, xval);

                    break;
                case "HX_Y":
                    HXApi.HXSetBit(HXMap.HX_Y, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool yval = HXApi.HXGetBit(HXMap.HX_Y, iaddress, ibit);
                    showBitValue(text_set_checkValue, yval);
                    break;
                case "HX_G":
                    HXApi.HXSetBit(HXMap.HX_G, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool gval = HXApi.HXGetBit(HXMap.HX_G, iaddress, ibit);
                    showBitValue(text_set_checkValue, gval);
                    break;
                case "HX_F":
                    HXApi.HXSetBit(HXMap.HX_F, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool fval = HXApi.HXGetBit(HXMap.HX_F, iaddress, ibit);
                    showBitValue(text_set_checkValue, fval);
                    break;
                case "HX_PA":
                    HXApi.HXSetRegister64(HXMap.HX_PA, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double paval = HXApi.HXGetRegister64(HXMap.HX_PA, iaddress);
                    showRegValue(text_set_checkValue, paval);
                    break;
                case "HX_PI":
                    HXApi.HXSetRegister64(HXMap.HX_PI, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double pival = HXApi.HXGetRegister64(HXMap.HX_PI, iaddress);
                    showRegValue(text_set_checkValue, pival);
                    break;
                case "HX_PM":
                    HXApi.HXSetRegister64(HXMap.HX_PM, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double pmval = HXApi.HXGetRegister64(HXMap.HX_PM, iaddress);
                    showRegValue(text_set_checkValue, pmval);
                    break;
                case "HX_PP":
                    HXApi.HXSetRegister64(HXMap.HX_PP, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double ppval = HXApi.HXGetRegister64(HXMap.HX_PP, iaddress);
                    showRegValue(text_set_checkValue, ppval);
                    break;
                case "HX_PU":
                    HXApi.HXSetRegister64(HXMap.HX_PU, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double puval = HXApi.HXGetRegister64(HXMap.HX_PU, iaddress);
                    showRegValue(text_set_checkValue, puval);
                    break;
                case "HX_PS":
                    HXApi.HXSetAxisParameter(iaxis, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double psval = HXApi.HXGetAxisParameter(iaxis, iaddress);
                    showRegValue(text_set_checkValue, psval);
                    break;
                case "HX_SV":
                    HXApi.HXSetRegister64(HXMap.HX_SV, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double svval = HXApi.HXGetRegister64(HXMap.HX_SV, iaddress);
                    showRegValue(text_set_checkValue, svval);
                    break;
                case "HX_MGV":
                    HXApi.HXSetRegister64(HXMap.HX_MGV, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double mgvval = HXApi.HXGetRegister64(HXMap.HX_MGV, iaddress);
                    showRegValue(text_set_checkValue, mgvval);
                    break;
                case "HX_R":
                    HXApi.HXSetBit(HXMap.HX_R, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool rval = HXApi.HXGetBit(HXMap.HX_R, iaddress, ibit);
                    showBitValue(text_set_checkValue, rval);
                    break;
                case "HX_T":
                    HXApi.HXSetRegister32(HXMap.HX_T, iaddress, ival);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double tval = HXApi.HXGetRegister32(HXMap.HX_T, iaddress);
                    showRegValue(text_set_checkValue, tval);
                    break;
                case "HX_C":
                    HXApi.HXSetRegister32(HXMap.HX_C, iaddress, ival);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double cval = HXApi.HXGetRegister32(HXMap.HX_C, iaddress);
                    showRegValue(text_set_checkValue, cval);
                    break;
                case "HX_D":
                    HXApi.HXSetRegister32(HXMap.HX_D, iaddress, ival);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double d_val = HXApi.HXGetRegister32(HXMap.HX_D, iaddress);
                    showRegValue(text_set_checkValue, d_val);
                    break;
                case "HX_SN":
                    HXApi.HXSetRegister64(HXMap.HX_SN, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double snval = HXApi.HXGetRegister64(HXMap.HX_SN, iaddress);
                    showRegValue(text_set_checkValue, snval);
                    break;
                case "HX_MGN":
                    HXApi.HXSetRegister64(HXMap.HX_MGN, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double mgnval = HXApi.HXGetRegister64(HXMap.HX_MGN, iaddress);
                    showRegValue(text_set_checkValue, mgnval);
                    break;
                case "HX_STR_AXIS":
                    HXApi.HXSetString(HXMap.HX_STR_AXIS, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string axisval = HXApi.HXGetString(HXMap.HX_STR_AXIS);
                    showStringValue(text_set_checkValue, axisval);
                    break;
                case "HX_STR_MACHINE":
                    HXApi.HXSetString(HXMap.HX_STR_MACHINE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string machval = HXApi.HXGetString(HXMap.HX_STR_MACHINE);
                    showStringValue(text_set_checkValue, machval);
                    break;
                case "HX_STR_SEQPROG":
                    HXApi.HXSetString(HXMap.HX_STR_SEQPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string seqval = HXApi.HXGetString(HXMap.HX_STR_SEQPROG);
                    showStringValue(text_set_checkValue, seqval);
                    break;
                case "HX_STR_ERRPROG":
                    HXApi.HXSetString(HXMap.HX_STR_ERRPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string errval = HXApi.HXGetString(HXMap.HX_STR_ERRPROG);
                    showStringValue(text_set_checkValue, errval);
                    break;
                case "HX_STR_NCPATH":
                    HXApi.HXSetString(HXMap.HX_STR_NCPATH, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string ncval = HXApi.HXGetString(HXMap.HX_STR_NCPATH);
                    showStringValue(text_set_checkValue, ncval);
                    break;
                case "HX_STR_MAINPROG":
                    HXApi.HXSetString(HXMap.HX_STR_MAINPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string mainval = HXApi.HXGetString(HXMap.HX_STR_MAINPROG);
                    showStringValue(text_set_checkValue, mainval);
                    break;
                case "HX_STR_SUBPROG":
                    HXApi.HXSetString(HXMap.HX_STR_SUBPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string subval = HXApi.HXGetString(HXMap.HX_STR_SUBPROG);
                    showStringValue(text_set_checkValue, subval);
                    break;
                case "HX_STR_MDIPROG":
                    HXApi.HXSetString(HXMap.HX_STR_MDIPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string mdival = HXApi.HXGetString(HXMap.HX_STR_MDIPROG);
                    showStringValue(text_set_checkValue, mdival);
                    break;
                case "HX_DEVICE":
                    HXApi.HXSetString(HXMap.HX_DEVICE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string devival = HXApi.HXGetString(HXMap.HX_DEVICE);
                    showStringValue(text_set_checkValue, devival);
                    break;
                case "HX_STR_SYSPATH":
                    HXApi.HXSetString(HXMap.HX_STR_SYSPATH, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string sysval = HXApi.HXGetString(HXMap.HX_STR_SYSPATH);
                    showStringValue(text_set_checkValue, sysval);
                    break;
                case "HX_STR_ALARMMSG":
                    HXApi.HXSetString(HXMap.HX_STR_ALARMMSG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string alarmval = HXApi.HXGetString(HXMap.HX_STR_ALARMMSG);
                    showStringValue(text_set_checkValue, alarmval);
                    break;
                case "HX_STR_OPMSG":
                    HXApi.HXSetString(HXMap.HX_STR_OPMSG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string opval = HXApi.HXGetString(HXMap.HX_STR_OPMSG);
                    showStringValue(text_set_checkValue, opval);
                    break;
                case "HX_STR_DATAPATH":
                    HXApi.HXSetString(HXMap.HX_STR_DATAPATH, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string dataval = HXApi.HXGetString(HXMap.HX_STR_DATAPATH);
                    showStringValue(text_set_checkValue, dataval);
                    break;
                case "HX_STR_PLCFILE":
                    HXApi.HXSetString(HXMap.HX_STR_PLCFILE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string plcval = HXApi.HXGetString(HXMap.HX_STR_PLCFILE);
                    showStringValue(text_set_checkValue, plcval);
                    break;
                case "HX_STR_MAPFILE":
                    HXApi.HXSetString(HXMap.HX_STR_MAPFILE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string mapval = HXApi.HXGetString(HXMap.HX_STR_MAPFILE);
                    showStringValue(text_set_checkValue, mapval);
                    break;
                case "HX_STR_LANGUAGE":
                    HXApi.HXSetString(HXMap.HX_STR_LANGUAGE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string lanval = HXApi.HXGetString(HXMap.HX_STR_LANGUAGE);
                    showStringValue(text_set_checkValue, lanval);
                    break;
            }
        }






        private void setMethodByMapName_hx_api_20(string mapname, int iaddress, int ibit, int iaxis, string value)
        {
            bool bval = false;
            if ((value == "1") || (value == "true") || (value == "TRUE") || (value == "True"))
                bval = true;
            else
                bval = false;


            double dval = 0;
            double.TryParse(value, out dval);

            int ival = 0;
            int.TryParse(value, out ival);


            switch (mapname)
            {
                case "HX_X":
                    m_api_20.SetBit(HxMap.HX_X, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool xval = m_api_20.GetBit(HxMap.HX_X, iaddress, ibit);
                    showBitValue(text_set_checkValue, xval);

                    break;
                case "HX_Y":
                    m_api_20.SetBit(HxMap.HX_Y, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool yval = m_api_20.GetBit(HxMap.HX_Y, iaddress, ibit);
                    showBitValue(text_set_checkValue, yval);
                    break;
                case "HX_G":
                    m_api_20.SetBit(HxMap.HX_G, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool gval = m_api_20.GetBit(HxMap.HX_G, iaddress, ibit);
                    showBitValue(text_set_checkValue, gval);
                    break;
                case "HX_F":
                    m_api_20.SetBit(HxMap.HX_F, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool fval = m_api_20.GetBit(HxMap.HX_F, iaddress, ibit);
                    showBitValue(text_set_checkValue, fval);
                    break;
                case "HX_PA":
                    m_api_20.SetReg64(HxMap.HX_PA, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double paval = m_api_20.GetReg64(HxMap.HX_PA, iaddress);
                    showRegValue(text_set_checkValue, paval);
                    break;
                case "HX_PI":
                    m_api_20.SetReg64(HxMap.HX_PI, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double pival = m_api_20.GetReg64(HxMap.HX_PI, iaddress);
                    showRegValue(text_set_checkValue, pival);
                    break;
                case "HX_PM":
                    m_api_20.SetReg64(HxMap.HX_PM, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double pmval = m_api_20.GetReg64(HxMap.HX_PM, iaddress);
                    showRegValue(text_set_checkValue, pmval);
                    break;
                case "HX_PP":
                    m_api_20.SetReg64(HxMap.HX_PP, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double ppval = m_api_20.GetReg64(HxMap.HX_PP, iaddress);
                    showRegValue(text_set_checkValue, ppval);
                    break;
                case "HX_PU":
                    m_api_20.SetReg64(HxMap.HX_PU, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double puval = m_api_20.GetReg64(HxMap.HX_PU, iaddress);
                    showRegValue(text_set_checkValue, puval);
                    break;
                case "HX_PS":
                    m_api_20.SetPSF(iaxis, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double psval = m_api_20.GetPSF(iaxis, iaddress);
                    showRegValue(text_set_checkValue, psval);
                    break;
                case "HX_SV":
                    m_api_20.SetReg64(HxMap.HX_SV, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double svval = m_api_20.GetReg64(HxMap.HX_SV, iaddress);
                    showRegValue(text_set_checkValue, svval);
                    break;
                case "HX_MGV":
                    m_api_20.SetReg64(HxMap.HX_MGV, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double mgvval = m_api_20.GetReg64(HxMap.HX_MGV, iaddress);
                    showRegValue(text_set_checkValue, mgvval);
                    break;
                case "HX_R":
                    m_api_20.SetBit(HxMap.HX_R, iaddress, ibit, bval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    bool rval = m_api_20.GetBit(HxMap.HX_R, iaddress, ibit);
                    showBitValue(text_set_checkValue, rval);
                    break;
                case "HX_T":
                    m_api_20.SetReg32(HxMap.HX_T, iaddress, ival);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    int tval = m_api_20.GetReg32(HxMap.HX_T, iaddress);
                    showRegValue(text_set_checkValue, tval);
                    break;
                case "HX_C":
                    m_api_20.SetReg32(HxMap.HX_C, iaddress, ival);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    int cval = m_api_20.GetReg32(HxMap.HX_C, iaddress);
                    showRegValue(text_set_checkValue, cval);
                    break;
                case "HX_D":
                    m_api_20.SetReg64(HxMap.HX_D, iaddress, ival);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    int d_val = m_api_20.GetReg32(HxMap.HX_D, iaddress);
                    showRegValue(text_set_checkValue, d_val);
                    break;
                case "HX_SN":
                    m_api_20.SetReg64(HxMap.HX_SN, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double snval = m_api_20.GetReg64(HxMap.HX_SN, iaddress);
                    showRegValue(text_set_checkValue, snval);
                    break;
                case "HX_MGN":
                    m_api_20.SetReg64(HxMap.HX_MGN, iaddress, dval);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    double mgnval = m_api_20.GetReg64(HxMap.HX_MGN, iaddress);
                    showRegValue(text_set_checkValue, mgnval);
                    break;
                case "HX_STR_AXIS":
                    m_api_20.SetString(HXMap.HX_STR_AXIS, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string axisval = m_api_20.GetString(HXMap.HX_STR_AXIS);
                    showStringValue(text_set_checkValue, axisval);
                    break;
                case "HX_STR_MACHINE":
                    m_api_20.SetString(HXMap.HX_STR_MACHINE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string machval = m_api_20.GetString(HXMap.HX_STR_MACHINE);
                    showStringValue(text_set_checkValue, machval);
                    break;
                case "HX_STR_SEQPROG":
                    m_api_20.SetString(HXMap.HX_STR_SEQPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string seqval = m_api_20.GetString(HXMap.HX_STR_SEQPROG);
                    showStringValue(text_set_checkValue, seqval);
                    break;
                case "HX_STR_ERRPROG":
                    m_api_20.SetString(HXMap.HX_STR_ERRPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string errval = m_api_20.GetString(HXMap.HX_STR_ERRPROG);
                    showStringValue(text_set_checkValue, errval);
                    break;
                case "HX_STR_NCPATH":
                    m_api_20.SetString(HXMap.HX_STR_NCPATH, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string ncval = m_api_20.GetString(HXMap.HX_STR_NCPATH);
                    showStringValue(text_set_checkValue, ncval);
                    break;
                case "HX_STR_MAINPROG":
                    m_api_20.SetString(HXMap.HX_STR_MAINPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string mainval = m_api_20.GetString(HXMap.HX_STR_MAINPROG);
                    showStringValue(text_set_checkValue, mainval);
                    break;
                case "HX_STR_SUBPROG":
                    m_api_20.SetString(HXMap.HX_STR_SUBPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string subval = m_api_20.GetString(HXMap.HX_STR_SUBPROG);
                    showStringValue(text_set_checkValue, subval);
                    break;
                case "HX_STR_MDIPROG":
                    m_api_20.SetString(HXMap.HX_STR_MDIPROG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string mdival = m_api_20.GetString(HXMap.HX_STR_MDIPROG);
                    showStringValue(text_set_checkValue, mdival);
                    break;
                case "HX_DEVICE":
                    m_api_20.SetString(HXMap.HX_DEVICE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string devival = m_api_20.GetString(HXMap.HX_DEVICE);
                    showStringValue(text_set_checkValue, devival);
                    break;
                case "HX_STR_SYSPATH":
                    m_api_20.SetString(HXMap.HX_STR_SYSPATH, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string sysval = m_api_20.GetString(HXMap.HX_STR_SYSPATH);
                    showStringValue(text_set_checkValue, sysval);
                    break;
                case "HX_STR_ALARMMSG":
                    m_api_20.SetString(HXMap.HX_STR_ALARMMSG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string alarmval = m_api_20.GetString(HXMap.HX_STR_ALARMMSG);
                    showStringValue(text_set_checkValue, alarmval);
                    break;
                case "HX_STR_OPMSG":
                    m_api_20.SetString(HXMap.HX_STR_OPMSG, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string opval = m_api_20.GetString(HXMap.HX_STR_OPMSG);
                    showStringValue(text_set_checkValue, opval);
                    break;
                case "HX_STR_DATAPATH":
                    m_api_20.SetString(HXMap.HX_STR_DATAPATH, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string dataval = m_api_20.GetString(HXMap.HX_STR_DATAPATH);
                    showStringValue(text_set_checkValue, dataval);
                    break;
                case "HX_STR_PLCFILE":
                    m_api_20.SetString(HXMap.HX_STR_PLCFILE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string plcval = m_api_20.GetString(HXMap.HX_STR_PLCFILE);
                    showStringValue(text_set_checkValue, plcval);
                    break;
                case "HX_STR_MAPFILE":
                    m_api_20.SetString(HXMap.HX_STR_MAPFILE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string mapval = m_api_20.GetString(HXMap.HX_STR_MAPFILE);
                    showStringValue(text_set_checkValue, mapval);
                    break;
                case "HX_STR_LANGUAGE":
                    m_api_20.SetString(HXMap.HX_STR_LANGUAGE, value);
                    System.Threading.Thread.Sleep(SLEEP_TIME);

                    string lanval = m_api_20.GetString(HXMap.HX_STR_LANGUAGE);
                    showStringValue(text_set_checkValue, lanval);
                    break;


            }

        }













        private void showBitValue(TextBox text, bool value)
        {
            if (value)
            {
                text.Text = "true";
            }
            else
            {
                text.Text = "false";
            }
        }



        private void showRegValue(TextBox text, double value)
        {
            text.Text = value.ToString("F3");
        }


        private void showStringValue(TextBox text, string value)
        {
            text.Text = value;
        }
        



    }
}
