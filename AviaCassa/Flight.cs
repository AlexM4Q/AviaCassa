using System;

namespace AviaCassa {

    public class Flight {

        private int _number;

        public int Number {
            get => _number;
            set {
                if (value < 0) throw new FormatException();
                _number = value;
            }
        }

        public string[] Crew { get; set; }

        public string Type { get; set; }

        public string Date { get; set; }

        public string Time;

        private int _cost;

        public int Cost {
            get => _cost;
            set {
                if (value < 0) throw new FormatException();
                _cost = value;
            }
        }

        public Flight() : this(0, null, null, null, null, 0) {
        }

        public Flight(int number, string[] crew, string type, string date, string time, int cost) {
            Number = number;
            Crew = crew;
            Type = type;
            Date = date;
            Time = time;
            Cost = cost;
        }

    }

}