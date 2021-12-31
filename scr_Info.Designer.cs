namespace HXApiTesterCS
{
    partial class scr_Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_axis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ab_use = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ab_max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ab_min = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_step_vel = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_tar_vel = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_jog_vel = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_dog = new System.Windows.Forms.CheckBox();
            this.cb_random = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_homing_ban = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_homing_2nd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_homing_1st = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_homing_vel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_homing_acc = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information /  Setup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(49, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Axis : ";
            // 
            // cmb_axis
            // 
            this.cmb_axis.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_axis.FormattingEnabled = true;
            this.cmb_axis.Items.AddRange(new object[] {
            "AXIS 01",
            "AXIS 02",
            "AXIS 03",
            "AXIS 04",
            "AXIS 05",
            "AXIS 06"});
            this.cmb_axis.Location = new System.Drawing.Point(170, 40);
            this.cmb_axis.Name = "cmb_axis";
            this.cmb_axis.Size = new System.Drawing.Size(213, 23);
            this.cmb_axis.TabIndex = 2;
            this.cmb_axis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ab_use);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(17, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limit Value(한계 설정)";
            // 
            // cb_ab_use
            // 
            this.cb_ab_use.AutoSize = true;
            this.cb_ab_use.Location = new System.Drawing.Point(164, 12);
            this.cb_ab_use.Name = "cb_ab_use";
            this.cb_ab_use.Size = new System.Drawing.Size(47, 19);
            this.cb_ab_use.TabIndex = 21;
            this.cb_ab_use.Text = "USE";
            this.cb_ab_use.UseVisualStyleBackColor = true;
            this.cb_ab_use.CheckedChanged += new System.EventHandler(this.cb_ab_use_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_ab_max);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_ab_min);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(18, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Absolute Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max :";
            // 
            // tb_ab_max
            // 
            this.tb_ab_max.Location = new System.Drawing.Point(68, 57);
            this.tb_ab_max.Name = "tb_ab_max";
            this.tb_ab_max.Size = new System.Drawing.Size(100, 23);
            this.tb_ab_max.TabIndex = 5;
            this.tb_ab_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ab_max_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Min : ";
            // 
            // tb_ab_min
            // 
            this.tb_ab_min.Location = new System.Drawing.Point(68, 22);
            this.tb_ab_min.Name = "tb_ab_min";
            this.tb_ab_min.Size = new System.Drawing.Size(100, 23);
            this.tb_ab_min.TabIndex = 4;
            this.tb_ab_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ab_min_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(17, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Value";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tb_step_vel);
            this.groupBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(18, 90);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 60);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step Move";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Velocity";
            // 
            // tb_step_vel
            // 
            this.tb_step_vel.Location = new System.Drawing.Point(68, 22);
            this.tb_step_vel.Name = "tb_step_vel";
            this.tb_step_vel.Size = new System.Drawing.Size(100, 23);
            this.tb_step_vel.TabIndex = 6;
            this.tb_step_vel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_step_vel_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tb_tar_vel);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(215, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 60);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target Pos. Move";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Velocity";
            // 
            // tb_tar_vel
            // 
            this.tb_tar_vel.Location = new System.Drawing.Point(68, 23);
            this.tb_tar_vel.Name = "tb_tar_vel";
            this.tb_tar_vel.Size = new System.Drawing.Size(100, 23);
            this.tb_tar_vel.TabIndex = 8;
            this.tb_tar_vel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tar_vel_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tb_jog_vel);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(18, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 60);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "JOG Move";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Velocity";
            // 
            // tb_jog_vel
            // 
            this.tb_jog_vel.Location = new System.Drawing.Point(68, 22);
            this.tb_jog_vel.Name = "tb_jog_vel";
            this.tb_jog_vel.Size = new System.Drawing.Size(100, 23);
            this.tb_jog_vel.TabIndex = 4;
            this.tb_jog_vel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jog_vel_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.cb_dog);
            this.groupBox7.Controls.Add(this.cb_random);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.tb_homing_ban);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.tb_homing_2nd);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.tb_homing_1st);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.tb_homing_vel);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.tb_homing_acc);
            this.groupBox7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(17, 402);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(412, 164);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Homing Move";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "mm,de";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_dog
            // 
            this.cb_dog.AutoSize = true;
            this.cb_dog.Location = new System.Drawing.Point(102, 131);
            this.cb_dog.Name = "cb_dog";
            this.cb_dog.Size = new System.Drawing.Size(80, 19);
            this.cb_dog.TabIndex = 19;
            this.cb_dog.Text = "DOG 사용";
            this.cb_dog.UseVisualStyleBackColor = true;
            this.cb_dog.CheckedChanged += new System.EventHandler(this.cb_dog_CheckedChanged);
            // 
            // cb_random
            // 
            this.cb_random.AutoSize = true;
            this.cb_random.Location = new System.Drawing.Point(18, 131);
            this.cb_random.Name = "cb_random";
            this.cb_random.Size = new System.Drawing.Size(78, 19);
            this.cb_random.TabIndex = 18;
            this.cb_random.Text = "임의 원점";
            this.cb_random.UseVisualStyleBackColor = true;
            this.cb_random.CheckedChanged += new System.EventHandler(this.cb_random_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "금지영역 :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_homing_ban
            // 
            this.tb_homing_ban.Location = new System.Drawing.Point(247, 97);
            this.tb_homing_ban.Name = "tb_homing_ban";
            this.tb_homing_ban.Size = new System.Drawing.Size(66, 23);
            this.tb_homing_ban.TabIndex = 16;
            this.tb_homing_ban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_homing_ban_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 30);
            this.label13.TabIndex = 15;
            this.label13.Text = "2nd Decel\r\nVelocity : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_homing_2nd
            // 
            this.tb_homing_2nd.Location = new System.Drawing.Point(333, 55);
            this.tb_homing_2nd.Name = "tb_homing_2nd";
            this.tb_homing_2nd.Size = new System.Drawing.Size(66, 23);
            this.tb_homing_2nd.TabIndex = 14;
            this.tb_homing_2nd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_homing_2nd_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "1st Decel\r\nVelocity : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_homing_1st
            // 
            this.tb_homing_1st.Location = new System.Drawing.Point(333, 22);
            this.tb_homing_1st.Name = "tb_homing_1st";
            this.tb_homing_1st.Size = new System.Drawing.Size(66, 23);
            this.tb_homing_1st.TabIndex = 12;
            this.tb_homing_1st.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_homing_1st_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Velocity :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_homing_vel
            // 
            this.tb_homing_vel.Location = new System.Drawing.Point(194, 54);
            this.tb_homing_vel.Name = "tb_homing_vel";
            this.tb_homing_vel.Size = new System.Drawing.Size(66, 23);
            this.tb_homing_vel.TabIndex = 10;
            this.tb_homing_vel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_homing_vel_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "Accel :\r\n(ms)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_homing_acc
            // 
            this.tb_homing_acc.Location = new System.Drawing.Point(194, 25);
            this.tb_homing_acc.Name = "tb_homing_acc";
            this.tb_homing_acc.Size = new System.Drawing.Size(66, 23);
            this.tb_homing_acc.TabIndex = 8;
            this.tb_homing_acc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_homing_acc_KeyPress);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_reset.Location = new System.Drawing.Point(17, 597);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(85, 85);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // scr_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_axis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "scr_Info";
            this.Size = new System.Drawing.Size(445, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_axis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ab_max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ab_min;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_step_vel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_tar_vel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_jog_vel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_homing_vel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_homing_acc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_homing_2nd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_homing_1st;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_homing_ban;
        private System.Windows.Forms.CheckBox cb_dog;
        private System.Windows.Forms.CheckBox cb_random;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox cb_ab_use;
    }
}
