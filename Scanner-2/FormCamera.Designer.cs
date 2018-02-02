namespace Scanner_2
{
    partial class FormCamera
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCamera));
            this.btnRefreshScreens = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerPattern = new System.Windows.Forms.Timer(this.components);
            this.picBoxA = new System.Windows.Forms.PictureBox();
            this.picBoxB = new System.Windows.Forms.PictureBox();
            this.picBoxC = new System.Windows.Forms.PictureBox();
            this.picBoxD = new System.Windows.Forms.PictureBox();
            this.chbxCamA = new System.Windows.Forms.CheckBox();
            this.chbxCamB = new System.Windows.Forms.CheckBox();
            this.chbxCamC = new System.Windows.Forms.CheckBox();
            this.chbxCamD = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.cmbxSpeed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCamC = new System.Windows.Forms.Label();
            this.lblCamD = new System.Windows.Forms.Label();
            this.lblCamB = new System.Windows.Forms.Label();
            this.lblCamA = new System.Windows.Forms.Label();
            this.chbxPattern = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetResolution = new System.Windows.Forms.Button();
            this.btnGetCurrentRes = new System.Windows.Forms.Button();
            this.lblCamDRes = new System.Windows.Forms.Label();
            this.lblCamCRes = new System.Windows.Forms.Label();
            this.lblCamBRes = new System.Windows.Forms.Label();
            this.lblCamARes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxResolution = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.chbxCameraAFlipHor = new System.Windows.Forms.CheckBox();
            this.chbxCameraBFlipHor = new System.Windows.Forms.CheckBox();
            this.chbxCameraCFlipHor = new System.Windows.Forms.CheckBox();
            this.chbxCameraDFlipHor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefreshScreens
            // 
            this.btnRefreshScreens.Location = new System.Drawing.Point(6, 23);
            this.btnRefreshScreens.Name = "btnRefreshScreens";
            this.btnRefreshScreens.Size = new System.Drawing.Size(142, 22);
            this.btnRefreshScreens.TabIndex = 0;
            this.btnRefreshScreens.Text = "Refresh List of Screens";
            this.btnRefreshScreens.UseVisualStyleBackColor = true;
            this.btnRefreshScreens.Click += new System.EventHandler(this.btnRefreshScreens_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Primary"});
            this.comboBox1.Location = new System.Drawing.Point(157, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timerPattern
            // 
            this.timerPattern.Interval = 1000;
            this.timerPattern.Tick += new System.EventHandler(this.timerPattern_Tick);
            // 
            // picBoxA
            // 
            this.picBoxA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxA.BackgroundImage")));
            this.picBoxA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxA.Location = new System.Drawing.Point(12, 26);
            this.picBoxA.Name = "picBoxA";
            this.picBoxA.Size = new System.Drawing.Size(320, 240);
            this.picBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxA.TabIndex = 5;
            this.picBoxA.TabStop = false;
            // 
            // picBoxB
            // 
            this.picBoxB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxB.BackgroundImage")));
            this.picBoxB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxB.Location = new System.Drawing.Point(338, 26);
            this.picBoxB.Name = "picBoxB";
            this.picBoxB.Size = new System.Drawing.Size(320, 240);
            this.picBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxB.TabIndex = 7;
            this.picBoxB.TabStop = false;
            // 
            // picBoxC
            // 
            this.picBoxC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxC.BackgroundImage")));
            this.picBoxC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxC.Location = new System.Drawing.Point(12, 311);
            this.picBoxC.Name = "picBoxC";
            this.picBoxC.Size = new System.Drawing.Size(320, 240);
            this.picBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxC.TabIndex = 9;
            this.picBoxC.TabStop = false;
            // 
            // picBoxD
            // 
            this.picBoxD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxD.BackgroundImage")));
            this.picBoxD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxD.Location = new System.Drawing.Point(338, 311);
            this.picBoxD.Name = "picBoxD";
            this.picBoxD.Size = new System.Drawing.Size(320, 240);
            this.picBoxD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxD.TabIndex = 11;
            this.picBoxD.TabStop = false;
            // 
            // chbxCamA
            // 
            this.chbxCamA.AutoSize = true;
            this.chbxCamA.Checked = true;
            this.chbxCamA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxCamA.Location = new System.Drawing.Point(9, 50);
            this.chbxCamA.Name = "chbxCamA";
            this.chbxCamA.Size = new System.Drawing.Size(78, 18);
            this.chbxCamA.TabIndex = 13;
            this.chbxCamA.Text = "Camera A";
            this.chbxCamA.UseVisualStyleBackColor = true;
            // 
            // chbxCamB
            // 
            this.chbxCamB.AutoSize = true;
            this.chbxCamB.Checked = true;
            this.chbxCamB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxCamB.Location = new System.Drawing.Point(184, 50);
            this.chbxCamB.Name = "chbxCamB";
            this.chbxCamB.Size = new System.Drawing.Size(77, 18);
            this.chbxCamB.TabIndex = 14;
            this.chbxCamB.Text = "Camera B";
            this.chbxCamB.UseVisualStyleBackColor = true;
            // 
            // chbxCamC
            // 
            this.chbxCamC.AutoSize = true;
            this.chbxCamC.Location = new System.Drawing.Point(9, 74);
            this.chbxCamC.Name = "chbxCamC";
            this.chbxCamC.Size = new System.Drawing.Size(77, 18);
            this.chbxCamC.TabIndex = 15;
            this.chbxCamC.Text = "Camera C";
            this.chbxCamC.UseVisualStyleBackColor = true;
            // 
            // chbxCamD
            // 
            this.chbxCamD.AutoSize = true;
            this.chbxCamD.Location = new System.Drawing.Point(184, 74);
            this.chbxCamD.Name = "chbxCamD";
            this.chbxCamD.Size = new System.Drawing.Size(78, 18);
            this.chbxCamD.TabIndex = 16;
            this.chbxCamD.Text = "Camera D";
            this.chbxCamD.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 131);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 14);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "C:\\Temp";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Storing Path";
            // 
            // btnDoIt
            // 
            this.btnDoIt.Location = new System.Drawing.Point(854, 508);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(130, 22);
            this.btnDoIt.TabIndex = 20;
            this.btnDoIt.Text = "Do It!";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // cmbxSpeed
            // 
            this.cmbxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSpeed.FormattingEnabled = true;
            this.cmbxSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "8",
            "10",
            "12",
            "15",
            "20",
            "25"});
            this.cmbxSpeed.Location = new System.Drawing.Point(99, 51);
            this.cmbxSpeed.Name = "cmbxSpeed";
            this.cmbxSpeed.Size = new System.Drawing.Size(49, 22);
            this.cmbxSpeed.TabIndex = 21;
            this.cmbxSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbxSpeed_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pattern per Second";
            // 
            // lblCamC
            // 
            this.lblCamC.AutoSize = true;
            this.lblCamC.Location = new System.Drawing.Point(12, 294);
            this.lblCamC.Name = "lblCamC";
            this.lblCamC.Size = new System.Drawing.Size(58, 14);
            this.lblCamC.TabIndex = 10;
            this.lblCamC.Text = "Camera C";
            // 
            // lblCamD
            // 
            this.lblCamD.AutoSize = true;
            this.lblCamD.Location = new System.Drawing.Point(335, 294);
            this.lblCamD.Name = "lblCamD";
            this.lblCamD.Size = new System.Drawing.Size(59, 14);
            this.lblCamD.TabIndex = 12;
            this.lblCamD.Text = "Camera D";
            // 
            // lblCamB
            // 
            this.lblCamB.AutoSize = true;
            this.lblCamB.Location = new System.Drawing.Point(335, 9);
            this.lblCamB.Name = "lblCamB";
            this.lblCamB.Size = new System.Drawing.Size(58, 14);
            this.lblCamB.TabIndex = 8;
            this.lblCamB.Text = "Camera B";
            // 
            // lblCamA
            // 
            this.lblCamA.AutoSize = true;
            this.lblCamA.Location = new System.Drawing.Point(12, 9);
            this.lblCamA.Name = "lblCamA";
            this.lblCamA.Size = new System.Drawing.Size(59, 14);
            this.lblCamA.TabIndex = 6;
            this.lblCamA.Text = "Camera A";
            // 
            // chbxPattern
            // 
            this.chbxPattern.AutoSize = true;
            this.chbxPattern.Checked = true;
            this.chbxPattern.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxPattern.Location = new System.Drawing.Point(9, 26);
            this.chbxPattern.Name = "chbxPattern";
            this.chbxPattern.Size = new System.Drawing.Size(67, 18);
            this.chbxPattern.TabIndex = 24;
            this.chbxPattern.Text = "Pattern";
            this.chbxPattern.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chbxPattern);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.chbxCamA);
            this.groupBox1.Controls.Add(this.chbxCamB);
            this.groupBox1.Controls.Add(this.chbxCamD);
            this.groupBox1.Controls.Add(this.chbxCamC);
            this.groupBox1.Location = new System.Drawing.Point(664, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Images";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnRefreshScreens);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbxSpeed);
            this.groupBox2.Location = new System.Drawing.Point(664, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 104);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pattern";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetResolution);
            this.groupBox3.Controls.Add(this.btnGetCurrentRes);
            this.groupBox3.Controls.Add(this.lblCamDRes);
            this.groupBox3.Controls.Add(this.lblCamCRes);
            this.groupBox3.Controls.Add(this.lblCamBRes);
            this.groupBox3.Controls.Add(this.lblCamARes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbxResolution);
            this.groupBox3.Location = new System.Drawing.Point(664, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 144);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // btnSetResolution
            // 
            this.btnSetResolution.Location = new System.Drawing.Point(213, 33);
            this.btnSetResolution.Name = "btnSetResolution";
            this.btnSetResolution.Size = new System.Drawing.Size(101, 22);
            this.btnSetResolution.TabIndex = 29;
            this.btnSetResolution.Text = "Set Resolution";
            this.btnSetResolution.UseVisualStyleBackColor = true;
            this.btnSetResolution.Click += new System.EventHandler(this.btnSetResolution_Click);
            // 
            // btnGetCurrentRes
            // 
            this.btnGetCurrentRes.Location = new System.Drawing.Point(9, 53);
            this.btnGetCurrentRes.Name = "btnGetCurrentRes";
            this.btnGetCurrentRes.Size = new System.Drawing.Size(92, 22);
            this.btnGetCurrentRes.TabIndex = 28;
            this.btnGetCurrentRes.Text = "Get Current";
            this.btnGetCurrentRes.UseVisualStyleBackColor = true;
            this.btnGetCurrentRes.Click += new System.EventHandler(this.btnGetCurrentRes_Click);
            // 
            // lblCamDRes
            // 
            this.lblCamDRes.AutoSize = true;
            this.lblCamDRes.Location = new System.Drawing.Point(6, 120);
            this.lblCamDRes.Name = "lblCamDRes";
            this.lblCamDRes.Size = new System.Drawing.Size(59, 14);
            this.lblCamDRes.TabIndex = 27;
            this.lblCamDRes.Text = "Camera D";
            // 
            // lblCamCRes
            // 
            this.lblCamCRes.AutoSize = true;
            this.lblCamCRes.Location = new System.Drawing.Point(6, 106);
            this.lblCamCRes.Name = "lblCamCRes";
            this.lblCamCRes.Size = new System.Drawing.Size(58, 14);
            this.lblCamCRes.TabIndex = 26;
            this.lblCamCRes.Text = "Camera C";
            // 
            // lblCamBRes
            // 
            this.lblCamBRes.AutoSize = true;
            this.lblCamBRes.Location = new System.Drawing.Point(6, 92);
            this.lblCamBRes.Name = "lblCamBRes";
            this.lblCamBRes.Size = new System.Drawing.Size(58, 14);
            this.lblCamBRes.TabIndex = 25;
            this.lblCamBRes.Text = "Camera B";
            // 
            // lblCamARes
            // 
            this.lblCamARes.AutoSize = true;
            this.lblCamARes.Location = new System.Drawing.Point(6, 78);
            this.lblCamARes.Name = "lblCamARes";
            this.lblCamARes.Size = new System.Drawing.Size(59, 14);
            this.lblCamARes.TabIndex = 24;
            this.lblCamARes.Text = "Camera A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "[Try] Resolution";
            // 
            // cmbxResolution
            // 
            this.cmbxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxResolution.FormattingEnabled = true;
            this.cmbxResolution.Items.AddRange(new object[] {
            "640 x 480",
            "800 x 600",
            "1024 x 576",
            "1024 x 640",
            "1024 x 768",
            "1280 x 720",
            "1280 x 960",
            "1280 x 1024",
            "1600 x 900",
            "1600 x 1200",
            "1920 x 1080",
            "1920 x 1200",
            "2048 x 1536",
            "2560 x 1920"});
            this.cmbxResolution.Location = new System.Drawing.Point(107, 33);
            this.cmbxResolution.Name = "cmbxResolution";
            this.cmbxResolution.Size = new System.Drawing.Size(100, 22);
            this.cmbxResolution.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(667, 533);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 14);
            this.lblInfo.TabIndex = 28;
            // 
            // chbxCameraAFlipHor
            // 
            this.chbxCameraAFlipHor.AutoSize = true;
            this.chbxCameraAFlipHor.Location = new System.Drawing.Point(229, 8);
            this.chbxCameraAFlipHor.Name = "chbxCameraAFlipHor";
            this.chbxCameraAFlipHor.Size = new System.Drawing.Size(100, 18);
            this.chbxCameraAFlipHor.TabIndex = 29;
            this.chbxCameraAFlipHor.Text = "Flip Horizontal";
            this.chbxCameraAFlipHor.UseVisualStyleBackColor = true;
            this.chbxCameraAFlipHor.CheckedChanged += new System.EventHandler(this.chbxCameraAFlipHor_CheckedChanged);
            // 
            // chbxCameraBFlipHor
            // 
            this.chbxCameraBFlipHor.AutoSize = true;
            this.chbxCameraBFlipHor.Location = new System.Drawing.Point(558, 8);
            this.chbxCameraBFlipHor.Name = "chbxCameraBFlipHor";
            this.chbxCameraBFlipHor.Size = new System.Drawing.Size(100, 18);
            this.chbxCameraBFlipHor.TabIndex = 30;
            this.chbxCameraBFlipHor.Text = "Flip Horizontal";
            this.chbxCameraBFlipHor.UseVisualStyleBackColor = true;
            this.chbxCameraBFlipHor.CheckedChanged += new System.EventHandler(this.chbxCameraAFlipHor_CheckedChanged);
            // 
            // chbxCameraCFlipHor
            // 
            this.chbxCameraCFlipHor.AutoSize = true;
            this.chbxCameraCFlipHor.Location = new System.Drawing.Point(229, 293);
            this.chbxCameraCFlipHor.Name = "chbxCameraCFlipHor";
            this.chbxCameraCFlipHor.Size = new System.Drawing.Size(100, 18);
            this.chbxCameraCFlipHor.TabIndex = 31;
            this.chbxCameraCFlipHor.Text = "Flip Horizontal";
            this.chbxCameraCFlipHor.UseVisualStyleBackColor = true;
            this.chbxCameraCFlipHor.CheckedChanged += new System.EventHandler(this.chbxCameraAFlipHor_CheckedChanged);
            // 
            // chbxCameraDFlipHor
            // 
            this.chbxCameraDFlipHor.AutoSize = true;
            this.chbxCameraDFlipHor.Location = new System.Drawing.Point(558, 293);
            this.chbxCameraDFlipHor.Name = "chbxCameraDFlipHor";
            this.chbxCameraDFlipHor.Size = new System.Drawing.Size(100, 18);
            this.chbxCameraDFlipHor.TabIndex = 32;
            this.chbxCameraDFlipHor.Text = "Flip Horizontal";
            this.chbxCameraDFlipHor.UseVisualStyleBackColor = true;
            this.chbxCameraDFlipHor.CheckedChanged += new System.EventHandler(this.chbxCameraAFlipHor_CheckedChanged);
            // 
            // FormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 563);
            this.Controls.Add(this.chbxCameraDFlipHor);
            this.Controls.Add(this.chbxCameraCFlipHor);
            this.Controls.Add(this.chbxCameraBFlipHor);
            this.Controls.Add(this.chbxCameraAFlipHor);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.lblCamD);
            this.Controls.Add(this.picBoxD);
            this.Controls.Add(this.lblCamC);
            this.Controls.Add(this.picBoxC);
            this.Controls.Add(this.lblCamB);
            this.Controls.Add(this.picBoxB);
            this.Controls.Add(this.lblCamA);
            this.Controls.Add(this.picBoxA);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "FormCamera";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshScreens;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timerPattern;
        private System.Windows.Forms.PictureBox picBoxA;
        private System.Windows.Forms.PictureBox picBoxB;
        private System.Windows.Forms.PictureBox picBoxC;
        private System.Windows.Forms.PictureBox picBoxD;
        private System.Windows.Forms.CheckBox chbxCamA;
        private System.Windows.Forms.CheckBox chbxCamB;
        private System.Windows.Forms.CheckBox chbxCamC;
        private System.Windows.Forms.CheckBox chbxCamD;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.ComboBox cmbxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCamC;
        private System.Windows.Forms.Label lblCamD;
        private System.Windows.Forms.Label lblCamB;
        private System.Windows.Forms.Label lblCamA;
        private System.Windows.Forms.CheckBox chbxPattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetCurrentRes;
        private System.Windows.Forms.Label lblCamDRes;
        private System.Windows.Forms.Label lblCamCRes;
        private System.Windows.Forms.Label lblCamBRes;
        private System.Windows.Forms.Label lblCamARes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxResolution;
        private System.Windows.Forms.Button btnSetResolution;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chbxCameraAFlipHor;
        private System.Windows.Forms.CheckBox chbxCameraBFlipHor;
        private System.Windows.Forms.CheckBox chbxCameraCFlipHor;
        private System.Windows.Forms.CheckBox chbxCameraDFlipHor;
    }
}

