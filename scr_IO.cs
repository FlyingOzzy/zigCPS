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
    public partial class scr_IO : UserControl {
        CheckBox[] m_buttons = new CheckBox[32];

        bool bMap_x = false;
        const int HX_API = 1;
        const int HX_20API = 0;

        int mConnType = -1;
        int mSelectedDevice = -1;

        Hx20Api m_api_20;

        public scr_IO() {
            InitializeComponent();
            initControls();
            this.VisibleChanged += visibleChanged;
        }

        private void visibleChanged(object sender, EventArgs e) {
            if(this.Visible) { io_timer.Start(); }
            
            else { io_timer.Stop(); }
        }

        public void setConnType(int type) { mConnType = type; }

        public void setApi_20(Hx20Api api) { m_api_20 = api; }

        public void setMapName(string str) {
            lb_mapname.Text = str;
   
            if (str.Contains("X")) {
                lb_title.Text = "IO INPUT";
                bMap_x = true;
            }
            
            else {
                lb_title.Text = "IO OUTPUT";
                bMap_x = false;
            }
        }

        private void initControls() {
            m_buttons[0] = checkBox1;
            m_buttons[1] = checkBox2;
            m_buttons[2] = checkBox3;
            m_buttons[3] = checkBox4;
            m_buttons[4] = checkBox5;
            m_buttons[5] = checkBox6;
            m_buttons[6] = checkBox7;
            m_buttons[7] = checkBox8;
            m_buttons[8] = checkBox9;
            m_buttons[9] = checkBox10;
            m_buttons[10] = checkBox11;

            m_buttons[11] = checkBox12;
            m_buttons[12] = checkBox13;
            m_buttons[13] = checkBox14;
            m_buttons[14] = checkBox15;
            m_buttons[15] = checkBox16;
            m_buttons[16] = checkBox17;
            m_buttons[17] = checkBox18;
            m_buttons[18] = checkBox19;
            m_buttons[19] = checkBox20;
            m_buttons[20] = checkBox21;

            m_buttons[21] = checkBox22;
            m_buttons[22] = checkBox23;
            m_buttons[23] = checkBox24;
            m_buttons[24] = checkBox25;
            m_buttons[25] = checkBox26;
            m_buttons[26] = checkBox27;
            m_buttons[27] = checkBox28;
            m_buttons[28] = checkBox29;
            m_buttons[29] = checkBox30;
            m_buttons[30] = checkBox31;
            m_buttons[31] = checkBox32;

            for (int i = 0; i < m_buttons.Length; i++) { m_buttons[i].Click += buttonClick; }

            cmb_device.SelectedIndex = 0;
        }

        private void buttonClick(object sender, EventArgs e) {
            CheckBox clickBtn = (CheckBox)sender;

            int index = -1;

            for (int i = 0; i < 32; i++) {
                if (m_buttons[i] == clickBtn) {
                    index = i;
                    break;
                }
            }

            CheckState check = m_buttons[index].CheckState;

            // x 맵 연결
            if (bMap_x) {
                if (mConnType == 0) {
                    if (check == CheckState.Checked) { m_api_20.SetBit(HxMap.HX_X, mSelectedDevice, index, true); }
                    
                    else if (check == CheckState.Unchecked) { m_api_20.SetBit(HxMap.HX_X, mSelectedDevice, index, false); }                   
                }

                else if (mConnType == 1) {
                    if (check == CheckState.Checked) { HXApi.HXSetBit(HXMap.HX_X, mSelectedDevice, index, true); }

                    else if (check == CheckState.Unchecked) { HXApi.HXSetBit(HXMap.HX_X, mSelectedDevice, index, false); }
                }
            }

            // y 맵 연결
            else {
                if (mConnType == 0) {
                    if (check == CheckState.Checked) { m_api_20.SetBit(HxMap.HX_Y, mSelectedDevice, index, true); }

                    else if (check == CheckState.Unchecked) { m_api_20.SetBit(HxMap.HX_Y, mSelectedDevice, index, false); }
                }

                else if (mConnType == 1) {
                    if (check == CheckState.Checked) {
                        HXApi.HXSetBit(HXMap.HX_Y, mSelectedDevice, index, true); }
                    
                    else if (check == CheckState.Unchecked) { HXApi.HXSetBit(HXMap.HX_Y, mSelectedDevice, index, false); }
                }
            }
        }

        private void io_timer_Tick(object sender, EventArgs e) { updateIOButtons(); }
        private void updateIOButtons() {
            if (mConnType < 0)
                return;
            
            if (bMap_x) {
                // x 맵 연결
                if (mConnType == 0) {
                    for (int i = 0; i < 32; i++) {
                        bool bval = m_api_20.GetBit(HxMap.HX_X, mSelectedDevice, i);

                        if (bval) { m_buttons[i].CheckState = CheckState.Checked; }

                        else { m_buttons[i].CheckState = CheckState.Unchecked; }
                    }
                }

                else if (mConnType == 1) {
                    for (int i = 0; i < 32; i++) {
                        bool bval = HXApi.HXGetBit(HXMap.HX_X, mSelectedDevice, i);

                        if (bval) {m_buttons[i].CheckState = CheckState.Checked; }

                        else { m_buttons[i].CheckState = CheckState.Unchecked; }
                    }
                }
            }

            else {
                // y 맵 연결
                if (mConnType == 0) {
                    for (int i = 0; i < 32; i++) {
                        bool bval = m_api_20.GetBit(HxMap.HX_Y, mSelectedDevice, i);

                        if (bval) { m_buttons[i].CheckState = CheckState.Checked; }

                        else { m_buttons[i].CheckState = CheckState.Unchecked; }
                    }
                }

                else if (mConnType == 1) {
                    for (int i = 0; i < 32; i++) {                      
                        bool bval = HXApi.HXGetBit(HXMap.HX_Y, mSelectedDevice, i);

                        if (bval) { m_buttons[i].CheckState = CheckState.Checked; }
                        
                        else { m_buttons[i].CheckState = CheckState.Unchecked; }
                    }
                }
            }
        }

        private void cmb_device_SelectedIndexChanged(object sender, EventArgs e) { mSelectedDevice = cmb_device.SelectedIndex; }
    }


}
