using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace libman
{
    /// <summary>
    /// Коллекция данных о книгах библиотеки.
    /// </summary>
    public class Sims: Tree<Sim, string>, ILibDataCollection<Sim, string>
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Создаёт пустой набор сим-карт.
        /// </summary>
        public Sims()
            : base()
        {
            LastNumbers = new Dictionary<uint, uint>();
        }

        #endregion

        #region Свойства (общедоступные)

        public Dictionary<uint, uint> LastNumbers;

        #endregion

        #region Методы (общедоступные)

        #region ILibDataCollection<Book, string>

        /// <summary>
        /// Текстовое описание карты.
        /// </summary>
        /// <param name="data">Описываемая книга (возможноб null).</param>
        /// <returns>Текстовое описание.</returns>
        public string Description(Sim data)
        {
            return data?.Description ?? string.Empty;
        }

        /// <summary>
        /// Расширенное (включающее номер) текстовое описание карты.
        /// </summary>
        /// <param name="datа">Описываемая сим-карта (возможно null).</param>
        /// <returns>Расширенное текстовое описание.</returns>
        public string ExtendedDescription(Sim datа)
        {
            return datа?.ExtendedDescription ?? string.Empty;
        }

        #endregion

        #region Реализация IDataCollection<Sim, string>

        /// <summary>
        /// Очищает данные о симках.
        /// </summary>
        public new void Clear()
        {
            base.Clear();
            LastNumbers.Clear();
        }

        #endregion

        #region Реализация IEditableCollection<Sim, string>

        /// <summary>
        /// Открывает форму списка карт для просмотра и редактирования.
        /// </summary>
        public void EditList()
        {
            using (FormSims form = new FormSims())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Запрашивает в диалоге у пользователя выбрать карту.
        /// </summary>
        /// <returns>Выбранная пользователем карта.<br />
        /// Если пользователь не выбрал карту, то null</returns>
        public Sim SelectItem()
        {
            using (FormSims form = new FormSims(FormPurpose.Select))
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return form.SelectedItem;
                else
                    return null;
            }
        }

        /// <summary>
        /// Открывает форму для редактирования данных об указанной сим-карте.
        /// </summary>
        /// <param name="item">Объект для редактирования.</param>
        public void EditItem(Sim item)
        {
            using(FormSim form = new FormSim(item))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Открывает форму для создания данных о новой сим-карте.
        /// </summary>
        public void NewItem()
        {
            using (FormSim form = new FormSim())
            {
                form.ShowDialog();
            }
        }

        #endregion

        #endregion

    }
}
