namespace HXApiTesterCS
{
    partial class scr_IO
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
            this.components = new System.ComponentModel.Container();
            this.cmb_device = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.lb_mapname = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.io_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmb_device
            // 
            this.cmb_device.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_device.FormattingEnabled = true;
            this.cmb_device.Items.AddRange(new object[] {
            "AXIS 01",
            "AXIS 02",
            "AXIS 03",
            "AXIS 04",
            "AXIS 05",
            "AXIS 06"});
            this.cmb_device.Location = new System.Drawing.Point(164, 53);
            this.cmb_device.Name = "cmb_device";
            this.cmb_device.Size = new System.Drawing.Size(213, 23);
            this.cmb_device.TabIndex = 4;
            this.cmb_device.SelectedIndexChanged += new System.EventHandler(this.cmb_device_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Device : ";
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_title.Location = new System.Drawing.Point(3, 7);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(439, 23);
            this.lb_title.TabIndex = 20;
            this.lb_title.Text = "IO";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Location = new System.Drawing.Point(22, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 45);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "00";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox2.Location = new System.Drawing.Point(73, 129);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 45);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "01";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox3.Location = new System.Drawing.Point(124, 129);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(45, 45);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "02";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox4.Location = new System.Drawing.Point(175, 129);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(45, 45);
            this.checkBox4.TabIndex = 24;
            this.checkBox4.Text = "03";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox5.Location = new System.Drawing.Point(226, 129);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 45);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.Text = "04";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox6.Location = new System.Drawing.Point(277, 129);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(45, 45);
            this.checkBox6.TabIndex = 26;
            this.checkBox6.Text = "05";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox7.Location = new System.Drawing.Point(328, 129);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(45, 45);
            this.checkBox7.TabIndex = 27;
            this.checkBox7.Text = "06";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox8.Location = new System.Drawing.Point(379, 129);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(45, 45);
            this.checkBox8.TabIndex = 28;
            this.checkBox8.Text = "07";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // lb_mapname
            // 
            this.lb_mapname.AutoSize = true;
            this.lb_mapname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_mapname.Location = new System.Drawing.Point(22, 111);
            this.lb_mapname.Name = "lb_mapname";
            this.lb_mapname.Size = new System.Drawing.Size(28, 15);
            this.lb_mapname.TabIndex = 29;
            this.lb_mapname.Text = "X 0.";
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox9.Location = new System.Drawing.Point(22, 179);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(45, 45);
            this.checkBox9.TabIndex = 30;
            this.checkBox9.Text = "08";
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox10.Location = new System.Drawing.Point(73, 179);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(45, 45);
            this.checkBox10.TabIndex = 31;
            this.checkBox10.Text = "09";
            this.checkBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox11.Location = new System.Drawing.Point(124, 179);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(45, 45);
            this.checkBox11.TabIndex = 32;
            this.checkBox11.Text = "10";
            this.checkBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox12.Location = new System.Drawing.Point(175, 179);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(45, 45);
            this.checkBox12.TabIndex = 33;
            this.checkBox12.Text = "11";
            this.checkBox12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox13.Location = new System.Drawing.Point(226, 179);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(45, 45);
            this.checkBox13.TabIndex = 34;
            this.checkBox13.Text = "12";
            this.checkBox13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox14.Location = new System.Drawing.Point(277, 179);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(45, 45);
            this.checkBox14.TabIndex = 35;
            this.checkBox14.Text = "13";
            this.checkBox14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox15.Location = new System.Drawing.Point(328, 179);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(45, 45);
            this.checkBox15.TabIndex = 36;
            this.checkBox15.Text = "14";
            this.checkBox15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox16.Location = new System.Drawing.Point(379, 179);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(45, 45);
            this.checkBox16.TabIndex = 37;
            this.checkBox16.Text = "15";
            this.checkBox16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox17.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox17.Location = new System.Drawing.Point(22, 229);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(45, 45);
            this.checkBox17.TabIndex = 38;
            this.checkBox17.Text = "16";
            this.checkBox17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox18.Location = new System.Drawing.Point(73, 229);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(45, 45);
            this.checkBox18.TabIndex = 39;
            this.checkBox18.Text = "17";
            this.checkBox18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox19.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox19.Location = new System.Drawing.Point(124, 229);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(45, 45);
            this.checkBox19.TabIndex = 40;
            this.checkBox19.Text = "18";
            this.checkBox19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox20.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox20.Location = new System.Drawing.Point(175, 229);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(45, 45);
            this.checkBox20.TabIndex = 41;
            this.checkBox20.Text = "19";
            this.checkBox20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox21.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox21.Location = new System.Drawing.Point(226, 229);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(45, 45);
            this.checkBox21.TabIndex = 42;
            this.checkBox21.Text = "20";
            this.checkBox21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox22.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox22.Location = new System.Drawing.Point(277, 229);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(45, 45);
            this.checkBox22.TabIndex = 43;
            this.checkBox22.Text = "21";
            this.checkBox22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox23.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox23.Location = new System.Drawing.Point(328, 229);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(45, 45);
            this.checkBox23.TabIndex = 44;
            this.checkBox23.Text = "22";
            this.checkBox23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox24.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox24.Location = new System.Drawing.Point(379, 229);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(45, 45);
            this.checkBox24.TabIndex = 45;
            this.checkBox24.Text = "23";
            this.checkBox24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox25.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox25.Location = new System.Drawing.Point(22, 279);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(45, 45);
            this.checkBox25.TabIndex = 46;
            this.checkBox25.Text = "24";
            this.checkBox25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox26.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox26.Location = new System.Drawing.Point(73, 279);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(45, 45);
            this.checkBox26.TabIndex = 47;
            this.checkBox26.Text = "25";
            this.checkBox26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox27.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox27.Location = new System.Drawing.Point(124, 279);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(45, 45);
            this.checkBox27.TabIndex = 48;
            this.checkBox27.Text = "26";
            this.checkBox27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox28.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox28.Location = new System.Drawing.Point(175, 279);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(45, 45);
            this.checkBox28.TabIndex = 49;
            this.checkBox28.Text = "27";
            this.checkBox28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox29.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox29.Location = new System.Drawing.Point(226, 279);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(45, 45);
            this.checkBox29.TabIndex = 50;
            this.checkBox29.Text = "28";
            this.checkBox29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox30.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox30.Location = new System.Drawing.Point(277, 279);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(45, 45);
            this.checkBox30.TabIndex = 51;
            this.checkBox30.Text = "29";
            this.checkBox30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox31.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox31.Location = new System.Drawing.Point(328, 279);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(45, 45);
            this.checkBox31.TabIndex = 52;
            this.checkBox31.Text = "30";
            this.checkBox31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox32
            // 
            this.checkBox32.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox32.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox32.Location = new System.Drawing.Point(379, 279);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(45, 45);
            this.checkBox32.TabIndex = 53;
            this.checkBox32.Text = "31";
            this.checkBox32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // io_timer
            // 
            this.io_timer.Tick += new System.EventHandler(this.io_timer_Tick);
            // 
            // scr_IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox32);
            this.Controls.Add(this.checkBox31);
            this.Controls.Add(this.checkBox30);
            this.Controls.Add(this.checkBox29);
            this.Controls.Add(this.checkBox28);
            this.Controls.Add(this.checkBox27);
            this.Controls.Add(this.checkBox26);
            this.Controls.Add(this.checkBox25);
            this.Controls.Add(this.checkBox24);
            this.Controls.Add(this.checkBox23);
            this.Controls.Add(this.checkBox22);
            this.Controls.Add(this.checkBox21);
            this.Controls.Add(this.checkBox20);
            this.Controls.Add(this.checkBox19);
            this.Controls.Add(this.checkBox18);
            this.Controls.Add(this.checkBox17);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.lb_mapname);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.cmb_device);
            this.Controls.Add(this.label2);
            this.Name = "scr_IO";
            this.Size = new System.Drawing.Size(445, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_device;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label lb_mapname;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.Timer io_timer;
    }
}
