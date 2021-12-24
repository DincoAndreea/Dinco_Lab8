
namespace Dinco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GlControl1 = new OpenTK.GLControl();
            //this.GlControl1 = new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(32, 24, 0, 8));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericXeye = new System.Windows.Forms.NumericUpDown();
            this.numericYeye = new System.Windows.Forms.NumericUpDown();
            this.numericZeye = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericCameraDepth = new System.Windows.Forms.NumericUpDown();
            this.btnMouseControl2D = new System.Windows.Forms.Button();
            this.btnMouseControl3D = new System.Windows.Forms.Button();
            this.btnShowAxes = new System.Windows.Forms.Button();
            this.btnCubeQ = new System.Windows.Forms.Button();
            this.btnCubeT = new System.Windows.Forms.Button();
            this.btnResetObjects = new System.Windows.Forms.Button();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnLightsNo = new System.Windows.Forms.Button();
            this.btnLight0 = new System.Windows.Forms.Button();
            this.btnLight0Reset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.trackLight0PositionX = new System.Windows.Forms.TrackBar();
            this.trackLight0PositionY = new System.Windows.Forms.TrackBar();
            this.trackLight0PositionZ = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericLight0Ambient_Red = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericLight0Ambient_Green = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericLight0Ambient_Blue = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericLight0Difuse_Red = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericLight0Difuse_Green = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericLight0Difuse_Blue = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numericLight0Specular_Red = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numericLight0Specular_Green = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numericLight0Specular_Blue = new System.Windows.Forms.NumericUpDown();
            this.Light1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericXeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCameraDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // GlControl1
            // 
            this.GlControl1.BackColor = System.Drawing.Color.Black;
            this.GlControl1.Location = new System.Drawing.Point(13, 13);
            this.GlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GlControl1.Name = "GlControl1";
            this.GlControl1.Size = new System.Drawing.Size(881, 789);
            this.GlControl1.TabIndex = 1;
            this.GlControl1.VSync = false;
            this.GlControl1.Load += new System.EventHandler(this.GlControl1_Load);
            this.GlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1_Paint);
            this.GlControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GlControl1_KeyDown);
            this.GlControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlControl1_KeyPress);
            this.GlControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlControl1_MouseDown);
            this.GlControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControl1_MouseMove);
            this.GlControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControl1_MouseUp);
            this.GlControl1.Move += new System.EventHandler(this.btnLights_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(907, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1041, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Oy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Oz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(924, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ViewDepthX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1053, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "ViewDepthY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1193, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "ViewDepthZ";
            // 
            // numericXeye
            // 
            this.numericXeye.Location = new System.Drawing.Point(910, 70);
            this.numericXeye.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericXeye.Name = "numericXeye";
            this.numericXeye.Size = new System.Drawing.Size(112, 22);
            this.numericXeye.TabIndex = 17;
            this.numericXeye.ValueChanged += new System.EventHandler(this.numericXeye_ValueChanged);
            // 
            // numericYeye
            // 
            this.numericYeye.Location = new System.Drawing.Point(1044, 70);
            this.numericYeye.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericYeye.Name = "numericYeye";
            this.numericYeye.Size = new System.Drawing.Size(112, 22);
            this.numericYeye.TabIndex = 18;
            this.numericYeye.ValueChanged += new System.EventHandler(this.numericYeye_ValueChanged);
            // 
            // numericZeye
            // 
            this.numericZeye.Location = new System.Drawing.Point(1181, 70);
            this.numericZeye.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericZeye.Name = "numericZeye";
            this.numericZeye.Size = new System.Drawing.Size(112, 22);
            this.numericZeye.TabIndex = 19;
            this.numericZeye.ValueChanged += new System.EventHandler(this.numericZeye_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(907, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Camera depth:";
            // 
            // numericCameraDepth
            // 
            this.numericCameraDepth.Location = new System.Drawing.Point(1009, 111);
            this.numericCameraDepth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericCameraDepth.Name = "numericCameraDepth";
            this.numericCameraDepth.Size = new System.Drawing.Size(284, 22);
            this.numericCameraDepth.TabIndex = 21;
            this.numericCameraDepth.ValueChanged += new System.EventHandler(this.numericCameraDepth_ValueChanged);
            // 
            // btnMouseControl2D
            // 
            this.btnMouseControl2D.Location = new System.Drawing.Point(905, 160);
            this.btnMouseControl2D.Name = "btnMouseControl2D";
            this.btnMouseControl2D.Size = new System.Drawing.Size(388, 28);
            this.btnMouseControl2D.TabIndex = 22;
            this.btnMouseControl2D.UseVisualStyleBackColor = true;
            this.btnMouseControl2D.Click += new System.EventHandler(this.btnMouseControl2D_Click);
            this.btnMouseControl2D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMouseControl2D_KeyPress);
            // 
            // btnMouseControl3D
            // 
            this.btnMouseControl3D.Location = new System.Drawing.Point(905, 194);
            this.btnMouseControl3D.Name = "btnMouseControl3D";
            this.btnMouseControl3D.Size = new System.Drawing.Size(388, 28);
            this.btnMouseControl3D.TabIndex = 23;
            this.btnMouseControl3D.UseVisualStyleBackColor = true;
            this.btnMouseControl3D.Click += new System.EventHandler(this.btnMouseControl3D_Click);
            // 
            // btnShowAxes
            // 
            this.btnShowAxes.Location = new System.Drawing.Point(905, 228);
            this.btnShowAxes.Name = "btnShowAxes";
            this.btnShowAxes.Size = new System.Drawing.Size(388, 28);
            this.btnShowAxes.TabIndex = 24;
            this.btnShowAxes.UseVisualStyleBackColor = true;
            this.btnShowAxes.Click += new System.EventHandler(this.btnShowAxes_Click);
            // 
            // btnCubeQ
            // 
            this.btnCubeQ.Location = new System.Drawing.Point(905, 262);
            this.btnCubeQ.Name = "btnCubeQ";
            this.btnCubeQ.Size = new System.Drawing.Size(142, 34);
            this.btnCubeQ.TabIndex = 25;
            this.btnCubeQ.Text = "Load cube (quads)";
            this.btnCubeQ.UseVisualStyleBackColor = true;
            this.btnCubeQ.Click += new System.EventHandler(this.btnCubeQ_Click);
            // 
            // btnCubeT
            // 
            this.btnCubeT.Location = new System.Drawing.Point(1137, 262);
            this.btnCubeT.Name = "btnCubeT";
            this.btnCubeT.Size = new System.Drawing.Size(156, 34);
            this.btnCubeT.TabIndex = 26;
            this.btnCubeT.Text = "Load cube (triangles)";
            this.btnCubeT.UseVisualStyleBackColor = true;
            this.btnCubeT.Click += new System.EventHandler(this.btnCubeT_Click);
            // 
            // btnResetObjects
            // 
            this.btnResetObjects.Location = new System.Drawing.Point(905, 302);
            this.btnResetObjects.Name = "btnResetObjects";
            this.btnResetObjects.Size = new System.Drawing.Size(388, 28);
            this.btnResetObjects.TabIndex = 27;
            this.btnResetObjects.Text = "Reset 3D objects";
            this.btnResetObjects.UseVisualStyleBackColor = true;
            this.btnResetObjects.Click += new System.EventHandler(this.btnResetObjects_Click);
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(905, 345);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(388, 28);
            this.btnLights.TabIndex = 28;
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // btnLightsNo
            // 
            this.btnLightsNo.Location = new System.Drawing.Point(905, 379);
            this.btnLightsNo.Name = "btnLightsNo";
            this.btnLightsNo.Size = new System.Drawing.Size(94, 34);
            this.btnLightsNo.TabIndex = 57;
            this.btnLightsNo.Text = "Lights #";
            this.btnLightsNo.UseVisualStyleBackColor = true;
            this.btnLightsNo.Click += new System.EventHandler(this.btnLightsNo_Click);
            // 
            // btnLight0
            // 
            this.btnLight0.Location = new System.Drawing.Point(1008, 379);
            this.btnLight0.Name = "btnLight0";
            this.btnLight0.Size = new System.Drawing.Size(148, 34);
            this.btnLight0.TabIndex = 58;
            this.btnLight0.UseVisualStyleBackColor = true;
            this.btnLight0.Click += new System.EventHandler(this.btnLight0_Click);
            // 
            // btnLight0Reset
            // 
            this.btnLight0Reset.Location = new System.Drawing.Point(1166, 379);
            this.btnLight0Reset.Name = "btnLight0Reset";
            this.btnLight0Reset.Size = new System.Drawing.Size(127, 34);
            this.btnLight0Reset.TabIndex = 59;
            this.btnLight0Reset.Text = "Reset";
            this.btnLight0Reset.UseVisualStyleBackColor = true;
            this.btnLight0Reset.Click += new System.EventHandler(this.btnLight0Reset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(907, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Manipulare pozitie sursă 0:";
            // 
            // trackLight0PositionX
            // 
            this.trackLight0PositionX.BackColor = System.Drawing.Color.Red;
            this.trackLight0PositionX.LargeChange = 10;
            this.trackLight0PositionX.Location = new System.Drawing.Point(901, 445);
            this.trackLight0PositionX.Maximum = 50;
            this.trackLight0PositionX.Minimum = -50;
            this.trackLight0PositionX.Name = "trackLight0PositionX";
            this.trackLight0PositionX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionX.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionX.TabIndex = 61;
            this.trackLight0PositionX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionX.Scroll += new System.EventHandler(this.trackLight0PositionX_Scroll);
            // 
            // trackLight0PositionY
            // 
            this.trackLight0PositionY.BackColor = System.Drawing.Color.Gold;
            this.trackLight0PositionY.LargeChange = 10;
            this.trackLight0PositionY.Location = new System.Drawing.Point(966, 445);
            this.trackLight0PositionY.Maximum = 50;
            this.trackLight0PositionY.Minimum = -50;
            this.trackLight0PositionY.Name = "trackLight0PositionY";
            this.trackLight0PositionY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionY.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionY.TabIndex = 62;
            this.trackLight0PositionY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionY.Scroll += new System.EventHandler(this.trackLight0PositionY_Scroll);
            // 
            // trackLight0PositionZ
            // 
            this.trackLight0PositionZ.BackColor = System.Drawing.Color.LimeGreen;
            this.trackLight0PositionZ.LargeChange = 10;
            this.trackLight0PositionZ.Location = new System.Drawing.Point(1029, 445);
            this.trackLight0PositionZ.Maximum = 50;
            this.trackLight0PositionZ.Minimum = -50;
            this.trackLight0PositionZ.Name = "trackLight0PositionZ";
            this.trackLight0PositionZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionZ.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionZ.TabIndex = 63;
            this.trackLight0PositionZ.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionZ.Scroll += new System.EventHandler(this.trackLight0PositionZ_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1109, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Manipulare culoare sursă 0:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1109, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "(iluminare ambientală)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1109, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "RED";
            // 
            // numericLight0Ambient_Red
            // 
            this.numericLight0Ambient_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Red.Location = new System.Drawing.Point(1181, 467);
            this.numericLight0Ambient_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Red.Name = "numericLight0Ambient_Red";
            this.numericLight0Ambient_Red.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Ambient_Red.TabIndex = 67;
            this.numericLight0Ambient_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Red.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Red_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1109, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "GREEN";
            // 
            // numericLight0Ambient_Green
            // 
            this.numericLight0Ambient_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Green.Location = new System.Drawing.Point(1181, 496);
            this.numericLight0Ambient_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Green.Name = "numericLight0Ambient_Green";
            this.numericLight0Ambient_Green.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Ambient_Green.TabIndex = 69;
            this.numericLight0Ambient_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Green.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Green_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1112, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 70;
            this.label12.Text = "BLUE";
            // 
            // numericLight0Ambient_Blue
            // 
            this.numericLight0Ambient_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Blue.Location = new System.Drawing.Point(1181, 522);
            this.numericLight0Ambient_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Blue.Name = "numericLight0Ambient_Blue";
            this.numericLight0Ambient_Blue.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Ambient_Blue.TabIndex = 71;
            this.numericLight0Ambient_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Blue.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Blue_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1109, 549);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 17);
            this.label18.TabIndex = 72;
            this.label18.Text = "Manipulare culoare sursă 0:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1109, 568);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 73;
            this.label14.Text = "(iluminare difuză)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1109, 590);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 74;
            this.label17.Text = "RED";
            // 
            // numericLight0Difuse_Red
            // 
            this.numericLight0Difuse_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Red.Location = new System.Drawing.Point(1181, 588);
            this.numericLight0Difuse_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Red.Name = "numericLight0Difuse_Red";
            this.numericLight0Difuse_Red.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Difuse_Red.TabIndex = 75;
            this.numericLight0Difuse_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Red.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Red_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1109, 621);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 76;
            this.label16.Text = "GREEN";
            // 
            // numericLight0Difuse_Green
            // 
            this.numericLight0Difuse_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Green.Location = new System.Drawing.Point(1181, 619);
            this.numericLight0Difuse_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Green.Name = "numericLight0Difuse_Green";
            this.numericLight0Difuse_Green.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Difuse_Green.TabIndex = 77;
            this.numericLight0Difuse_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Green.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Green_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1109, 650);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 78;
            this.label15.Text = "BLUE";
            // 
            // numericLight0Difuse_Blue
            // 
            this.numericLight0Difuse_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Blue.Location = new System.Drawing.Point(1181, 648);
            this.numericLight0Difuse_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Blue.Name = "numericLight0Difuse_Blue";
            this.numericLight0Difuse_Blue.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Difuse_Blue.TabIndex = 79;
            this.numericLight0Difuse_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Blue.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Blue_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1104, 679);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 17);
            this.label23.TabIndex = 80;
            this.label23.Text = "Manipulare culoare sursă 0:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1104, 696);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 17);
            this.label19.TabIndex = 81;
            this.label19.Text = "(iluminare speculară)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1109, 718);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 17);
            this.label22.TabIndex = 82;
            this.label22.Text = "RED";
            // 
            // numericLight0Specular_Red
            // 
            this.numericLight0Specular_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Red.Location = new System.Drawing.Point(1181, 716);
            this.numericLight0Specular_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Red.Name = "numericLight0Specular_Red";
            this.numericLight0Specular_Red.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Specular_Red.TabIndex = 83;
            this.numericLight0Specular_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Red.ValueChanged += new System.EventHandler(this.numericLight0Specular_Red_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1109, 746);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 17);
            this.label21.TabIndex = 84;
            this.label21.Text = "GREEN";
            // 
            // numericLight0Specular_Green
            // 
            this.numericLight0Specular_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Green.Location = new System.Drawing.Point(1181, 744);
            this.numericLight0Specular_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Green.Name = "numericLight0Specular_Green";
            this.numericLight0Specular_Green.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Specular_Green.TabIndex = 85;
            this.numericLight0Specular_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Green.ValueChanged += new System.EventHandler(this.numericLight0Specular_Green_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1109, 774);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 86;
            this.label20.Text = "BLUE";
            // 
            // numericLight0Specular_Blue
            // 
            this.numericLight0Specular_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Blue.Location = new System.Drawing.Point(1181, 772);
            this.numericLight0Specular_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Blue.Name = "numericLight0Specular_Blue";
            this.numericLight0Specular_Blue.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Specular_Blue.TabIndex = 87;
            this.numericLight0Specular_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Blue.ValueChanged += new System.EventHandler(this.numericLight0Specular_Blue_ValueChanged);
            // 
            // Light1
            // 
            this.Light1.Location = new System.Drawing.Point(1052, 262);
            this.Light1.Name = "Light1";
            this.Light1.Size = new System.Drawing.Size(79, 33);
            this.Light1.TabIndex = 88;
            this.Light1.Text = "Light1";
            this.Light1.UseVisualStyleBackColor = true;
            this.Light1.Click += new System.EventHandler(this.Light1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 811);
            this.Controls.Add(this.Light1);
            this.Controls.Add(this.numericLight0Specular_Blue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.numericLight0Specular_Green);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.numericLight0Specular_Red);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.numericLight0Difuse_Blue);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericLight0Difuse_Green);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericLight0Difuse_Red);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericLight0Ambient_Blue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericLight0Ambient_Green);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericLight0Ambient_Red);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackLight0PositionZ);
            this.Controls.Add(this.trackLight0PositionY);
            this.Controls.Add(this.trackLight0PositionX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLight0Reset);
            this.Controls.Add(this.btnLight0);
            this.Controls.Add(this.btnLightsNo);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.btnResetObjects);
            this.Controls.Add(this.btnCubeT);
            this.Controls.Add(this.btnCubeQ);
            this.Controls.Add(this.btnShowAxes);
            this.Controls.Add(this.btnMouseControl3D);
            this.Controls.Add(this.btnMouseControl2D);
            this.Controls.Add(this.numericCameraDepth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericZeye);
            this.Controls.Add(this.numericYeye);
            this.Controls.Add(this.numericXeye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GlControl1);
            this.Name = "Form1";
            this.Text = "Illumination";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericXeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCameraDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl GlControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericXeye;
        private System.Windows.Forms.NumericUpDown numericYeye;
        private System.Windows.Forms.NumericUpDown numericZeye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericCameraDepth;
        private System.Windows.Forms.Button btnMouseControl2D;
        private System.Windows.Forms.Button btnMouseControl3D;
        private System.Windows.Forms.Button btnShowAxes;
        private System.Windows.Forms.Button btnCubeQ;
        private System.Windows.Forms.Button btnCubeT;
        private System.Windows.Forms.Button btnResetObjects;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnLightsNo;
        private System.Windows.Forms.Button btnLight0;
        private System.Windows.Forms.Button btnLight0Reset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackLight0PositionX;
        private System.Windows.Forms.TrackBar trackLight0PositionY;
        private System.Windows.Forms.TrackBar trackLight0PositionZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Red;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Green;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Blue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Red;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Green;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Blue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Red;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Green;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Blue;
        private System.Windows.Forms.Button Light1;
    }
}