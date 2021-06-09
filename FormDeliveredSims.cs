using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libman
{
    public partial class FormDeliveredSims : Form, IListForm<DeliveredSim, string>
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.<br />
        /// Создаёт форму в режиме просмотра.
        /// </summary>
        public FormDeliveredSims()
            : this(FormPurpose.View)
        { }

        /// <summary>
        /// Создаёт новую форму для указанного назначения (просмотра либо выбора).
        /// </summary>
        /// <param name="purpose">Назначение формы.</param>
        public FormDeliveredSims(FormPurpose purpose)
        {
            InitializeComponent();

            bsourceDelivered.DataSource = Filter.ToList();
            gridDelivered.Update();
            Purpose = purpose;
        }

        #endregion

        #region Свойства (общедоступные)

        #region Реализация IListForm<DeliveredBook, string>

        /// <summary>
        /// Назначение формы.
        /// </summary>
        public FormPurpose Purpose
        {
            get => purpose;
            set
            {
                purpose = value;
                toolbtnSelect.Visible = purpose == FormPurpose.Select;
            }
        }

        /// <summary>
        /// Выбранный элемент (выдача сим).<br />
        /// При установке закрывает форму.
        /// </summary>
        public DeliveredSim SelectedItem
        {
            get => selecteditem;
            set
            {
                selecteditem = value;
                Close();
            }
        }

        

        #endregion

        #endregion

        #region Свойства (закрытые)

        private string CurrentKey
        {
            get
            {
                if (gridDelivered.CurrentRow == null)
                    return null;
                else if (gridDelivered.CurrentRow.Index < 0)
                    return null;
                else
                {
                    string number = (string)gridDelivered.CurrentRow.Cells["colNumber"].Value;
                    string passportid = (string)gridDelivered.CurrentRow.Cells["colPassportId"].Value;
                    return DeliveredSim.CreateKey(number, passportid);
                }
            }
        }

        private DeliveredSim CurrentItem
        {
            get
            {
                if (Service.Data.DeliveredSims.Lookup(CurrentKey, out DeliveredSim delivered))
                    return delivered;
                else
                    return null;
            }
        }

        private IEnumerable<DeliveredSim> Filter
        {
            get
            {
                return
                    from delivered in Service.Data.DeliveredSims
                    select delivered;
            }
        }

        #endregion

        #region Методы (закрытые)

        #region Вспомогательные методы

        void RefreshGrid()
        {
            bsourceDelivered.DataSource = Sorting<DeliveredSim, string>.Count_search(Filter, item => item.Number).ToList();
            gridDelivered.Update();            
        }

        #endregion

        #region Команды

        void CmdSelectItem()
        {
            if (CurrentKey == null)
            {
                this.Warning("Не выбрана выдача sim!");
                return;
            }
            SelectedItem = CurrentItem;
        }

        void CmdClose()
        {
            Close();
        }

        void CmdRefresh()
        {
            RefreshGrid();
        }

        void CmdNewItem()
        {
            Service.Data.DeliveredSims.NewItem();
            RefreshGrid();
        }

        void CmdEdit()
        {
            if (CurrentKey == null)
            {
                this.Warning("Не выбрана выдача sim!");
                return;
            }
            CurrentItem.Edit();
            RefreshGrid();
        }

        void CmdRemove()
        {
            if (CurrentKey == null)
            {
                this.Warning("Не выбрана выдача sim!");
                return;
            }
            Service.Data.DeliveredSims.Remove(CurrentKey);
            RefreshGrid();
        }

        void CmdClear()
        {
            if (this.Question("Вы уверены, что хотите удалить все данные о выдаче sim?", false))
            {
                Service.Data.DeliveredSims.Clear();
                RefreshGrid();
            }
        }

        #endregion

        #region Обработчики событий

        #region Командная панель

        private void ToolBtnSelect_Click(object sender, EventArgs e)
        {
            CmdSelectItem();
        }

        private void ToolBtnRefresh_Click(object sender, EventArgs e)
        {
            CmdRefresh();
        }

        private void ToolBtnNewItem_Click(object sender, EventArgs e)
        {
            CmdNewItem();
        }

        private void ToolBtnEdit_Click(object sender, EventArgs e)
        {
            CmdEdit();
        }

        private void ToolBtnRemove_Click(object sender, EventArgs e)
        {
            CmdRemove();
        }

        #endregion

        #region Обработчики событий элементов формы

        private void СheckActive_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        #endregion

        #endregion

        #endregion

        #region Поля

        FormPurpose purpose;

        DeliveredSim selecteditem;
        #endregion

        private void GridDelivered_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            gridDelivered.CurrentCell = gridDelivered.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void GridDelivered_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            gridDelivered.CurrentCell = gridDelivered.Rows[e.RowIndex].Cells[e.ColumnIndex];
            switch (Purpose)
            {
                case FormPurpose.View:
                    CmdEdit();
                    break;
                case FormPurpose.Select:
                    CmdSelectItem();
                    break;
                default:
                    break;
            }
        }
    }
}
