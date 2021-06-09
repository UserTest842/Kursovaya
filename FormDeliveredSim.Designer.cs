namespace libman
{
    partial class FormDeliveredSim
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
            this.labelBookCode = new System.Windows.Forms.Label();
            this.labelCustomerCardId = new System.Windows.Forms.Label();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.maskedBookNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedCustomerPassportId = new System.Windows.Forms.MaskedTextBox();
            this.buttonSelectBook = new System.Windows.Forms.Button();
            this.buttonSelectCustomer = new System.Windows.Forms.Button();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBookCode
            // 
            this.labelBookCode.AutoSize = true;
            this.labelBookCode.Location = new System.Drawing.Point(64, 18);
            this.labelBookCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookCode.Name = "labelBookCode";
            this.labelBookCode.Size = new System.Drawing.Size(125, 17);
            this.labelBookCode.TabIndex = 0;
            this.labelBookCode.Text = "Номер телефона:";
            // 
            // labelCustomerCardId
            // 
            this.labelCustomerCardId.AutoSize = true;
            this.labelCustomerCardId.Location = new System.Drawing.Point(41, 81);
            this.labelCustomerCardId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerCardId.Name = "labelCustomerCardId";
            this.labelCustomerCardId.Size = new System.Drawing.Size(150, 17);
            this.labelCustomerCardId.TabIndex = 4;
            this.labelCustomerCardId.Text = "№ паспорта клиента:";
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Location = new System.Drawing.Point(92, 156);
            this.labelDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(99, 17);
            this.labelDeliveryDate.TabIndex = 5;
            this.labelDeliveryDate.Text = "Дата выдачи:";
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(79, 228);
            this.labelReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(112, 17);
            this.labelReturnDate.TabIndex = 6;
            this.labelReturnDate.Text = "Дата списания:";
            // 
            // maskedBookNumber
            // 
            this.maskedBookNumber.Location = new System.Drawing.Point(201, 15);
            this.maskedBookNumber.Margin = new System.Windows.Forms.Padding(4);
            this.maskedBookNumber.Mask = "000\\-0000000";
            this.maskedBookNumber.Name = "maskedBookNumber";
            this.maskedBookNumber.Size = new System.Drawing.Size(81, 22);
            this.maskedBookNumber.TabIndex = 1;
            this.maskedBookNumber.TextChanged += new System.EventHandler(this.MaskedBookCode_TextChanged);
            this.maskedBookNumber.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedBookCode_Validating);
            this.maskedBookNumber.Validated += new System.EventHandler(this.MaskedBookCode_Validated);
            // 
            // maskedCustomerPassportId
            // 
            this.maskedCustomerPassportId.Location = new System.Drawing.Point(203, 78);
            this.maskedCustomerPassportId.Margin = new System.Windows.Forms.Padding(4);
            this.maskedCustomerPassportId.Mask = "0000-000000";
            this.maskedCustomerPassportId.Name = "maskedCustomerPassportId";
            this.maskedCustomerPassportId.Size = new System.Drawing.Size(81, 22);
            this.maskedCustomerPassportId.TabIndex = 5;
            this.maskedCustomerPassportId.TextChanged += new System.EventHandler(this.MaskedCustomerCardId_TextChanged);
            this.maskedCustomerPassportId.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedCustomerCardId_Validating);
            // 
            // buttonSelectBook
            // 
            this.buttonSelectBook.Location = new System.Drawing.Point(283, 12);
            this.buttonSelectBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectBook.Name = "buttonSelectBook";
            this.buttonSelectBook.Size = new System.Drawing.Size(37, 28);
            this.buttonSelectBook.TabIndex = 2;
            this.buttonSelectBook.Text = "...";
            this.buttonSelectBook.UseVisualStyleBackColor = true;
            this.buttonSelectBook.Click += new System.EventHandler(this.ButtonSelectBook_Click);
            // 
            // buttonSelectCustomer
            // 
            this.buttonSelectCustomer.Location = new System.Drawing.Point(283, 75);
            this.buttonSelectCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectCustomer.Name = "buttonSelectCustomer";
            this.buttonSelectCustomer.Size = new System.Drawing.Size(37, 28);
            this.buttonSelectCustomer.TabIndex = 6;
            this.buttonSelectCustomer.Text = "...";
            this.buttonSelectCustomer.UseVisualStyleBackColor = true;
            this.buttonSelectCustomer.Click += new System.EventHandler(this.ButtonSelectCustomer_Click);
            // 
            // dateDelivery
            // 
            this.dateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivery.Location = new System.Drawing.Point(201, 153);
            this.dateDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(116, 22);
            this.dateDelivery.TabIndex = 12;
            // 
            // dateReturn
            // 
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReturn.Location = new System.Drawing.Point(201, 224);
            this.dateReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(116, 22);
            this.dateReturn.TabIndex = 13;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(93, 282);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(201, 282);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(199, 50);
            this.labelBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(0, 17);
            this.labelBook.TabIndex = 3;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(199, 116);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(0, 17);
            this.labelCustomer.TabIndex = 7;
            // 
            // FormDeliveredSim
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1036, 351);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.dateDelivery);
            this.Controls.Add(this.buttonSelectCustomer);
            this.Controls.Add(this.buttonSelectBook);
            this.Controls.Add(this.maskedCustomerPassportId);
            this.Controls.Add(this.maskedBookNumber);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.labelDeliveryDate);
            this.Controls.Add(this.labelCustomerCardId);
            this.Controls.Add(this.labelBookCode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDeliveredSim";
            this.Text = "Выданная симка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeliveredBook_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookCode;
        private System.Windows.Forms.Label labelCustomerCardId;
        private System.Windows.Forms.Label labelDeliveryDate;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.MaskedTextBox maskedBookNumber;
        private System.Windows.Forms.MaskedTextBox maskedCustomerPassportId;
        private System.Windows.Forms.Button buttonSelectBook;
        private System.Windows.Forms.Button buttonSelectCustomer;
        private System.Windows.Forms.DateTimePicker dateDelivery;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelCustomer;
    }
}