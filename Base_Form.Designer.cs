namespace HXApiTesterCS
{
    partial class Base_Form
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            this.lb_connect = new System.Windows.Forms.Label();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_motion = new System.Windows.Forms.Button();
            this.btn_io = new System.Windows.Forms.Button();
            this.btn_nclist = new System.Windows.Forms.Button();
            this.btn_maptest = new System.Windows.Forms.Button();
            this.panel_scr = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(0, 0);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(233, 54);
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // lb_title
            // 
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.Location = new System.Drawing.Point(234, 1);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(658, 53);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "label1";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_time.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_time.Location = new System.Drawing.Point(0, 55);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(233, 25);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "label1";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_message
            // 
            this.lb_message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_message.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_message.Location = new System.Drawing.Point(234, 55);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(658, 25);
            this.lb_message.TabIndex = 3;
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_connect
            // 
            this.lb_connect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_connect.Location = new System.Drawing.Point(899, 67);
            this.lb_connect.Name = "lb_connect";
            this.lb_connect.Size = new System.Drawing.Size(95, 23);
            this.lb_connect.TabIndex = 4;
            this.lb_connect.Text = "연결 안 됨";
            this.lb_connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_conn
            // 
            this.btn_conn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_conn.Location = new System.Drawing.Point(898, 90);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(96, 47);
            this.btn_conn.TabIndex = 5;
            this.btn_conn.Text = "Connect";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_motion
            // 
            this.btn_motion.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_motion.Location = new System.Drawing.Point(898, 202);
            this.btn_motion.Name = "btn_motion";
            this.btn_motion.Size = new System.Drawing.Size(96, 47);
            this.btn_motion.TabIndex = 6;
            this.btn_motion.Text = "Motion";
            this.btn_motion.UseVisualStyleBackColor = true;
            this.btn_motion.Click += new System.EventHandler(this.btn_motion_Click);
            // 
            // btn_io
            // 
            this.btn_io.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_io.Location = new System.Drawing.Point(898, 255);
            this.btn_io.Name = "btn_io";
            this.btn_io.Size = new System.Drawing.Size(96, 47);
            this.btn_io.TabIndex = 7;
            this.btn_io.Text = "IO";
            this.btn_io.UseVisualStyleBackColor = true;
            this.btn_io.Click += new System.EventHandler(this.btn_io_Click);
            // 
            // btn_nclist
            // 
            this.btn_nclist.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_nclist.Location = new System.Drawing.Point(898, 308);
            this.btn_nclist.Name = "btn_nclist";
            this.btn_nclist.Size = new System.Drawing.Size(96, 47);
            this.btn_nclist.TabIndex = 8;
            this.btn_nclist.Text = "NC List";
            this.btn_nclist.UseVisualStyleBackColor = true;
            this.btn_nclist.Click += new System.EventHandler(this.btn_nclist_Click);
            // 
            // btn_maptest
            // 
            this.btn_maptest.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_maptest.Location = new System.Drawing.Point(898, 361);
            this.btn_maptest.Name = "btn_maptest";
            this.btn_maptest.Size = new System.Drawing.Size(96, 47);
            this.btn_maptest.TabIndex = 9;
            this.btn_maptest.Text = "Map Test";
            this.btn_maptest.UseVisualStyleBackColor = true;
            this.btn_maptest.Click += new System.EventHandler(this.btn_maptest_Click);
            // 
            // panel_scr
            // 
            this.panel_scr.Location = new System.Drawing.Point(1, 84);
            this.panel_scr.Name = "panel_scr";
            this.panel_scr.Size = new System.Drawing.Size(890, 700);
            this.panel_scr.TabIndex = 10;
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 791);
            this.Controls.Add(this.panel_scr);
            this.Controls.Add(this.btn_maptest);
            this.Controls.Add(this.btn_nclist);
            this.Controls.Add(this.btn_io);
            this.Controls.Add(this.btn_motion);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.lb_connect);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Base_Form";
            this.Text = "Base_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Base_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
 
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Label lb_connect;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_motion;
        private System.Windows.Forms.Button btn_io;
        private System.Windows.Forms.Button btn_nclist;
        private System.Windows.Forms.Button btn_maptest;
        private System.Windows.Forms.Panel panel_scr;
    }
}

