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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonFacts = new System.Windows.Forms.Button();
            this.panelFacts = new System.Windows.Forms.Panel();
            this.panelFactories = new System.Windows.Forms.Panel();
            this.panelDepartment = new System.Windows.Forms.Panel();
            this.panelWorkers = new System.Windows.Forms.Panel();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.panelMachines = new System.Windows.Forms.Panel();
            this.buttonMachine1 = new System.Windows.Forms.Button();
            this.buttonMachines = new System.Windows.Forms.Button();
            this.buttonDepartment1 = new System.Windows.Forms.Button();
            this.buttonDepartments = new System.Windows.Forms.Button();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonClock = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelMenu.SuspendLayout();
            this.panelFacts.SuspendLayout();
            this.panelFactories.SuspendLayout();
            this.panelDepartment.SuspendLayout();
            this.panelWorkers.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.panelBase);
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
            this.panelBase.Size = new System.Drawing.Size(200, 455);
            this.panelBase.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Alfa_Vega.Properties.Resources.Banner;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 106);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonFacts
            // 
            this.buttonFacts.FlatAppearance.BorderSize = 0;
            this.buttonFacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacts.Image = global::Alfa_Vega.Properties.Resources.icons8_factory;
            this.buttonFacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFacts.Location = new System.Drawing.Point(419, 66);
            this.buttonFacts.Name = "buttonFacts";
            this.buttonFacts.Size = new System.Drawing.Size(200, 41);
            this.buttonFacts.TabIndex = 4;
            this.buttonFacts.Text = "Fabrikalar";
            this.buttonFacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFacts.UseVisualStyleBackColor = true;
            // 
            // panelFacts
            // 
            this.panelFacts.BackColor = System.Drawing.Color.Transparent;
            this.panelFacts.Controls.Add(this.panelFactories);
            this.panelFacts.Controls.Add(this.buttonDepartments);
            this.panelFacts.Location = new System.Drawing.Point(101, 80);
            this.panelFacts.Name = "panelFacts";
            this.panelFacts.Size = new System.Drawing.Size(246, 312);
            this.panelFacts.TabIndex = 3;
            // 
            // panelFactories
            // 
            this.panelFactories.BackColor = System.Drawing.Color.Transparent;
            this.panelFactories.Controls.Add(this.panelDepartment);
            this.panelFactories.Controls.Add(this.buttonDepartment1);
            this.panelFactories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFactories.Location = new System.Drawing.Point(0, 43);
            this.panelFactories.Name = "panelFactories";
            this.panelFactories.Size = new System.Drawing.Size(246, 260);
            this.panelFactories.TabIndex = 3;
            // 
            // panelDepartment
            // 
            this.panelDepartment.BackColor = System.Drawing.Color.Transparent;
            this.panelDepartment.Controls.Add(this.panelWorkers);
            this.panelDepartment.Controls.Add(this.buttonWorkers);
            this.panelDepartment.Controls.Add(this.panelMachines);
            this.panelDepartment.Controls.Add(this.buttonMachines);
            this.panelDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDepartment.Location = new System.Drawing.Point(0, 43);
            this.panelDepartment.Name = "panelDepartment";
            this.panelDepartment.Size = new System.Drawing.Size(246, 207);
            this.panelDepartment.TabIndex = 3;
            // 
            // panelWorkers
            // 
            this.panelWorkers.BackColor = System.Drawing.Color.Transparent;
            this.panelWorkers.Controls.Add(this.buttonWorker);
            this.panelWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorkers.Location = new System.Drawing.Point(0, 143);
            this.panelWorkers.Name = "panelWorkers";
            this.panelWorkers.Size = new System.Drawing.Size(246, 55);
            this.panelWorkers.TabIndex = 5;
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorker.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonWorker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWorker.Image = global::Alfa_Vega.Properties.Resources.icons8_worker;
            this.buttonWorker.Location = new System.Drawing.Point(0, 0);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.buttonWorker.Size = new System.Drawing.Size(246, 43);
            this.buttonWorker.TabIndex = 0;
            this.buttonWorker.Text = "Çalışan 1";
            this.buttonWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWorker.UseVisualStyleBackColor = false;
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorkers.FlatAppearance.BorderSize = 0;
            this.buttonWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkers.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonWorkers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWorkers.Image = global::Alfa_Vega.Properties.Resources.icons8_workers;
            this.buttonWorkers.Location = new System.Drawing.Point(0, 100);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonWorkers.Size = new System.Drawing.Size(246, 43);
            this.buttonWorkers.TabIndex = 4;
            this.buttonWorkers.Text = "Çalışanlar";
            this.buttonWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWorkers.UseVisualStyleBackColor = false;
            // 
            // panelMachines
            // 
            this.panelMachines.BackColor = System.Drawing.Color.Transparent;
            this.panelMachines.Controls.Add(this.buttonMachine1);
            this.panelMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMachines.Location = new System.Drawing.Point(0, 43);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(246, 57);
            this.panelMachines.TabIndex = 3;
            // 
            // buttonMachine1
            // 
            this.buttonMachine1.BackColor = System.Drawing.Color.Transparent;
            this.buttonMachine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMachine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMachine1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonMachine1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMachine1.Image = global::Alfa_Vega.Properties.Resources.icons8_cnc_machine_1;
            this.buttonMachine1.Location = new System.Drawing.Point(0, 0);
            this.buttonMachine1.Name = "buttonMachine1";
            this.buttonMachine1.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.buttonMachine1.Size = new System.Drawing.Size(246, 43);
            this.buttonMachine1.TabIndex = 0;
            this.buttonMachine1.Text = "Makine 1";
            this.buttonMachine1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMachine1.UseVisualStyleBackColor = false;
            // 
            // buttonMachines
            // 
            this.buttonMachines.BackColor = System.Drawing.Color.Transparent;
            this.buttonMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMachines.FlatAppearance.BorderSize = 0;
            this.buttonMachines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMachines.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonMachines.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMachines.Image = global::Alfa_Vega.Properties.Resources.icons8_server;
            this.buttonMachines.Location = new System.Drawing.Point(0, 0);
            this.buttonMachines.Name = "buttonMachines";
            this.buttonMachines.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonMachines.Size = new System.Drawing.Size(246, 43);
            this.buttonMachines.TabIndex = 0;
            this.buttonMachines.Text = "Makineler";
            this.buttonMachines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMachines.UseVisualStyleBackColor = false;
            // 
            // buttonDepartment1
            // 
            this.buttonDepartment1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDepartment1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartment1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonDepartment1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDepartment1.Image = global::Alfa_Vega.Properties.Resources.icons8_department_shop_24px;
            this.buttonDepartment1.Location = new System.Drawing.Point(0, 0);
            this.buttonDepartment1.Name = "buttonDepartment1";
            this.buttonDepartment1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDepartment1.Size = new System.Drawing.Size(246, 43);
            this.buttonDepartment1.TabIndex = 0;
            this.buttonDepartment1.Text = "Departman 1";
            this.buttonDepartment1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDepartment1.UseVisualStyleBackColor = true;
            // 
            // buttonDepartments
            // 
            this.buttonDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartments.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonDepartments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDepartments.Image = global::Alfa_Vega.Properties.Resources.icons8_module;
            this.buttonDepartments.Location = new System.Drawing.Point(0, 0);
            this.buttonDepartments.Name = "buttonDepartments";
            this.buttonDepartments.Size = new System.Drawing.Size(246, 43);
            this.buttonDepartments.TabIndex = 0;
            this.buttonDepartments.Text = "Fabrika 1";
            this.buttonDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDepartments.UseVisualStyleBackColor = true;
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.Transparent;
            this.panelUpper.Controls.Add(this.buttonUser);
            this.panelUpper.Controls.Add(this.buttonClock);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(200, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(744, 48);
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
            this.buttonUser.Location = new System.Drawing.Point(368, 0);
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
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 48);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(744, 513);
            this.panelMain.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFacts);
            this.groupBox1.Controls.Add(this.panelFacts);
            this.groupBox1.Location = new System.Drawing.Point(120, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alfa_Vega.Properties.Resources.Başlıksız_111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUpper);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alfa-VEGA Modular SCADA Systems v1";
            this.panelMenu.ResumeLayout(false);
            this.panelFacts.ResumeLayout(false);
            this.panelFactories.ResumeLayout(false);
            this.panelDepartment.ResumeLayout(false);
            this.panelWorkers.ResumeLayout(false);
            this.panelMachines.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonClock;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonFacts;
        private System.Windows.Forms.Panel panelFacts;
        private System.Windows.Forms.Button buttonDepartments;
        private System.Windows.Forms.Panel panelFactories;
        private System.Windows.Forms.Button buttonDepartment1;
        private System.Windows.Forms.Panel panelDepartment;
        private System.Windows.Forms.Button buttonMachines;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Panel panelMachines;
        private System.Windows.Forms.Button buttonMachine1;
        private System.Windows.Forms.Panel panelWorkers;
        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button button1;
    }
}