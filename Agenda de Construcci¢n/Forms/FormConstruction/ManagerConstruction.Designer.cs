namespace Agenda_de_Construcción
{
    partial class ManagerConstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerConstruction));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEdite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.listViewConstr = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suburb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.buttonExit.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.salir_norm;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(893, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 33);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEdite
            // 
            this.buttonEdite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.buttonEdite.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.editar_norm;
            this.buttonEdite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdite.FlatAppearance.BorderSize = 0;
            this.buttonEdite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdite.ForeColor = System.Drawing.Color.White;
            this.buttonEdite.Location = new System.Drawing.Point(113, 12);
            this.buttonEdite.Name = "buttonEdite";
            this.buttonEdite.Size = new System.Drawing.Size(95, 33);
            this.buttonEdite.TabIndex = 10;
            this.buttonEdite.UseVisualStyleBackColor = false;
            this.buttonEdite.Click += new System.EventHandler(this.buttonEdite_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.buttonDelete.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.limpiar_norm;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(214, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 33);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.buttonRegister.BackgroundImage = global::Agenda_de_Construcción.Properties.Resources.nuevo_norm;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(12, 12);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(95, 33);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // listViewConstr
            // 
            this.listViewConstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.listViewConstr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Description,
            this.Street,
            this.Suburb,
            this.Number,
            this.StartDate,
            this.EndDate});
            this.listViewConstr.ForeColor = System.Drawing.Color.White;
            this.listViewConstr.FullRowSelect = true;
            this.listViewConstr.Location = new System.Drawing.Point(12, 51);
            this.listViewConstr.Name = "listViewConstr";
            this.listViewConstr.Size = new System.Drawing.Size(976, 539);
            this.listViewConstr.TabIndex = 7;
            this.listViewConstr.UseCompatibleStateImageBehavior = false;
            this.listViewConstr.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.DisplayIndex = 7;
            this.ID.Width = 0;
            // 
            // Name
            // 
            this.Name.DisplayIndex = 0;
            this.Name.Text = "Construccción";
            this.Name.Width = 150;
            // 
            // Description
            // 
            this.Description.DisplayIndex = 1;
            this.Description.Text = "Descripción";
            this.Description.Width = 200;
            // 
            // Street
            // 
            this.Street.DisplayIndex = 2;
            this.Street.Text = "Dirección";
            this.Street.Width = 205;
            // 
            // Suburb
            // 
            this.Suburb.DisplayIndex = 3;
            this.Suburb.Text = "Colonia";
            this.Suburb.Width = 180;
            // 
            // Number
            // 
            this.Number.DisplayIndex = 4;
            this.Number.Text = "No.";
            this.Number.Width = 76;
            // 
            // StartDate
            // 
            this.StartDate.DisplayIndex = 5;
            this.StartDate.Text = "Inicio";
            this.StartDate.Width = 79;
            // 
            // EndDate
            // 
            this.EndDate.DisplayIndex = 6;
            this.EndDate.Text = "Fin";
            this.EndDate.Width = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cliente:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(402, 14);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(0, 24);
            this.labelClient.TabIndex = 15;
            // 
            // ManagerConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEdite);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.listViewConstr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Construcciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEdite;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ListView listViewConstr;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader Suburb;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ColumnHeader ID;
    }
}