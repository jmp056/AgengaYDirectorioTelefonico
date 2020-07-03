namespace AgengaYDirectorioTelefonico.UI.Consultas
{
    partial class cEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEventos));
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.MyGroupBox = new System.Windows.Forms.GroupBox();
            this.HoraComboBox = new System.Windows.Forms.ComboBox();
            this.RangoCheckBox = new System.Windows.Forms.CheckBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EventosDataGridView = new System.Windows.Forms.DataGridView();
            this.MyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.Location = new System.Drawing.Point(75, 19);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(54, 16);
            this.DesdeLabel.TabIndex = 1;
            this.DesdeLabel.Text = "Desde";
            // 
            // MyGroupBox
            // 
            this.MyGroupBox.Controls.Add(this.HoraComboBox);
            this.MyGroupBox.Controls.Add(this.RangoCheckBox);
            this.MyGroupBox.Controls.Add(this.FiltroLabel);
            this.MyGroupBox.Controls.Add(this.CriterioLabel);
            this.MyGroupBox.Controls.Add(this.FiltroComboBox);
            this.MyGroupBox.Controls.Add(this.CriterioTextBox);
            this.MyGroupBox.Controls.Add(this.AgregarButton);
            this.MyGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.MyGroupBox.Controls.Add(this.HastaLabel);
            this.MyGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.MyGroupBox.Controls.Add(this.DesdeLabel);
            this.MyGroupBox.Location = new System.Drawing.Point(10, 10);
            this.MyGroupBox.Name = "MyGroupBox";
            this.MyGroupBox.Size = new System.Drawing.Size(697, 98);
            this.MyGroupBox.TabIndex = 2;
            this.MyGroupBox.TabStop = false;
            // 
            // HoraComboBox
            // 
            this.HoraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraComboBox.FormattingEnabled = true;
            this.HoraComboBox.Items.AddRange(new object[] {
            "12:00 A.M.",
            "1:00 A.M.",
            "2:00 A.M.",
            "3:00 A.M.",
            "4:00 A.M.",
            "5:00 A.M.",
            "6:00 A.M.",
            "7:00 A.M.",
            "8:00 A.M.",
            "9:00 A.M.",
            "10:00 A.M.",
            "11:00 A.M.",
            "12:00 P.M.",
            "1:00 P.M.",
            "2:00 P.M.",
            "3:00 P.M.",
            "4:00 P.M.",
            "5:00 P.M.",
            "6:00 P.M.",
            "7:00 P.M.",
            "8:00 P.M.",
            "9:00 P.M.",
            "10:00 P.M.",
            "11:00 P.M."});
            this.HoraComboBox.Location = new System.Drawing.Point(285, 54);
            this.HoraComboBox.Name = "HoraComboBox";
            this.HoraComboBox.Size = new System.Drawing.Size(85, 24);
            this.HoraComboBox.TabIndex = 109;
            this.HoraComboBox.Visible = false;
            this.HoraComboBox.SelectedIndexChanged += new System.EventHandler(this.HoraComboBox_SelectedIndexChanged);
            // 
            // RangoCheckBox
            // 
            this.RangoCheckBox.AutoSize = true;
            this.RangoCheckBox.Checked = true;
            this.RangoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RangoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangoCheckBox.Location = new System.Drawing.Point(400, 19);
            this.RangoCheckBox.Name = "RangoCheckBox";
            this.RangoCheckBox.Size = new System.Drawing.Size(202, 20);
            this.RangoCheckBox.TabIndex = 11;
            this.RangoCheckBox.Text = "Filtrar por rango de fecha";
            this.RangoCheckBox.UseVisualStyleBackColor = true;
            this.RangoCheckBox.CheckedChanged += new System.EventHandler(this.RangoCheckBox_CheckedChanged);
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(11, 56);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(75, 16);
            this.FiltroLabel.TabIndex = 6;
            this.FiltroLabel.Text = "Filtrar por";
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioLabel.Location = new System.Drawing.Point(221, 56);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(58, 16);
            this.CriterioLabel.TabIndex = 10;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Hora",
            "Descripcion",
            "Nota"});
            this.FiltroComboBox.Location = new System.Drawing.Point(91, 54);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltroComboBox.TabIndex = 7;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(281, 56);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(200, 22);
            this.CriterioTextBox.TabIndex = 8;
            this.CriterioTextBox.TextChanged += new System.EventHandler(this.CriterioTextBox_TextChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(491, 46);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(197, 42);
            this.AgregarButton.TabIndex = 9;
            this.AgregarButton.Text = "Agregar nuevo evento";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(290, 17);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.HastaDateTimePicker.TabIndex = 4;
            this.HastaDateTimePicker.ValueChanged += new System.EventHandler(this.HastaDateTimePicker_ValueChanged);
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.Location = new System.Drawing.Point(235, 19);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 16);
            this.HastaLabel.TabIndex = 3;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(130, 17);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.DesdeDateTimePicker.TabIndex = 2;
            this.DesdeDateTimePicker.ValueChanged += new System.EventHandler(this.DesdeDateTimePicker_ValueChanged);
            // 
            // EventosDataGridView
            // 
            this.EventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventosDataGridView.Location = new System.Drawing.Point(10, 117);
            this.EventosDataGridView.Name = "EventosDataGridView";
            this.EventosDataGridView.ReadOnly = true;
            this.EventosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventosDataGridView.Size = new System.Drawing.Size(697, 217);
            this.EventosDataGridView.TabIndex = 5;
            this.EventosDataGridView.DoubleClick += new System.EventHandler(this.EventosDataGridView_DoubleClick);
            // 
            // cEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 346);
            this.Controls.Add(this.EventosDataGridView);
            this.Controls.Add(this.MyGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cEventos";
            this.Text = "Consulta de eventos";
            this.Activated += new System.EventHandler(this.cEventos_Activated);
            this.Load += new System.EventHandler(this.cEventos_Load);
            this.MyGroupBox.ResumeLayout(false);
            this.MyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.GroupBox MyGroupBox;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.CheckBox RangoCheckBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView EventosDataGridView;
        private System.Windows.Forms.ComboBox HoraComboBox;
    }
}