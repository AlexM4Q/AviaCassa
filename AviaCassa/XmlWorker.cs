using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace AviaCassa {

    internal static class XmlWorker {

        /// <summary>
        /// Возвращает массив рейсов из xml
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IEnumerable<Flight> GetFlights(string path) {
            var result = new List<Flight>(); // создаем список для хранения результатов

            var doc = new XmlDocument(); // создаем объект для работы с xml    
            doc.Load(path); // загружаем в память выбранный документ

            // для каждого элемента с именем "flight"
            foreach (XmlElement elem in doc.GetElementsByTagName("flight")) {
                // теперь добавляем рейс в список
                result.Add(new Flight(
                    int.Parse(elem.GetAttribute("number")),
                    elem.GetElementsByTagName("crew").Item(0).InnerText.Trim().Split(';'),
                    elem.GetAttribute("type"),
                    elem.GetAttribute("date"),
                    elem.GetAttribute("time"),
                    int.Parse(elem.GetAttribute("cost"))));
            }

            return result; // возвращаем список информации о рейсах
        }

        /// <summary>
        /// Записывает массив рейсов в xml
        /// </summary>
        /// <param name="flights"></param>
        /// <param name="path"></param>
        public static void WriteFlights(IEnumerable<Flight> flights, string path) {
            File.AppendAllText(path, ""); // очищает файл

            XmlTextWriter xmlWrt = new XmlTextWriter(path, null); // используем обертку для записи
            xmlWrt.WriteStartDocument(); // записываем начало документа
            xmlWrt.WriteDocType("flights", null, "DataBase.dtd", null); // присобачиваем DOCTYPE со схемой dtd для валидации
            xmlWrt.WriteStartElement("flights"); // записываем корневой элемент
            xmlWrt.WriteEndDocument(); // закрываем тэг корневого элемента
            xmlWrt.Close(); // закрываем поток

            XmlDocument doc = new XmlDocument(); // создаем документ xml
            doc.Load(path); // связываем переменную документа с реальным файлом

            XmlElement flight = doc.CreateElement("flight"); // создаем элемент рейса
            XmlElement crew = doc.CreateElement("crew"); // создаем элемент экипажа

            foreach (Flight fl in flights) {
                // теперь каждый рейс из коллекции пишем в xml-документ

                // Подготавливаем ЭЛЕМЕНТ экипажа
                crew.InnerText = fl.Crew[0] + ";" + fl.Crew[1];

                // устанавливаем АТРИБУТ номера
                flight.SetAttribute("number", fl.Number.ToString());

                // добавляем ЭЛЕМЕНТ экипажа
                flight.AppendChild(crew);

                // тип рейса АТРИБУТ
                flight.SetAttribute("type", fl.Type);

                // дату АТРИБУТ
                flight.SetAttribute("date", fl.Date);

                // время АТРИБУТ
                flight.SetAttribute("time", fl.Time);

                //стоимость АТРИБУТ
                flight.SetAttribute("cost", fl.Cost.ToString());

                doc.DocumentElement.AppendChild(flight); // присобачиваем заполненный элемент рейса к документу
            }

            doc.Save(path); // сохраняем xml-документ в xml-файл
        }

    }

}