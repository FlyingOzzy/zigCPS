namespace HXApiTesterCS
{
    partial class scr_MapTest
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_get_mapname = new System.Windows.Forms.ComboBox();
            this.text_get_addr = new System.Windows.Forms.TextBox();
            this.text_get_bit = new System.Windows.Forms.TextBox();
            this.text_get_axis = new System.Windows.Forms.TextBox();
            this.text_get_value = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.text_set_value = new System.Windows.Forms.TextBox();
            this.text_set_axis = new System.Windows.Forms.TextBox();
            this.text_set_bit = new System.Windows.Forms.TextBox();
            this.text_set_address = new System.Windows.Forms.TextBox();
            this.cmb_set_mapname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_set_checkValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tester";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Map Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(148, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(238, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(310, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Axis";
            // 
            // cmb_get_mapname
            // 
            this.cmb_get_mapname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_get_mapname.FormattingEnabled = true;
            this.cmb_get_mapname.Location = new System.Drawing.Point(22, 77);
            this.cmb_get_mapname.Name = "cmb_get_mapname";
            this.cmb_get_mapname.Size = new System.Drawing.Size(107, 23);
            this.cmb_get_mapname.TabIndex = 5;
            // 
            // text_get_addr
            // 
            this.text_get_addr.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_get_addr.Location = new System.Drawing.Point(139, 77);
            this.text_get_addr.Name = "text_get_addr";
            this.text_get_addr.Size = new System.Drawing.Size(66, 23);
            this.text_get_addr.TabIndex = 6;
            this.text_get_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_get_bit
            // 
            this.text_get_bit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_get_bit.Location = new System.Drawing.Point(215, 77);
            this.text_get_bit.Name = "text_get_bit";
            this.text_get_bit.Size = new System.Drawing.Size(66, 23);
            this.text_get_bit.TabIndex = 7;
            this.text_get_bit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_get_axis
            // 
            this.text_get_axis.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_get_axis.Location = new System.Drawing.Point(291, 77);
            this.text_get_axis.Name = "text_get_axis";
            this.text_get_axis.Size = new System.Drawing.Size(66, 23);
            this.text_get_axis.TabIndex = 8;
            this.text_get_axis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_get_value
            // 
            this.text_get_value.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_get_value.Location = new System.Drawing.Point(139, 111);
            this.text_get_value.Name = "text_get_value";
            this.text_get_value.Size = new System.Drawing.Size(218, 23);
            this.text_get_value.TabIndex = 9;
            this.text_get_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_get.Location = new System.Drawing.Point(367, 77);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(60, 57);
            this.btn_get.TabIndex = 10;
            this.btn_get.Text = "GET";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_set
            // 
            this.btn_set.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_set.Location = new System.Drawing.Point(367, 272);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(60, 57);
            this.btn_set.TabIndex = 20;
            this.btn_set.Text = "SET";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // text_set_value
            // 
            this.text_set_value.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_set_value.Location = new System.Drawing.Point(139, 274);
            this.text_set_value.Name = "text_set_value";
            this.text_set_value.Size = new System.Drawing.Size(218, 23);
            this.text_set_value.TabIndex = 19;
            this.text_set_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_set_axis
            // 
            this.text_set_axis.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_set_axis.Location = new System.Drawing.Point(291, 240);
            this.text_set_axis.Name = "text_set_axis";
            this.text_set_axis.Size = new System.Drawing.Size(66, 23);
            this.text_set_axis.TabIndex = 18;
            this.text_set_axis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_set_bit
            // 
            this.text_set_bit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_set_bit.Location = new System.Drawing.Point(215, 240);
            this.text_set_bit.Name = "text_set_bit";
            this.text_set_bit.Size = new System.Drawing.Size(66, 23);
            this.text_set_bit.TabIndex = 17;
            this.text_set_bit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_set_address
            // 
            this.text_set_address.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_set_address.Location = new System.Drawing.Point(139, 240);
            this.text_set_address.Name = "text_set_address";
            this.text_set_address.Size = new System.Drawing.Size(66, 23);
            this.text_set_address.TabIndex = 16;
            this.text_set_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_set_mapname
            // 
            this.cmb_set_mapname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_set_mapname.FormattingEnabled = true;
            this.cmb_set_mapname.Location = new System.Drawing.Point(22, 240);
            this.cmb_set_mapname.Name = "cmb_set_mapname";
            this.cmb_set_mapname.Size = new System.Drawing.Size(107, 23);
            this.cmb_set_mapname.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(310, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Axis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(238, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(148, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(42, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Map Name";
            // 
            // text_set_checkValue
            // 
            this.text_set_checkValue.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_set_checkValue.Location = new System.Drawing.Point(139, 303);
            this.text_set_checkValue.Name = "text_set_checkValue";
            this.text_set_checkValue.Size = new System.Drawing.Size(218, 23);
            this.text_set_checkValue.TabIndex = 21;
            this.text_set_checkValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(71, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Set Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(98, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "확인";
            // 
            // scr_MapTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_set_checkValue);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.text_set_value);
            this.Controls.Add(this.text_set_axis);
            this.Controls.Add(this.text_set_bit);
            this.Controls.Add(this.text_set_address);
            this.Controls.Add(this.cmb_set_mapname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.text_get_value);
            this.Controls.Add(this.text_get_axis);
            this.Controls.Add(this.text_get_bit);
            this.Controls.Add(this.text_get_addr);
            this.Controls.Add(this.cmb_get_mapname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "scr_MapTest";
            this.Size = new System.Drawing.Size(445, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_get_mapname;
        private System.Windows.Forms.TextBox text_get_addr;
        private System.Windows.Forms.TextBox text_get_bit;
        private System.Windows.Forms.TextBox text_get_axis;
        private System.Windows.Forms.TextBox text_get_value;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.TextBox text_set_value;
        private System.Windows.Forms.TextBox text_set_axis;
        private System.Windows.Forms.TextBox text_set_bit;
        private System.Windows.Forms.TextBox text_set_address;
        private System.Windows.Forms.ComboBox cmb_set_mapname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_set_checkValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
