namespace libman
{
    partial class FormSim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNew = new System.Windows.Forms.Label();
            this.maskedYear = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.textTarif = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.maskedNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.panelDeliveredBooks = new System.Windows.Forms.Panel();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.colCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxExist = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panelDeliveredBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxExist);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNew);
            this.panel1.Controls.Add(this.maskedYear);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.textTarif);
            this.panel1.Controls.Add(this.labelPublisher);
            this.panel1.Controls.Add(this.maskedNumber);
            this.panel1.Controls.Add(this.labelCode);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 297);
            this.panel1.TabIndex = 16;
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNew.ForeColor = System.Drawing.Color.Red;
            this.labelNew.Location = new System.Drawing.Point(319, 10);
            this.labelNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(60, 17);
            this.labelNew.TabIndex = 1;
            this.labelNew.Text = "Новый!";
            // 
            // maskedYear
            // 
            this.maskedYear.Location = new System.Drawing.Point(140, 91);
            this.maskedYear.Margin = new System.Windows.Forms.Padding(4);
            this.maskedYear.Mask = "0000";
            this.maskedYear.Name = "maskedYear";
            this.maskedYear.Size = new System.Drawing.Size(53, 22);
            this.maskedYear.TabIndex = 5;
            this.maskedYear.TextChanged += new System.EventHandler(this.MaskedYear_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(727, 247);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(222, 247);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(37, 91);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(95, 17);
            this.labelYear.TabIndex = 24;
            this.labelYear.Text = "Год издания:";
            // 
            // textTarif
            // 
            this.textTarif.Location = new System.Drawing.Point(140, 50);
            this.textTarif.Margin = new System.Windows.Forms.Padding(4);
            this.textTarif.Name = "textTarif";
            this.textTarif.Size = new System.Drawing.Size(132, 22);
            this.textTarif.TabIndex = 4;
            this.textTarif.TextChanged += new System.EventHandler(this.TextPublisher_TextChanged);
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(76, 53);
            this.labelPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(56, 17);
            this.labelPublisher.TabIndex = 21;
            this.labelPublisher.Text = "Тариф:";
            // 
            // maskedNumber
            // 
            this.maskedNumber.Location = new System.Drawing.Point(140, 10);
            this.maskedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.maskedNumber.Mask = "000\\-0000000";
            this.maskedNumber.Name = "maskedNumber";
            this.maskedNumber.Size = new System.Drawing.Size(88, 22);
            this.maskedNumber.TabIndex = 0;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(7, 13);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(125, 17);
            this.labelCode.TabIndex = 16;
            this.labelCode.Text = "Номер телефона:";
            // 
            // panelDeliveredBooks
            // 
            this.panelDeliveredBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeliveredBooks.Controls.Add(this.labelCustomers);
            this.panelDeliveredBooks.Controls.Add(this.gridCustomers);
            this.panelDeliveredBooks.Location = new System.Drawing.Point(16, 319);
            this.panelDeliveredBooks.Margin = new System.Windows.Forms.Padding(4);
            this.panelDeliveredBooks.Name = "panelDeliveredBooks";
            this.panelDeliveredBooks.Size = new System.Drawing.Size(1035, 279);
            this.panelDeliveredBooks.TabIndex = 19;
            this.panelDeliveredBooks.Visible = false;
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Location = new System.Drawing.Point(11, 16);
            this.labelCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(134, 17);
            this.labelCustomers.TabIndex = 1;
            this.labelCustomers.Text = "Сим-карта выдана:";
            // 
            // gridCustomers
            // 
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.AutoGenerateColumns = false;
            this.gridCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardId,
            this.colName,
            this.colDeliveryDate});
            this.gridCustomers.DataSource = this.bsourceCustomers;
            this.gridCustomers.GridColor = System.Drawing.SystemColors.Control;
            this.gridCustomers.Location = new System.Drawing.Point(15, 36);
            this.gridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.gridCustomers.MultiSelect = false;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.RowHeadersWidth = 51;
            this.gridCustomers.Size = new System.Drawing.Size(996, 240);
            this.gridCustomers.TabIndex = 0;
            // 
            // colCardId
            // 
            this.colCardId.DataPropertyName = "CustomerPassportId";
            this.colCardId.HeaderText = "№ паспорта";
            this.colCardId.MinimumWidth = 6;
            this.colCardId.Name = "colCardId";
            this.colCardId.ReadOnly = true;
            this.colCardId.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Фамилия, имя, отчество";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 400;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Наличие:";
            // 
            // checkBoxExist
            // 
            this.checkBoxExist.AutoSize = true;
            this.checkBoxExist.Location = new System.Drawing.Point(139, 131);
            this.checkBoxExist.Name = "checkBoxExist";
            this.checkBoxExist.Size = new System.Drawing.Size(18, 17);
            this.checkBoxExist.TabIndex = 26;
            this.checkBoxExist.UseVisualStyleBackColor = true;
            this.checkBoxExist.CheckedChanged += new System.EventHandler(this.checkBoxExist_CheckedChanged);
            // 
            // FormSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 613);
            this.Controls.Add(this.panelDeliveredBooks);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSim";
            this.Text = "Сим-карта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBook_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDeliveredBooks.ResumeLayout(false);
            this.panelDeliveredBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedYear;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textTarif;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.MaskedTextBox maskedNumber;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Panel panelDeliveredBooks;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.BindingSource bsourceCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryDate;
        private System.Windows.Forms.CheckBox checkBoxExist;
        private System.Windows.Forms.Label label1;
    }
}