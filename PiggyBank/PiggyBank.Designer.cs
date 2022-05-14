namespace PiggyBank
{
    partial class PiggyBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiggyBank));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBanknote = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCrash = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCoin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnShake = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(585, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "PIGGY BANK";
            // 
            // btnBanknote
            // 
            this.btnBanknote.ActiveBorderThickness = 1;
            this.btnBanknote.ActiveCornerRadius = 20;
            this.btnBanknote.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnBanknote.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnBanknote.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnBanknote.BackColor = System.Drawing.Color.Pink;
            this.btnBanknote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanknote.BackgroundImage")));
            this.btnBanknote.ButtonText = "Add Banknote";
            this.btnBanknote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanknote.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanknote.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBanknote.IdleBorderThickness = 1;
            this.btnBanknote.IdleCornerRadius = 20;
            this.btnBanknote.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.btnBanknote.IdleForecolor = System.Drawing.Color.White;
            this.btnBanknote.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.btnBanknote.Location = new System.Drawing.Point(45, 225);
            this.btnBanknote.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBanknote.Name = "btnBanknote";
            this.btnBanknote.Size = new System.Drawing.Size(223, 50);
            this.btnBanknote.TabIndex = 26;
            this.btnBanknote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBanknote.Click += new System.EventHandler(this.btnBanknote_Click);
            // 
            // btnCrash
            // 
            this.btnCrash.ActiveBorderThickness = 1;
            this.btnCrash.ActiveCornerRadius = 20;
            this.btnCrash.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnCrash.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnCrash.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnCrash.BackColor = System.Drawing.Color.Pink;
            this.btnCrash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrash.BackgroundImage")));
            this.btnCrash.ButtonText = "Crash Piggy";
            this.btnCrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrash.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrash.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCrash.IdleBorderThickness = 1;
            this.btnCrash.IdleCornerRadius = 20;
            this.btnCrash.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.btnCrash.IdleForecolor = System.Drawing.Color.White;
            this.btnCrash.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.btnCrash.Location = new System.Drawing.Point(594, 687);
            this.btnCrash.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCrash.Name = "btnCrash";
            this.btnCrash.Size = new System.Drawing.Size(181, 48);
            this.btnCrash.TabIndex = 24;
            this.btnCrash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrash.Click += new System.EventHandler(this.btnCrash_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PiggyBank.Properties.Resources.piggy5;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(345, 101);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(765, 570);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnCoin
            // 
            this.btnCoin.ActiveBorderThickness = 1;
            this.btnCoin.ActiveCornerRadius = 20;
            this.btnCoin.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnCoin.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnCoin.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnCoin.BackColor = System.Drawing.Color.Pink;
            this.btnCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoin.BackgroundImage")));
            this.btnCoin.ButtonText = "Add Coin";
            this.btnCoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoin.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCoin.IdleBorderThickness = 1;
            this.btnCoin.IdleCornerRadius = 20;
            this.btnCoin.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.btnCoin.IdleForecolor = System.Drawing.Color.White;
            this.btnCoin.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.btnCoin.Location = new System.Drawing.Point(45, 101);
            this.btnCoin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCoin.Name = "btnCoin";
            this.btnCoin.Size = new System.Drawing.Size(223, 48);
            this.btnCoin.TabIndex = 22;
            this.btnCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCoin.Click += new System.EventHandler(this.btnCoin_Click);
            // 
            // btnShake
            // 
            this.btnShake.ActiveBorderThickness = 1;
            this.btnShake.ActiveCornerRadius = 20;
            this.btnShake.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnShake.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnShake.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnShake.BackColor = System.Drawing.Color.Pink;
            this.btnShake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShake.BackgroundImage")));
            this.btnShake.ButtonText = "Shake";
            this.btnShake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShake.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShake.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShake.IdleBorderThickness = 1;
            this.btnShake.IdleCornerRadius = 20;
            this.btnShake.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.btnShake.IdleForecolor = System.Drawing.Color.White;
            this.btnShake.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.btnShake.Location = new System.Drawing.Point(957, 687);
            this.btnShake.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(181, 48);
            this.btnShake.TabIndex = 27;
            this.btnShake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(1247, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Volume";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(45, 186);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(223, 36);
            this.guna2ComboBox1.TabIndex = 29;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(45, 56);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(223, 36);
            this.guna2ComboBox2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(1247, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Volume";
            // 
            // PiggyBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1462, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnBanknote);
            this.Controls.Add(this.btnCrash);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnCoin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "PiggyBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PiggyBank";
            this.Load += new System.EventHandler(this.PiggyBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCoin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCrash;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBanknote;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShake;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label3;
    }
}