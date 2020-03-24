namespace Agenda_de_Construcción
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewMaterial = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Import = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PurchaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxConstruction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.monthCalendarDate = new System.Windows.Forms.MonthCalendar();
            this.labelToday = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSuburb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMoneyRecieved = new System.Windows.Forms.Button();
            this.buttonEdite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.labelAutor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMaterial
            // 
            this.listViewMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.listViewMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Description,
            this.Import,
            this.Quantity,
            this.Total,
            this.PurchaseDate});
            this.listViewMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMaterial.ForeColor = System.Drawing.Color.White;
            this.listViewMaterial.FullRowSelect = true;
            this.listViewMaterial.Location = new System.Drawing.Point(12, 97);
            this.listViewMaterial.Name = "listViewMaterial";
            this.listViewMaterial.Size = new System.Drawing.Size(1050, 650);
            this.listViewMaterial.TabIndex = 1;
            this.listViewMaterial.UseCompatibleStateImageBehavior = false;
            this.listViewMaterial.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.DisplayIndex = 6;
            this.ID.Width = 0;
            // 
            // Name
            // 
            this.Name.DisplayIndex = 0;
            this.Name.Text = "Nombre de Material o Servicio";
            this.Name.Width = 250;
            // 
            // Description
            // 
            this.Description.DisplayIndex = 1;
            this.Description.Text = "Descripción";
            this.Description.Width = 433;
            // 
            // Import
            // 
            this.Import.DisplayIndex = 2;
            this.Import.Text = "Importe";
            this.Import.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Import.Width = 75;
            // 
            // Quantity
            // 
            this.Quantity.DisplayIndex = 3;
            this.Quantity.Text = "Cantidad";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 77;
            // 
            // Total
            // 
            this.Total.DisplayIndex = 4;
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.Width = 88;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DisplayIndex = 5;
            this.PurchaseDate.Text = "Fecha de Compra";
            this.PurchaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PurchaseDate.Width = 120;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 67);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(250, 24);
            this.comboBoxClient.TabIndex = 2;
            this.comboBoxClient.Click += new System.EventHandler(this.comboBoxClient_Click);
            // 
            // comboBoxConstruction
            // 
            this.comboBoxConstruction.FormattingEnabled = true;
            this.comboBoxConstruction.Location = new System.Drawing.Point(268, 66);
            this.comboBoxConstruction.Name = "comboBoxConstruction";
            this.comboBoxConstruction.Size = new System.Drawing.Size(250, 24);
            this.comboBoxConstruction.TabIndex = 3;
            this.comboBoxConstruction.Click += new System.EventHandler(this.comboBoxConstruction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Construcción";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(336, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(693, 31);
            this.Title.TabIndex = 13;
            this.Title.Text = "Agenda de Construcción de Armando Suárez Avalos";
            // 
            // monthCalendarDate
            // 
            this.monthCalendarDate.BackColor = System.Drawing.Color.Gainsboro;
            this.monthCalendarDate.Location = new System.Drawing.Point(1086, 146);
            this.monthCalendarDate.MaxSelectionCount = 1;
            this.monthCalendarDate.Name = "monthCalendarDate";
            this.monthCalendarDate.ShowTodayCircle = false;
            this.monthCalendarDate.TabIndex = 15;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToday.ForeColor = System.Drawing.Color.White;
            this.labelToday.Location = new System.Drawing.Point(1083, 115);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(105, 16);
            this.labelToday.TabIndex = 16;
            this.labelToday.Text = "Fecha de Hoy";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumber.Enabled = false;
            this.textBoxNumber.Location = new System.Drawing.Point(217, 223);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(50, 22);
            this.textBoxNumber.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "No.";
            // 
            // textBoxSuburb
            // 
            this.textBoxSuburb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSuburb.Enabled = false;
            this.textBoxSuburb.Location = new System.Drawing.Point(19, 223);
            this.textBoxSuburb.Name = "textBoxSuburb";
            this.textBoxSuburb.Size = new System.Drawing.Size(192, 22);
            this.textBoxSuburb.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Colonia";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStreet.Enabled = false;
            this.textBoxStreet.Location = new System.Drawing.Point(19, 179);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(248, 22);
            this.textBoxStreet.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dirección";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(19, 91);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(248, 66);
            this.textBoxDescription.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descripción";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(19, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 22);
            this.textBoxName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre de la Construcción";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(19, 267);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(120, 22);
            this.textBoxTotal.TabIndex = 31;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(144, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Fecha de Inicio";
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStartDate.Enabled = false;
            this.textBoxStartDate.Location = new System.Drawing.Point(147, 267);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(120, 22);
            this.textBoxStartDate.TabIndex = 33;
            this.textBoxStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.textBoxStartDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNumber);
            this.groupBox1.Controls.Add(this.textBoxStreet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSuburb);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1068, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 311);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Construcción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Agenda_de_Construcción.Properties.Resources.Loader;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.About;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAbout.Location = new System.Drawing.Point(1228, 17);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(23, 23);
            this.buttonAbout.TabIndex = 38;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Image = global::Agenda_de_Construcción.Properties.Resources.Draw;
            this.pictureBoxPlane.Location = new System.Drawing.Point(1102, 637);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(212, 113);
            this.pictureBoxPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlane.TabIndex = 37;
            this.pictureBoxPlane.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonSettings.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.Settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Location = new System.Drawing.Point(1274, 48);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(64, 64);
            this.buttonSettings.TabIndex = 36;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonMoneyRecieved
            // 
            this.buttonMoneyRecieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonMoneyRecieved.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.Money;
            this.buttonMoneyRecieved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoneyRecieved.FlatAppearance.BorderSize = 0;
            this.buttonMoneyRecieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoneyRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoneyRecieved.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMoneyRecieved.Location = new System.Drawing.Point(1180, 48);
            this.buttonMoneyRecieved.Name = "buttonMoneyRecieved";
            this.buttonMoneyRecieved.Size = new System.Drawing.Size(64, 64);
            this.buttonMoneyRecieved.TabIndex = 35;
            this.buttonMoneyRecieved.UseVisualStyleBackColor = false;
            this.buttonMoneyRecieved.Click += new System.EventHandler(this.buttonMoneyRecieved_Click);
            // 
            // buttonEdite
            // 
            this.buttonEdite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonEdite.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.editar_norm;
            this.buttonEdite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdite.FlatAppearance.BorderSize = 0;
            this.buttonEdite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdite.ForeColor = System.Drawing.Color.White;
            this.buttonEdite.Location = new System.Drawing.Point(967, 61);
            this.buttonEdite.Name = "buttonEdite";
            this.buttonEdite.Size = new System.Drawing.Size(95, 33);
            this.buttonEdite.TabIndex = 9;
            this.buttonEdite.UseVisualStyleBackColor = false;
            this.buttonEdite.Click += new System.EventHandler(this.buttonEdite_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonDelete.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.limpiar_norm;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(866, 61);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 33);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonRegister.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.nuevo_norm;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(765, 62);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(95, 33);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonLoad.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.upd_norm;
            this.buttonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(524, 61);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(95, 33);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonClient.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.Client;
            this.buttonClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClient.Location = new System.Drawing.Point(1086, 48);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(64, 64);
            this.buttonClient.TabIndex = 4;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.buttonExit.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.salir_norm;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1257, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 33);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Agenda_de_Construcción.Properties.Resources.Loader;
            this.pictureBox2.Location = new System.Drawing.Point(1035, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.Print;
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(625, 62);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(32, 32);
            this.buttonPrint.TabIndex = 41;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.Color.White;
            this.labelAutor.Location = new System.Drawing.Point(1089, 750);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(238, 16);
            this.labelAutor.TabIndex = 42;
            this.labelAutor.Text = "Creado por Alexis Suárez Llamas";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 726);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.pictureBoxPlane);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonMoneyRecieved);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.monthCalendarDate);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdite);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.comboBoxConstruction);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.listViewMaterial);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Construcción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listViewMaterial;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxConstruction;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Import;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader PurchaseDate;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.MonthCalendar monthCalendarDate;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSuburb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMoneyRecieved;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label labelAutor;
    }
}

