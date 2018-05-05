using System;
using System.Globalization;
using System.Windows.Forms;

namespace AviaCassa {

    /// <summary>
    /// Форма добавления/изменения рейса
    /// </summary>
    public partial class FormAdd : Form {

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAdd() {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для определения типа формы
        /// </summary>
        /// <param name="type">Тип формы. "add" - добавление строки, "mod" - редактирование строки</param>
        public FormAdd(string type) : this() {
            switch (type) {
                case "add":
                    ButtonAdd.Visible = true;
                    break;
                case "mod":
                    ButtonEdit.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Очищает текстовые поля
        /// </summary>
        private void ClearData() {
            TextBoxNumber.Clear();
            TextBoxCrew1.Clear();
            TextBoxCrew2.Clear();
            TextBoxCost.Clear();
        }

        /// <summary>
        /// Сформировать рейс из введенных данных
        /// </summary>
        /// <returns>Объект рейса, если введенные данные корректны</returns>
        private Flight CollectData() {
            var flight = new Flight();
            var isValid = true;

            try {
                flight.Number = int.Parse(TextBoxNumber.Text);
            } catch (FormatException) {
                isValid = false;
                MessageBox.Show("Введите целое положительное число в поле \"Номер\"");
            }

            if (TextBoxCrew1.Text == string.Empty || TextBoxCrew2.Text == string.Empty) {
                isValid = false;
            } else {
                flight.Crew = new[] {TextBoxCrew1.Text, TextBoxCrew2.Text};
            }

            if (ComboBoxType.Text == string.Empty) {
                isValid = false;
            } else {
                flight.Type = ComboBoxType.Text;
            }

            if (DatePicker.Value == default(DateTime)) {
                isValid = false;
            } else {
                flight.Date = TimePicker.Value.ToString("dd.MM.yyyy");
            }

            if (TimePicker.Value == default(DateTime)) {
                isValid = false;
            } else {
                flight.Time = TimePicker.Value.ToString("HH:mm:ss");
            }

            try {
                flight.Cost = int.Parse(TextBoxCost.Text);
            } catch (Exception) {
                isValid = false;
                MessageBox.Show("Введите целое положительное число в поле \"Стоимость\"!");
            }

            if (!isValid) {
                MessageBox.Show("Введите допустимые значения!");
                return null;
            }

            return flight;
        }

        /// <summary>
        /// Устанавливает значения текстовых полей
        /// в соответствии с выбранной строкой таблицы
        /// </summary>
        /// <param name="row"></param>
        internal void SetData(DataGridViewRow row) {
            TextBoxNumber.Text = row.Cells[0].Value.ToString();
            var crew = row.Cells[1].Value.ToString().Split(';');
            TextBoxCrew1.Text = crew[0];
            TextBoxCrew2.Text = crew[1];
            ComboBoxType.Text = row.Cells[2].Value.ToString();
            DatePicker.Text = row.Cells[3].Value.ToString();
            TimePicker.Text = row.Cells[4].Value.ToString();
            TextBoxCost.Text = row.Cells[5].Value.ToString();
        }

        /// <summary>
        /// Добавить рейс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e) {
            var flight = CollectData();
            if (flight == null) return;

            (Owner as FormMain ?? throw new ArgumentException("Owner is null")).AppendFlight(flight);
        }

        /// <summary>
        /// Изменить рейс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e) {
            var flight = CollectData();
            if (flight == null) return;

            (Owner as FormMain ?? throw new ArgumentException("Owner is null")).SetFlight(flight);
        }

        /// <summary>
        /// Очистить поля ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e) => ClearData();

        /// <summary>
        /// Отмена добавления рейса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    }

}