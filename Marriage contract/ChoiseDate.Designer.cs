namespace Marriage_contract
{
    partial class ChoiseDate
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
            label_year = new Label();
            label_month = new Label();
            label_day_month = new Label();
            label_day_weak = new Label();
            comboBox_year = new ComboBox();
            comboBox_month = new ComboBox();
            comboBox_day_month = new ComboBox();
            comboBox_day_weak = new ComboBox();
            button = new Button();
            SuspendLayout();
            // 
            // label_year
            // 
            label_year.AutoSize = true;
            label_year.Font = new Font("Segoe UI", 15F);
            label_year.Location = new Point(66, 70);
            label_year.Name = "label_year";
            label_year.Size = new Size(50, 28);
            label_year.TabIndex = 0;
            label_year.Text = "שנה";
            // 
            // label_month
            // 
            label_month.AutoSize = true;
            label_month.Font = new Font("Segoe UI", 15F);
            label_month.Location = new Point(239, 70);
            label_month.Name = "label_month";
            label_month.Size = new Size(56, 28);
            label_month.TabIndex = 1;
            label_month.Text = "חודש";
            // 
            // label_day_month
            // 
            label_day_month.AutoSize = true;
            label_day_month.Font = new Font("Segoe UI", 15F);
            label_day_month.Location = new Point(415, 70);
            label_day_month.Name = "label_day_month";
            label_day_month.Size = new Size(110, 28);
            label_day_month.TabIndex = 2;
            label_day_month.Text = "היום בחודש";
            // 
            // label_day_weak
            // 
            label_day_weak.AutoSize = true;
            label_day_weak.Font = new Font("Segoe UI", 15F);
            label_day_weak.Location = new Point(593, 70);
            label_day_weak.Name = "label_day_weak";
            label_day_weak.Size = new Size(110, 28);
            label_day_weak.TabIndex = 3;
            label_day_weak.Text = "היום בשבוע";
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Items.AddRange(new object[] { "תשע״ד", "תשע״ה", "תשע״ו", "תשע״ז", "תשע״ח", "תשע״ט", "תש״פ", "תשפ״א", "תשפ״ב", "תשפ״ג", "תשפ״ד", "תשפ״ה", "תשפ״ו", "תשפ״ז", "תשפ״ח", "תשפ״ט", "תש״צ" });
            comboBox_year.Location = new Point(42, 115);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(121, 23);
            comboBox_year.TabIndex = 4;
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Items.AddRange(new object[] { "תשרי", "חשוון", "כסליו", "טבת", "שבט", "אדר", "אדר א", "אדר ב", "ניסן", "אייר", "סיון", "תמוס", "אב", "אלול" });
            comboBox_month.Location = new Point(214, 115);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(121, 23);
            comboBox_month.TabIndex = 5;
            // 
            // comboBox_day_month
            // 
            comboBox_day_month.FormattingEnabled = true;
            comboBox_day_month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox_day_month.Location = new Point(388, 115);
            comboBox_day_month.Name = "comboBox_day_month";
            comboBox_day_month.Size = new Size(121, 23);
            comboBox_day_month.TabIndex = 6;
            // 
            // comboBox_day_weak
            // 
            comboBox_day_weak.FormattingEnabled = true;
            comboBox_day_weak.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBox_day_weak.Location = new Point(568, 115);
            comboBox_day_weak.Name = "comboBox_day_weak";
            comboBox_day_weak.Size = new Size(121, 23);
            comboBox_day_weak.TabIndex = 7;
            // 
            // button
            // 
            button.Location = new Point(56, 355);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 8;
            button.Text = "אישור";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // ChoiseDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(button);
            Controls.Add(comboBox_day_weak);
            Controls.Add(comboBox_day_month);
            Controls.Add(comboBox_month);
            Controls.Add(comboBox_year);
            Controls.Add(label_day_weak);
            Controls.Add(label_day_month);
            Controls.Add(label_month);
            Controls.Add(label_year);
            Name = "ChoiseDate";
            Text = "ChoiseDate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_year;
        private Label label_month;
        private Label label_day_month;
        private Label label_day_weak;
        private ComboBox comboBox_year;
        private ComboBox comboBox_month;
        private ComboBox comboBox_day_month;
        private ComboBox comboBox_day_weak;
        private Button button;
    }
}