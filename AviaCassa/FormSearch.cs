using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AviaCassa {

    public partial class FormSearch : Form {

        public FormSearch() {
            InitializeComponent();
        }

        private void NumberDiapason_CheckedChanged(object sender, EventArgs e) {
            num2Text.Enabled = numDiapCheck.Checked;
        }

        private void typeOrCheck_CheckedChanged(object sender, EventArgs e) {
            type2Text.Enabled = typeOrCheck.Checked;
        }

        private void CheckBoxDateDiapason_CheckedChanged(object sender, EventArgs e) => DatePickerDiapason.Enabled = CheckBoxDateDiapason.Checked;

        private void CheckBoxTimeDiapason_CheckedChanged(object sender, EventArgs e) => TimePickerDiapason.Enabled = CheckBoxTimeDiapason.Checked;

        private void CheckBoxCostDiapason_CheckedChanged(object sender, EventArgs e) {
            cost2Text.Enabled = CheckBoxCostDiapason.Checked;
        }

        //----------------------------------- Блок поиска ---------------------------------------------------------
        private IEnumerable<Flight> FindData(List<Flight> flights) {
            var result = flights; // искомые элементы - все переданные

            // отсев по номеру рейса
            if (numText.Text != "") // если указан номер рейса 
                result = FindByNum(result); // результатом будет отсеянное по номеру
            // и теперь результат хранит в себе отсеянные 
            // по номеру рейса записи            

            if (crewText.Text != "") // если указан член экипажа
                result = FindByCrew(result); // результатом будет отсеянное по члену экипажа
            // и теперь результат хранит в себе отсеянные 
            // по члену экипажа записи

            /*
                По такому же принципу действует дальнейший поиск.
                Если были указаны параметры поиска, результатом становятся записи,
                удовлетворяющие условию.
                И они же подаются для поиска среди них записей, удовлетворяющих
                следующей ступени поиска.
            */

            if (typeText.Text != "")
                result = FindByType(result);

            result = FindByDate(result);
            result = FindByTime(result);

            if (costText.Text != "")
                result = FindByCost(result);

            return result;
        }

        /// <summary>
        /// Поиск по номеру рейса
        /// </summary>
        /// <param name="flights">Массив рейсов</param>
        /// <returns></returns>
        private List<Flight> FindByNum(IEnumerable<Flight> flights) {
            return numDiapCheck.Checked
                ? flights.Where(f => int.Parse(numText.Text) <= f.Number && f.Number <= int.Parse(num2Text.Text)).ToList()
                : flights.Where(f => int.Parse(numText.Text) == f.Number).ToList();
        }

        /// <summary>
        /// Поиск по членам экипажа
        /// </summary>
        /// <param name="flights">Массив рейсов</param>
        /// <returns></returns>
        private List<Flight> FindByCrew(IEnumerable<Flight> flights) {
            return flights.Where(f => f.Crew.Contains(crewText.Text)).ToList();
        }

        /// <summary>
        /// Поиск по типу рейса
        /// </summary>
        /// <param name="flights">Массив рейсов</param>
        /// <returns></returns>
        private List<Flight> FindByType(IEnumerable<Flight> flights) {
            return typeOrCheck.Checked
                ? flights.Where(f => f.Type.Equals(typeText.Text) || f.Type.Equals(type2Text.Text)).ToList()
                : flights.Where(f => f.Type.Equals(typeText.Text)).ToList();
        }

        /// <summary>
        /// Поиск по датее рейса
        /// </summary>
        /// <param name="flights">Массив рейсов</param>
        /// <returns></returns>
        private List<Flight> FindByDate(IEnumerable<Flight> flights) {
            return CheckBoxDateDiapason.Checked
                ? flights.Where(f => DatePicker.Value <= Convert.ToDateTime(f.Date) && Convert.ToDateTime(f.Date) <= DatePickerDiapason.Value).ToList()
                : flights.Where(f => DatePicker.Value == Convert.ToDateTime(f.Date)).ToList();
        }

        /// <summary>
        /// Поиск по времени рейса
        /// </summary>
        /// <param name="flights">Массив рейсов</param>
        /// <returns></returns>
        private List<Flight> FindByTime(IEnumerable<Flight> flights) {
            return CheckBoxTimeDiapason.Checked
                ? flights.Where(f => TimePicker.Value <= Convert.ToDateTime(f.Time) && Convert.ToDateTime(f.Time) <= TimePickerDiapason.Value).ToList()
                : flights.Where(f => TimePicker.Value == Convert.ToDateTime(f.Time)).ToList();
        }

        /// <summary>
        /// Поиск по стоимости рейса
        /// </summary>
        /// <param name="flights">Массив рейсов</param>
        /// <returns></returns>
        private List<Flight> FindByCost(IEnumerable<Flight> flights) {
            return CheckBoxCostDiapason.Checked
                ? flights.Where(f => int.Parse(costText.Text) <= f.Cost && f.Cost <= int.Parse(cost2Text.Text)).ToList()
                : flights.Where(f => int.Parse(costText.Text) == f.Cost).ToList();
        }
        //--------------------------- Конец блока поиска --------------------------------------------------------


        // Обработка нажатия кнопки поиска
        private void ButtonSearch_Click(object sender, EventArgs e) {
            if (Owner is FormMain main) {
                var formResult = new FormResult {Owner = this};
                formResult.FillTab(FindData(main.ExportFlights()));
                formResult.Show();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    }

}