using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libman
{
    public class DeliveredSims : SkipList<DeliveredSim, string>, ILibDataCollection<DeliveredSim, string>
    {
        #region Конструкторы (общедоступные)

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public DeliveredSims()
        { }

        #endregion

        #region Методы (общедоступные)

        /// <summary>
        /// Показывает клиента данной симки
        /// </summary>
        /// <param name="sim">Выданная sim.</param>
        /// <returns>Последовательность читателей.</returns>
        public IEnumerable<DeliveredSim> SimForCustomer(Sim sim)
        {
            string number = sim.Number;
            return
                from delivery in this where delivery.Number == number select delivery;
        }

        /// <summary>
        /// Перечисляет sim, выданные указанному клиенту.
        /// </summary>
        /// <param name="customer">Клиент.</param>
        /// <returns>Выданные читателю сим.</returns>
        public IEnumerable<DeliveredSim> SimsForCustomer(Customer customer)
        {
            string passportid = customer.PassportId;
            return
                from delivery in this where delivery.PassportId == passportid select delivery;
        }

        #region ILibDataCollection<DeliveredBook, string>

        /// <summary>
        /// Текстовое описание выдачи sim.
        /// </summary>
        /// <param name="datа">Описываемая выдача sim (возможно, null).</param>
        /// <returns>Текстовое описание.</returns>
        public string Description(DeliveredSim datа) => datа?.Description ?? string.Empty;

        /// <summary>
        /// Расширенное (включающее ключ) текстовое описание выдачи sim.
        /// </summary>
        /// <param name="datа">Описываемая выдача sim (возможно, null).</param>
        /// <returns>Расширеннное описание.</returns>
        public string ExtendedDescription(DeliveredSim datа) => datа?.ExtendedDescription ?? string.Empty;

        #region IEditableCollection<DeliveredBook>

        public void EditItem(DeliveredSim item)
        {
            using (FormDeliveredSim form = new FormDeliveredSim(item))
            {
                form.ShowDialog();
            }
        }

        public void EditList()
        {
            using (FormDeliveredSims form = new FormDeliveredSims())
            {
                form.ShowDialog();
            }
        }

        public void NewItem()
        {
            using (FormDeliveredSim form = new FormDeliveredSim())
            {
                form.ShowDialog();
            }
        }

        public DeliveredSim SelectItem()
        {
            using (FormDeliveredSims form = new FormDeliveredSims(FormPurpose.Select))
            {
                return (form.ShowDialog() == DialogResult.OK) ? form.SelectedItem : null;
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
