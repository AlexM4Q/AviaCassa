namespace AviaCassa {
    partial class FormSearch {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.numDiapCheck = new System.Windows.Forms.CheckBox();
            this.num2Text = new System.Windows.Forms.TextBox();
            this.crewText = new System.Windows.Forms.TextBox();
            this.typeText = new System.Windows.Forms.TextBox();
            this.type2Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeOrCheck = new System.Windows.Forms.CheckBox();
            this.costText = new System.Windows.Forms.TextBox();
            this.cost2Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxDateDiapason = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBoxTimeDiapason = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBoxCostDiapason = new System.Windows.Forms.CheckBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePickerDiapason = new System.Windows.Forms.DateTimePicker();
            this.DatePickerDiapason = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // numText
            // 
            this.numText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numText.Location = new System.Drawing.Point(121, 12);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(150, 20);
            this.numText.TabIndex = 1;
            // 
            // numDiapCheck
            // 
            this.numDiapCheck.AutoSize = true;
            this.numDiapCheck.BackColor = System.Drawing.Color.Transparent;
            this.numDiapCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDiapCheck.Location = new System.Drawing.Point(13, 40);
            this.numDiapCheck.Name = "numDiapCheck";
            this.numDiapCheck.Size = new System.Drawing.Size(85, 17);
            this.numDiapCheck.TabIndex = 2;
            this.numDiapCheck.Text = "Диапазон";
            this.numDiapCheck.UseVisualStyleBackColor = false;
            this.numDiapCheck.CheckedChanged += new System.EventHandler(this.NumberDiapason_CheckedChanged);
            // 
            // num2Text
            // 
            this.num2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num2Text.Enabled = false;
            this.num2Text.Location = new System.Drawing.Point(121, 38);
            this.num2Text.Name = "num2Text";
            this.num2Text.Size = new System.Drawing.Size(150, 20);
            this.num2Text.TabIndex = 3;
            // 
            // crewText
            // 
            this.crewText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crewText.Location = new System.Drawing.Point(121, 64);
            this.crewText.Name = "crewText";
            this.crewText.Size = new System.Drawing.Size(150, 20);
            this.crewText.TabIndex = 4;
            // 
            // typeText
            // 
            this.typeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeText.Location = new System.Drawing.Point(121, 90);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(150, 20);
            this.typeText.TabIndex = 5;
            // 
            // type2Text
            // 
            this.type2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.type2Text.Enabled = false;
            this.type2Text.Location = new System.Drawing.Point(121, 116);
            this.type2Text.Name = "type2Text";
            this.type2Text.Size = new System.Drawing.Size(150, 20);
            this.type2Text.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Экипаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип";
            // 
            // typeOrCheck
            // 
            this.typeOrCheck.AutoSize = true;
            this.typeOrCheck.BackColor = System.Drawing.Color.Transparent;
            this.typeOrCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOrCheck.Location = new System.Drawing.Point(13, 118);
            this.typeOrCheck.Name = "typeOrCheck";
            this.typeOrCheck.Size = new System.Drawing.Size(49, 17);
            this.typeOrCheck.TabIndex = 9;
            this.typeOrCheck.Text = "Или";
            this.typeOrCheck.UseVisualStyleBackColor = false;
            this.typeOrCheck.CheckedChanged += new System.EventHandler(this.typeOrCheck_CheckedChanged);
            // 
            // costText
            // 
            this.costText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.costText.Location = new System.Drawing.Point(121, 246);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(150, 20);
            this.costText.TabIndex = 14;
            // 
            // cost2Text
            // 
            this.cost2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cost2Text.Enabled = false;
            this.cost2Text.Location = new System.Drawing.Point(121, 272);
            this.cost2Text.Name = "cost2Text";
            this.cost2Text.Size = new System.Drawing.Size(150, 20);
            this.cost2Text.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата";
            // 
            // DateDiapasonCheck
            // 
            this.CheckBoxDateDiapason.AutoSize = true;
            this.CheckBoxDateDiapason.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxDateDiapason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxDateDiapason.Location = new System.Drawing.Point(13, 170);
            this.CheckBoxDateDiapason.Name = "CheckBoxDateDiapason";
            this.CheckBoxDateDiapason.Size = new System.Drawing.Size(85, 17);
            this.CheckBoxDateDiapason.TabIndex = 17;
            this.CheckBoxDateDiapason.Text = "Диапазон";
            this.CheckBoxDateDiapason.UseVisualStyleBackColor = false;
            this.CheckBoxDateDiapason.CheckedChanged += new System.EventHandler(this.CheckBoxDateDiapason_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Время";
            // 
            // TimeDiapasonCheck
            // 
            this.CheckBoxTimeDiapason.AutoSize = true;
            this.CheckBoxTimeDiapason.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxTimeDiapason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxTimeDiapason.Location = new System.Drawing.Point(13, 222);
            this.CheckBoxTimeDiapason.Name = "CheckBoxTimeDiapason";
            this.CheckBoxTimeDiapason.Size = new System.Drawing.Size(85, 17);
            this.CheckBoxTimeDiapason.TabIndex = 19;
            this.CheckBoxTimeDiapason.Text = "Диапазон";
            this.CheckBoxTimeDiapason.UseVisualStyleBackColor = false;
            this.CheckBoxTimeDiapason.CheckedChanged += new System.EventHandler(this.CheckBoxTimeDiapason_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Стоимость";
            // 
            // costDiapCheck
            // 
            this.CheckBoxCostDiapason.AutoSize = true;
            this.CheckBoxCostDiapason.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxCostDiapason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxCostDiapason.Location = new System.Drawing.Point(13, 274);
            this.CheckBoxCostDiapason.Name = "CheckBoxCostDiapason";
            this.CheckBoxCostDiapason.Size = new System.Drawing.Size(85, 17);
            this.CheckBoxCostDiapason.TabIndex = 21;
            this.CheckBoxCostDiapason.Text = "Диапазон";
            this.CheckBoxCostDiapason.UseVisualStyleBackColor = false;
            this.CheckBoxCostDiapason.CheckedChanged += new System.EventHandler(this.CheckBoxCostDiapason_CheckedChanged);
            // 
            // buttFind
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.Location = new System.Drawing.Point(13, 325);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 22;
            this.ButtonSearch.Text = "Искать";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePicker.CustomFormat = "HH.mm.ss";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(121, 194);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(150, 20);
            this.TimePicker.TabIndex = 23;
            // 
            // TimePickerDiapason
            // 
            this.TimePickerDiapason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePickerDiapason.CustomFormat = "HH.mm.ss";
            this.TimePickerDiapason.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerDiapason.Location = new System.Drawing.Point(121, 220);
            this.TimePickerDiapason.Name = "TimePickerDiapason";
            this.TimePickerDiapason.Size = new System.Drawing.Size(150, 20);
            this.TimePickerDiapason.TabIndex = 24;
            // 
            // DatePickerDiapason
            // 
            this.DatePickerDiapason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerDiapason.CustomFormat = "dd.MM.yyyy";
            this.DatePickerDiapason.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerDiapason.Location = new System.Drawing.Point(121, 170);
            this.DatePickerDiapason.Name = "DatePickerDiapason";
            this.DatePickerDiapason.Size = new System.Drawing.Size(150, 20);
            this.DatePickerDiapason.TabIndex = 25;
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.CustomFormat = "dd.MM.yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(121, 144);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(150, 20);
            this.DatePicker.TabIndex = 26;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(196, 325);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 27;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormSearch
            // 
            this.AcceptButton = this.ButtonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AviaCassa.Properties.Resources.background;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DatePickerDiapason);
            this.Controls.Add(this.TimePickerDiapason);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.CheckBoxCostDiapason);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckBoxTimeDiapason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckBoxDateDiapason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cost2Text);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.typeOrCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type2Text);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.crewText);
            this.Controls.Add(this.num2Text);
            this.Controls.Add(this.numDiapCheck);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSearch";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.CheckBox numDiapCheck;
        private System.Windows.Forms.TextBox num2Text;
        private System.Windows.Forms.TextBox crewText;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.TextBox type2Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox typeOrCheck;
        private System.Windows.Forms.TextBox costText;
        private System.Windows.Forms.TextBox cost2Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxDateDiapason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxTimeDiapason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBoxCostDiapason;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker TimePickerDiapason;
        private System.Windows.Forms.DateTimePicker DatePickerDiapason;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button ButtonCancel;
    }
}