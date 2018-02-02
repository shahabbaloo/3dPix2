namespace Scanner_2
{
    partial class FormMain
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
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnStereo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCamera
            // 
            this.btnCamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCamera.Location = new System.Drawing.Point(35, 64);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(150, 50);
            this.btnCamera.TabIndex = 0;
            this.btnCamera.Text = "Camera && Pattern";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnStereo
            // 
            this.btnStereo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStereo.Location = new System.Drawing.Point(35, 163);
            this.btnStereo.Name = "btnStereo";
            this.btnStereo.Size = new System.Drawing.Size(150, 50);
            this.btnStereo.TabIndex = 1;
            this.btnStereo.Text = "Stereoscopy";
            this.btnStereo.UseVisualStyleBackColor = true;
            this.btnStereo.Click += new System.EventHandler(this.btnStereo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 281);
            this.Controls.Add(this.btnStereo);
            this.Controls.Add(this.btnCamera);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnStereo;
    }
}