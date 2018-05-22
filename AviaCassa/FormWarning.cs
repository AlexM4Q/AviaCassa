using System;
using System.Windows.Forms;

namespace AviaCassa {

    public sealed partial class FormWarning : Form {

        public string Title {
            get => Text;
            set => Text = value;
        }

        public string Message {
            get => WarningLabel.Text;
            set => WarningLabel.Text = value;
        }

        public FormWarning() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) => Close();

    }

}