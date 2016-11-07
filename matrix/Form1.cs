using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace matrix
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hwnd, IntPtr lpRect, bool bErase);

        [DllImport("user32")]
        internal static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32.dll")]
        internal static extern void ReleaseDC(IntPtr dc);


        public Point temp = new Point(620, 0);

        Random rd = new Random();
        string te="";
        string te1 = "";
        string te2 = "";
        string te3 = "";
        string te4 = "";
        string te5 = "";
        string te6 = "";
        
       
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            label1.Text = "";
            for (int i = 0; i < 100; i++)
            {
                te += Convert.ToChar(rd.Next(40, 450)).ToString() + "\n";
                te1 += Convert.ToChar(rd.Next(30, 500)).ToString() + "\n";
                te2 += Convert.ToChar(rd.Next(20, 450)).ToString() + "\n";
                te4 += Convert.ToChar(rd.Next(40, 550)).ToString() + "\n";
                te5 += Convert.ToChar(rd.Next(40, 450)).ToString() + "\n";
                te6 += Convert.ToChar(rd.Next(40, 450)).ToString() + "\n";
            }
                
        }
        Timer t = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            t.Interval =80;
            t.Tick += new EventHandler(t_Tick);
            t.Stop();
        }

        void t_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        
        
        
       
        int heightToGo = Screen.PrimaryScreen.WorkingArea.Height/3;// + Screen.PrimaryScreen.WorkingArea.Height / 2;
        #region rectangle_declarations
        Rectangle rec1 = new Rectangle(0, 0, 20, 10);
        Rectangle rec1_1 = new Rectangle(0, 0, 20, 10);
        Rectangle rec2 = new Rectangle(30, 300, 20, 10);
        Rectangle rec2_2 = new Rectangle(30, 300, 20, 10);
        Rectangle rec3 = new Rectangle(60, 100, 20, 10);
        Rectangle rec3_3 = new Rectangle(60, 100, 20, 10);
        Rectangle rec4 = new Rectangle(90, 50, 20, 10);
        Rectangle rec4_4 = new Rectangle(90, 50, 20, 10);
        Rectangle rec5 = new Rectangle(120, 150, 20, 10);
        Rectangle rec5_5 = new Rectangle(120, 150, 20, 10);
        Rectangle rec6 = new Rectangle(150, 500, 20, 10);
        Rectangle rec6_6 = new Rectangle(150, 500, 20, 10);
        Rectangle rec7 = new Rectangle(180, 700, 20, 10);
        Rectangle rec7_7 = new Rectangle(180, 700, 20, 10);
        Rectangle rec8 = new Rectangle(210, 50, 20, 10);
        Rectangle rec8_8 = new Rectangle(210, 50, 20, 10);
        Rectangle rec9 = new Rectangle(240, 250, 20, 10);
        Rectangle rec9_9 = new Rectangle(240, 250, 20, 10);
        Rectangle rec10 = new Rectangle(270, 0, 20, 10);
        Rectangle rec10_10 = new Rectangle(270, 0, 20, 10);
        Rectangle rec11 = new Rectangle(300, 150, 20, 10);
        Rectangle rec11_11 = new Rectangle(300, 150, 20, 10);
        Rectangle rec12 = new Rectangle(330, 450, 20, 10);
        Rectangle rec12_12 = new Rectangle(330, 450, 20, 10);
        Rectangle rec13 = new Rectangle(360, 50, 20, 10);
        Rectangle rec13_13 = new Rectangle(360, 50, 20, 10);
        Rectangle rec14 = new Rectangle(390, 120, 20, 10);
        Rectangle rec14_14 = new Rectangle(390, 120, 20, 10);
        Rectangle rec15 = new Rectangle(420, 280, 20, 10);
        Rectangle rec15_15 = new Rectangle(420, 280, 20, 10);
        Rectangle rec16 = new Rectangle(450, 380, 20, 10);
        Rectangle rec16_16 = new Rectangle(450, 380, 20, 10);
        Rectangle rec17 = new Rectangle(480, 80, 20, 10);
        Rectangle rec17_17 = new Rectangle(480, 80, 20, 10);
        Rectangle rec18 = new Rectangle(510, 180, 20, 10);
        Rectangle rec18_18 = new Rectangle(510, 180, 20, 10);
        Rectangle rec19 = new Rectangle(540, 580, 20, 10);
        Rectangle rec19_19 = new Rectangle(540, 580, 20, 10);
        Rectangle rec20 = new Rectangle(570, 20, 20, 10);
        Rectangle rec20_20 = new Rectangle(570, 20, 20, 10);
        Rectangle rec21 = new Rectangle(600, 200, 20, 10);
        Rectangle rec21_21 = new Rectangle(600, 200, 20, 10);
        Rectangle rec22 = new Rectangle(630, 460, 20, 10);
        Rectangle rec22_22 = new Rectangle(630, 460, 20, 10);
        Rectangle rec23 = new Rectangle(660, 130, 130, 10);
        Rectangle rec23_23 = new Rectangle(660, 130, 20, 10);
        Rectangle rec24 = new Rectangle(690, 60, 20, 10);
        Rectangle rec24_24 = new Rectangle(690, 60, 20, 10);
        Rectangle rec25 = new Rectangle(720, 280, 20, 10);
        Rectangle rec25_25 = new Rectangle(720, 280, 20, 10);
        Rectangle rec26 = new Rectangle(750, 380, 20, 10);
        Rectangle rec26_26 = new Rectangle(750, 380, 20, 10);
        Rectangle rec27 = new Rectangle(780, 100, 20, 10);
        Rectangle rec27_27 = new Rectangle(780, 100, 20, 10);
        Rectangle rec28 = new Rectangle(810, 280, 20, 10);
        Rectangle rec28_28 = new Rectangle(810, 280, 20, 10);
        Rectangle rec29 = new Rectangle(840, 80, 20, 10);
        Rectangle rec29_29 = new Rectangle(840, 80, 20, 10);
        Rectangle rec30 = new Rectangle(870, 10, 20, 10);
        Rectangle rec30_30 = new Rectangle(870, 10, 20, 10);


        #endregion

        Font fnt = new Font("Times New Roman", 16, FontStyle.Bold, GraphicsUnit.Pixel);

        Color col = Color.Lime;
        Color black = Color.Black;
        bool drawName = true;

        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics g = pea.Graphics; //Graphics.FromHdc(GetDC(IntPtr.Zero));
            if (drawName)
            {
                base.OnPaint(pea);
                return;
            }
            #region allRTects
            #region rec1
            LinearGradientBrush b1_1 = new LinearGradientBrush(rec1, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b1_2 = new LinearGradientBrush(rec1_1, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te, fnt, b1_1, rec1);
            g.FillRectangle(b1_2, rec1_1);

            rec1_1.Height += 5;
            rec1_1.Y += 2;
            rec1.Height += 12;

            b1_1.Dispose();
            b1_2.Dispose();

            if (rec1_1.Y >= heightToGo)
            {
                rec1.X += 30;
                rec1.Y = 0;
                rec1.Height = 20;
                rec1_1.X += 30;
                rec1_1.Y = 0;
                rec1_1.Height = 10;

            }

            if (rec1.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec1.X = 0;
                rec1_1.X = 0;
            }


            #endregion
            #region rec2
            LinearGradientBrush b2_1 = new LinearGradientBrush(rec2, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b2_2 = new LinearGradientBrush(rec2_2, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te1, fnt, b2_1, rec2);
            g.FillRectangle(b2_2, rec2_2);

            rec2_2.Height += 5;
            rec2_2.Y += 2;
            rec2.Height += 12;

            b2_1.Dispose();
            b2_2.Dispose();

            if (rec2_2.Y >= heightToGo)
            {
                rec2.X += 30;
                rec2.Y = 0;
                rec2.Height = 20;
                rec2_2.X += 30;
                rec2_2.Y = 0;
                rec2_2.Height = 20;

            }

            if (rec2.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec2.X = 0;
                rec2_2.X = 0;
            }


            #endregion
            #region rec3
            LinearGradientBrush b3_1 = new LinearGradientBrush(rec3, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b3_2 = new LinearGradientBrush(rec3_3, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te2, fnt, b3_1, rec3);
            g.FillRectangle(b3_2, rec3_3);

            rec3_3.Height += 7;
            rec3_3.Y += 2;
            rec3.Height += 15;

            b3_1.Dispose();
            b3_2.Dispose();

            if (rec3_3.Y >= heightToGo)
            {
                rec3.X += 30;
                rec3.Y = 0;
                rec3.Height = 20;
                rec3_3.X += 30;
                rec3_3.Y = 0;
                rec3_3.Height = 20;

            }

            if (rec3.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec3.X = 0;
                rec3_3.X = 0;
            }


            #endregion
            #region rec4
            LinearGradientBrush b4_1 = new LinearGradientBrush(rec4, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b4_2 = new LinearGradientBrush(rec4_4, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te3, fnt, b4_1, rec4);
            g.FillRectangle(b4_2, rec4_4);

            rec4_4.Height += 5;
            rec4_4.Y += 2;
            rec4.Height += 12;

            b4_1.Dispose();
            b4_2.Dispose();

            if (rec4_4.Y >= heightToGo)
            {
                rec4.X += 30;
                rec4.Y = 0;
                rec4.Height = 20;
                rec4_4.X += 30;
                rec4_4.Y = 0;
                rec4_4.Height = 20;

            }

            if (rec4.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec4.X = 0;
                rec4_4.X = 0;
            }


            #endregion
            #region rec5
            LinearGradientBrush b5_1 = new LinearGradientBrush(rec5, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b5_2 = new LinearGradientBrush(rec5_5, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te4, fnt, b5_1, rec5);
            g.FillRectangle(b5_2, rec5_5);

            rec5_5.Height += 5;
            rec5_5.Y += 2;
            rec5.Height += 12;

            b5_1.Dispose();
            b5_2.Dispose();

            if (rec5_5.Y >= heightToGo)
            {
                rec5.X += 30;
                rec5.Y = 0;
                rec5.Height = 20;
                rec5_5.X += 30;
                rec5_5.Y = 0;
                rec5_5.Height = 20;

            }

            if (rec5.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec5.X = 0;
                rec5_5.X = 0;
            }


            #endregion
            #region rec6
            LinearGradientBrush b6_1 = new LinearGradientBrush(rec6, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b6_2 = new LinearGradientBrush(rec6_6, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te5, fnt, b6_1, rec6);
            g.FillRectangle(b6_2, rec6_6);

            rec6_6.Height += 5;
            rec6_6.Y += 2;
            rec6.Height += 12;

            b6_1.Dispose();
            b6_2.Dispose();

            if (rec6_6.Y >= heightToGo)
            {
                rec6.X += 30;
                rec6.Y = 0;
                rec6.Height = 20;
                rec6_6.X += 30;
                rec6_6.Y = 0;
                rec6_6.Height = 20;

            }

            if (rec6.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec6.X = 0;
                rec6_6.X = 0;
            }


            #endregion
            #region rec7
            LinearGradientBrush b7_1 = new LinearGradientBrush(rec7, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b7_2 = new LinearGradientBrush(rec7_7, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te6, fnt, b7_1, rec7);
            g.FillRectangle(b7_2, rec7_7);

            rec7_7.Height += 7;
            rec7_7.Y += 2;
            rec7.Height += 17;

            b7_1.Dispose();
            b7_2.Dispose();

            if (rec7_7.Y >= heightToGo)
            {
                rec7.X += 30;
                rec7.Y = 0;
                rec7.Height = 20;
                rec7_7.X += 30;
                rec7_7.Y = 0;
                rec7_7.Height = 20;

            }

            if (rec7.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec7.X = 0;
                rec7_7.X = 0;
            }


            #endregion
            #region rec8
            LinearGradientBrush b8_1 = new LinearGradientBrush(rec8, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b8_2 = new LinearGradientBrush(rec8_8, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te4, fnt, b8_1, rec8);
            g.FillRectangle(b8_2, rec8_8);

            rec8_8.Height += 5;
            rec8_8.Y += 2;
            rec8.Height += 12;

            b8_1.Dispose();
            b8_2.Dispose();

            if (rec8_8.Y >= heightToGo)
            {
                rec8.X += 30;
                rec8.Y = 0;
                rec8.Height = 20;
                rec8_8.X += 30;
                rec8_8.Y = 0;
                rec8_8.Height = 20;

            }

            if (rec8.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec8.X = 0;
                rec8_8.X = 0;
            }


            #endregion
            #region rec9
            LinearGradientBrush b9_1 = new LinearGradientBrush(rec9, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b9_2 = new LinearGradientBrush(rec9_9, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te, fnt, b9_1, rec9);
            g.FillRectangle(b9_2, rec9_9);

            rec9_9.Height += 9;
            rec9_9.Y += 2;
            rec9.Height += 20;

            b9_1.Dispose();
            b9_2.Dispose();

            if (rec9_9.Y >= heightToGo)
            {
                rec9.X += 30;
                rec9.Y = 0;
                rec9.Height = 20;
                rec9_9.X += 30;
                rec9_9.Y = 0;
                rec9_9.Height = 20;

            }

            if (rec9.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec9.X = 0;
                rec9_9.X = 0;
            }


            #endregion
            #region rec10
            LinearGradientBrush b10_1 = new LinearGradientBrush(rec10, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b10_2 = new LinearGradientBrush(rec10_10, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te3, fnt, b10_1, rec10);
            g.FillRectangle(b10_2, rec10_10);

            rec10_10.Height += 5;
            rec10_10.Y += 2;
            rec10.Height += 12;

            b10_1.Dispose();
            b10_2.Dispose();

            if (rec10_10.Y >= heightToGo)
            {
                rec10.X += 30;
                rec10.Y = 0;
                rec10.Height = 20;
                rec10_10.X += 30;
                rec10_10.Y = 0;
                rec10_10.Height = 20;

            }

            if (rec10.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec10.X = 0;
                rec10_10.X = 0;
            }


            #endregion
            #region rec11
            LinearGradientBrush b11_1 = new LinearGradientBrush(rec11, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b11_2 = new LinearGradientBrush(rec11_11, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te1, fnt, b11_1, rec11);
            g.FillRectangle(b11_2, rec11_11);

            rec11_11.Height += 5;
            rec11_11.Y += 2;
            rec11.Height += 12;

            b11_1.Dispose();
            b11_2.Dispose();

            if (rec11_11.Y >= heightToGo)
            {
                rec11.X += 30;
                rec11.Y = 0;
                rec11.Height = 20;
                rec11_11.X += 30;
                rec11_11.Y = 0;
                rec11_11.Height = 20;

            }

            if (rec11.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec11.X = 0;
                rec11_11.X = 0;
            }


            #endregion
            #region rec12
            LinearGradientBrush b12_1 = new LinearGradientBrush(rec12, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b12_2 = new LinearGradientBrush(rec12_12, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te, fnt, b12_1, rec12);
            g.FillRectangle(b12_2, rec12_12);

            rec12_12.Height += 4;
            rec12_12.Y += 2;
            rec12.Height += 10;

            b12_1.Dispose();
            b12_2.Dispose();

            if (rec12_12.Y >= heightToGo)
            {
                rec12.X += 30;
                rec12.Y = 0;
                rec12.Height = 20;
                rec12_12.X += 30;
                rec12_12.Y = 0;
                rec12_12.Height = 20;

            }

            if (rec12.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec12.X = 0;
                rec12_12.X = 0;
            }


            #endregion
            #region rec13
            LinearGradientBrush b13_1 = new LinearGradientBrush(rec13, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b13_2 = new LinearGradientBrush(rec13_13, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te5, fnt, b13_1, rec13);
            g.FillRectangle(b13_2, rec13_13);

            rec13_13.Height += 5;
            rec13_13.Y += 2;
            rec13.Height += 12;

            b13_1.Dispose();
            b13_2.Dispose();

            if (rec13_13.Y >= heightToGo)
            {
                rec13.X += 30;
                rec13.Y = 0;
                rec13.Height = 20;
                rec13_13.X += 30;
                rec13_13.Y = 0;
                rec13_13.Height = 20;

            }

            if (rec13.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec13.X = 0;
                rec13_13.X = 0;
            }

            #endregion
            #region rec14
            LinearGradientBrush b14_1 = new LinearGradientBrush(rec14, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b14_2 = new LinearGradientBrush(rec14_14, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te6, fnt, b14_1, rec14);
            g.FillRectangle(b14_2, rec14_14);

            rec14_14.Height += 5;
            rec14_14.Y += 2;
            rec14.Height += 12;

            b14_1.Dispose();
            b14_2.Dispose();

            if (rec14_14.Y >= heightToGo)
            {
                rec14.X += 30;
                rec14.Y = 0;
                rec14.Height = 20;
                rec14_14.X += 30;
                rec14_14.Y = 0;
                rec14_14.Height = 20;

            }

            if (rec14.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec14.X = 0;
                rec14_14.X = 0;
            }

            #endregion
            #region rec15
            LinearGradientBrush b15_1 = new LinearGradientBrush(rec15, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b15_2 = new LinearGradientBrush(rec15_15, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te3, fnt, b15_1, rec15);
            g.FillRectangle(b15_2, rec15_15);

            rec15_15.Height += 3;
            rec15_15.Y += 2;
            rec15.Height += 8;

            b15_1.Dispose();
            b15_2.Dispose();

            if (rec15_15.Y >= heightToGo)
            {
                rec15.X += 30;
                rec15.Y = 0;
                rec15.Height = 20;
                rec15_15.X += 30;
                rec15_15.Y = 0;
                rec15_15.Height = 20;

            }

            if (rec15.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec15.X = 0;
                rec15_15.X = 0;
            }


            #endregion
            #region rec16
            LinearGradientBrush b16_1 = new LinearGradientBrush(rec16, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b16_2 = new LinearGradientBrush(rec16_16, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te4, fnt, b16_1, rec16);
            g.FillRectangle(b16_2, rec16_16);

            rec16_16.Height += 9;
            rec16_16.Y += 2;
            rec16.Height += 16;

            b16_1.Dispose();
            b16_2.Dispose();

            if (rec16_16.Y >= heightToGo)
            {
                rec16.X += 30;
                rec16.Y = 0;
                rec16.Height = 20;
                rec16_16.X += 30;
                rec16_16.Y = 0;
                rec16_16.Height = 20;

            }

            if (rec16.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec16.X = 0;
                rec16_16.X = 0;
            }


            #endregion
            #region rec17
            LinearGradientBrush b17_1 = new LinearGradientBrush(rec17, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b17_2 = new LinearGradientBrush(rec17_17, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te, fnt, b17_1, rec17);
            g.FillRectangle(b17_2, rec17_17);

            rec17_17.Height += 4;
            rec17_17.Y += 2;
            rec17.Height += 8;

            b17_1.Dispose();
            b17_2.Dispose();

            if (rec17_17.Y >= heightToGo)
            {
                rec17.X += 30;
                rec17.Y = 0;
                rec17.Height = 20;
                rec17_17.X += 30;
                rec17_17.Y = 0;
                rec17_17.Height = 20;

            }

            if (rec17.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec17.X = 0;
                rec17_17.X = 0;
            }


            #endregion
            #region rec18
            LinearGradientBrush b18_1 = new LinearGradientBrush(rec18, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b18_2 = new LinearGradientBrush(rec18_18, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te6, fnt, b18_1, rec18);
            g.FillRectangle(b18_2, rec18_18);

            rec18_18.Height += 4;
            rec18_18.Y += 2;
            rec18.Height += 13;

            b18_1.Dispose();
            b18_2.Dispose();

            if (rec18_18.Y >= heightToGo)
            {
                rec18.X += 30;
                rec18.Y = 0;
                rec18.Height = 20;
                rec18_18.X += 30;
                rec18_18.Y = 0;
                rec18_18.Height = 20;

            }

            if (rec18.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec18.X = 0;
                rec18_18.X = 0;
            }


            #endregion
            #region rec19
            LinearGradientBrush b19_1 = new LinearGradientBrush(rec19, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b19_2 = new LinearGradientBrush(rec19_19, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te4, fnt, b19_1, rec19);
            g.FillRectangle(b19_2, rec19_19);

            rec19_19.Height += 4;
            rec19_19.Y += 2;
            rec19.Height += 12;

            b19_1.Dispose();
            b19_2.Dispose();

            if (rec19_19.Y >= heightToGo)
            {
                rec19.X += 30;
                rec19.Y = 0;
                rec19.Height = 20;
                rec19_19.X += 30;
                rec19_19.Y = 0;
                rec19_19.Height = 20;

            }

            if (rec19.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec19.X = 0;
                rec19_19.X = 0;
            }


            #endregion
            #region rec20
            LinearGradientBrush b20_1 = new LinearGradientBrush(rec20, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b20_2 = new LinearGradientBrush(rec20_20, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te5, fnt, b20_1, rec20);
            g.FillRectangle(b20_2, rec20_20);

            rec20_20.Height += 10;
            rec20_20.Y += 2;
            rec20.Height += 18;

            b20_1.Dispose();
            b20_2.Dispose();

            if (rec20_20.Y >= heightToGo)
            {
                rec20.X += 30;
                rec20.Y = 0;
                rec20.Height = 20;
                rec20_20.X += 30;
                rec20_20.Y = 0;
                rec20_20.Height = 20;

            }

            if (rec20.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec20.X = 0;
                rec20_20.X = 0;
            }


            #endregion
            #region rec21
            LinearGradientBrush b21_1 = new LinearGradientBrush(rec21, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b21_2 = new LinearGradientBrush(rec21_21, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te1, fnt, b21_1, rec21);
            g.FillRectangle(b21_2, rec21_21);

            rec21_21.Height += 12;
            rec21_21.Y += 2;
            rec21.Height += 22;

            b21_1.Dispose();
            b21_2.Dispose();

            if (rec21_21.Y >= heightToGo)
            {
                rec21.X += 30;
                rec21.Y = 0;
                rec21.Height = 20;
                rec21_21.X += 30;
                rec21_21.Y = 0;
                rec21_21.Height = 20;

            }

            if (rec21.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec21.X = 0;
                rec21_21.X = 0;
            }


            #endregion
            #region rec22
            LinearGradientBrush b22_1 = new LinearGradientBrush(rec22, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b22_2 = new LinearGradientBrush(rec22_22, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te5, fnt, b22_1, rec22);
            g.FillRectangle(b22_2, rec22_22);

            rec22_22.Height += 3;
            rec22_22.Y += 2;
            rec22.Height += 8;

            b22_1.Dispose();
            b22_2.Dispose();

            if (rec21_21.Y >= heightToGo)
            {
                rec22.X += 30;
                rec22.Y = 0;
                rec22.Height = 20;
                rec22_22.X += 30;
                rec22_22.Y = 0;
                rec22_22.Height = 20;

            }

            if (rec22.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec22.X = 0;
                rec22_22.X = 0;
            }


            #endregion
            #region rec23
            LinearGradientBrush b23_1 = new LinearGradientBrush(rec23, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b23_2 = new LinearGradientBrush(rec23_23, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te2, fnt, b23_1, rec23);
            g.FillRectangle(b23_2, rec23_23);

            rec23_23.Height += 5;
            rec23_23.Y += 2;
            rec23.Height += 15;

            b23_1.Dispose();
            b23_2.Dispose();

            if (rec23_23.Y >= heightToGo)
            {
                rec23.X += 30;
                rec23.Y = 0;
                rec23.Height = 20;
                rec23_23.X += 30;
                rec23_23.Y = 0;
                rec23_23.Height = 20;

            }

            if (rec23.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec23.X = 0;
                rec23_23.X = 0;
            }


            #endregion
            #region rec24
            LinearGradientBrush b24_1 = new LinearGradientBrush(rec24, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b24_2 = new LinearGradientBrush(rec24_24, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te, fnt, b24_1, rec24);
            g.FillRectangle(b24_2, rec24_24);

            rec24_24.Height += 3;
            rec24_24.Y += 2;
            rec24.Height += 8;

            b24_1.Dispose();
            b24_2.Dispose();

            if (rec24_24.Y >= heightToGo)
            {
                rec24.X += 30;
                rec24.Y = 0;
                rec24.Height = 20;
                rec24_24.X += 30;
                rec24_24.Y = 0;
                rec24_24.Height = 20;

            }

            if (rec24.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec24.X = 0;
                rec24_24.X = 0;
            }


            #endregion
            #region rec25
            LinearGradientBrush b25_1 = new LinearGradientBrush(rec25, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b25_2 = new LinearGradientBrush(rec25_25, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te5, fnt, b25_1, rec25);
            g.FillRectangle(b25_2, rec25_25);

            rec25_25.Height += 3;
            rec25_25.Y += 2;
            rec25.Height += 8;

            b25_1.Dispose();
            b25_2.Dispose();

            if (rec25_25.Y >= heightToGo)
            {
                rec25.X += 30;
                rec25.Y = 0;
                rec25.Height = 20;
                rec25_25.X += 30;
                rec25_25.Y = 0;
                rec25_25.Height = 20;

            }

            if (rec25.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec25.X = 0;
                rec25_25.X = 0;
            }


            #endregion
            #region rec26
            LinearGradientBrush b26_1 = new LinearGradientBrush(rec26, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b26_2 = new LinearGradientBrush(rec26_26, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te1, fnt, b26_1, rec26);
            g.FillRectangle(b26_2, rec26_26);

            rec26_26.Height += 3;
            rec26_26.Y += 2;
            rec26.Height += 8;

            b26_1.Dispose();
            b26_2.Dispose();

            if (rec26_26.Y >= heightToGo)
            {
                rec26.X += 30;
                rec26.Y = 0;
                rec26.Height = 20;
                rec26_26.X += 30;
                rec26_26.Y = 0;
                rec26_26.Height = 20;

            }

            if (rec26.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec26.X = 0;
                rec26_26.X = 0;
            }


            #endregion
            #region rec27
            LinearGradientBrush b27_1 = new LinearGradientBrush(rec27, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b27_2 = new LinearGradientBrush(rec27_27, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te3, fnt, b27_1, rec27);
            g.FillRectangle(b27_2, rec27_27);

            rec27_27.Height += 12;
            rec27_27.Y += 3;
            rec27.Height += 25;

            b27_1.Dispose();
            b27_2.Dispose();

            if (rec27_27.Y >= heightToGo)
            {
                rec27.X += 30;
                rec27.Y = 0;
                rec27.Height = 20;
                rec27_27.X += 30;
                rec27_27.Y = 0;
                rec27_27.Height = 20;

            }

            if (rec27.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec27.X = 0;
                rec27_27.X = 0;
            }


            #endregion
            #region rec28
            LinearGradientBrush b28_1 = new LinearGradientBrush(rec28, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b28_2 = new LinearGradientBrush(rec28_28, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te2, fnt, b28_1, rec28);
            g.FillRectangle(b28_2, rec28_28);

            rec28_28.Height += 4;
            rec28_28.Y += 2;
            rec28.Height += 10;

            b28_1.Dispose();
            b28_2.Dispose();

            if (rec28_28.Y >= heightToGo)
            {
                rec28.X += 30;
                rec28.Y = 0;
                rec28.Height = 20;
                rec28_28.X += 30;
                rec28_28.Y = 0;
                rec28_28.Height = 20;

            }

            if (rec28.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec28.X = 0;
                rec28_28.X = 0;
            }


            #endregion
            #region rec29
            LinearGradientBrush b29_1 = new LinearGradientBrush(rec29, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b29_2 = new LinearGradientBrush(rec29_29, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te4, fnt, b29_1, rec29);
            g.FillRectangle(b29_2, rec29_29);

            rec29_29.Height += 4;
            rec29_29.Y += 2;
            rec29.Height += 12;

            b29_1.Dispose();
            b29_2.Dispose();

            if (rec29_29.Y >= heightToGo)
            {
                rec29.X += 30;
                rec29.Y = 0;
                rec29.Height = 20;
                rec29_29.X += 30;
                rec29_29.Y = 0;
                rec29_29.Height = 20;

            }

            if (rec29.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec29.X = 0;
                rec29_29.X = 0;
            }


            #endregion
            #region rec30
            LinearGradientBrush b30_1 = new LinearGradientBrush(rec30, Color.FromArgb(0, col), Color.FromArgb(255, col), LinearGradientMode.Vertical);
            LinearGradientBrush b30_2 = new LinearGradientBrush(rec30_30, Color.FromArgb(255, black), Color.FromArgb(0, black), LinearGradientMode.Vertical);

            g.DrawString(te6, fnt, b30_1, rec30);
            g.FillRectangle(b30_2, rec30_30);

            rec30_30.Height += 5;
            rec30_30.Y += 2;
            rec30.Height += 18;

            b30_1.Dispose();
            b30_2.Dispose();

            if (rec30_30.Y >= heightToGo)
            {
                rec30.X += 30;
                rec30.Y = 0;
                rec30.Height = 20;
                rec30_30.X += 30;
                rec30_30.Y = 0;
                rec30_30.Height = 20;

            }

            if (rec30.X >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                rec30.X = 0;
                rec30_30.X = 0;
            }


            #endregion
            #endregion
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
        string str = "";
        int count, index = 0;
        string[] name = new string[] { "C", "r", "e", "a", "t", "e", "d", " ", "B", "y", " ", ":"," ", "I", "n", "d", "i", "k", "a",
        " ", "R", "a", "t", "n", "a", "y", "a", "k", "e", "\n", 
        "n", "i", "r", "a", "t", "n", "a", "y", "a", "k", "e", "@", "g", "m", "a", "i", "l", ".", "c", "o", "m", "\n"};
        private void timer1_Tick(object sender, EventArgs e)
        {
            prepareText();
            
        }
        private void prepareText()
        {
            if (count <= 10||str=="_")
            {
                if (str == "")
                    str = "_";
                else if (str == "_")
                    str = "";
                count++;
            }
            else
            {
                if (index >= name.Length)
                {
                    label1.Text = "";
                    label1.Visible = false;
                    t.Start();
                    timer1.Stop();
                    timer1.Enabled = false;
                    drawName = false;
                    return;
                }
                if (str.Contains("_"))
                    str = str.Remove(str.IndexOf("_"));
                timer1.Interval = 200;
                if (name[index] == "\n")
                {
                    str += name[index];
                    timer2.Enabled = true;
                    timer2.Start();
                    timer1.Stop();
                    return;
                }
                str += name[index]+"_";
                index++;
            }
            drawMyName(str);
        
            
        }
        private void drawMyName(string st)
        {
            label1.Text = st;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count <= 18)
            {
                if (str.Contains("_"))
                    str = str.Remove(str.IndexOf("_"));
                else
                    str += "_";
                count++;
            }
            else
            {
                count = 10;
                timer2.Stop();
                timer1.Start();
                index++;
            }
            drawMyName(str);
        }


    }
}