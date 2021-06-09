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
    /// <summary>
    /// Форма для редактирования в диалоге данных о читателе.
    /// </summary>
    public partial class FormCustomer : Form, IDataForm<Customer, string>
    {

        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.<br />
        /// Используется для создания данных о новом клиенте.
        /// </summary>
        public FormCustomer()
            : this(null)
        { }

        /// <summary>
        /// Создаёт форму для редактирования данных клиента.<br />
        /// Если клиент не указан (null), то открывается форма для
        /// регистрации нового клиента.
        /// </summary>
        /// <param name="customer">Клиент, данные которого редактируются.</param>
        public FormCustomer(Customer customer)
        {
            InitializeComponent();
            dateRegistration.Value = DateTime.Now;

            Source = customer;
            IsNew = Source == null;
            Modified = false;

            bsourceBooks.DataSource = CurrentCard();
            panelDeliveredBooks.Visible = !IsNew;
        }

        #endregion

        #region Свойства (общедоступные)

        /// <summary>
        /// Редактируемый объект "Клиент" (<see cref="Customer"/>).
        /// </summary>
        public Customer Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                labelNew.Visible = IsNew;
                dateRegistration.Visible = IsNew;
                panelDeliveredBooks.Visible = !IsNew;
                maskedPassportId.Text = source?.PassportId;
                textName.Text = source?.Name;
                maskedBirthYear.Text = source?.BirthYear.ToString();
                textAddress.Text = source?.Address;
            }
        }

        /// <summary>
        /// Признак модифицированности данных формы.
        /// </summary>
        public bool Modified
        {
            get
            {
                return modified;
            }
            set
            {
                modified = value;
                Text = Title;
            }
        }

        #endregion

        #region Свойства (закрытые)

        /// <summary>
        /// Вычисляемый заголовок формы.
        /// </summary>
        private string Title => "Клиент" + (isnew ? "<новый>" : modified ? "<*>" : string.Empty);

        /// <summary>
        /// Являются ли редактируемые данные данными нового клиента.
        /// </summary>
        private bool IsNew
        {
            get => isnew;
            set
            {
                isnew = value;
                labelNew.Visible = isnew;
            }
        }

        #endregion

        #region Методы (закрытые)
        /// <summary>
        /// Перечисляет выданные клиенту сим-карты.
        /// </summary>
        /// <returns>Последовательность полученных клиентом сим-карт.</returns>
        IEnumerable<object> CurrentCard()
        {
            string passportid = source?.PassportId ?? string.Empty;
            var deliveries =
                from delivered in Service.Data.DeliveredSims
                where (delivered.PassportId == passportid)
                select delivered;
            foreach (DeliveredSim delivered in deliveries)
            {
                Sim sim = Service.Data.Sims.Lookup(delivered.Number);
                yield return new
                {
                    Number = delivered.Number,
                    Tarif = sim.Tarif,
                    DeliveryDate = delivered.DeliveryDate
                };
            }
        }

        #region Команды

        /// <summary>
        /// Сохраняет данные о клиенте.
        /// </summary>
        /// <returns>true, если команда выполнена успешно;<br />
        /// false в противном случае.</returns>
        bool CmdSave()
        {
            try
            {
                if (IsNew)
                    source = new Customer();
                else
                    Service.Data.Customers.Remove(source);
                if (!Customer.PassportIdIsValid(maskedPassportId.Text))
                {
                    this.ErrorMessage("Неверный формат номера паспорта !");
                    return false;
                }
                source.PassportInfo = textPassportInfo.Text;
                source.Name = textName.Text;
                source.BirthYear = Convert.ToUInt16(maskedBirthYear.Text);
                source.Address = textAddress.Text;
            }
            catch (Exception exception)
            {
                this.ErrorMessage("Неверный формат данных: " + exception.Message);
                return false;
            }
            if (IsNew)
            {
                if (Service.Data.Customers.ContainsKey(maskedPassportId.Text))
                {
                    this.ErrorMessage("Номер паспорта " + maskedPassportId.Text + "уже зарегистрирован ранее");
                    return false;
                }
            }
            source.PassportId = maskedPassportId.Text;
            try
            {
                Service.Data.Customers.Insert(source);
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
        /// Сохраняет данные и закрывает форму.
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

        #region Обработчики событий формы

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
            {
                string question = "Несохранённые данные будут утеряны!\nВсё равно закрыть форму?";
                if (this.Question(question, false))
                {
                    Modified = true;
                    CmdCancel();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region Обработчики событий элементов формы

        #region dateRegistration

        private void DateRegistration_ValueChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        #endregion

        #region textName

        private void TextName_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        #endregion

        #region maskedBitrhYear

        private void MaskedBirthYear_Changed(object sender, MaskInputRejectedEventArgs e)
        {
            Modified = true;
        }

        private void maskedBirthYear_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        #endregion

        #region textAddress

        private void TextAddress_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        #endregion

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            CmdClose();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CmdCancel();
        }

        #endregion

        #endregion

        #region Поля

        private bool modified;

        Customer source;

        bool isnew;

        #endregion

        #region Статические члены (общедоступные)

        public static Customer Edit(Customer customer)
        {
            FormCustomer form = new FormCustomer(customer);
            if (form.ShowDialog() == DialogResult.OK)
                return form.Source;
            else
                return null;
        }

        #endregion

        private void textPassportInfo_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }
    }
}
