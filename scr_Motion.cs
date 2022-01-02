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


namespace HXApiTesterCS {
    public partial class scr_Motion : UserControl {
        const int HX_API = 1;
        const int HX_20API = 0;

        int mConnType = -1;

        Hx20Api m_api_20;

        const int AUTO_ADDR = 1;
        const int AUTO_BIT = 0;        

        const int MPG_ADDR = 1;
        const int MPG_BIT = 5;

        const int JOG_ADDR = 1;
        const int JOG_BIT = 4;

        const int ZRN_ADDR = 1;
        const int ZRN_BIT = 3;

        const int MDI_ADDR = 1;
        const int MDI_BIT = 1;

        const int EDIT_ADDR = 1;
        const int EDIT_BIT = 7;

        const int READY_ADDR = 200;
        const int READY_BIT = 0;

        const int RESET_ADDR = 200;
        const int RESET_BIT = 1;

        const int START_ADDR = 201;
        const int START_BIT = 0;

        const int STOP_ADDR = 201;
        const int STOT_BIT = 1;

        const int JOG_XP_ADDR = 201;
        const int JOG_XP_BIT = 7;

        const int JOG_XM_ADDR = 201;
        const int JOG_XM_BIT = 6;

        const int JOG_YP_ADDR = 201;
        const int JOG_YP_BIT = 9;

        const int JOG_YM_ADDR = 201;
        const int JOG_YM_BIT = 8;

        const int JOG_ZP_ADDR = 201;
        const int JOG_ZP_BIT = 10;

        const int JOG_ZM_ADDR = 201;
        const int JOG_ZM_BIT = 11;

        public scr_Motion() {
            InitializeComponent();
            initControls();
            this.VisibleChanged += visibleChanged;
        }

        private void visibleChanged(object sender, EventArgs e) {
            if(this.Visible) { timer_motion.Start(); }
            
            else { timer_motion.Stop(); }
        }

        public void setConnType(int type) { mConnType = type; }

        public void setApi_20(Hx20Api api) { m_api_20 = api; }

        private void initControls() {
            btn_auto.MouseDown += auto_down;
            btn_auto.MouseUp += auto_up;

            btn_mpg.MouseDown += mpg_down;
            btn_mpg.MouseUp += mpg_up;

            btn_jog.MouseDown += jog_down;
            btn_jog.MouseUp += jog_up;

            btn_zrn.MouseDown += zrn_down;
            btn_zrn.MouseUp += zrn_up;

            btn_mdi.MouseDown += mdi_down;
            btn_mdi.MouseUp += mdi_up;

            btn_edit.MouseDown += edit_down;
            btn_edit.MouseUp += edit_up;

            btn_ready.MouseDown += ready_down;
            btn_ready.MouseUp += ready_up;

            btn_reset.MouseDown += reset_down;
            btn_reset.MouseUp += reset_up;

            btn_start.MouseDown += start_down;
            btn_start.MouseUp += start_up;

            btn_stop.MouseDown += stop_down;
            btn_stop.MouseUp += stop_up;

            btn_jog_ap.MouseDown += jog_ap_down;
            btn_jog_ap.MouseUp += jog_ap_up;

            btn_jog_am.MouseDown += jog_am_down;
            btn_jog_am.MouseUp += jog_am_up;

            btn_jog_xp.MouseDown += jog_xp_down;
            btn_jog_xp.MouseUp += jog_xp_up;

            btn_jog_xm.MouseDown += jog_xm_down;
            btn_jog_xm.MouseUp += jog_xm_up;

            btn_jog_yp.MouseDown += jog_yp_down;
            btn_jog_yp.MouseUp += jog_yp_up;

            btn_jog_ym.MouseDown += jog_ym_down;
            btn_jog_ym.MouseUp += jog_ym_up;

            btn_jog_zp.MouseDown += jog_zp_down;
            btn_jog_zp.MouseUp += jog_zp_up;

            btn_jog_zm.MouseDown += jog_zm_down;
            btn_jog_zm.MouseUp += jog_zm_up;
        }

