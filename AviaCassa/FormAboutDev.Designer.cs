namespace AviaCassa
{
    partial class FormAboutDev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutDev));
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(10, 286);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(764, 115);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "Приложение «Авиакасса»\r\nРазработала студентка Самарского Государственного Техниче" +
    "ского Университета\r\nСуфалова М.М.\r\nГруппа 3-АИТ-7\r\n2018 год";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAboutDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AviaCassa.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAboutDev";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "О Разработчике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
    }
}