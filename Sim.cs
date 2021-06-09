using System;
using System.Collections.Generic;
using System.Linq;

namespace libman
{
    /// <summary>
    /// Сведения о книге.
    /// </summary>
    public class Sim: IServiceDataObject<string>, IEditableObject
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Sim()
        { }

        /// <summary>
        /// Создаёт объект, свойства которого задаются набором значений.<br />
        /// Значения с именами, не являющимися именами свойств, игнорируются.<br />
        /// Используется при считывании из файла.
        /// </summary>
        /// <param name="values">Набор значений свойств.</param>
        public Sim(ValueSet values)
        {
            foreach (KeyValuePair<string, string> pair in values)
            {
                string key = pair.Key;
                string value = pair.Value;
                if (key == "Number")
                    Number = value;
                else if (key == "Tarif")
                    Tarif = value;
                else if (key == "Year")
                    Year = Convert.ToUInt16(value);
                else if (key == "Exist")
                    Exist = Convert.ToBoolean(value);
            }
        }

        #endregion

        #region Свойства (общедоступные)

        /// <summary>
        /// Номер.<br />
        /// Имеет вид XXX-XXXXXXX, номер телефона.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///Тариф номера.
        /// </summary>
        public string Tarif { get; set; }

        /// <summary>
        /// Год выпуска.
        /// </summary>
        public uint Year { get; set; }

        /// <summary>
        /// Признак наличия
        /// </summary>
        public bool Exist { get; set; }

        #region Реализация ILibObject<>

        public string Description => (Tarif).Trim();

        public string ExtendedDescription => (Key).Trim();

        public ValueSet AsValues =>
            new ValueSet
            {
                ["Number"] = Number,
                ["Tarif"] = Tarif,
                ["Year"] = Year.ToString(),
                ["Exist"] = Exist.ToString()
            };

        #region Реализация IKeyed<string>

        public string Key => Number;

        #endregion

        #endregion

        #endregion

        #region Методы (общедоступные)

        #region ILibDataObject<string>

        #endregion

        #region Реализация IEditableObject

        /// <summary>
        /// Открывает форму для редактирования данных о симкарте в диалоге.
        /// </summary>
        public void Edit()
        {
            using(FormSim form = new FormSim(this))
            {
                form.ShowDialog();
            }
        }

        #endregion

        #endregion

        #region Статические свойства (общедоступные)

        public static string EmptyNumber => "   -       ";

        #endregion

        #region Статические методы (общедоступные)
        /// <summary>
        /// Проверка корректности номера телефона.
        /// </summary>
        /// <param name="code">Проверяемая строка.</param>
        /// <returns>true, если строка соответствует правилам для номера
        /// телефона<br />
        /// false в противном случае.</returns>
        public static bool CodeIsValid(string code)
        {
            return
                (code.Length == 11) &&
                char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) &&
                (code[3] == '-') &&
                char.IsDigit(code[4]) && char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) && char.IsDigit(code[9]) && char.IsDigit(code[10]);
        }

        #endregion
    }
}
