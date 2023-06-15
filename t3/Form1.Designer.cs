namespace t3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(581, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 46);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblWhite
            // 
            this.lblWhite.AutoSize = true;
            this.lblWhite.Location = new System.Drawing.Point(581, 66);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(64, 17);
            this.lblWhite.TabIndex = 2;
            this.lblWhite.Text = "White : 0";
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Location = new System.Drawing.Point(581, 93);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(62, 17);
            this.lblBlack.TabIndex = 3;
            this.lblBlack.Text = "Black : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 578);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.lblWhite);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblBlack;
    }
}

