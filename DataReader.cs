using System;
using System.IO;
using System.Text;
using System.Xml;

namespace libman
{
    public class DataReader
    {
        #region Типы исключений (общедоступные)

        public class DataFormatError : Exception
        {
            public DataFormatError(string message)
                : base("Неверный формат файла данных сервиса: " + message)
            { }
        }

        #endregion

        #region Конструкторы (общедоступные)

        /// <summary>
        /// Начинает чтение данных из XML.
        /// </summary>
        /// <param name="filename">Имя файла для чтения.</param>
        public DataReader(string filename)
        {
            input = XmlReader.Create(filename);
        }

        #endregion

        public void Load()
        {
            Service.Data.Clear();
            Start();
            ReadObjects();
            //Service.Data.Sims.RestoreNumeration();
            //Service.Data.Customers.RestoreNumeration();
        }

        #region Методы (закрытые)

        public void Start()
        {
            while (input.Read())
            {
                switch (input.NodeType)
                {
                    case XmlNodeType.XmlDeclaration:
                        break;
                    case XmlNodeType.Element:
                        if (input.Name == "library")
                            return;
                        else
                            throw new DataFormatError("ожидался элемент <library>");
                    default:
                        throw new DataFormatError("ожидался элемент <library>");
                }
            }
        }

        public void ReadObjects()
        {
            while (input.Read())
            {
                switch(input.NodeType)
                {
                    case XmlNodeType.Element:
                        string typename = input.Name;
                        ValueSet values = ReadValues(typename);
                        if (typename == typeof(Sim).Name)
                            Service.Data.Sims.Insert(new Sim(values));
                        else if (typename == typeof(Customer).Name)
                            Service.Data.Customers.Insert(new Customer(values));
                        else if (typename == typeof(DeliveredSim).Name)
                            Service.Data.DeliveredSims.Insert(new DeliveredSim(values));
                        else
                            throw new DataFormatError($"Неизвестный тип {typename}.");
                        break;
                    case XmlNodeType.EndElement:
                        if (input.Name == "library")
                            return;
                        else
                            throw new DataFormatError($"Неожиданный конец элемента </{input.Name}>.");
                    default:
                        throw new DataFormatError("Неожиданные данные среди значений.");
                }
            }
        }

        public ValueSet ReadValues(string type)
        {
            ValueSet result = new ValueSet();
            while(input.Read())
            {
                switch (input.NodeType)
                {
                    case XmlNodeType.Element:
                        string name = input.Name;
                        result.Add(name, ReadValue(name));
                        break;
                    case XmlNodeType.EndElement:
                        if (input.Name == type)
                            return result;
                        else
                            throw new DataFormatError($"Неожиданный конец элемента </{input.Name}>.");
                    default:
                        throw new DataFormatError("Неожиданные данные среди значений.");
                }
            }
            throw new DataFormatError("Неожиданный конец данных.");
        }

        /// <summary>
        /// Завершает чтение.
        /// </summary>
        public void Close()
        {
            input.Close();
        }

        #endregion

        #region Методы (закрытые)

        string ReadValue(string name)
        {
            StringBuilder value = new StringBuilder();
            while(input.Read())
            {
                switch(input.NodeType)
                {
                    case XmlNodeType.Text:
                        value.Append(input.Value);
                        break;
                    case XmlNodeType.EndElement:
                        if (input.Name == name)
                            return value.ToString();
                        else
                            throw new DataFormatError($"Ожидался конец элемента <{name}>.");
                    default:
                        throw new DataFormatError("Недопустимый формат значения.");
                }
            }
            throw new DataFormatError("Неожиданный конец данных.");
        }

        #endregion

        #region Поля

        XmlReader input;

        #endregion
    }
}
