namespace KutuphaneOtomasyonWinForm
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 739);
            this.panel1.TabIndex = 0;
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(240, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(1024, 47);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "              Kullanıcılar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 90);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 739);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button button4;
    }
}