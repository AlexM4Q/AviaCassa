using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AviaCassa {

    public partial class FormMain : Form {

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            new FormAuth(this).Show();
        }

        /// <summary>
        /// Экспорт рейсов из таблицы
        /// </summary>
        internal List<Flight> ExportFlights() {
            return (from DataGridViewRow row in DataGrid.Rows
                    select new Flight(
                        int.Parse(row.Cells[0].Value.ToString()),
                        row.Cells[1].Value.ToString().Split(';'),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        int.Parse(row.Cells[5].Value.ToString()))
                ).ToList();
        }

        /// <summary>
        /// Добавляет рейс в таблицу
        /// </summary>
        /// <param name="flight">Рейс</param>
        internal void AppendFlight(Flight flight) => SetFlight(DataGrid.Rows.Add(), flight);

        /// <summary>
        /// Изменяет значения выделенного рейса
        /// </summary>
        /// <param name="flight">Рейс</param>
        internal void SetFlight(Flight flight) => SetFlight(DataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected), flight);

        /// <summary>
        /// Установить рейс в строку таблицы по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="flight">Рейс</param>
        private void SetFlight(int index, Flight flight) {
            DataGrid.Rows[index].Cells[0].Value = flight.Number.ToString();
            DataGrid.Rows[index].Cells[1].Value = flight.Crew[0] + ';' + flight.Crew[1];
            DataGrid.Rows[index].Cells[2].Value = flight.Type;
            DataGrid.Rows[index].Cells[3].Value = flight.Date;
            DataGrid.Rows[index].Cells[4].Value = flight.Time;
            DataGrid.Rows[index].Cells[5].Value = flight.Cost.ToString();
        }

        /// <summary>
        /// Открыть таблицу из xml-файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemOpen_Click(object sender, EventArgs e) {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                var flights = XmlWorker.GetFlights(OpenFileDialog.FileName);

                DataGrid.Rows.Clear();
                foreach (var flight in flights) {
                    AppendFlight(flight);
                }
            }
        }

        /// <summary>
        /// Сохранение таблицы в xml-файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemSave_Click(object sender, EventArgs e) {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK) {
                XmlWorker.WriteFlights(ExportFlights(), SaveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Изменить запись рейса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemEdit_Click(object sender, EventArgs e) {
            if (DataGrid.Rows.Count > 0) {
                var formMod = new FormAdd("mod") {Owner = this};
                formMod.SetData(DataGrid.Rows[DataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected)]);
                formMod.Show();
            } else {
                MessageBox.Show("Нечего изменять");
            }
        }

        /// <summary>
        /// Удаление рейса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemRemove_Click(object sender, EventArgs e) {
            if (DataGrid.Rows.Count > 0) {
                DataGrid.Rows.RemoveAt(DataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected));
            } else {
                MessageBox.Show("Нечего удалять");
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e) => Application.Exit();

        private void ButtonAdd_Click(object sender, EventArgs e) => new FormAdd("add") {Owner = this}.Show();

        private void ButtonSearch_Click(object sender, EventArgs e) => new FormSearch {Owner = this}.Show();

        private void MenuItemHelp_Click(object sender, EventArgs e) => new FormAboutHelp {Owner = this}.Show();

        private void MenuItemProgram_Click(object sender, EventArgs e) => new FormAboutProgram {Owner = this}.Show();

        private void MenuItemDev_Click(object sender, EventArgs e) => new FormAboutDev {Owner = this}.Show();

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            var messageBoxResult = MessageBox.Show("Вы уверены, что хотите покиинуть приложение?", "АвиаКасса - Выход", MessageBoxButtons.YesNo);
            e.Cancel = messageBoxResult != DialogResult.Yes;
        }

    }

}