namespace tuan1
{
    partial class Game1
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
            this._MainPanel = new System.Windows.Forms.Panel();
            this._Ball = new System.Windows.Forms.PictureBox();
            this._ControlPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._Result = new System.Windows.Forms.Label();
            this._Play = new System.Windows.Forms.Button();
            this._Timer = new System.Windows.Forms.Timer(this.components);
            this._MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Ball)).BeginInit();
            this._ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _MainPanel
            // 
            this._MainPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._MainPanel.Controls.Add(this._Ball);
            this._MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._MainPanel.Location = new System.Drawing.Point(0, 0);
            this._MainPanel.Name = "_MainPanel";
            this._MainPanel.Size = new System.Drawing.Size(500, 500);
            this._MainPanel.TabIndex = 0;
            this._MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel);
            // 
            // _Ball
            // 
            this._Ball.Image = global::tuan1.Properties.Resources.SphereAda;
            this._Ball.Location = new System.Drawing.Point(475, 3);
            this._Ball.Name = "_Ball";
            this._Ball.Size = new System.Drawing.Size(25, 25);
            this._Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Ball.TabIndex = 0;
            this._Ball.TabStop = false;
            // 
            // _ControlPanel
            // 
            this._ControlPanel.Controls.Add(this.pictureBox1);
            this._ControlPanel.Controls.Add(this._Result);
            this._ControlPanel.Controls.Add(this._Play);
            this._ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ControlPanel.ForeColor = System.Drawing.Color.Red;
            this._ControlPanel.Location = new System.Drawing.Point(500, 0);
            this._ControlPanel.Name = "_ControlPanel";
            this._ControlPanel.Size = new System.Drawing.Size(200, 500);
            this._ControlPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // _Result
            // 
            this._Result.Dock = System.Windows.Forms.DockStyle.Top;
            this._Result.Font = new System.Drawing.Font("Rosewood Std Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._Result.Location = new System.Drawing.Point(0, 0);
            this._Result.Name = "_Result";
            this._Result.Size = new System.Drawing.Size(200, 54);
            this._Result.TabIndex = 1;
            this._Result.Text = "0";
            this._Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Play
            // 
            this._Play.AutoSize = true;
            this._Play.BackColor = System.Drawing.Color.White;
            this._Play.FlatAppearance.BorderSize = 0;
            this._Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Play.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Play.ForeColor = System.Drawing.Color.DimGray;
            this._Play.Location = new System.Drawing.Point(25, 100);
            this._Play.Name = "_Play";
            this._Play.Size = new System.Drawing.Size(150, 75);
            this._Play.TabIndex = 0;
            this._Play.Text = "PLAY";
            this._Play.UseVisualStyleBackColor = false;
            this._Play.Click += new System.EventHandler(this.Play);
            // 
            // _Timer
            // 
            this._Timer.Tick += new System.EventHandler(this.RotateForm);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this._ControlPanel);
            this.Controls.Add(this._MainPanel);
            this.Name = "Game1";
            this.Text = "Game1";
            this._MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Ball)).EndInit();
            this._ControlPanel.ResumeLayout(false);
            this._ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _MainPanel;
        private System.Windows.Forms.Panel _ControlPanel;
        private System.Windows.Forms.Timer _Timer;
        private System.Windows.Forms.PictureBox _Ball;
        private System.Windows.Forms.Label _Result;
        private System.Windows.Forms.Button _Play;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}