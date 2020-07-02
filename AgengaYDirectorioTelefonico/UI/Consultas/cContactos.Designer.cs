namespace AgengaYDirectorioTelefonico.UI.Consultas
{
    partial class cContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cContactos));
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ContactosDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.MyGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContactosDataGridView)).BeginInit();
            this.MyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(7, 25);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(79, 16);
            this.FiltroLabel.TabIndex = 0;
            this.FiltroLabel.Text = "Filtrar por:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Nombre",
            "Teléfono",
            "Celular",
            "Correo",
            "Dirección",
            "Nota"});
            this.FiltroComboBox.Location = new System.Drawing.Point(92, 23);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltroComboBox.TabIndex = 1;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(307, 25);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(200, 22);
            this.CriterioTextBox.TabIndex = 2;
            this.CriterioTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CriterioTextBox_KeyUp);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(532, 15);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(215, 42);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar nuevo contacto";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ContactosDataGridView
            // 
            this.ContactosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactosDataGridView.Location = new System.Drawing.Point(13, 88);
            this.ContactosDataGridView.Name = "ContactosDataGridView";
            this.ContactosDataGridView.ReadOnly = true;
            this.ContactosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContactosDataGridView.Size = new System.Drawing.Size(753, 217);
            this.ContactosDataGridView.TabIndex = 4;
            this.ContactosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactosDataGridView_CellDoubleClick);
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioLabel.Location = new System.Drawing.Point(237, 25);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(62, 16);
            this.CriterioLabel.TabIndex = 5;
            this.CriterioLabel.Text = "Criterio:";
            // 
            // MyGroupBox
            // 
            this.MyGroupBox.Controls.Add(this.FiltroLabel);
            this.MyGroupBox.Controls.Add(this.CriterioLabel);
            this.MyGroupBox.Controls.Add(this.FiltroComboBox);
            this.MyGroupBox.Controls.Add(this.CriterioTextBox);
            this.MyGroupBox.Controls.Add(this.AgregarButton);
            this.MyGroupBox.Location = new System.Drawing.Point(13, 12);
            this.MyGroupBox.Name = "MyGroupBox";
            this.MyGroupBox.Size = new System.Drawing.Size(753, 67);
            this.MyGroupBox.TabIndex = 6;
            this.MyGroupBox.TabStop = false;
            // 
            // cContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 315);
            this.Controls.Add(this.MyGroupBox);
            this.Controls.Add(this.ContactosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contactos";
            this.Activated += new System.EventHandler(this.cContactos_Activated);
            this.Load += new System.EventHandler(this.cContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactosDataGridView)).EndInit();
            this.MyGroupBox.ResumeLayout(false);
            this.MyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView ContactosDataGridView;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.GroupBox MyGroupBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
    }
}