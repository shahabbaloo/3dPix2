using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using System.Diagnostics;
//using Emgu.CV.CvEnum;

namespace Scanner_2
{
    public partial class FormCamera : Form
    {
        FormPatternOnSecondary frmPtrnOnDspl;
        Camera_Capture CMR_CAPTR;
        public FormCamera()
        {
            InitializeComponent();
            CMR_CAPTR = new Camera_Capture();
            frmPtrnOnDspl = new FormPatternOnSecondary();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnRefreshScreens_Click(null, null);
            cmbxSpeed.SelectedIndex = 5;

            CMR_CAPTR.picBoxCameraA = picBoxA;
            CMR_CAPTR.picBoxCameraB = picBoxB;
            CMR_CAPTR.picBoxCameraC = picBoxC;
            CMR_CAPTR.picBoxCameraD = picBoxD;

            cmbxResolution.SelectedIndex = 0;
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CMR_CAPTR.ReleaseData();
            frmPtrnOnDspl.Close();
        }

        private void btnRefreshScreens_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (i == 0) comboBox1.Items.Add("Primary");
                else if (i == 1) comboBox1.Items.Add("Secondary");
                else if (i == 2) comboBox1.Items.Add("3rd");
                else if (i == 3) comboBox1.Items.Add("4th");
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count > 1 ? 1 : 0;
        }

