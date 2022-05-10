namespace hanoi.GUI
{
    partial class HanoiUI
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
            this.peg0Base = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.peg0 = new System.Windows.Forms.FlowLayoutPanel();
            this.disc2 = new System.Windows.Forms.Panel();
            this.disc1 = new System.Windows.Forms.Panel();
            this.disc0 = new System.Windows.Forms.Panel();
            this.peg1 = new System.Windows.Forms.FlowLayoutPanel();
            this.peg1Base = new System.Windows.Forms.Panel();
            this.peg2Base = new System.Windows.Forms.Panel();
            this.peg2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblBFS = new System.Windows.Forms.Label();
            this.peg0.SuspendLayout();
            this.SuspendLayout();
            // 
            // peg0Base
            // 
            this.peg0Base.BackColor = System.Drawing.Color.Black;
            this.peg0Base.Location = new System.Drawing.Point(121, 304);
            this.peg0Base.Margin = new System.Windows.Forms.Padding(4, 4, 27, 4);
            this.peg0Base.Name = "peg0Base";
            this.peg0Base.Size = new System.Drawing.Size(160, 6);
            this.peg0Base.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(114, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 26, 4, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Towers of Hanoi";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // peg0
            // 
            this.peg0.Controls.Add(this.disc2);
            this.peg0.Controls.Add(this.disc1);
            this.peg0.Controls.Add(this.disc0);
            this.peg0.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg0.Location = new System.Drawing.Point(121, 159);
            this.peg0.Margin = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.peg0.Name = "peg0";
            this.peg0.Size = new System.Drawing.Size(160, 142);
            this.peg0.TabIndex = 2;
            // 
            // disc2
            // 
            this.disc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.disc2.Location = new System.Drawing.Point(13, 105);
            this.disc2.Margin = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.disc2.Name = "disc2";
            this.disc2.Size = new System.Drawing.Size(133, 31);
            this.disc2.TabIndex = 3;
            // 
            // disc1
            // 
            this.disc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(231)))));
            this.disc1.Location = new System.Drawing.Point(29, 62);
            this.disc1.Margin = new System.Windows.Forms.Padding(29, 6, 29, 6);
            this.disc1.Name = "disc1";
            this.disc1.Size = new System.Drawing.Size(101, 31);
            this.disc1.TabIndex = 4;
            // 
            // disc0
            // 
            this.disc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.disc0.Location = new System.Drawing.Point(47, 19);
            this.disc0.Margin = new System.Windows.Forms.Padding(47, 0, 47, 6);
            this.disc0.Name = "disc0";
            this.disc0.Size = new System.Drawing.Size(67, 31);
            this.disc0.TabIndex = 4;
            this.disc0.Paint += new System.Windows.Forms.PaintEventHandler(this.disc0_Paint);
            // 
            // peg1
            // 
            this.peg1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg1.Location = new System.Drawing.Point(308, 159);
            this.peg1.Margin = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.peg1.Name = "peg1";
            this.peg1.Size = new System.Drawing.Size(160, 142);
            this.peg1.TabIndex = 3;
            // 
            // peg1Base
            // 
            this.peg1Base.BackColor = System.Drawing.Color.Black;
            this.peg1Base.Location = new System.Drawing.Point(308, 304);
            this.peg1Base.Margin = new System.Windows.Forms.Padding(4, 4, 27, 4);
            this.peg1Base.Name = "peg1Base";
            this.peg1Base.Size = new System.Drawing.Size(160, 6);
            this.peg1Base.TabIndex = 1;
            // 
            // peg2Base
            // 
            this.peg2Base.BackColor = System.Drawing.Color.Black;
            this.peg2Base.Location = new System.Drawing.Point(495, 304);
            this.peg2Base.Margin = new System.Windows.Forms.Padding(4, 4, 27, 4);
            this.peg2Base.Name = "peg2Base";
            this.peg2Base.Size = new System.Drawing.Size(160, 6);
            this.peg2Base.TabIndex = 4;
            // 
            // peg2
            // 
            this.peg2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg2.Location = new System.Drawing.Point(495, 159);
            this.peg2.Margin = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.peg2.Name = "peg2";
            this.peg2.Size = new System.Drawing.Size(160, 142);
            this.peg2.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(848, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Crimson;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("OCR A Extended", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(521, 63);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(134, 47);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Start";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblBFS
            // 
            this.lblBFS.AutoSize = true;
            this.lblBFS.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBFS.ForeColor = System.Drawing.Color.Black;
            this.lblBFS.Location = new System.Drawing.Point(127, 97);
            this.lblBFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBFS.Name = "lblBFS";
            this.lblBFS.Size = new System.Drawing.Size(84, 39);
            this.lblBFS.TabIndex = 20;
            this.lblBFS.Text = "BFS";
            // 
            // HanoiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(936, 349);
            this.Controls.Add(this.lblBFS);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.peg2Base);
            this.Controls.Add(this.peg2);
            this.Controls.Add(this.peg1Base);
            this.Controls.Add(this.peg1);
            this.Controls.Add(this.peg0Base);
            this.Controls.Add(this.peg0);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HanoiUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "T. of Hanoi";
            this.Load += new System.EventHandler(this.HanoiUI_Load);
            this.peg0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel peg0Base;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel peg0;
        private System.Windows.Forms.Panel disc2;
        private System.Windows.Forms.Panel disc1;
        private System.Windows.Forms.Panel disc0;
        private System.Windows.Forms.FlowLayoutPanel peg1;
        private System.Windows.Forms.Panel peg1Base;
        private System.Windows.Forms.Panel peg2Base;
        private System.Windows.Forms.FlowLayoutPanel peg2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblBFS;
    }
}

