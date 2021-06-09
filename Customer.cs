using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libman
{
    public class Customer : IServiceDataObject<string>, IEditableObject
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию - создаёт пустой объект.
        /// </summary>
        public Customer()
        { }

        /// <summary>
        /// Создаёт объект, свойства которого задаются набором значений.<br />
        /// Значения с именами, не являющимися именами свойств, игнорируются.
        /// </summary>
        /// <param name="values">Набор значений свойств</param>
        public Customer(ValueSet values)
        {
            foreach (KeyValuePair<string, string> pair in values)
            {
                string key = pair.Key;
                string value = pair.Value;
                if (key == "PassportId")
                    PassportId = value;
                else if (key == "PassportInfo")
                    PassportInfo = value;
                else if (key == "Name")
                    Name = value;
                else if (key == "BirthYear")
                    BirthYear = Convert.ToUInt16(value);
                else if (key == "Address")
                    Address = value;
            }
        }

        #endregion

        #region Свойства (общедоступные)

        /// <summary>
        /// Паспорт.
        /// </summary>
        public string PassportId { get; set; }

        /// <summary>
        /// Информация по паспорту.
        /// </summary>
        public string PassportInfo { get; set; }

        /// <summary>
        /// Фамилия, имя, отчество.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Год рождения.
        /// </summary>
        public ushort BirthYear { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Проверяет наличие выданных книг на руках. !!!!!!!!!!!!
        /// </summary>
        public bool HasBooks
        {
            get
            {
                foreach (DeliveredSim delivered in Service.Data.DeliveredSims.SimsForCustomer(this))
                    return true;
                return false;
            }
        }

        #region Реализация ILibDataObject

        public string Description => Name;

        public string ExtendedDescription => (Key + " " + Description).Trim();

        /// <summary>
        /// Набор имён свойств и строковых представлений их значений.
        /// </summary>
        public ValueSet AsValues =>
                new ValueSet
                {
                    ["PassportId"] = PassportId,
                    ["PassportInfo"] = PassportInfo,
                    ["Name"] = Name,
                    ["BirthYear"] = BirthYear.ToString(),
                    ["Address"] = Address
                };

        #region Реализация IKeyed

        public string Key => PassportId;

        #endregion

        #endregion

        #endregion

        #region Методы (общедоступные)

        #region Реализация IEditable

        /// <summary>
        /// Открывает форму для редактирования в диалоге данных о клиенте.
        /// </summary>
        public void Edit()
        {
            using (FormCustomer form = new FormCustomer(this))
            {
                form.ShowDialog();
            }
        }

        #endregion

        #endregion

        #region Статические методы (общедоступные)
        /// <summary>
        /// Проверка правильности строки номера паспорта.
        /// </summary>
        /// <param name="passportid">Проверяемая строка номера.</param>
        /// <returns>true, если строка соответствует формату номера
        /// паспорта;<br />
        /// false в противном случае.</returns>
        public static bool PassportIdIsValid(string passportid)
        {
            if (passportid.Length != 11)
                return false;
            if (!(char.IsDigit(passportid[0]) && char.IsDigit(passportid[1]) && char.IsDigit(passportid[2]) && char.IsDigit(passportid[3])))
                return false;
            if (passportid[4] != '-')
                return false;
            if (!(char.IsDigit(passportid[5]) && char.IsDigit(passportid[6]) && char.IsDigit(passportid[7]) && char.IsDigit(passportid[8]) && char.IsDigit(passportid[9]) && char.IsDigit(passportid[10])))
                return false;
            return true;
        }

        #endregion

    }
}
