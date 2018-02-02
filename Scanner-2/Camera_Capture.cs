using Emgu.CV;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scanner_2
{
    public class Camera_Capture
    {
        private VideoCapture _captureA;
        private VideoCapture _captureB;
        private VideoCapture _captureC;
        private VideoCapture _captureD;

        private Mat _ImageCameraA = new Mat();
        private Mat _ImageCameraB = new Mat();
        private Mat _ImageCameraC = new Mat();
        private Mat _ImageCameraD = new Mat();

        public PictureBox picBoxCameraA = null;
        public PictureBox picBoxCameraB = null;
        public PictureBox picBoxCameraC = null;
        public PictureBox picBoxCameraD = null;

        private int camDefaultWidth = 1280, camDefaultHeight = 1024;

        public Camera_Capture()
        {
            InitialCaptures();
        }


        public Size cameraResolutionA
        {
            get { return new Size((int)_captureA.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth), (int)_captureA.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight)); }
            set
            {
                if (value.Width > 0 && value.Height > 0)
                {
                    _captureA.Stop();
                    _captureA.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, camDefaultWidth);
                    _captureA.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, camDefaultHeight);
                    _captureA.Start();
                }
            }
        }

        public Size cameraResolutionB
        {
            get { return new Size((int)_captureB.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth), (int)_captureB.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight)); }
            set
            {
                if (value.Width > 0 && value.Height > 0)
                {
                    _captureB.Stop();
                    _captureB.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, camDefaultWidth);
                    _captureB.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, camDefaultHeight);
                    _captureB.Start();
                }
            }
        }

        public Size cameraResolutionC
        {
            get { return new Size((int)_captureC.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth), (int)_captureC.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight)); }
            set
            {
                if (value.Width > 0 && value.Height > 0)
                {
                    _captureC.Stop();
                    _captureC.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, camDefaultWidth);
                    _captureC.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, camDefaultHeight);
                    _captureC.Start();
                }
            }
        }

        public Size cameraResolutionD
        {
            get { return new Size((int)_captureD.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth), (int)_captureD.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight)); }
            set
            {
                if (value.Width > 0 && value.Height > 0)
                {
                    _captureD.Stop();
                    _captureD.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, camDefaultWidth);
                    _captureD.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, camDefaultHeight);
                    _captureD.Start();
                }
            }
        }


        public bool CameraAFlipHor { get { return _captureA.FlipHorizontal; } internal set { _captureA.FlipHorizontal = value; } }
        public bool CameraBFlipHor { get { return _captureB.FlipHorizontal; } internal set { _captureB.FlipHorizontal = value; } }
        public bool CameraCFlipHor { get { return _captureC.FlipHorizontal; } internal set { _captureC.FlipHorizontal = value; } }
        public bool CameraDFlipHor { get { return _captureD.FlipHorizontal; } internal set { _captureD.FlipHorizontal = value; } }


        private void InitialCaptures()
        {
            if (_captureA == null || _captureA.Ptr == IntPtr.Zero)
            {
                try
                {
                    _captureA = new VideoCapture(0);
                    _captureA.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 1280);
                    _captureA.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 1024);
                    _captureA.ImageGrabbed += ProcessFrameA;
                    _captureA.Start();
                }
                catch (NullReferenceException excpt) { }
            }
            if (_captureB == null || _captureB.Ptr == IntPtr.Zero)
            {
                try
                {
                    _captureB = new VideoCapture(1);
                    _captureB.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 1280);
                    _captureB.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 1024);
                    _captureB.ImageGrabbed += ProcessFrameB;
                    _captureB.Start();
                }
                catch (NullReferenceException excpt) { }
            }
            if (_captureC == null || _captureC.Ptr == IntPtr.Zero)
            {
                try
                {
                    _captureC = new VideoCapture(2);
                    _captureC.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 1280);
                    _captureC.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 1024);
                    _captureC.ImageGrabbed += ProcessFrameC;
                    _captureC.Start();
                }
                catch (NullReferenceException excpt) { }
            }
            if (_captureD == null || _captureD.Ptr == IntPtr.Zero)
            {
                try
                {
                    _captureD = new VideoCapture(3);
                    _captureD.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 1280);
                    _captureD.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 1024);
                    _captureD.ImageGrabbed += ProcessFrameD;
                    _captureD.Start();
                }
                catch (NullReferenceException excpt) { }
            }
        }

        public void ProcessFrameA(Object sender, EventArgs arg)
        {
            if (_captureA != null && _captureA.Ptr != IntPtr.Zero && _captureA.IsOpened)
            {
                if (_captureA.Retrieve(_ImageCameraA))
                {
                    if (picBoxCameraA != null)
                        picBoxCameraA.Image = _ImageCameraA.Bitmap;
                }
                else
                    picBoxCameraA.Image = null;
            }
            else
            {
                if (picBoxCameraA != null)
                    picBoxCameraA.Image = null;
            }

        }
        public void ProcessFrameB(Object sender, EventArgs arg)
        {
            if (_captureB != null && _captureB.Ptr != IntPtr.Zero && _captureB.IsOpened)
                _captureB.Retrieve(_ImageCameraB);
            if (picBoxCameraB != null)
                picBoxCameraB.Image = _ImageCameraB.Bitmap;
        }
        public void ProcessFrameC(Object sender, EventArgs arg)
        {
            if (_captureC != null && _captureC.Ptr != IntPtr.Zero && _captureC.IsOpened)
                _captureC.Retrieve(_ImageCameraC, 0);
            if (picBoxCameraC != null)
                picBoxCameraC.Image = _ImageCameraC.Bitmap;
        }
        public void ProcessFrameD(Object sender, EventArgs arg)
        {
            if (_captureD != null && _captureD.Ptr != IntPtr.Zero && _captureD.IsOpened)
                _captureD.Retrieve(_ImageCameraD, 0);
            if (picBoxCameraD != null)
                picBoxCameraD.Image = _ImageCameraD.Bitmap;
        }

        public void ReleaseData()
        {
            if (_captureA != null)
            {
                _captureA.ImageGrabbed -= ProcessFrameA;
                _captureA.Stop();
                _captureA.Dispose();
                _captureA = null;
            }
            if (_captureB != null)
            {
                _captureB.ImageGrabbed -= ProcessFrameB;
                _captureB.Stop();
                _captureB.Dispose();
                _captureB = null;
            }
            if (_captureC != null)
            {
                _captureC.ImageGrabbed -= ProcessFrameC;
                _captureC.Stop();
                _captureC.Dispose();
                _captureC = null;
            }
            if (_captureD != null)
            {
                _captureD.ImageGrabbed -= ProcessFrameD;
                _captureD.Stop();
                _captureD.Dispose();
                _captureD = null;
            }
        }

    }
}
