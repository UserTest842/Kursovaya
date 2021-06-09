namespace libman
{
    partial class FormSims
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridSims = new System.Windows.Forms.DataGridView();
            this.bsourceSims = new System.Windows.Forms.BindingSource(this.components);
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.toolbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolsepData = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnNewBook = new System.Windows.Forms.ToolStripButton();
            this.toolbtnEditBook = new System.Windows.Forms.ToolStripButton();
            this.toolbtnRemoveBook = new System.Windows.Forms.ToolStripButton();
            this.toolsetEdit = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolbtnResetFilter = new System.Windows.Forms.ToolStripButton();
            this.toolsepSearch = new System.Windows.Forms.ToolStripSeparator();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.checkExactly = new System.Windows.Forms.CheckBox();
            this.labelSentinel = new System.Windows.Forms.Label();
            this.textSentinel = new System.Windows.Forms.TextBox();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceSims)).BeginInit();
            this.toolstrip.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSims
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridSims.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSims.AutoGenerateColumns = false;
            this.gridSims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSims.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSims.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridSims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colTarif,
            this.colYear,
            this.colExist});
            this.gridSims.DataSource = this.bsourceSims;
            this.gridSims.Location = new System.Drawing.Point(11, 117);
            this.gridSims.Margin = new System.Windows.Forms.Padding(4);
            this.gridSims.Name = "gridSims";
            this.gridSims.RowHeadersWidth = 51;
            this.gridSims.Size = new System.Drawing.Size(1157, 402);
            this.gridSims.TabIndex = 0;
            this.gridSims.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBooks_CellClick);
            this.gridSims.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBooks_CellDoubleClick);
            // 
            // toolstrip
            // 
            this.toolstrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnSelect,
            this.toolbtnRefresh,
            this.toolsepData,
            this.toolbtnNewBook,
            this.toolbtnEditBook,
            this.toolbtnRemoveBook,
            this.toolsetEdit,
            this.toolbtnSearch,
            this.toolbtnResetFilter,
            this.toolsepSearch});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(1181, 27);
            this.toolstrip.TabIndex = 1;
            this.toolstrip.Text = "toolstrip";
            // 
            // toolbtnSelect
            // 
            this.toolbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnSelect.Image = global::libman.Properties.Resources.Ok;
            this.toolbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSelect.Name = "toolbtnSelect";
            this.toolbtnSelect.Size = new System.Drawing.Size(29, 24);
            this.toolbtnSelect.Text = "toolbtnSelect";
            this.toolbtnSelect.Click += new System.EventHandler(this.ToolBtnSelect_Click);
            // 
            // toolbtnRefresh
            // 
            this.toolbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnRefresh.Image = global::libman.Properties.Resources.Refresh;
            this.toolbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnRefresh.Name = "toolbtnRefresh";
            this.toolbtnRefresh.Size = new System.Drawing.Size(29, 24);
            this.toolbtnRefresh.Text = "Обновить";
            this.toolbtnRefresh.Click += new System.EventHandler(this.ToolBtnRefresh_Click);
            // 
            // toolsepData
            // 
            this.toolsepData.Name = "toolsepData";
            this.toolsepData.Size = new System.Drawing.Size(6, 27);
            // 
            // toolbtnNewBook
            // 
            this.toolbtnNewBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnNewBook.Image = global::libman.Properties.Resources.page;
            this.toolbtnNewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnNewBook.Name = "toolbtnNewBook";
            this.toolbtnNewBook.Size = new System.Drawing.Size(29, 24);
            this.toolbtnNewBook.Text = "Новая сим-карта";
            this.toolbtnNewBook.Click += new System.EventHandler(this.toolbtnNewBook_Click);
            // 
            // toolbtnEditBook
            // 
            this.toolbtnEditBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnEditBook.Image = global::libman.Properties.Resources.page_white_edit;
            this.toolbtnEditBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnEditBook.Name = "toolbtnEditBook";
            this.toolbtnEditBook.Size = new System.Drawing.Size(29, 24);
            this.toolbtnEditBook.Text = "Редактировать данные  сим-карты";
            this.toolbtnEditBook.Click += new System.EventHandler(this.ToolBtnEditBook_Click);
            // 
            // toolbtnRemoveBook
            // 
            this.toolbtnRemoveBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnRemoveBook.Image = global::libman.Properties.Resources.page_delete;
            this.toolbtnRemoveBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnRemoveBook.Name = "toolbtnRemoveBook";
            this.toolbtnRemoveBook.Size = new System.Drawing.Size(29, 24);
            this.toolbtnRemoveBook.Text = "Удалить сим-карту";
            this.toolbtnRemoveBook.Click += new System.EventHandler(this.ToolBtnRemoveBook_Click);
            // 
            // toolsetEdit
            // 
            this.toolsetEdit.Name = "toolsetEdit";
            this.toolsetEdit.Size = new System.Drawing.Size(6, 27);
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
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.comboSearch);
            this.groupFilter.Controls.Add(this.checkExactly);
            this.groupFilter.Controls.Add(this.labelSentinel);
            this.groupFilter.Controls.Add(this.textSentinel);
            this.groupFilter.Location = new System.Drawing.Point(16, 64);
            this.groupFilter.Margin = new System.Windows.Forms.Padding(4);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Padding = new System.Windows.Forms.Padding(4);
            this.groupFilter.Size = new System.Drawing.Size(1157, 57);
            this.groupFilter.TabIndex = 14;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Отбор:";
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "<отсутствует>",
            "по тарифу",
            "по номеру"});
            this.comboSearch.Location = new System.Drawing.Point(8, 23);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(160, 24);
            this.comboSearch.TabIndex = 19;
            // 
            // checkExactly
            // 
            this.checkExactly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkExactly.AutoSize = true;
            this.checkExactly.Location = new System.Drawing.Point(968, 26);
            this.checkExactly.Margin = new System.Windows.Forms.Padding(4);
            this.checkExactly.Name = "checkExactly";
            this.checkExactly.Size = new System.Drawing.Size(159, 21);
            this.checkExactly.TabIndex = 18;
            this.checkExactly.Text = "точное совпадение";
            this.checkExactly.UseVisualStyleBackColor = true;
            // 
            // labelSentinel
            // 
            this.labelSentinel.AutoSize = true;
            this.labelSentinel.Location = new System.Drawing.Point(209, 27);
            this.labelSentinel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSentinel.Name = "labelSentinel";
            this.labelSentinel.Size = new System.Drawing.Size(70, 17);
            this.labelSentinel.TabIndex = 17;
            this.labelSentinel.Text = "Образец:";
            // 
            // textSentinel
            // 
            this.textSentinel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSentinel.Location = new System.Drawing.Point(289, 23);
            this.textSentinel.Margin = new System.Windows.Forms.Padding(4);
            this.textSentinel.Name = "textSentinel";
            this.textSentinel.Size = new System.Drawing.Size(664, 22);
            this.textSentinel.TabIndex = 16;
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "Number";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNumber.HeaderText = "Номер";
            this.colNumber.MinimumWidth = 6;
            this.colNumber.Name = "colNumber";
            this.colNumber.Width = 80;
            // 
            // colTarif
            // 
            this.colTarif.DataPropertyName = "Tarif";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTarif.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTarif.HeaderText = "Тариф";
            this.colTarif.MinimumWidth = 6;
            this.colTarif.Name = "colTarif";
            this.colTarif.Width = 81;
            // 
            // colYear
            // 
            this.colYear.DataPropertyName = "Year";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colYear.DefaultCellStyle = dataGridViewCellStyle4;
            this.colYear.HeaderText = "Год издания";
            this.colYear.MinimumWidth = 6;
            this.colYear.Name = "colYear";
            this.colYear.Width = 120;
            // 
            // colExist
            // 
            this.colExist.DataPropertyName = "Exist";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colExist.DefaultCellStyle = dataGridViewCellStyle5;
            this.colExist.HeaderText = "В наличии";
            this.colExist.MinimumWidth = 6;
            this.colExist.Name = "colExist";
            this.colExist.Width = 106;
            // 
            // FormSims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1181, 532);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.gridSims);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSims";
            this.Text = "Сим-карты";
            ((System.ComponentModel.ISupportInitialize)(this.gridSims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceSims)).EndInit();
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSims;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton toolbtnSelect;
        private System.Windows.Forms.ToolStripSeparator toolsepData;
        private System.Windows.Forms.ToolStripButton toolbtnNewBook;
        private System.Windows.Forms.ToolStripButton toolbtnEditBook;
        private System.Windows.Forms.ToolStripButton toolbtnRemoveBook;
        private System.Windows.Forms.BindingSource bsourceSims;
        private System.Windows.Forms.ToolStripSeparator toolsetEdit;
        private System.Windows.Forms.ToolStripButton toolbtnSearch;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.CheckBox checkExactly;
        private System.Windows.Forms.Label labelSentinel;
        private System.Windows.Forms.TextBox textSentinel;
        private System.Windows.Forms.ToolStripButton toolbtnResetFilter;
        private System.Windows.Forms.ToolStripSeparator toolsepSearch;
        private System.Windows.Forms.ToolStripButton toolbtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExist;
    }
}