namespace libman
{
    partial class FormCustomer
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
            this.panelPersonalData = new System.Windows.Forms.Panel();
            this.dateRegistration = new System.Windows.Forms.DateTimePicker();
            this.labelNew = new System.Windows.Forms.Label();
            this.maskedPassportId = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.maskedBirthYear = new System.Windows.Forms.MaskedTextBox();
            this.labelBirthYear = new System.Windows.Forms.Label();
            this.labelCardId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.panelDeliveredBooks = new System.Windows.Forms.Panel();
            this.labelBooks = new System.Windows.Forms.Label();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsourceBooks = new System.Windows.Forms.BindingSource(this.components);
            this.textPassportInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPersonalData.SuspendLayout();
            this.panelDeliveredBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPersonalData
            // 
            this.panelPersonalData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPersonalData.Controls.Add(this.label1);
            this.panelPersonalData.Controls.Add(this.textPassportInfo);
            this.panelPersonalData.Controls.Add(this.dateRegistration);
            this.panelPersonalData.Controls.Add(this.labelNew);
            this.panelPersonalData.Controls.Add(this.maskedPassportId);
            this.panelPersonalData.Controls.Add(this.buttonCancel);
            this.panelPersonalData.Controls.Add(this.buttonOK);
            this.panelPersonalData.Controls.Add(this.labelAddress);
            this.panelPersonalData.Controls.Add(this.textAddress);
            this.panelPersonalData.Controls.Add(this.maskedBirthYear);
            this.panelPersonalData.Controls.Add(this.labelBirthYear);
            this.panelPersonalData.Controls.Add(this.labelCardId);
            this.panelPersonalData.Controls.Add(this.labelName);
            this.panelPersonalData.Controls.Add(this.textName);
            this.panelPersonalData.Location = new System.Drawing.Point(5, 1);
            this.panelPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.panelPersonalData.Name = "panelPersonalData";
            this.panelPersonalData.Size = new System.Drawing.Size(1045, 287);
            this.panelPersonalData.TabIndex = 17;
            // 
            // dateRegistration
            // 
            this.dateRegistration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRegistration.Location = new System.Drawing.Point(428, 10);
            this.dateRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.dateRegistration.Name = "dateRegistration";
            this.dateRegistration.Size = new System.Drawing.Size(120, 22);
            this.dateRegistration.TabIndex = 18;
            this.dateRegistration.TabStop = false;
            this.dateRegistration.ValueChanged += new System.EventHandler(this.DateRegistration_ValueChanged);
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNew.ForeColor = System.Drawing.Color.Red;
            this.labelNew.Location = new System.Drawing.Point(330, 10);
            this.labelNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(60, 17);
            this.labelNew.TabIndex = 32;
            this.labelNew.Text = "Новый!";
            // 
            // maskedPassportId
            // 
            this.maskedPassportId.Location = new System.Drawing.Point(199, 10);
            this.maskedPassportId.Margin = new System.Windows.Forms.Padding(4);
            this.maskedPassportId.Mask = "0000-000000";
            this.maskedPassportId.Name = "maskedPassportId";
            this.maskedPassportId.Size = new System.Drawing.Size(90, 22);
            this.maskedPassportId.TabIndex = 17;
            this.maskedPassportId.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(849, 234);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(91, 234);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(136, 146);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 17);
            this.labelAddress.TabIndex = 30;
            this.labelAddress.Text = "Адрес:";
            // 
            // textAddress
            // 
            this.textAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddress.Location = new System.Drawing.Point(199, 142);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(817, 22);
            this.textAddress.TabIndex = 25;
            this.textAddress.TextChanged += new System.EventHandler(this.TextAddress_TextChanged);
            // 
            // maskedBirthYear
            // 
            this.maskedBirthYear.Location = new System.Drawing.Point(199, 110);
            this.maskedBirthYear.Margin = new System.Windows.Forms.Padding(4);
            this.maskedBirthYear.Mask = "0000";
            this.maskedBirthYear.Name = "maskedBirthYear";
            this.maskedBirthYear.Size = new System.Drawing.Size(48, 22);
            this.maskedBirthYear.TabIndex = 23;
            this.maskedBirthYear.TextChanged += new System.EventHandler(this.maskedBirthYear_TextChanged);
            // 
            // labelBirthYear
            // 
            this.labelBirthYear.AutoSize = true;
            this.labelBirthYear.Location = new System.Drawing.Point(83, 114);
            this.labelBirthYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthYear.Name = "labelBirthYear";
            this.labelBirthYear.Size = new System.Drawing.Size(105, 17);
            this.labelBirthYear.TabIndex = 26;
            this.labelBirthYear.Text = "Год рождения:";
            // 
            // labelCardId
            // 
            this.labelCardId.AutoSize = true;
            this.labelCardId.Location = new System.Drawing.Point(92, 14);
            this.labelCardId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCardId.Name = "labelCardId";
            this.labelCardId.Size = new System.Drawing.Size(92, 17);
            this.labelCardId.TabIndex = 24;
            this.labelCardId.Text = "№ паспорта:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 84);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(175, 17);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Фамилия, имя, отчество:";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(199, 80);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(817, 22);
            this.textName.TabIndex = 20;
            this.textName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // panelDeliveredBooks
            // 
            this.panelDeliveredBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeliveredBooks.Controls.Add(this.labelBooks);
            this.panelDeliveredBooks.Controls.Add(this.gridBooks);
            this.panelDeliveredBooks.Location = new System.Drawing.Point(5, 295);
            this.panelDeliveredBooks.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeliveredBooks.Name = "panelDeliveredBooks";
            this.panelDeliveredBooks.Size = new System.Drawing.Size(1045, 299);
            this.panelDeliveredBooks.TabIndex = 18;
            this.panelDeliveredBooks.Visible = false;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(11, 16);
            this.labelBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(154, 17);
            this.labelBooks.TabIndex = 1;
            this.labelBooks.Text = "Выданные сим-карты:";
            // 
            // gridBooks
            // 
            this.gridBooks.AllowUserToAddRows = false;
            this.gridBooks.AllowUserToDeleteRows = false;
            this.gridBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBooks.AutoGenerateColumns = false;
            this.gridBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colAuthors,
            this.colDeliveryDate});
            this.gridBooks.DataSource = this.bsourceBooks;
            this.gridBooks.GridColor = System.Drawing.SystemColors.Control;
            this.gridBooks.Location = new System.Drawing.Point(11, 36);
            this.gridBooks.Margin = new System.Windows.Forms.Padding(4);
            this.gridBooks.MultiSelect = false;
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            this.gridBooks.RowHeadersWidth = 51;
            this.gridBooks.Size = new System.Drawing.Size(1007, 260);
            this.gridBooks.TabIndex = 0;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Number";
            this.colCode.HeaderText = "Номер";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 70;
            // 
            // colAuthors
            // 
            this.colAuthors.DataPropertyName = "Tarif";
            this.colAuthors.HeaderText = "Тариф";
            this.colAuthors.MinimumWidth = 6;
            this.colAuthors.Name = "colAuthors";
            this.colAuthors.ReadOnly = true;
            this.colAuthors.Width = 200;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.DataPropertyName = "DeliveryDate";
            this.colDeliveryDate.HeaderText = "Дата выдачи";
            this.colDeliveryDate.MinimumWidth = 6;
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.ReadOnly = true;
            this.colDeliveryDate.Width = 80;
            // 
            // textPassportInfo
            // 
            this.textPassportInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassportInfo.Location = new System.Drawing.Point(199, 40);
            this.textPassportInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textPassportInfo.Name = "textPassportInfo";
            this.textPassportInfo.Size = new System.Drawing.Size(817, 22);
            this.textPassportInfo.TabIndex = 33;
            this.textPassportInfo.TextChanged += new System.EventHandler(this.textPassportInfo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Дата и место паспорта:";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 609);
            this.Controls.Add(this.panelDeliveredBooks);
            this.Controls.Add(this.panelPersonalData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCustomer";
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomer_FormClosing);
            this.panelPersonalData.ResumeLayout(false);
            this.panelPersonalData.PerformLayout();
            this.panelDeliveredBooks.ResumeLayout(false);
            this.panelDeliveredBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonalData;
        private System.Windows.Forms.DateTimePicker dateRegistration;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.MaskedTextBox maskedPassportId;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.MaskedTextBox maskedBirthYear;
        private System.Windows.Forms.Label labelBirthYear;
        private System.Windows.Forms.Label labelCardId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panelDeliveredBooks;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.BindingSource bsourceBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPassportInfo;
    }
}