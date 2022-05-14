namespace PiggyBank
{
    partial class CrashedPiggy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashedPiggy));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.btnFix = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(589, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 49);
            this.label1.TabIndex = 26;
            this.label1.Text = "PIGGY BANK";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblTotalMoney.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.Location = new System.Drawing.Point(1159, 698);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(170, 23);
            this.lblTotalMoney.TabIndex = 30;
            this.lblTotalMoney.Text = "TOTAL MONEY";
            // 
            // btnFix
            // 
            this.btnFix.ActiveBorderThickness = 1;
            this.btnFix.ActiveCornerRadius = 20;
            this.btnFix.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnFix.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnFix.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnFix.BackColor = System.Drawing.Color.Pink;
            this.btnFix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFix.BackgroundImage")));
            this.btnFix.ButtonText = "Fix Piggy";
            this.btnFix.CausesValidation = false;
            this.btnFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFix.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFix.IdleBorderThickness = 1;
            this.btnFix.IdleCornerRadius = 20;
            this.btnFix.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.btnFix.IdleForecolor = System.Drawing.Color.White;
            this.btnFix.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.btnFix.Location = new System.Drawing.Point(668, 687);
            this.btnFix.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(181, 48);
            this.btnFix.TabIndex = 29;
            this.btnFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PiggyBank.Properties.Resources.brokenpiggy;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(349, 95);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(765, 570);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 27;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CrashedPiggy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1462, 750);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrashedPiggy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrashedPiggy";
            this.Load += new System.EventHandler(this.CrashedPiggy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFix;
        private System.Windows.Forms.Label lblTotalMoney;
    }
}