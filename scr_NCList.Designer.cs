namespace HXApiTesterCS
{
    partial class scr_NCList
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridview_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.gridview_pc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.lb_pc_path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_title.Location = new System.Drawing.Point(3, 7);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(884, 23);
            this.lb_title.TabIndex = 21;
            this.lb_title.Text = "NC List";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "제어기";
            // 
            // gridview_list
            // 
            this.gridview_list.AllowUserToAddRows = false;
            this.gridview_list.AllowUserToDeleteRows = false;
            this.gridview_list.AllowUserToResizeColumns = false;
            this.gridview_list.AllowUserToResizeRows = false;
            this.gridview_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gridview_list.Location = new System.Drawing.Point(41, 100);
            this.gridview_list.MultiSelect = false;
            this.gridview_list.Name = "gridview_list";
            this.gridview_list.ReadOnly = true;
            this.gridview_list.RowHeadersVisible = false;
            this.gridview_list.RowTemplate.Height = 23;
            this.gridview_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_list.Size = new System.Drawing.Size(362, 375);
            this.gridview_list.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "NC File";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_select.Location = new System.Drawing.Point(41, 481);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(150, 41);
            this.btn_select.TabIndex = 25;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_download
            // 
            this.btn_download.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_download.Location = new System.Drawing.Point(484, 549);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(150, 41);
            this.btn_download.TabIndex = 26;
            this.btn_download.Text = "PC->제어기 Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_upload.Location = new System.Drawing.Point(41, 549);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(150, 41);
            this.btn_upload.TabIndex = 27;
            this.btn_upload.Text = "제어기->PC Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // gridview_pc
            // 
            this.gridview_pc.AllowUserToAddRows = false;
            this.gridview_pc.AllowUserToDeleteRows = false;
            this.gridview_pc.AllowUserToResizeColumns = false;
            this.gridview_pc.AllowUserToResizeRows = false;
            this.gridview_pc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_pc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gridview_pc.Location = new System.Drawing.Point(484, 100);
            this.gridview_pc.MultiSelect = false;
            this.gridview_pc.Name = "gridview_pc";
            this.gridview_pc.ReadOnly = true;
            this.gridview_pc.RowHeadersVisible = false;
            this.gridview_pc.RowTemplate.Height = 23;
            this.gridview_pc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_pc.Size = new System.Drawing.Size(362, 375);
            this.gridview_pc.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "PC File";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(484, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "PC";
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_up.Location = new System.Drawing.Point(758, 481);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(41, 41);
            this.btn_up.TabIndex = 30;
            this.btn_up.Text = "↑";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_down.Location = new System.Drawing.Point(805, 481);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(41, 41);
            this.btn_down.TabIndex = 31;
            this.btn_down.Text = "↓";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // lb_pc_path
            // 
            this.lb_pc_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pc_path.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_pc_path.Location = new System.Drawing.Point(484, 74);
            this.lb_pc_path.Name = "lb_pc_path";
            this.lb_pc_path.Size = new System.Drawing.Size(362, 23);
            this.lb_pc_path.TabIndex = 32;
            this.lb_pc_path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scr_NCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_pc_path);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.gridview_pc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.gridview_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.Name = "scr_NCList";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_pc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridview_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.DataGridView gridview_pc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Label lb_pc_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
