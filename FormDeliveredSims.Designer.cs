namespace libman
{
    partial class FormDeliveredSims
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
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolsepData = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolbtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolsepEdit = new System.Windows.Forms.ToolStripSeparator();
            this.gridDelivered = new System.Windows.Forms.DataGridView();
            this.bsourceDelivered = new System.Windows.Forms.BindingSource(this.components);
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnSelect,
            this.toolbtnRefresh,
            this.toolsepData,
            this.toolbtnNewItem,
            this.toolbtnEdit,
            this.toolbtnRemove,
            this.toolsepEdit});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(760, 27);
            this.tools.TabIndex = 1;
            this.tools.Text = "toolStrip1";
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
            // toolbtnNewItem
            // 
            this.toolbtnNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnNewItem.Image = global::libman.Properties.Resources.page;
            this.toolbtnNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnNewItem.Name = "toolbtnNewItem";
            this.toolbtnNewItem.Size = new System.Drawing.Size(29, 24);
            this.toolbtnNewItem.Text = "Новая выдача";
            this.toolbtnNewItem.Click += new System.EventHandler(this.ToolBtnNewItem_Click);
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
            // toolsepEdit
            // 
            this.toolsepEdit.Name = "toolsepEdit";
            this.toolsepEdit.Size = new System.Drawing.Size(6, 27);
            // 
            // gridDelivered
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridDelivered.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDelivered.AutoGenerateColumns = false;
            this.gridDelivered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDelivered.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDelivered.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDelivered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colPassportId,
            this.colDeliveryDate,
            this.colReturnDate});
            this.gridDelivered.DataSource = this.bsourceDelivered;
            this.gridDelivered.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridDelivered.Location = new System.Drawing.Point(0, 95);
            this.gridDelivered.Margin = new System.Windows.Forms.Padding(4);
            this.gridDelivered.Name = "gridDelivered";
            this.gridDelivered.RowHeadersWidth = 51;
            this.gridDelivered.Size = new System.Drawing.Size(760, 444);
            this.gridDelivered.TabIndex = 2;
            this.gridDelivered.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDelivered_CellClick);
            this.gridDelivered.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDelivered_CellContentDoubleClick);
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "Number";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNumber.HeaderText = "Номер телефона";
            this.colNumber.MinimumWidth = 6;
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 137;
            // 
            // colPassportId
            // 
            this.colPassportId.DataPropertyName = "PassportId";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPassportId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPassportId.HeaderText = "№ паспорта";
            this.colPassportId.MinimumWidth = 6;
            this.colPassportId.Name = "colPassportId";
            this.colPassportId.ReadOnly = true;
            this.colPassportId.Width = 108;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.DataPropertyName = "DeliveryDate";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDeliveryDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDeliveryDate.HeaderText = "Дата выдачи";
            this.colDeliveryDate.MinimumWidth = 6;
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.ReadOnly = true;
            this.colDeliveryDate.Width = 114;
            // 
            // colReturnDate
            // 
            this.colReturnDate.DataPropertyName = "ReturnDate";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colReturnDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colReturnDate.HeaderText = "Дата списания";
            this.colReturnDate.MinimumWidth = 6;
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReturnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colReturnDate.Width = 103;
            // 
            // FormDeliveredSims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 554);
            this.Controls.Add(this.gridDelivered);
            this.Controls.Add(this.tools);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDeliveredSims";
            this.Text = "Выданные номера";
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsourceDelivered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton toolbtnSelect;
        private System.Windows.Forms.ToolStripButton toolbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolsepData;
        private System.Windows.Forms.ToolStripButton toolbtnNewItem;
        private System.Windows.Forms.ToolStripButton toolbtnEdit;
        private System.Windows.Forms.ToolStripButton toolbtnRemove;
        private System.Windows.Forms.ToolStripSeparator toolsepEdit;
        private System.Windows.Forms.DataGridView gridDelivered;
        private System.Windows.Forms.BindingSource bsourceDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
    }
}