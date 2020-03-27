namespace Alfa_Vega
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonClock = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.panelBase);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelBase
            // 
            this.panelBase.AutoScroll = true;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 106);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(200, 411);
            this.panelBase.TabIndex = 5;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::Alfa_Vega.Properties.Resources.icons8_settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 517);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 44);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Alfa_Vega.Properties.Resources.Banner;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.button1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 106);
            this.panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.Transparent;
            this.panelUpper.Controls.Add(this.buttonUser);
            this.panelUpper.Controls.Add(this.buttonClock);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(200, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1014, 48);
            this.panelUpper.TabIndex = 1;
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUser.Image = global::Alfa_Vega.Properties.Resources.icons8_user;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.Location = new System.Drawing.Point(638, 0);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(376, 48);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "Administrator";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonClock
            // 
            this.buttonClock.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClock.FlatAppearance.BorderSize = 0;
            this.buttonClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClock.Image = global::Alfa_Vega.Properties.Resources.icons8_clock;
            this.buttonClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClock.Location = new System.Drawing.Point(0, 0);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(337, 48);
            this.buttonClock.TabIndex = 0;
            this.buttonClock.Text = "Time";
            this.buttonClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClock.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoScrollMargin = new System.Drawing.Size(20, 0);
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 48);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1014, 513);
            this.panelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alfa_Vega.Properties.Resources.Başlıksız_111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUpper);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1194, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alfa-VEGA Modular SCADA Systems v1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonClock;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSettings;
    }
}