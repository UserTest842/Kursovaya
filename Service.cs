using System.Xml;

namespace libman
{
    public class Service
    {
        #region Типы

        public class FileNameEventArgs
        {
            public FileNameEventArgs(string filename)
            {
                FileName = filename;
            }

            public string FileName { get; private set; }
        }

        public delegate void FileNameChangedEventHandler(object sender, FileNameEventArgs args);

        #endregion

        #region Конструкторы (закрытые)

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Service()
        {
            FileName = "";
            Customers = new Customers();
            Sims = new Sims();
            DeliveredSims = new DeliveredSims();
        }

        #endregion

        #region Cвойства (общедоступные)

        /// <summary>
        /// Имя файла салона связи.
        /// </summary>
        public string FileName
        {
            get => filename;
            private set
            {
                filename = value;
                FileNameChanged?.Invoke(this, new FileNameEventArgs(filename));
            }
        }

        /// <summary>
        /// Признак модифицированности данных библиотеки.
        /// </summary>
        public bool Modified
        {
            get => Customers.Modified || Sims.Modified || DeliveredSims.Modified;
            set
            {
                Customers.Modified = value;
                Sims.Modified = value;
                DeliveredSims.Modified = value;
            }
        }

        /// <summary>
        /// Данные о клиентах.
        /// </summary>
        public Customers Customers { get; set; }

        /// <summary>
        /// Данные о симках.
        /// </summary>
        public Sims Sims { get; set; }

        /// <summary>
        /// Данные о выданных симках.
        /// </summary>
        public DeliveredSims DeliveredSims { get; set; }

        #endregion

        #region Методы (общедоступные)

        /// <summary>
        /// Сохраняет данные салона в файл.
        /// </summary>
        /// <param name="filename">Имя файла для выгрузки.</param>
        public void Save(string filename)
        {
            using (DataWriter output = new DataWriter(filename))
            {
                output.Start();
                output.Write(Customers);
                output.Write(Sims);
                output.Write(DeliveredSims);
                output.Finish();
                output.Close();
                Modified = false;
                FileName = filename;
            }
        }

        /// <summary>
        /// Загружает данные сервиса из файла.
        /// </summary>
        /// <param name="filename">Имя файла для загрузки.</param>
        public void Load(string filename)
        {
            DataReader input = new DataReader(filename);
            input.Start();
            input.ReadObjects();
            input.Close();
            Modified = false;
            FileName = filename;
        }

        /// <summary>
        /// Полностью очищает все данные.
        /// </summary>
        public void Clear()
        {
            FileName = "";
            Customers.Clear();
            Sims.Clear();
            DeliveredSims.Clear();
        }

        #endregion

        #region События (общедоступные)

        public event FileNameChangedEventHandler FileNameChanged;

        #endregion

        #region Поля

        string filename;

        #endregion

        #region Статические поля (общедоступные)

        public static Service Data = new Service();

        #endregion

        #region Статические методы

        bool IsAllowedTypeName(string typename)
        {
            return
                typename == typeof(Customer).Name ? true :
                typename == typeof(Sim).Name ? true :
                typename == typeof(DeliveredSim).Name ? true :
                false;
        }

        #endregion
    }
}
