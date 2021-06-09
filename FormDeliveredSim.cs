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
    public partial class FormDeliveredSim : Form, IDataForm<DeliveredSim, string>
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.<br />
        /// Создаёт форму для регистрации выдачи симки.
        /// </summary>
        public FormDeliveredSim()
            : this(null)
        { }

        /// <summary>
        /// Открывает форму для редактирования данных о указанной выданной сим-карте.
        /// </summary>
        /// <param name="delivered">Выдача книг</param>
        public FormDeliveredSim(DeliveredSim delivered)
        {
            InitializeComponent();

            Source = delivered;
            IsNew = Source == null;
            Modified = false;
        }

        #endregion

        #region Свойства (общедоступные)

        /// <summary>
        /// Редактируемая выдача сим-карты.
        /// </summary>
        public DeliveredSim Source
        {
            get => source;
            set
            {
                source = value;
                if (source == null)
                {
                    maskedBookNumber.Text = string.Empty;
                    labelBook.Text = Service.Data.Sims.Description(null);
                    maskedCustomerPassportId.Text = string.Empty;
                    labelCustomer.Text = Service.Data.Customers.Description(null);
                    dateDelivery.Text = string.Empty;
                    labelReturnDate.Visible = true;
                    dateReturn.Visible = true;
                    dateReturn.Text = string.Empty;
                }
                else
                {
                    maskedBookNumber.Text = source.Number;
                    if (Service.Data.Sims.Lookup(maskedBookNumber.Text, out Sim book))
                        labelBook.Text = Service.Data.Sims.Description(book);
                    else
                        labelBook.Text = Service.Data.Sims.Description(null);
                    maskedCustomerPassportId.Text = source.PassportId;
                    if (Service.Data.Customers.Lookup(maskedCustomerPassportId.Text, out Customer customer))
                        labelCustomer.Text = Service.Data.Customers.Description(customer);
                    else
                        labelCustomer.Text = Service.Data.Customers.Description(null);
                    dateDelivery.Value = source.DeliveryDate;
                    dateReturn.Value = source.ReturnDate.Value;
                }
            }
        }

        /// <summary>
        /// Признак модифицированности формы.
        /// </summary>
        public bool Modified
        {
            get => modified;
            set
            {
                modified = value;
                Text = Title;
            }
        }

        #endregion

        #region Свойства (закрытые)

        /// <summary>
        /// Редактируется новая выдача сим-карты.
        /// </summary>
        private bool IsNew
        {
            get => isnew;
            set
            {
                isnew = value;
                Text = Title;
            }
        }

        /// <summary>
        /// Основной заголовок формы.
        /// </summary>
        private string Title => "Выданная сим-карта" + (isnew ? "<новая>" : modified ? "<*>" : string.Empty);

        #endregion

        #region Методы (закрытые)

        #region Команды

        /// <summary>
        /// Сохраняет данные из формы.
        /// </summary>
        /// <returns>true, если команда выполнена успешно;<br />
        /// false в противном случае.</returns>
        bool CmdSave()
        {
            if (IsNew)
                source = new DeliveredSim();
            else
                Service.Data.DeliveredSims.Remove(source);
            if (!Sim.CodeIsValid(maskedBookNumber.Text))
            {
                this.ErrorMessage("Неверный формат номера.");
                return false;
            }
            if (Service.Data.Sims.Lookup(maskedBookNumber.Text, out Sim sim))
            {
                if (sim.Exist == false)
                {
                    this.ErrorMessage("Сим-карта занята.");
                    return true;
                }
            }
            else
            {
                this.ErrorMessage($"Сим-карты с номером {maskedBookNumber.Text} не существует.");
                return false;
            }
            if (!Customer.PassportIdIsValid(maskedCustomerPassportId.Text))
            {
                this.ErrorMessage("Неверный формат номера паспорта.");
                return false;
            }
            if (!Service.Data.Customers.ContainsKey(maskedCustomerPassportId.Text))
            {
                this.ErrorMessage($"Клиента с номером паспорта {maskedCustomerPassportId.Text} не существует.");
                return false;
            }
            source.Number = maskedBookNumber.Text;
            source.PassportId = maskedCustomerPassportId.Text;
            source.DeliveryDate = dateDelivery.Value;
            source.ReturnDate = dateReturn.Value;

            try
            {
                Service.Data.DeliveredSims.Insert(source);
                Modified = false;
                return true;
            }
            catch (Exception exception)
            {
                this.ErrorMessage("Данные не сохранены: " + exception.Message);
                return false;
            }
        }

        /// <summary>
        /// Сохраняет данные и закрывает форму
        /// </summary>
        /// <returns>true, если команда выполнена успешно;<br />
        /// false в противном случае.</returns>
        bool CmdClose()
        {
            if (Modified && !CmdSave())
                return false;
            DialogResult = DialogResult.OK;
            Close();
            return true;
        }

        /// <summary>
        /// Закрывает форму без сохранения данных.
        /// </summary>
        /// <returns>true, если команда выполнена успешно;<br />
        /// false в противном случае.</returns>
        bool CmdCancel()
        {
            Modified = false;
            DialogResult = DialogResult.Cancel;
            Close();
            return true;
        }

        #endregion

        #region Обработчики событий

        #region Обработчики событий формы

        private void FormDeliveredBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
            {
                string question = "Несохранённые данные будут утеряны!\nВсё равно закрыть форму?";
                if (this.Question(question, false))
                    CmdCancel();
                else
                    e.Cancel = true;
            }
        }

        #endregion

        #region Обработчики событий элементов формы

        #region maskedBookCode

        private void MaskedBookCode_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        private void MaskedBookCode_Validating(object sender, CancelEventArgs e)
        {
            if (maskedBookNumber.Text.Trim() != Sim.EmptyNumber.Trim())
            {
                if (!Service.Data.Sims.ContainsKey(maskedBookNumber.Text))
                    this.Warning("Сим-карты с таким номером не существует!");
            }
        }

        private void MaskedBookCode_Validated(object sender, EventArgs e)
        {
            if (Service.Data.Sims.Lookup(maskedBookNumber.Text, out Sim book))
                labelBook.Text = Service.Data.Sims.Description(book);
            else
                labelBook.Text = Service.Data.Sims.Description(null);
        }

        #endregion

        #region buttonSelectBook

        private void ButtonSelectBook_Click(object sender, EventArgs e)
        {
            Sim book = Service.Data.Sims.SelectItem();
            if (book != null)
            {
                maskedBookNumber.Text = book.Number;
                labelBook.Text = book.Description;
                Modified = true;
            }
        }

        #endregion

        #region maskedCustomerCardId

        private void MaskedCustomerCardId_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        private void MaskedCustomerCardId_Validating(object sender, CancelEventArgs e)
        {
            if (!Service.Data.Customers.ContainsKey(maskedCustomerPassportId.Text))
            {
                this.Warning("Клиента с таким номером паспорта не существует!");
            }
        }

        #endregion

        #region buttonSelectCustomer

        private void ButtonSelectCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = Service.Data.Customers.SelectItem();
            if (customer != null)
            {
                maskedCustomerPassportId.Text = customer.PassportId;
                labelCustomer.Text = customer.Name;
                Modified = true;
            }
        }

        #endregion

        #region buttonOK

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            CmdClose();
        }

        #endregion

        #region buttonCancel

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CmdCancel();
        }

        #endregion

        #endregion

        #endregion

        #endregion

        #region Поля

        DeliveredSim source;

        bool modified;

        bool isnew;

        #endregion
    }
}
