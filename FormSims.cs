using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace libman
{
    public partial class FormSims : Form
    {

        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public FormSims()
            : this(FormPurpose.View)
        { }

        public FormSims(FormPurpose purpose)
        {
            InitializeComponent();

            comboSearch.SelectedIndex = 0;

            Purpose = purpose;
            Filter = from item in Service.Data.Sims select item;
            selecteditem = null;
        }

        #endregion

        #region Свойства(общедоступные)

        /// <summary>
        /// Значение, выбранное в форме.
        /// </summary>
        public Sim SelectedItem
        {
            get => selecteditem;
            private set
            {
                selecteditem = value;
                if (selecteditem != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        /// <summary>
        /// Назначение экземпляра формы.
        /// </summary>
        public FormPurpose Purpose
        {
            get => purpose;
            set
            {
                purpose = value;
                bool selectvisibility = purpose == FormPurpose.Select;
                toolbtnSelect.Visible = selectvisibility;
            }
        }

        #endregion

        #region Свойства (закрытые)

        /// <summary>
        /// Текущий источник отображаемых данных.
        /// </summary>
        private IEnumerable<Sim> Filter
        {
            get => filter;
            set
            {
                filter = value;
                RefreshGrid();
            }
        }

        #endregion

        #region Методы (закрытые)

        /// <summary>
        /// Обновляет данные таблицы на форме
        /// </summary>
        void RefreshGrid()
        {
            bsourceSims.DataSource = filter.ToList();
            gridSims.Update();
        }

        #region Команды

        /// <summary>
        /// Обновляет данные в таблице формы.
        /// </summary>
        void CmdRefresh()
        {
            RefreshGrid();
        }

        /// <summary>
        /// Выбирает книгу из текущей строки как результат.
        /// </summary>
        void CmdSelectItem()
        {
            if (gridSims.CurrentRow != null)
            {
                string number = (string)gridSims.CurrentRow.Cells["colNumber"].Value;
                if (Service.Data.Sims.Lookup(number, out Sim book))
                {
                    SelectedItem = book;
                    return;
                }
            }
            this.Warning("Не выбрана карта!");
        }

        /// <summary>
        /// Закрывает форму
        /// </summary>
        void CmdClose()
        {
            Close();
        }

        /// <summary>
        /// Открывает форму для добавления новой книги.
        /// </summary>
        void CmdNewSim()
        {
            if (Service.Data.Sims.IsFull)
            {
                this.ErrorMessage("Таблица карт заполнена - добавление данных невозможно");
                return;
            }
            Service.Data.Sims.NewItem();
            RefreshGrid();
        }

        /// <summary>
        /// Открывает форму для редактирования симки из текущей строки таблицы.
        /// </summary>
        void CmdEditSim()
        {
            if (gridSims.CurrentRow == null)
                CmdNewSim();
            else
            {
                string number = (string)gridSims.CurrentRow.Cells["colNumber"].Value;
                if (Service.Data.Sims.Lookup(number, out Sim book))
                {
                    book.Edit();
                    RefreshGrid();
                }
                else
                    CmdNewSim();
            }
        }

        /// <summary>
        /// Удаление данных о карте.
        /// </summary>
        void CmdRemoveSim()
        {
            if (gridSims.CurrentRow != null)
            {
                string number = (string)gridSims.CurrentRow.Cells["colNumber"].Value;
                if (Service.Data.Sims.Lookup(number, out Sim book))
                {
                    if (this.Question($"Удалить {number}?"))
                    {
                        foreach (DeliveredSim delivered in Service.Data.DeliveredSims.SimForCustomer(book))
                        {
                            this.ProhibitionMessage("Удалить симку невозможно, так как она работает у пользователя.");
                            return;
                        }
                        Service.Data.Sims.Remove(number);
                        RefreshGrid();
                    }
                }
            }
        }

        /// <summary>
        /// Удаляет все книги.
        /// </summary>
        void CmdClearSims()
        {
            if (this.Question("Вы действительно хотите удалить данные о симкартах?", false))
            {
                Service.Data.Sims.Clear();
                RefreshGrid();
            }
        }

        /// <summary>
        /// Устанавливает фильтр по тарифам.
        /// </summary>
        void CmdSearchByTarif()
        {
            if (checkExactly.Checked)
            {
                Filter =
                    from item in Service.Data.Sims
                    where item.Tarif == textSentinel.Text
                    select item;
            }
            else
            {
                AnotherSearch kmp = new AnotherSearch(textSentinel.Text);
                Filter =
                    from item in Service.Data.Sims
                    where kmp.FindFirstIn(item.Tarif) >= 0
                    select item;
            }
        }

        /// <summary>
        /// Устанавливает фильтр по номеру.
        /// </summary>
        void CmdSearchByNumber()
        {
            if (checkExactly.Checked)
            {
                Filter =
                    from item in Service.Data.Sims
                    where item.Number == textSentinel.Text
                    select item;
            }
            else
            {
                AnotherSearch kmp = new AnotherSearch(textSentinel.Text);
                Filter =
                    from item in Service.Data.Sims
                    where kmp.FindFirstIn(item.Number) >= 0
                    select item;
            }
        }
        /// <summary>
        /// Сбрасывает ранее установленный фильтр.
        /// </summary>
        void CmdResetFilter()
        {
            comboSearch.SelectedIndex = 0;
            textSentinel.Text = string.Empty;
            checkExactly.Checked = false;
            Filter = from item in Service.Data.Sims select item;
        }

        #endregion

        #region Обработчики событий

        #region Кнопки командной панели

        private void ToolBtnSelect_Click(object sender, EventArgs e)
        {
            CmdSelectItem();
        }

        private void ToolBtnRefresh_Click(object sender, EventArgs e)
        {
            CmdRefresh();
        }

        private void toolbtnNewBook_Click(object sender, EventArgs e)
        {
            CmdNewSim();
        }

        private void ToolBtnEditBook_Click(object sender, EventArgs e)
        {
            CmdEditSim();
        }

        private void ToolBtnRemoveBook_Click(object sender, EventArgs e)
        {
            CmdRemoveSim();
        }

        private void ToolBtnSearch_Click(object sender, EventArgs e)
        {
            switch (comboSearch.SelectedIndex)
            {
                case 0:
                    CmdResetFilter();
                    break;
                case 1:
                    CmdSearchByTarif();
                    break;
                case 2:
                    CmdSearchByNumber();
                    break;
                default:
                    break;
            }
        }

        private void ToolBtnResetFilter_Click(object sender, EventArgs e)
        {
            CmdResetFilter();
        }

        #endregion

        #region Обработчики событий элементов формы

        #region gridBooks

        private void GridBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            gridSims.CurrentCell = gridSims.Rows[e.RowIndex].Cells[e.ColumnIndex];
            switch (Purpose)
            {
                case FormPurpose.View:
                    CmdEditSim();
                    break;
                case FormPurpose.Select:
                    CmdSelectItem();
                    break;
                default:
                    break;
            }
        }

        private void GridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #endregion

        #endregion

        #endregion

        #region Поля

        FormPurpose purpose;

        IEnumerable<Sim> filter;

        Sim selecteditem;

        #endregion
    }
}
