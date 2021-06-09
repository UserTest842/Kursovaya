using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libman
{
    /// <summary>
    /// Сведения о выдаче СИМ
    /// </summary>
    public class DeliveredSim: IServiceDataObject<string>, IEditableObject
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public DeliveredSim()
        { }

        public DeliveredSim(ValueSet values)
        {
            Number = values["Number"];
            PassportId = values["PassportId"];
            DeliveryDate = DateTime.Parse(values["DeliveryDate"]);
            ReturnDate = DateTime.Parse(values["ReturnDate"]);
        }

        #endregion

        #region Свойства (общедоступные)

        /// <summary>
        /// Номер.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Номер паспорта.
        /// </summary>
        public string PassportId { get; set; }

        /// <summary>
        /// Дата выдачи сим.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Дата конца сим, если симка кончилась.<br />
        /// null, если симка еще на руках.
        /// </summary>
        public DateTime? ReturnDate { get; set; }

        /// <summary>
        /// Симка еще работает.
        /// </summary>
        public bool Active => !ReturnDate.HasValue || (ReturnDate.Value > DateTime.Now);

        #region Реализация ILibObject<string>

        /// <summary>
        /// Описание выдачи номера.
        /// </summary>
        public string Description => Number + "->" + PassportId;

        /// <summary>
        /// Расширенное описание выдачи номера.
        /// </summary>
        public string ExtendedDescription => Description;

        /// <summary>
        /// Набор имён свойств и строковых представлений их значений.
        /// </summary>
        public ValueSet AsValues =>
            ReturnDate.HasValue ?
            new ValueSet()
            {
                ["Number"] = Number,
                ["PassportId"] = PassportId,
                ["DeliveryDate"] = DeliveryDate.ToString("dd'.'MM'.'yyyy"),
                ["ReturnDate"] = ReturnDate.Value.ToString("dd'.'MM'.'yyyy")
            } :
            new ValueSet()
            {
                ["Number"] = Number,
                ["PassportId"] = PassportId,
                ["DeliveryDate"] = DeliveryDate.ToString("dd'.'MM'.'yyyy")
            };

        #region IKeyed<string>

        /// <summary>
        /// Ключевое (индексное) свойство.
        /// </summary>
        public string Key => CreateKey(Number, PassportId);

        #endregion

        #endregion

        #endregion

        #region Методы (общедоступные)

        #region Реализация IEditableObject

        /// <summary>
        /// Открывает форму для редактирования в диалоге.
        /// </summary>
        public void Edit()
        {
            using (FormDeliveredSim form = new FormDeliveredSim(this))
            {
                form.ShowDialog();
            }
        }

        #endregion

        #endregion

        #region Статические методы (общедоступные)

        public static string CreateKey(string sim, string customer) => sim + "->" + customer;

        public static string CreateKey(Sim sim, Customer customer)
        {
            return (sim == null) || (customer == null) ? string.Empty : CreateKey(sim.Key, customer.Key);
        }

        #endregion
    }
}
