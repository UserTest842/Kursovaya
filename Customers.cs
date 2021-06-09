using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace libman
{
    public class Customers : KeyedHashTable<Customer, string>, ILibDataCollection<Customer, string>
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Создаёт пустой набор клиентов.
        /// </summary>
        public Customers()
        {
            customers = new KeyedHashTable<Customer, string>();
        }

        #endregion

        #region Методы (общедоступные)

        #region Реализация ILibDataCollection<Customer, string>

        /// <summary>
        /// Текстовое описание клиента.
        /// </summary>
        /// <param name="datа">Описываемый клиент (возможно. null).</param>
        /// <returns>Текстовое описание.</returns>
        public string Description(Customer datа)
        {
            return datа?.Description ?? string.Empty;
        }

        /// <summary>
        /// Расширенное (с паспортом) описание клиента.
        /// </summary>
        /// <param name="datа">Описываемый клиент (возможно. null).</param>
        /// <returns>Расширенное описание.</returns>
        public string ExtendedDescription(Customer datа)
        {
            return datа?.ExtendedDescription ?? string.Empty;
        }

        #region Реализация IDataCollection<Customer, string>

        /// <summary>
        /// Очищает данные о клиентах.
        /// </summary>
        public new void Clear()
        {
            base.Clear();
        }

        #endregion

        #region Реализация IEditableCollection<Customer, string>

        /// <summary>
        /// Открывает список пользователей для просмотра и редактирования.
        /// </summary>
        public void EditList()
        {
            using (FormCustomers form = new FormCustomers())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Открывает форму списка клиентов для выбора.
        /// </summary>
        /// <returns>Выбранный пользователем клиент.<br />
        /// Если клиент не был выбран, то null.</returns>
        public Customer SelectItem()
        {
            using (FormCustomers form = new FormCustomers(FormPurpose.Select))
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return form.SelectedItem;
                else
                    return null;
            }
        }

        /// <summary>
        /// Открывает форму для редактирования данных об указанном клиенте.
        /// </summary>
        /// <param name="item">Клиент.</param>
        public void EditItem(Customer item)
        {
            using (FormCustomer form = new FormCustomer(item))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Открывает форму для создания данных о новом клиенте.
        /// </summary>
        public void NewItem()
        {
            using (FormCustomer form = new FormCustomer())
            {
                form.ShowDialog();
            }
        }

        #endregion

        #endregion

        #endregion

        #region Поля

        readonly KeyedHashTable<Customer, string> customers;

        #endregion

    }
}