        private void cmbxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerPattern.Interval = 1000 / int.Parse(cmbxSpeed.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmPtrnOnDspl.Hide();
            frmPtrnOnDspl.WindowState = FormWindowState.Normal;
            frmPtrnOnDspl.Location = Screen.AllScreens[comboBox1.SelectedIndex].WorkingArea.Location;
            frmPtrnOnDspl.WindowState = FormWindowState.Maximized;
            frmPtrnOnDspl.Show();
            this.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!System.IO.Directory.Exists(linkLabel1.Text))
                System.IO.Directory.CreateDirectory(linkLabel1.Text);
            folderBrowserDialog1.SelectedPath = linkLabel1.Text;
            folderBrowserDialog1.ShowDialog();
            linkLabel1.Text = folderBrowserDialog1.SelectedPath;
        }


        Bitmap fposbmp = new Bitmap(1, 1);
        Orientation dir = Orientation.Horizontal;
        PatternType pType;

        Stopwatch sw = new Stopwatch();

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            sw.Reset();
            sw.Start();
            PatCount = 0;
            if (timerPattern.Enabled)
            {
                timerPattern.Enabled = false;
                sw.Stop();
                lblInfo.Text = "Number of Patterns : " + PatCount.ToString() + " , Elapsed Time = " + sw.ElapsedMilliseconds.ToString() + " (ms)";
                btnDoIt.Text = "Do It!";
            }
            else
            {
                btnDoIt.Text = "Stop";
                lblInfo.Text = "In Progress...";
                frmPtrnOnDspl.Visible = true;
                fposbmp = new Bitmap(frmPtrnOnDspl.Width, frmPtrnOnDspl.Height);
                pType = PatternType.Strip;
                PatSize = (frmPtrnOnDspl.Height / 3) * 2;
                dir = Orientation.Horizontal;
                frmPtrnOnDspl.SetPattern(pType, (PatSize + 1) / 2, dir, PatSize % 2 == 1);
                timerPattern.Enabled = true;
            }
        }

        int PatCount = 0;
        int PatSize = 4;
        private void timerPattern_Tick(object sender, EventArgs e)
        {
            PatCount++;
            frmPtrnOnDspl.SetPattern(pType, (PatSize + 1) / 2, dir, PatSize % 2 == 1);
            if (chbxPattern.Checked)
            {
                frmPtrnOnDspl.DrawToBitmap(fposbmp, new Rectangle(0, 0, frmPtrnOnDspl.Width, frmPtrnOnDspl.Height));
                fposbmp.Save(linkLabel1.Text + "\\" + pType.ToString() + dir.ToString() + ((PatSize + 1) / 2).ToString() + (PatSize % 2 == 1).ToString() + ".png");
            }
            if (chbxCamA.Checked && picBoxA.Image != null)
                picBoxA.Image.Save(linkLabel1.Text + "\\" + pType.ToString() + dir.ToString() + ((PatSize + 1) / 2).ToString() + (PatSize % 2 == 1).ToString() + "CamA.png");
            if (chbxCamB.Checked && picBoxB.Image != null)
                picBoxB.Image.Save(linkLabel1.Text + "\\" + pType.ToString() + dir.ToString() + ((PatSize + 1) / 2).ToString() + (PatSize % 2 == 1).ToString() + "CamB.png");
            if (chbxCamC.Checked && picBoxC.Image != null)
                picBoxC.Image.Save(linkLabel1.Text + "\\" + pType.ToString() + dir.ToString() + ((PatSize + 1) / 2).ToString() + (PatSize % 2 == 1).ToString() + "CamB.png");
            if (chbxCamD.Checked && picBoxD.Image != null)
                picBoxD.Image.Save(linkLabel1.Text + "\\" + pType.ToString() + dir.ToString() + ((PatSize + 1) / 2).ToString() + (PatSize % 2 == 1).ToString() + "CamB.png");

            if (PatSize % 2 == 0)
                PatSize--;
            else
            {
                PatSize = 1 + PatSize / 2;
                if (PatSize % 2 == 1)
                    PatSize--;
                if (PatSize < 8)
                {
                    if (pType == PatternType.Strip)
                    {
                        if (dir == Orientation.Horizontal)
                        {
                            dir = Orientation.Vertical;
                            PatSize = (frmPtrnOnDspl.Width / 3) * 2;
                        }
                        else
                        {
                            pType = PatternType.Lattice;
                            PatSize = (frmPtrnOnDspl.Width / 3) * 2;
                        }
                    }
                    else
                    {
                        sw.Stop();
                        lblInfo.Text = "Number of Patterns : " + PatCount.ToString() + " , Elapsed Time = " + sw.ElapsedMilliseconds.ToString() + " (ms)";
                        timerPattern.Enabled = false;
                        btnDoIt.Text = "Do It!";
                    }
                }
            }
        }

        private void btnGetCurrentRes_Click(object sender, EventArgs e)
        {
            lblCamARes.Text = "Camera A " + (picBoxA.Image == null ? "{off}" : picBoxA.Image.Size.ToString());
            lblCamBRes.Text = "Camera B " + (picBoxB.Image == null ? "{off}" : picBoxB.Image.Size.ToString());
            lblCamCRes.Text = "Camera C " + (picBoxC.Image == null ? "{off}" : picBoxC.Image.Size.ToString());
            lblCamDRes.Text = "Camera D " + (picBoxD.Image == null ? "{off}" : picBoxD.Image.Size.ToString());
        }

        private void btnSetResolution_Click(object sender, EventArgs e)
        {
            Size res = new Size(int.Parse(cmbxResolution.Text.Split('x')[0].Trim()), int.Parse(cmbxResolution.Text.Split('x')[1].Trim()));

            CMR_CAPTR.cameraResolutionA = res;
            CMR_CAPTR.cameraResolutionB = res;
            CMR_CAPTR.cameraResolutionC = res;
            CMR_CAPTR.cameraResolutionD = res;
        }

        private void chbxCameraAFlipHor_CheckedChanged(object sender, EventArgs e)
        {
            CMR_CAPTR.CameraAFlipHor = chbxCameraAFlipHor.Checked;
            CMR_CAPTR.CameraBFlipHor = chbxCameraBFlipHor.Checked;
            CMR_CAPTR.CameraCFlipHor = chbxCameraCFlipHor.Checked;
            CMR_CAPTR.CameraDFlipHor = chbxCameraDFlipHor.Checked;
        }

    }
}
