using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner_2
{
    public partial class FormPatternOnSecondary : Form
    {
        public FormPatternOnSecondary()
        {
            InitializeComponent();
        }

        Bitmap bmpPat = null;
        Graphics gr;
        private void FormPatternOnSecondary_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !e.Cancel;
            this.Hide();
        }

        public void SetStripPattern(Color Color_A, int BarWidth_A, Color Color_B, int BarWidth_B, Orientation direction, bool Reverse)
        {
            if (!Reverse)
                SetStripPattern(Color_B, BarWidth_B, Color_A, BarWidth_A, direction);
            else
                SetStripPattern(Color_A, BarWidth_A, Color_B, BarWidth_B, direction);
        }
        public void SetStripPattern(Color Color_A, int BarWidth_A, Color Color_B, int BarWidth_B, Orientation direction)
        {
            if (direction == Orientation.Horizontal)
            {
                bmpPat = new Bitmap(1, (BarWidth_A + BarWidth_B));
                for (int i = 0; i < BarWidth_A; i++)
                    bmpPat.SetPixel(0, i, Color_A);
                for (int i = BarWidth_A; i < BarWidth_A + BarWidth_B; i++)
                    bmpPat.SetPixel(0, i, Color_B);
            }
            else
            {
                bmpPat = new Bitmap((BarWidth_A + BarWidth_B), 1);
                for (int i = 0; i < BarWidth_A; i++)
                    bmpPat.SetPixel(i, 0, Color_A);
                for (int i = BarWidth_A; i < BarWidth_A + BarWidth_B; i++)
                    bmpPat.SetPixel(i, 0, Color_B);
            }
            this.BackgroundImage = bmpPat;
            this.Update();
        }

        void SetLatticePattern(Color Color_A, Color Color_B, int Sqr_Width, bool Reverse)
        {
            if (!Reverse)
                SetLatticePattern(Color_A, Color_B, Sqr_Width);
            else
                SetLatticePattern(Color_B, Color_A, Sqr_Width);
        }
        void SetLatticePattern(Color Color_A, Color Color_B, int Sqr_Width)
        {
            bmpPat = new Bitmap(Sqr_Width + Sqr_Width , Sqr_Width + Sqr_Width);
            gr = Graphics.FromImage(bmpPat);
            Brush brA = new SolidBrush(Color_A);
            Brush brB = new SolidBrush(Color_B);
            gr.FillRectangle(brA, new RectangleF(0, 0, Sqr_Width, Sqr_Width));
            gr.FillRectangle(brB, new RectangleF(Sqr_Width, 0, Sqr_Width, Sqr_Width));
            gr.FillRectangle(brB, new RectangleF(0, Sqr_Width, Sqr_Width, Sqr_Width));
            gr.FillRectangle(brA, new RectangleF(Sqr_Width, Sqr_Width, Sqr_Width, Sqr_Width));
            this.BackgroundImage = bmpPat;
            this.Update();
        }

        public void SetPattern(PatternType patternType, int PatternSize, Orientation direction, bool reversedColor)
        {
            if (patternType == PatternType.Strip)
                SetStripPattern(Color.White, PatternSize, Color.Black, PatternSize, direction, reversedColor);
            else if (patternType == PatternType.Lattice)
                SetLatticePattern(Color.White, Color.Black, PatternSize, reversedColor);
        }

    }
}