        private void auto_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(AUTO_ADDR, AUTO_BIT, true); }

            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, AUTO_ADDR, AUTO_BIT, true); }
        }

        private void auto_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(AUTO_ADDR, AUTO_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, AUTO_ADDR, AUTO_BIT, false); }
        }

        private void mpg_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(MPG_ADDR, MPG_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, MPG_ADDR, MPG_BIT, true); }
        }

        private void mpg_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(MPG_ADDR, MPG_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, MPG_ADDR, MPG_BIT, false); }
        }

        private void jog_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(JOG_ADDR, JOG_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, JOG_ADDR, 4, true); }
        }

        private void jog_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(JOG_ADDR, JOG_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, JOG_ADDR, JOG_BIT, false); }
        }

        private void zrn_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(ZRN_ADDR, ZRN_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, ZRN_ADDR, ZRN_BIT, true); }
        }

        private void zrn_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(ZRN_ADDR, ZRN_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, ZRN_ADDR, ZRN_BIT, false); }
        }

        private void mdi_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(MDI_ADDR, MDI_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, MDI_ADDR, MDI_BIT, true); }
        }

        private void mdi_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(MDI_ADDR, MDI_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, MDI_ADDR, MDI_BIT, false); }
        }

        private void edit_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(EDIT_ADDR, EDIT_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, EDIT_ADDR, EDIT_BIT, true); }
        }

        private void edit_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetGB(EDIT_ADDR, EDIT_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_G, EDIT_ADDR, EDIT_BIT, false); }
        }

        private void ready_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(READY_ADDR, READY_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, READY_ADDR, READY_BIT, true); }
        }

        private void ready_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(READY_ADDR, READY_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, READY_ADDR, READY_BIT, false); }
        }

        private void reset_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(RESET_ADDR, RESET_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, RESET_ADDR, RESET_BIT, true); }
        }

        private void reset_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(RESET_ADDR, RESET_BIT, false); }

            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, RESET_ADDR, RESET_BIT, false); }
        }

        private void start_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(START_ADDR, START_BIT, true); }
        
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, START_ADDR, START_BIT, true); }
        }

        private void start_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(START_ADDR, START_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, START_ADDR, START_BIT, false); }
        }

        private void stop_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(STOP_ADDR, STOT_BIT, true); }
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, STOP_ADDR, STOT_BIT, true); }
        }

        private void stop_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(STOP_ADDR, STOT_BIT, false); }

            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, STOP_ADDR, STOT_BIT, false); }
        }

        private void jog_xp_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_XP_ADDR, JOG_XP_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_XP_ADDR, JOG_XP_BIT, true); }
        }

        private void jog_xp_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_XP_ADDR, JOG_XP_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_XP_ADDR, JOG_XP_BIT, false); }
        }

        private void jog_xm_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_XM_ADDR, JOG_XM_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_XM_ADDR, JOG_XM_BIT, true); }
        }

        private void jog_xm_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_XM_ADDR, JOG_XM_BIT, false); }
        
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_XM_ADDR, JOG_XM_BIT, false); }
        }

        private void jog_yp_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_YP_ADDR, JOG_YP_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_YP_ADDR, JOG_YP_BIT, true); }
        }

        private void jog_yp_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_YP_ADDR, JOG_YP_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_YP_ADDR, JOG_YP_BIT, false); }
        }

        private void jog_ym_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_YM_ADDR, JOG_YM_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_YM_ADDR, JOG_YM_BIT, true); }
        }

        private void jog_ym_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_YM_ADDR, JOG_YM_BIT, false); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_YM_ADDR, JOG_YM_BIT, false); }
        }

        private void jog_zp_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_ZP_ADDR, JOG_ZP_BIT, true); }

            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_ZP_ADDR, JOG_ZP_BIT, true); }
        }

        private void jog_zp_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_ZP_ADDR, JOG_ZP_BIT, false); }

            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_ZP_ADDR, JOG_ZP_BIT, false); }
        }

        private void jog_zm_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_ZM_ADDR, JOG_ZM_BIT, true); }
            
            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_ZM_ADDR, JOG_ZM_BIT, true); }
        }

        private void jog_zm_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { m_api_20.SetXB(JOG_ZM_ADDR, JOG_ZM_BIT, false); }

            else if (mConnType == 1) { HXApi.HXSetBit(HXMap.HX_X, JOG_ZM_ADDR, JOG_ZM_BIT, false); }
        }

        private void jog_ap_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { }
            
            else if (mConnType == 1) { }
        }

        private void jog_ap_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { }
            
            else if (mConnType == 1) { }
        }

        private void jog_am_down(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { }
            
            else if (mConnType == 1) { }
        }

        private void jog_am_up(object sender, EventArgs e) {
            if (mConnType < 0)
                return;

            if (mConnType == 0) { }
            
            else if (mConnType == 1) { }
        }

        private void timer_motion_Tick(object sender, EventArgs e) {
            // 현재 위치
            // sv 83
            double curpos1 = 0;
            double curpos2 = 0;
            double curpos3 = 0;
            double curpos4 = 0;
            double curpos5 = 0;

            // 기계 위치 
            //sn 237
            double macpos1 = 0;
            double macpos2 = 0;
            double macpos3 = 0;
            double macpos4 = 0;
            double macpos5 = 0;

            // 상대위치
            // sv 1150
            double relpos1 = 0;
            double relpos2 = 0;
            double relpos3 = 0;
            double relpos4 = 0;
            double relpos5 = 0;

            // 남은거리
            // sv 247
            double dispos1 = 0;
            double dispos2 = 0;
            double dispos3 = 0;
            double dispos4 = 0;
            double dispos5 = 0;

            if (mConnType == 0) {
                // 현재 위치
                // sv 83
                curpos1 = m_api_20.GetSVF(83);
                curpos2 = m_api_20.GetSVF(84);
                curpos3 = m_api_20.GetSVF(85);
                curpos4 = m_api_20.GetSVF(86);
                curpos5 = m_api_20.GetSVF(87);

                // 기계 위치 
                //sn 237
                macpos1 = m_api_20.GetSNF(237);
                macpos2 = m_api_20.GetSNF(238);
                macpos3 = m_api_20.GetSNF(239);
                macpos4 = m_api_20.GetSNF(240);
                macpos5 = m_api_20.GetSNF(241);

                // 상대위치
                // sn 269?
                relpos1 = m_api_20.GetSNF(269);
                relpos2 = m_api_20.GetSNF(270);
                relpos3 = m_api_20.GetSNF(271);
                relpos4 = m_api_20.GetSNF(272);
                relpos5 = m_api_20.GetSNF(273);

                // 남은거리
                // sv 247
                dispos1 = m_api_20.GetSVF(247);
                dispos2 = m_api_20.GetSVF(248);
                dispos3 = m_api_20.GetSVF(249);
                dispos4 = m_api_20.GetSVF(250);
                dispos5 = m_api_20.GetSVF(251);
            }

            else if (mConnType == 1) {
                // sv 83
                curpos1 = HXApi.HXGetRegister64 (HXMap.HX_SV, 83);
                curpos2 = HXApi.HXGetRegister64(HXMap.HX_SV, 84);
                curpos3 = HXApi.HXGetRegister64(HXMap.HX_SV, 85);
                curpos4 = HXApi.HXGetRegister64(HXMap.HX_SV, 86);
                curpos5 = HXApi.HXGetRegister64(HXMap.HX_SV, 87);

                // 기계 위치 
                //sn 237
                macpos1 = HXApi.HXGetRegister64(HXMap.HX_SN, 237);
                macpos2 = HXApi.HXGetRegister64(HXMap.HX_SN, 238);
                macpos3 = HXApi.HXGetRegister64(HXMap.HX_SN, 239);
                macpos4 = HXApi.HXGetRegister64(HXMap.HX_SN, 240);
                macpos5 = HXApi.HXGetRegister64(HXMap.HX_SN, 241);

                // 상대위치
                // sn 269?
                relpos1 = HXApi.HXGetRegister64(HXMap.HX_SN, 269);
                relpos2 = HXApi.HXGetRegister64(HXMap.HX_SN, 270);
                relpos3 = HXApi.HXGetRegister64(HXMap.HX_SN, 271);
                relpos4 = HXApi.HXGetRegister64(HXMap.HX_SN, 272);
                relpos5 = HXApi.HXGetRegister64(HXMap.HX_SN, 273);

                // 남은거리
                // sv 247
                dispos1 = HXApi.HXGetRegister64(HXMap.HX_SV, 247);
                dispos2 = HXApi.HXGetRegister64(HXMap.HX_SV, 248);
                dispos3 = HXApi.HXGetRegister64(HXMap.HX_SV, 249);
                dispos4 = HXApi.HXGetRegister64(HXMap.HX_SV, 250);
                dispos5 = HXApi.HXGetRegister64(HXMap.HX_SV, 251);
            }

            setDataText(lb_curpos_1, curpos1);
            setDataText(lb_curpos_2, curpos2);
            setDataText(lb_curpos_3, curpos3);
            setDataText(lb_curpos_4, curpos4);
            setDataText(lb_curpos_5, curpos5);

            setDataText(lb_macpos_1, macpos1);
            setDataText(lb_macpos_2, macpos2);
            setDataText(lb_macpos_3, macpos3);
            setDataText(lb_macpos_4, macpos4);
            setDataText(lb_macpos_5, macpos5);

            setDataText(lb_relpos_1, relpos1);
            setDataText(lb_relpos_2, relpos2);
            setDataText(lb_relpos_3, relpos3);
            setDataText(lb_relpos_4, relpos4);
            setDataText(lb_relpos_5, relpos5);

            setDataText(lb_dispos_1, dispos1);
            setDataText(lb_dispos_2, dispos2);
            setDataText(lb_dispos_3, dispos3);
            setDataText(lb_dispos_4, dispos4);
            setDataText(lb_dispos_5, dispos5);
        }

        private void setDataText(Label lb, double value) {
            string str = value.ToString("F3");

            if (lb.Text == str)
                return;

            lb.Text = str;
        }
    }
}
