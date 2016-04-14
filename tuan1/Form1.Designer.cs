namespace tuan1
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
            this._Game1 = new System.Windows.Forms.Button();
            this._Game2 = new System.Windows.Forms.Button();
            this._Game3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Game1
            // 
            this._Game1.Location = new System.Drawing.Point(198, 42);
            this._Game1.Name = "_Game1";
            this._Game1.Size = new System.Drawing.Size(75, 23);
            this._Game1.TabIndex = 0;
            this._Game1.Text = "Đoán Số";
            this._Game1.UseVisualStyleBackColor = true;
            this._Game1.Click += new System.EventHandler(this.PlayGame1);
            // 
            // _Game2
            // 
            this._Game2.Location = new System.Drawing.Point(198, 93);
            this._Game2.Name = "_Game2";
            this._Game2.Size = new System.Drawing.Size(75, 23);
            this._Game2.TabIndex = 1;
            this._Game2.Text = "Game2";
            this._Game2.UseVisualStyleBackColor = true;
            // 
            // _Game3
            // 
            this._Game3.Location = new System.Drawing.Point(198, 144);
            this._Game3.Name = "_Game3";
            this._Game3.Size = new System.Drawing.Size(75, 23);
            this._Game3.TabIndex = 2;
            this._Game3.Text = "Game3";
            this._Game3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 274);
            this.Controls.Add(this._Game3);
            this.Controls.Add(this._Game2);
            this.Controls.Add(this._Game1);
            this.Name = "Form1";
            this.Text = "Mini Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _Game1;
        private System.Windows.Forms.Button _Game2;
        private System.Windows.Forms.Button _Game3;
    }
}

