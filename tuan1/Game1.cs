using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan1
{
    public partial class Game1 : Form
    {

        int _penWidth = 2;
        int _numNumber = 4;
        int _radius;
        int _innerRadius;
        int _angle;
        float _alpha;
        int _X;
        int _Y;
        int _ballPathRadius;
        float _a;
        System.Drawing.Drawing2D.Matrix mt = new System.Drawing.Drawing2D.Matrix();

        Button[,] NumberOptions = null;
        int _Number;
        void ButtonClick(object o, EventArgs e)
        {
            _Number = int.Parse((o as Button).Text);
        }

        public Game1()
        {
            InitializeComponent();
            _radius = _MainPanel.Width - _penWidth;
            _innerRadius = (int)(_radius * 0.9f / 2);
            _ballPathRadius = (int)(_radius * 0.8f / 2);
            _angle = (int)(360 * 1.0f / _numNumber);
            _alpha = 0;
            _X = _MainPanel.Width / 2 - _Ball.Width / 2;
            _Y = _MainPanel.Height / 2 - _Ball.Height / 2;

            int padding = 10;
            int x = padding, y = 300;
            int temp = (int)Math.Sqrt(_numNumber);
            int temp1 = 0;
            int size = (_ControlPanel.Width - 2 * padding) / temp;


            NumberOptions = new Button[temp, temp];
            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    NumberOptions[i, j] = new Button();
                    NumberOptions[i, j].Text = (temp1++).ToString();
                    NumberOptions[i, j].AutoSize = false;
                    NumberOptions[i, j].Size = new Size(size, size);
                    NumberOptions[i, j].Location = new Point(x + j * size, y + i * size);
                    NumberOptions[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    NumberOptions[i, j].Click += new System.EventHandler(ButtonClick);
                    _ControlPanel.Controls.Add(NumberOptions[i, j]);
                }
            }
        }

        private void DrawPanel(object sender, PaintEventArgs e)
        {

            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.GhostWhite, _penWidth);
            Brush br = Brushes.Red;
            Font f = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);

            mt.Translate(250, 250);
            gr.DrawEllipse(p, 0, 0, _radius, _radius);


            for (int i = 0; i < _numNumber; i++)
            {
                gr.Transform = mt;
                gr.DrawLine(p, 0, 0, 0, 180);
                gr.DrawString(i.ToString(), f, br, new PointF(_innerRadius, -8));
                mt.Rotate(-_angle);
            }
            gr.Dispose();
        }

        

        private void RotateForm(object sender, EventArgs e)
        {
            _Ball.Location = new Point(_X + (int)(_ballPathRadius * Math.Sin(_alpha / 180f)), _Y - (int)(_ballPathRadius * Math.Cos(_alpha / 180f)));
            _alpha = _alpha + _a;

            _a -= 2f;

            if(_a <= 0)
            {
                _Timer.Enabled = false;
                _Result.Text = (GetNumber() / (360 / _numNumber)).ToString();

                if (_Number == int.Parse(_Result.Text))
                    this.pictureBox1.Image = global::tuan1.Properties.Resources.congratulations_4_79207;
                else
                    this.pictureBox1.Image = global::tuan1.Properties.Resources.tumblr_nrx70sOPVy1tzr9z1o1_500;
            }
        }

        int GetNumber()
        {
            int X = _Ball.Location.X - _X;
            int Y = _Y - _Ball.Location.Y;
            int _CurrentAngle;
            if(X == 0)
            {
                if (Y > 0)
                    _CurrentAngle = 90;
                else
                    _CurrentAngle = 270;
            }
            else
            {
                _CurrentAngle = (int)(Math.Atan(Math.Abs(Y) * 1.0f / Math.Abs(X)) * 180 / Math.PI);
                if (X > 0 && Y < 0)
                    _CurrentAngle = 360 - _CurrentAngle;
                if (X < 0 && Y < 0)
                    _CurrentAngle += 180;
                if (X < 0 && Y > 0)
                    _CurrentAngle = 180 - _CurrentAngle;
            }
            return _CurrentAngle;
        }

        private void Play(object sender, EventArgs e)
        {
            Random r = new Random();
            if (_Timer.Enabled == false)
            {
                _a = r.Next(100, 300);
                _Timer.Enabled = true;
                this.pictureBox1.Image = null;
            }
        }
    }
}
