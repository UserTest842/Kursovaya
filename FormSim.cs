using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace libman
{
    /// <summary>
    /// Форма для редактирования данных о книге.
    /// </summary>
    public partial class FormSim : Form, IDataForm<Sim, string>
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.<br />
        /// Используется для создания данных о новой книге.
        /// </summary>
        public FormSim()
            : this(null)
        { }

        /// <summary>
        /// Создаёт форму для редактирования данных книги.<br />
        /// Если читатель не указан (null), то открывается форма для
        /// ввода данных о новой книге.
        /// </summary>
        /// <param name="customer">Книга, данные о которой редактируются.</param>
        public FormSim(Sim book)
        {
            InitializeComponent();

            Source = book;
            Modified = false;
            IsNew = book == null;

            panelDeliveredBooks.Visible = !IsNew;
            bsourceCustomers.DataSource = CurrentCustomer();
        }

        #endregion

        #region Свойства (общедоступные)

        #region Реализация IDataForm

        /// <summary>
        /// Симка, редактируемая в форме.
        /// </summary>
        public Sim Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                if (source == null)
                {
                    maskedNumber.Text = string.Empty;
                    textTarif.Text = string.Empty;
                    maskedYear.Text = string.Empty;
                    checkBoxExist.Visible = false;
                }
                else
                {
                    maskedNumber.Text = source.Number;
                    textTarif.Text = source.Tarif;
                    maskedYear.Text = source.Year.ToString();
                    checkBoxExist.Visible = true;
                    checkBoxExist.Checked = source.Exist;
                }
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

        #endregion

        #region Свойства (закрытые)

        /// <summary>
        /// Основной заголовок формы.
        /// </summary>
        private string Title => "Симка" + (isnew ? "<новая>" : modified ? "<*>" : string.Empty);

        /// <summary>
        /// Редактируются данные новой книги.
        /// </summary>
        private bool IsNew
        {
            get
            {
                return isnew;
            }
            set
            {
                isnew = value;
                labelNew.Visible = isnew;
                Text = Title;
            }
        }

        #endregion

        #region Методы (закрытые)

        /// <summary>
        /// Данные о пользователе симки.
        /// </summary>
        IEnumerable<object> CurrentCustomer()
        {
            string number = source?.Number ?? string.Empty;
            var deliveries =
                from delivered in Service.Data.DeliveredSims
                where delivered.Active && (delivered.Number == number)
                select delivered;
            foreach (DeliveredSim delivered in deliveries)
            {
                Customer customer = Service.Data.Customers.Lookup(delivered.PassportId);
                yield return new
                {
                    CustomerPassportId = customer.PassportId,
                    Name = customer.Name,
                    DeliveryDate = delivered.DeliveryDate
                };
            }
        }

        #region Команды

        /// <summary>
        /// Сохраняет данные из формы.
        /// </summary>
        /// <returns>true, если команда выполнена успешно;<br />
        /// false в противном случае.</returns>
        bool CmdSave()
        {
            if (IsNew)
                source = new Sim();
            else
                Service.Data.Sims.Remove(source);
            if (!Sim.CodeIsValid(maskedNumber.Text))
            {
                this.ErrorMessage("Неверный формат номера телефона.");
                return false;
            }
            source.Number = maskedNumber.Text;
            source.Tarif = textTarif.Text;
            source.Exist = checkBoxExist.Checked;
            try
            {
                source.Year = Convert.ToUInt16(maskedYear.Text);
            }
            catch (Exception)
            {
                this.ErrorMessage("Неверный формат года выпуска.");
                return false;
            }
            try
            {
                Service.Data.Sims.Insert(source);
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

        #region Обработчики событий

        #region Обработчики событий формы

        private void FormBook_FormClosing(object sender, FormClosingEventArgs e)
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

        #region textPublisher

        private void TextPublisher_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        #endregion

        #region maskedYear

        private void MaskedYear_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        #endregion

        #region checkBoxExist
        private void checkBoxExist_CheckedChanged(object sender, EventArgs e)
        {
            Modified = true;
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

        private Sim source;

        private bool modified;

        private bool isnew;

        #endregion

        
    }
}
