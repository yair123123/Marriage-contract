using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Marriage_contract
{
    public partial class ChoiseDate : Form
    {
            XmlService MyFile = new XmlService("Details.xml");
        public ChoiseDate()
        {
            InitializeComponent();
        }

        public void SaveDetails()
        {
            // בשורות הבאות ניצור משתנים, כאשר הרגילים זה לפני הפרסור במילון, והמשתנים שנוסף להם ניו, זה לאחר הפרסור 

            string DayWeak = comboBox_day_weak.Text;
            int DayMonth = int.Parse(comboBox_day_month.Text);
            string Month = comboBox_month.Text;
            string Year = comboBox_year.Text;
            string DayMonthNew;
            string DayWeakNew = DayWeak;
            string MonthNew;
            string Result;
            int IndexThisMonth = comboBox_month.Items.IndexOf(Month);
            // בשורות הבאות נבדוק מה החודש הבא אחריו כדי שבזמן ראש חודש נוכל להציג את הראש חודש 
            if (IndexThisMonth > 0)
            {
                MonthNew = comboBox_month.Items[IndexThisMonth - 1].ToString();
            }
            else { MonthNew = comboBox_month.Items[comboBox_month.Items.Count - 1].ToString(); }
                 

            // נעשה כמה תנאים למקרים מיוחדים שלא כללתי אותם במילון כמו ראש חודש או ראשון = אחד
            if (DayWeak == "ראשון") { DayWeakNew = "אחד"; }

            DayMonthNew = DictService.DaysMonth[DayMonth];

            string YearNew = DictService.years[Year];

            if (DayMonth == 30)
            {
                Result = $"ב{DayWeakNew} בשבת  30 יום לירח  {MonthNew} שהוא ראש חודש {Month} בשנת {YearNew} לבריאת העולם";
            }
            else
            {
                Result = $"ב{DayWeakNew} בשבת  {DayMonthNew} לירח {Month} בשנת {YearNew} לבריאת העולם";
            }

            // ניצור מופע מהקלאס שבנינו ונכניס את הערכים לקובץ XML
            MyFile.add(new XElement("Query",
                new XElement("DayWeak", DayWeak),
                new XElement("DayMonth", DayMonth),
                new XElement("Month", Month),
                new XElement("Year", Year),
                new XElement("Result", Result)
                )
            );
        }
        /// <summary>
        /// זו תהיה אירוע לחיצה שכשאשר המשתמש ילחץ על הכפתור אישור אני אשמור את המידע בקובץ 
        /// XML ואציג את המידע בהודעה
        /// (יש פה קצת בעיה עם עברית ואנגלית)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            SaveDetails();
            //   אני מעדיף לשלוף את ההודעה מתוך קובת הXML  כדי להיות בטוח שאכן הפרטים נשמרו 
            if (MyFile.SelectLastItem() is null)
            {
                MessageBox.Show("אני מצטער חלה שגיאה");
            }
            else
            {
                XElement resultAttribute = MyFile.SelectLastItem().Element("Result");
                MessageBox.Show(resultAttribute.Value);
            }
        }
    }
}
