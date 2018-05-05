using System.Collections.Generic;
using System.Windows.Forms;

namespace AviaCassa {

    public partial class FormResult : Form {

        public FormResult() {
            InitializeComponent();
        }

        /// <summary>
        /// Заполняет таблицу
        /// </summary>
        /// <param name="flights"></param>
        internal void FillTab(IEnumerable<Flight> flights) {
            foreach (var fl in flights) {
                AppendFlight(fl);
            }
        }

        /// <summary>
        /// Добавляет запись в конец таблицы
        /// </summary>
        /// <param name="flight"></param>
        private void AppendFlight(Flight flight) {
            DataGrid.Rows.Add();
            DataGrid.Rows[DataGrid.Rows.Count - 1].Cells[0].Value = flight.Number.ToString();
            DataGrid.Rows[DataGrid.Rows.Count - 1].Cells[1].Value = flight.Crew[0] + "\n" + flight.Crew[1];
            DataGrid.Rows[DataGrid.Rows.Count - 1].Cells[2].Value = flight.Type;
            DataGrid.Rows[DataGrid.Rows.Count - 1].Cells[3].Value = flight.Date;
            DataGrid.Rows[DataGrid.Rows.Count - 1].Cells[4].Value = flight.Time;
            DataGrid.Rows[DataGrid.Rows.Count - 1].Cells[5].Value = flight.Cost.ToString();
        }

    }

}