namespace Alfa_Vega
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.indicator2 = new System.Windows.Forms.PictureBox();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProduct = new Bunifu.Framework.UI.BunifuTileButton();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnVega = new Bunifu.Framework.UI.BunifuTileButton();
            this.gbPlace = new System.Windows.Forms.GroupBox();
            this.placeRFID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbWorker = new System.Windows.Forms.GroupBox();
            this.workerRFID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPicture = new System.Windows.Forms.ComboBox();
            this.gbInitial = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOwner = new System.Windows.Forms.ComboBox();
            this.btnDepartment = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnWorker = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMachine = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPlace = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFactory = new Bunifu.Framework.UI.BunifuTileButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.gbPlace.SuspendLayout();
            this.gbWorker.SuspendLayout();
            this.gbInitial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.indicator2);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.buttonSet);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1010, 64);
            this.panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Image = global::Alfa_Vega.Properties.Resources.icons8_delete;
            this.buttonDelete.Location = new System.Drawing.Point(231, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 44);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.Button_Click);
            // 
            // indicator2
            // 
            this.indicator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(67)))));
            this.indicator2.Location = new System.Drawing.Point(11, 48);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(98, 5);
            this.indicator2.TabIndex = 20;
            this.indicator2.TabStop = false;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Right;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button12.Image = global::Alfa_Vega.Properties.Resources.icons8_qr_code;
            this.button12.Location = new System.Drawing.Point(820, 10);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(180, 44);
            this.button12.TabIndex = 5;
            this.button12.Text = "QR-yakında-";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonSet
            // 
            this.buttonSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSet.Image = global::Alfa_Vega.Properties.Resources.icons8_edit_1;
            this.buttonSet.Location = new System.Drawing.Point(108, 10);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(123, 44);
            this.buttonSet.TabIndex = 1;
            this.buttonSet.Text = "Düzenle";
            this.buttonSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Image = global::Alfa_Vega.Properties.Resources.icons8_add_2;
            this.buttonAdd.Location = new System.Drawing.Point(10, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 44);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.indicator);
            this.panel2.Controls.Add(this.gbEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnVega);
            this.panel2.Controls.Add(this.gbPlace);
            this.panel2.Controls.Add(this.gbWorker);
            this.panel2.Controls.Add(this.gbInitial);
            this.panel2.Controls.Add(this.btnDepartment);
            this.panel2.Controls.Add(this.btnWorker);
            this.panel2.Controls.Add(this.btnMachine);
            this.panel2.Controls.Add(this.btnPlace);
            this.panel2.Controls.Add(this.btnFactory);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 442);
            this.panel2.TabIndex = 1;
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProduct.color = System.Drawing.Color.Transparent;
            this.btnProduct.colorActive = System.Drawing.Color.DarkGray;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Alfa_Vega.Properties.Resources.icons8_package_52px;
            this.btnProduct.ImagePosition = 20;
            this.btnProduct.ImageZoom = 50;
            this.btnProduct.LabelPosition = 41;
            this.btnProduct.LabelText = "Ürün";
            this.btnProduct.Location = new System.Drawing.Point(720, 29);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(128, 129);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Click += new System.EventHandler(this.Button_Click);
            // 
            // indicator
            // 
            this.indicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(67)))));
            this.indicator.Location = new System.Drawing.Point(15, 148);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(128, 10);
            this.indicator.TabIndex = 32;
            this.indicator.TabStop = false;
            // 
            // gbEdit
            // 
            this.gbEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbEdit.Controls.Add(this.cbName);
            this.gbEdit.Controls.Add(this.label7);
            this.gbEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.gbEdit.Location = new System.Drawing.Point(93, 208);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(195, 100);
            this.gbEdit.TabIndex = 29;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Düzenle/Sil";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(54, 44);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(135, 29);
            this.cbName.TabIndex = 14;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(9, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "İsim:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave.Image = global::Alfa_Vega.Properties.Resources.icons8_checkmark;
            this.btnSave.Location = new System.Drawing.Point(733, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 43);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Onayla";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnVega
            // 
            this.btnVega.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVega.BackColor = System.Drawing.Color.Transparent;
            this.btnVega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVega.color = System.Drawing.Color.Transparent;
            this.btnVega.colorActive = System.Drawing.Color.DarkGray;
            this.btnVega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVega.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnVega.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btnVega.Image = global::Alfa_Vega.Properties.Resources.icons8_vegas_96px;
            this.btnVega.ImagePosition = 20;
            this.btnVega.ImageZoom = 50;
            this.btnVega.LabelPosition = 41;
            this.btnVega.LabelText = "VEGA";
            this.btnVega.Location = new System.Drawing.Point(860, 29);
            this.btnVega.Margin = new System.Windows.Forms.Padding(6);
            this.btnVega.Name = "btnVega";
            this.btnVega.Size = new System.Drawing.Size(128, 129);
            this.btnVega.TabIndex = 9;
            this.btnVega.Click += new System.EventHandler(this.Button_Click);
            // 
            // gbPlace
            // 
            this.gbPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPlace.Controls.Add(this.placeRFID);
            this.gbPlace.Controls.Add(this.label6);
            this.gbPlace.ForeColor = System.Drawing.SystemColors.Control;
            this.gbPlace.Location = new System.Drawing.Point(532, 314);
            this.gbPlace.Name = "gbPlace";
            this.gbPlace.Size = new System.Drawing.Size(195, 100);
            this.gbPlace.TabIndex = 28;
            this.gbPlace.TabStop = false;
            this.gbPlace.Text = "Genel Bilgiler(Mekan)";
            // 
            // placeRFID
            // 
            this.placeRFID.Location = new System.Drawing.Point(74, 44);
            this.placeRFID.Name = "placeRFID";
            this.placeRFID.Size = new System.Drawing.Size(100, 27);
            this.placeRFID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "RFID:";
            // 
            // gbWorker
            // 
            this.gbWorker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbWorker.Controls.Add(this.workerRFID);
            this.gbWorker.Controls.Add(this.label4);
            this.gbWorker.Controls.Add(this.label5);
            this.gbWorker.Controls.Add(this.cbPicture);
            this.gbWorker.ForeColor = System.Drawing.SystemColors.Control;
            this.gbWorker.Location = new System.Drawing.Point(94, 314);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Size = new System.Drawing.Size(432, 100);
            this.gbWorker.TabIndex = 27;
            this.gbWorker.TabStop = false;
            this.gbWorker.Text = "Genel Bilgiler(Çalışan)";
            // 
            // workerRFID
            // 
            this.workerRFID.Location = new System.Drawing.Point(74, 44);
            this.workerRFID.Name = "workerRFID";
            this.workerRFID.Size = new System.Drawing.Size(100, 27);
            this.workerRFID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "RFID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(220, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resim:";
            // 
            // cbPicture
            // 
            this.cbPicture.Enabled = false;
            this.cbPicture.FormattingEnabled = true;
            this.cbPicture.Location = new System.Drawing.Point(291, 44);
            this.cbPicture.Name = "cbPicture";
            this.cbPicture.Size = new System.Drawing.Size(121, 29);
            this.cbPicture.TabIndex = 11;
            // 
            // gbInitial
            // 
            this.gbInitial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInitial.Controls.Add(this.label1);
            this.gbInitial.Controls.Add(this.tbName);
            this.gbInitial.Controls.Add(this.cbType);
            this.gbInitial.Controls.Add(this.label3);
            this.gbInitial.Controls.Add(this.label2);
            this.gbInitial.Controls.Add(this.cbOwner);
            this.gbInitial.ForeColor = System.Drawing.SystemColors.Control;
            this.gbInitial.Location = new System.Drawing.Point(294, 208);
            this.gbInitial.Name = "gbInitial";
            this.gbInitial.Size = new System.Drawing.Size(633, 100);
            this.gbInitial.TabIndex = 26;
            this.gbInitial.TabStop = false;
            this.gbInitial.Text = "Temel Bilgiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tip:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(257, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 27);
            this.tbName.TabIndex = 13;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(59, 44);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 29);
            this.cbType.TabIndex = 7;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(403, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bağlılık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(213, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "İsim:";
            // 
            // cbOwner
            // 
            this.cbOwner.FormattingEnabled = true;
            this.cbOwner.Location = new System.Drawing.Point(479, 44);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Size = new System.Drawing.Size(135, 29);
            this.cbOwner.TabIndex = 11;
            this.cbOwner.SelectedIndexChanged += new System.EventHandler(this.cbOwner_SelectedIndexChanged);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDepartment.color = System.Drawing.Color.Transparent;
            this.btnDepartment.colorActive = System.Drawing.Color.DarkGray;
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDepartment.Image = global::Alfa_Vega.Properties.Resources.icons8_module_100px;
            this.btnDepartment.ImagePosition = 20;
            this.btnDepartment.ImageZoom = 50;
            this.btnDepartment.LabelPosition = 41;
            this.btnDepartment.LabelText = "Departman";
            this.btnDepartment.Location = new System.Drawing.Point(155, 29);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(6);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(133, 129);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWorker.BackColor = System.Drawing.Color.Transparent;
            this.btnWorker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnWorker.color = System.Drawing.Color.Transparent;
            this.btnWorker.colorActive = System.Drawing.Color.DarkGray;
            this.btnWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorker.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnWorker.ForeColor = System.Drawing.Color.White;
            this.btnWorker.Image = ((System.Drawing.Image)(resources.GetObject("btnWorker.Image")));
            this.btnWorker.ImagePosition = 20;
            this.btnWorker.ImageZoom = 50;
            this.btnWorker.LabelPosition = 41;
            this.btnWorker.LabelText = "Çalışan";
            this.btnWorker.Location = new System.Drawing.Point(580, 29);
            this.btnWorker.Margin = new System.Windows.Forms.Padding(6);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(128, 129);
            this.btnWorker.TabIndex = 7;
            this.btnWorker.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMachine
            // 
            this.btnMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMachine.BackColor = System.Drawing.Color.Transparent;
            this.btnMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMachine.color = System.Drawing.Color.Transparent;
            this.btnMachine.colorActive = System.Drawing.Color.DarkGray;
            this.btnMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMachine.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMachine.ForeColor = System.Drawing.Color.White;
            this.btnMachine.Image = global::Alfa_Vega.Properties.Resources.icons8_cnc_machine_64px;
            this.btnMachine.ImagePosition = 20;
            this.btnMachine.ImageZoom = 50;
            this.btnMachine.LabelPosition = 41;
            this.btnMachine.LabelText = "Makine";
            this.btnMachine.Location = new System.Drawing.Point(440, 29);
            this.btnMachine.Margin = new System.Windows.Forms.Padding(6);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(128, 129);
            this.btnMachine.TabIndex = 6;
            this.btnMachine.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlace.BackColor = System.Drawing.Color.Transparent;
            this.btnPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPlace.color = System.Drawing.Color.Transparent;
            this.btnPlace.colorActive = System.Drawing.Color.DarkGray;
            this.btnPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlace.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPlace.ForeColor = System.Drawing.Color.White;
            this.btnPlace.Image = global::Alfa_Vega.Properties.Resources.icons8_place_marker_64px;
            this.btnPlace.ImagePosition = 20;
            this.btnPlace.ImageZoom = 50;
            this.btnPlace.LabelPosition = 41;
            this.btnPlace.LabelText = "Mekan";
            this.btnPlace.Location = new System.Drawing.Point(300, 29);
            this.btnPlace.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(128, 129);
            this.btnPlace.TabIndex = 5;
            this.btnPlace.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnFactory
            // 
            this.btnFactory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFactory.BackColor = System.Drawing.Color.Transparent;
            this.btnFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFactory.color = System.Drawing.Color.Transparent;
            this.btnFactory.colorActive = System.Drawing.Color.DarkGray;
            this.btnFactory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactory.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFactory.ForeColor = System.Drawing.Color.White;
            this.btnFactory.Image = global::Alfa_Vega.Properties.Resources.icons8_factory_50px;
            this.btnFactory.ImagePosition = 20;
            this.btnFactory.ImageZoom = 40;
            this.btnFactory.LabelPosition = 41;
            this.btnFactory.LabelText = "Fabrika";
            this.btnFactory.Location = new System.Drawing.Point(15, 29);
            this.btnFactory.Margin = new System.Windows.Forms.Padding(6);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(128, 129);
            this.btnFactory.TabIndex = 3;
            this.btnFactory.Click += new System.EventHandler(this.Button_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1010, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbPlace.ResumeLayout(false);
            this.gbPlace.PerformLayout();
            this.gbWorker.ResumeLayout(false);
            this.gbWorker.PerformLayout();
            this.gbInitial.ResumeLayout(false);
            this.gbInitial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox indicator2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btnProduct;
        private System.Windows.Forms.PictureBox indicator;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnVega;
        private System.Windows.Forms.GroupBox gbPlace;
        private System.Windows.Forms.TextBox placeRFID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbWorker;
        private System.Windows.Forms.TextBox workerRFID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPicture;
        private System.Windows.Forms.GroupBox gbInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOwner;
        private Bunifu.Framework.UI.BunifuTileButton btnDepartment;
        private Bunifu.Framework.UI.BunifuTileButton btnWorker;
        private Bunifu.Framework.UI.BunifuTileButton btnMachine;
        private Bunifu.Framework.UI.BunifuTileButton btnPlace;
        private Bunifu.Framework.UI.BunifuTileButton btnFactory;
        private System.Windows.Forms.Timer timer;
    }
}