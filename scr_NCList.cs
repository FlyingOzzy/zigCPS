﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HXApiCS;
using System.IO;


namespace HXApiTesterCS {
    public partial class scr_NCList : UserControl {
        const int HX_API = 1;
        const int HX_20API = 0;

        int mConnType = -1;

        Hx20Api m_api_20;

        const string DEFAULT_PATH = "D:\\";

        public scr_NCList() {
            InitializeComponent();
            this.VisibleChanged += visibleChanged;        
        }

        private void visibleChanged(object sender ,EventArgs e) {
            if(this.Visible) {            
                // 로컬 리스트 가져오기
                setPCDirPath(DEFAULT_PATH);
                
                if (mConnType < 0)
                    return;

                // 제어기 nc list가져오기
                setNCList();
            }

            else { }
        }

        public void setConnType(int type) {
            mConnType = type;

            // 제어기 nc list가져오기
            //setNCList();

            // 로컬 리스트 가져오기
            setPCDirList(DEFAULT_PATH); 
        }

        public void setApi_20(Hx20Api api) { m_api_20 = api; }

        private void setNCList() {
            // nc list 가져오기
            removeAllRows();

            if (mConnType == 0) {
                // HX 20 API
                int count = m_api_20.GetNcFileCount();

                for (int i = 0; i < count; i++) {
                    string name = m_api_20.HxGetNcFileStr(i);
                    gridview_list.Rows.Add(name);
                }
            }

            else if (mConnType == 1) {
                // HX API
                int count = HXApi.HXGetNcFileCount();

                for (int i = 0; i < count; i++) {
                    string name = HXApi.HXGetNcFileStr(i);
                    gridview_list.Rows.Add(name);
                }
            }
        }
        
        private void removeAllRows() { gridview_list.Rows.Clear(); }

        private void btn_select_Click(object sender, EventArgs e) {
            // .nc 삭제하고 파일명만 전달
            if (gridview_list.CurrentCell == null)
                return;

            int index = gridview_list.CurrentCell.RowIndex;

            if (index < 0)
                return;

            string str = gridview_list.Rows[index].Cells[0].Value.ToString();
            string[] arr_str = str.Split('.');
            
            if (mConnType == 0) {
                // HX 20 API
                m_api_20.HxSetMainProg(arr_str[0]);
                m_api_20.HxSetSubProg(arr_str[0]);

                string syspath = m_api_20.HxGetSysPath();
                syspath += "nc\\";

                m_api_20.HxSetNcPath(syspath);
            }

            else if (mConnType == 1) {
                // HX API
                HXApi.HXSetMainProgram(arr_str[0]);
                HXApi.HXSetSubProgram(arr_str[0]);

                string syspath = HXApi.HXGetSystemPath();
                syspath += "nc\\";

                HXApi.HXSetNcPath(syspath);   
            }
        }

        private void btn_download_Click(object sender, EventArgs e) {
            // local에 있는 nc파일을 nc 폴더에
            if (gridview_pc.CurrentCell == null)
                return;

            int index = gridview_pc.CurrentCell.RowIndex;

            if (index < 0)
                return;

            string selected_name = gridview_pc.Rows[index].Cells[0].Value.ToString();
            string selected_path = lb_pc_path.Text;
            
            if (mConnType == 0) {
                // HX 20 API
                m_api_20.DownloadFile(selected_path, selected_name);
            }

            else if (mConnType == 1) {
                // HX API
                HXApi.XHXDownloadFile(0, selected_path, selected_name);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e) {
            if (gridview_list.CurrentCell == null)
                return;

            // 현재 선택한 nc 파일을 local에

            int index = gridview_list.CurrentCell.RowIndex;

            if (index < 0)
                return;

            string str = gridview_list.Rows[index].Cells[0].Value.ToString();
            string dir_path = lb_pc_path.Text;

            if (mConnType == 0) { m_api_20.UploadFile(dir_path, str); }

            else if (mConnType == 1) { HXApi.XHXUploadFile(0, dir_path, str); }
        }

        private void setPCDirPath(string path) { lb_pc_path.Text = path; }

        private void setPCDirList(string path) {
            gridview_pc.Rows.Clear();
            string[] str_folder = Directory.GetDirectories(path);

            foreach(string file in str_folder) {
                string dic = Path.GetFileName(file);
                gridview_pc.Rows.Add(dic);
            }
            
            string[] str_file =  Directory.GetFiles(path);

            foreach (string file in str_file) {
                string file_name= Path.GetFileName(file);

                if (file_name.Contains(".nc")) { gridview_pc.Rows.Add(file_name); }
                
                else
                    continue;                
            }
        }

        private void btn_up_Click(object sender, EventArgs e) {
            // 상위 폴더로 이동
            if (lb_pc_path.Text == DEFAULT_PATH)
                return;

            string cur_path = lb_pc_path.Text;
            string[] str_arr = cur_path.Split('\\');
            string new_path = "";

            for(int i =0; i<str_arr.Length-2; i++) { new_path += str_arr[i] + "\\"; }

            setPCDirList(new_path);
            setPCDirPath(new_path);
        }

        private void btn_down_Click(object sender, EventArgs e) {
            // 하위 폴더로 이동
            if (gridview_pc.CurrentCell == null)
                return;

            int index = gridview_pc.CurrentCell.RowIndex;

            if (index < 0)
                return;

            string str = gridview_pc.Rows[index].Cells[0].Value.ToString();

            //.nc 파일이면 return;
            if(str.Contains(".nc"))
                return;
            
            string newPath = lb_pc_path.Text + str + "\\";

            setPCDirList(newPath);
            setPCDirPath(newPath);
        }
    }
}
