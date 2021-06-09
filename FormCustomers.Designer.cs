namespace libman
{
    partial class FormCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.toolbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolsepData = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolbtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolbtnResetFilter = new System.Windows.Forms.ToolStripButton();
            this.toolsepSearch = new System.Windows.Forms.ToolStripSeparator();
            this.buttonClose = new System.Windows.Forms.Button();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.colCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.checkExactly = new System.Windows.Forms.CheckBox();
            this.labelSentinel = new System.Windows.Forms.Label();
            this.textSentinel = new System.Windows.Forms.TextBox();
            this.toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceCustomers)).BeginInit();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnSelect,
            this.toolbtnUpdate,
            this.toolsepData,
            this.toolbtnNew,
            this.toolbtnEdit,
            this.toolbtnRemove,
            this.toolStripSeparator1,
            this.toolbtnSearch,
            this.toolbtnResetFilter,
            this.toolsepSearch});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(1067, 27);
            this.toolstrip.TabIndex = 1;
            // 
            // toolbtnSelect
            // 
            this.toolbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnSelect.Image = global::libman.Properties.Resources.Ok;
            this.toolbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSelect.Name = "toolbtnSelect";
            this.toolbtnSelect.Size = new System.Drawing.Size(29, 24);
            this.toolbtnSelect.Text = "Выбрать";
            this.toolbtnSelect.Click += new System.EventHandler(this.ToolBtnSelect_Click);
            // 
            // toolbtnUpdate
            // 
            this.toolbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnUpdate.Image = global::libman.Properties.Resources.Refresh;
            this.toolbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnUpdate.Name = "toolbtnUpdate";
            this.toolbtnUpdate.Size = new System.Drawing.Size(29, 24);
            this.toolbtnUpdate.Text = "Обновить";
            this.toolbtnUpdate.Click += new System.EventHandler(this.ToolBtnUpdate_Click);
            // 
            // toolsepData
            // 
            this.toolsepData.Name = "toolsepData";
            this.toolsepData.Size = new System.Drawing.Size(6, 27);
            // 
            // toolbtnNew
            // 
            this.toolbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnNew.Image = global::libman.Properties.Resources.page;
            this.toolbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnNew.Name = "toolbtnNew";
            this.toolbtnNew.Size = new System.Drawing.Size(29, 24);
            this.toolbtnNew.Text = "Новый клиент";
            this.toolbtnNew.Click += new System.EventHandler(this.ToolBtnNew_Click);
            // 
            // toolbtnEdit
            // 
            this.toolbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnEdit.Image = global::libman.Properties.Resources.page_white_edit;
            this.toolbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnEdit.Name = "toolbtnEdit";
            this.toolbtnEdit.Size = new System.Drawing.Size(29, 24);
            this.toolbtnEdit.Text = "Редактировать";
            this.toolbtnEdit.Click += new System.EventHandler(this.ToolBtnEdit_Click);
            // 
            // toolbtnRemove
            // 
            this.toolbtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnRemove.Image = global::libman.Properties.Resources.page_delete;
            this.toolbtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnRemove.Name = "toolbtnRemove";
            this.toolbtnRemove.Size = new System.Drawing.Size(29, 24);
            this.toolbtnRemove.Text = "Удалить";
            this.toolbtnRemove.Click += new System.EventHandler(this.ToolBtnRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolbtnSearch
            // 
            this.toolbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnSearch.Image = global::libman.Properties.Resources.find;
            this.toolbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSearch.Name = "toolbtnSearch";
            this.toolbtnSearch.Size = new System.Drawing.Size(29, 24);
            this.toolbtnSearch.Text = "Поиск";
            this.toolbtnSearch.Click += new System.EventHandler(this.ToolBtnSearch_Click);
            // 
            // toolbtnResetFilter
            // 
            this.toolbtnResetFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnResetFilter.Image = global::libman.Properties.Resources.cancel;
            this.toolbtnResetFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnResetFilter.Name = "toolbtnResetFilter";
            this.toolbtnResetFilter.Size = new System.Drawing.Size(29, 24);
            this.toolbtnResetFilter.Text = "Сбросить фильтр";
            this.toolbtnResetFilter.Click += new System.EventHandler(this.ToolBtnResetFilter_Click);
            // 
            // toolsepSearch
            // 
            this.toolsepSearch.Name = "toolsepSearch";
            this.toolsepSearch.Size = new System.Drawing.Size(6, 27);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(0, 517);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // gridCustomers
            // 
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.AutoGenerateColumns = false;
            this.gridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCustomers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardId,
            this.PassportInfo,
            this.colName,
            this.colBirthYear,
            this.Address});
            this.gridCustomers.DataSource = this.bsourceCustomers;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCustomers.GridColor = System.Drawing.SystemColors.Info;
            this.gridCustomers.Location = new System.Drawing.Point(0, 137);
            this.gridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.RowHeadersWidth = 51;
            this.gridCustomers.Size = new System.Drawing.Size(1051, 373);
            this.gridCustomers.TabIndex = 0;
            this.gridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCustomers_CellClick);
            this.gridCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCustomers_CellDoubleClick);
            // 
            // colCardId
            // 
            this.colCardId.DataPropertyName = "PassportId";
            this.colCardId.HeaderText = "№ паспорт";
            this.colCardId.MinimumWidth = 6;
            this.colCardId.Name = "colCardId";
            // 
            // PassportInfo
            // 
            this.PassportInfo.DataPropertyName = "PassportInfo";
            this.PassportInfo.HeaderText = "Дата и место выдачи паспорта";
            this.PassportInfo.MinimumWidth = 6;
            this.PassportInfo.Name = "PassportInfo";
            this.PassportInfo.Width = 167;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Фамилия, имя, отчество";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 182;
            // 
            // colBirthYear
            // 
            this.colBirthYear.DataPropertyName = "BirthYear";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colBirthYear.DefaultCellStyle = dataGridViewCellStyle1;
            this.colBirthYear.HeaderText = "Год рождения";
            this.colBirthYear.MinimumWidth = 6;
            this.colBirthYear.Name = "colBirthYear";
            this.colBirthYear.Width = 119;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 77;
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.comboSearch);
            this.groupFilter.Controls.Add(this.checkExactly);
            this.groupFilter.Controls.Add(this.labelSentinel);
            this.groupFilter.Controls.Add(this.textSentinel);
            this.groupFilter.Location = new System.Drawing.Point(0, 69);
            this.groupFilter.Margin = new System.Windows.Forms.Padding(4);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Padding = new System.Windows.Forms.Padding(4);
            this.groupFilter.Size = new System.Drawing.Size(1051, 60);
            this.groupFilter.TabIndex = 8;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Отбор:";
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "<отсутствует>",
            "по Ф.И.О.",
            "по номеру"});
            this.comboSearch.Location = new System.Drawing.Point(7, 23);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(160, 24);
            this.comboSearch.TabIndex = 14;
            // 
            // checkExactly
            // 
            this.checkExactly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkExactly.AutoSize = true;
            this.checkExactly.Location = new System.Drawing.Point(854, 26);
            this.checkExactly.Margin = new System.Windows.Forms.Padding(4);
            this.checkExactly.Name = "checkExactly";
            this.checkExactly.Size = new System.Drawing.Size(159, 21);
            this.checkExactly.TabIndex = 13;
            this.checkExactly.Text = "точное совпадение";
            this.checkExactly.UseVisualStyleBackColor = true;
            // 
            // labelSentinel
            // 
            this.labelSentinel.AutoSize = true;
            this.labelSentinel.Location = new System.Drawing.Point(181, 27);
            this.labelSentinel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSentinel.Name = "labelSentinel";
            this.labelSentinel.Size = new System.Drawing.Size(70, 17);
            this.labelSentinel.TabIndex = 12;
            this.labelSentinel.Text = "Образец:";
            // 
            // textSentinel
            // 
            this.textSentinel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSentinel.Location = new System.Drawing.Point(261, 23);
            this.textSentinel.Margin = new System.Windows.Forms.Padding(4);
            this.textSentinel.Name = "textSentinel";
            this.textSentinel.Size = new System.Drawing.Size(579, 22);
            this.textSentinel.TabIndex = 11;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.gridCustomers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCustomers";
            this.Text = "Клиенты";
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceCustomers)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton toolbtnSelect;
        private System.Windows.Forms.ToolStripButton toolbtnNew;
        private System.Windows.Forms.ToolStripButton toolbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource bsourceCustomers;
        private System.Windows.Forms.ToolStripSeparator toolsepData;
        private System.Windows.Forms.ToolStripButton toolbtnRemove;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.ToolStripButton toolbtnSearch;
        private System.Windows.Forms.ToolStripButton toolbtnResetFilter;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.CheckBox checkExactly;
        private System.Windows.Forms.Label labelSentinel;
        private System.Windows.Forms.TextBox textSentinel;
        private System.Windows.Forms.ToolStripButton toolbtnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolsepSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}