namespace libman
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuitemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemSaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemSaveDataAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemCatalogs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemCustomersNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBooksNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeliveredBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDeliveredBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemNewDeliveredBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemFile,
            this.menuitemCatalogs,
            this.menuDeliveredBooks,
            this.menuitemHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1111, 30);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuitemFile
            // 
            this.menuitemFile.AutoSize = false;
            this.menuitemFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuitemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.menuitemSaveData,
            this.menuitemSaveDataAs,
            this.menuitemClearData,
            this.toolStripSeparator1,
            this.menuitemFileExit});
            this.menuitemFile.Image = global::libman.Properties.Resources.page;
            this.menuitemFile.Name = "menuitemFile";
            this.menuitemFile.Size = new System.Drawing.Size(200, 26);
            this.menuitemFile.Text = "Файл";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            this.загрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеToolStripMenuItem_Click);
            // 
            // menuitemSaveData
            // 
            this.menuitemSaveData.Name = "menuitemSaveData";
            this.menuitemSaveData.Size = new System.Drawing.Size(258, 26);
            this.menuitemSaveData.Text = "Сохранить данные";
            this.menuitemSaveData.Click += new System.EventHandler(this.MenuItemSaveData_Click);
            // 
            // menuitemSaveDataAs
            // 
            this.menuitemSaveDataAs.Name = "menuitemSaveDataAs";
            this.menuitemSaveDataAs.Size = new System.Drawing.Size(258, 26);
            this.menuitemSaveDataAs.Text = "Сохранить данные как...";
            this.menuitemSaveDataAs.Click += new System.EventHandler(this.MenuItemSaveDataAs_Click);
            // 
            // menuitemClearData
            // 
            this.menuitemClearData.Name = "menuitemClearData";
            this.menuitemClearData.Size = new System.Drawing.Size(258, 26);
            this.menuitemClearData.Text = "Очистить данные";
            this.menuitemClearData.Click += new System.EventHandler(this.MenuItemClearData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // menuitemFileExit
            // 
            this.menuitemFileExit.Name = "menuitemFileExit";
            this.menuitemFileExit.Size = new System.Drawing.Size(258, 26);
            this.menuitemFileExit.Text = "Выход";
            this.menuitemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // menuitemCatalogs
            // 
            this.menuitemCatalogs.AutoSize = false;
            this.menuitemCatalogs.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuitemCatalogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemCustomers,
            this.menuitemCustomersNew,
            this.toolStripSeparator2,
            this.menuitemBooks,
            this.menuItemBooksNew});
            this.menuitemCatalogs.Image = global::libman.Properties.Resources.find;
            this.menuitemCatalogs.Name = "menuitemCatalogs";
            this.menuitemCatalogs.Size = new System.Drawing.Size(200, 26);
            this.menuitemCatalogs.Text = "Справочная";
            // 
            // menuitemCustomers
            // 
            this.menuitemCustomers.Name = "menuitemCustomers";
            this.menuitemCustomers.Size = new System.Drawing.Size(278, 26);
            this.menuitemCustomers.Text = "Клиенты";
            this.menuitemCustomers.Click += new System.EventHandler(this.MenuItemCustomers_Click);
            // 
            // menuitemCustomersNew
            // 
            this.menuitemCustomersNew.Name = "menuitemCustomersNew";
            this.menuitemCustomersNew.Size = new System.Drawing.Size(278, 26);
            this.menuitemCustomersNew.Text = "Зарегистрировать клиента";
            this.menuitemCustomersNew.Click += new System.EventHandler(this.MenuItemCustomersNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // menuitemBooks
            // 
            this.menuitemBooks.Name = "menuitemBooks";
            this.menuitemBooks.Size = new System.Drawing.Size(278, 26);
            this.menuitemBooks.Text = "Сим-карты";
            this.menuitemBooks.Click += new System.EventHandler(this.MenuItemBooks_Click);
            // 
            // menuItemBooksNew
            // 
            this.menuItemBooksNew.Name = "menuItemBooksNew";
            this.menuItemBooksNew.Size = new System.Drawing.Size(278, 26);
            this.menuItemBooksNew.Text = "Новая сим-карта";
            this.menuItemBooksNew.Click += new System.EventHandler(this.MenuItemBooksNew_Click);
            // 
            // menuDeliveredBooks
            // 
            this.menuDeliveredBooks.AutoSize = false;
            this.menuDeliveredBooks.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuDeliveredBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDeliveredBooks,
            this.menuitemNewDeliveredBook});
            this.menuDeliveredBooks.Image = global::libman.Properties.Resources.update;
            this.menuDeliveredBooks.Name = "menuDeliveredBooks";
            this.menuDeliveredBooks.Size = new System.Drawing.Size(200, 26);
            this.menuDeliveredBooks.Text = "Выданные сим-карты";
            // 
            // menuitemDeliveredBooks
            // 
            this.menuitemDeliveredBooks.Name = "menuitemDeliveredBooks";
            this.menuitemDeliveredBooks.Size = new System.Drawing.Size(251, 26);
            this.menuitemDeliveredBooks.Text = "Список выданных карт";
            this.menuitemDeliveredBooks.Click += new System.EventHandler(this.MenuItemDeliveredBooks_Click);
            // 
            // menuitemNewDeliveredBook
            // 
            this.menuitemNewDeliveredBook.Name = "menuitemNewDeliveredBook";
            this.menuitemNewDeliveredBook.Size = new System.Drawing.Size(251, 26);
            this.menuitemNewDeliveredBook.Text = "Выдача сим-карты";
            this.menuitemNewDeliveredBook.Click += new System.EventHandler(this.MenuItemNewDeliveredBook_Click);
            // 
            // menuitemHelp
            // 
            this.menuitemHelp.AutoSize = false;
            this.menuitemHelp.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuitemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelpAbout});
            this.menuitemHelp.Image = global::libman.Properties.Resources._003834;
            this.menuitemHelp.Name = "menuitemHelp";
            this.menuitemHelp.Size = new System.Drawing.Size(200, 26);
            this.menuitemHelp.Text = "Справка";
            // 
            // menuItemHelpAbout
            // 
            this.menuItemHelpAbout.Name = "menuItemHelpAbout";
            this.menuItemHelpAbout.Size = new System.Drawing.Size(224, 26);
            this.menuItemHelpAbout.Text = "О программе...";
            this.menuItemHelpAbout.Click += new System.EventHandler(this.MenuItemHelpAbout_Click);
            // 
            // menuitemLoadData
            // 
            this.menuitemLoadData.Name = "menuitemLoadData";
            this.menuitemLoadData.Size = new System.Drawing.Size(32, 19);
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tools.Location = new System.Drawing.Point(0, 30);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1111, 25);
            this.tools.TabIndex = 4;
            this.tools.Text = "tools";
            // 
            // openDialog
            // 
            this.openDialog.DefaultExt = "xml";
            this.openDialog.FileName = "openDialog";
            this.openDialog.Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*";
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "xml";
            this.saveDialog.Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 554);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Салон связи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuitemFile;
        private System.Windows.Forms.ToolStripMenuItem menuitemCatalogs;
        private System.Windows.Forms.ToolStripMenuItem menuitemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuitemCustomersNew;
        private System.Windows.Forms.ToolStripMenuItem menuitemCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuitemLoadData;
        private System.Windows.Forms.ToolStripMenuItem menuitemSaveData;
        private System.Windows.Forms.ToolStripMenuItem menuitemSaveDataAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuitemBooks;
        private System.Windows.Forms.ToolStripMenuItem menuItemBooksNew;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripMenuItem menuitemClearData;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolStripMenuItem menuDeliveredBooks;
        private System.Windows.Forms.ToolStripMenuItem menuitemDeliveredBooks;
        private System.Windows.Forms.ToolStripMenuItem menuitemNewDeliveredBook;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
    }
}

