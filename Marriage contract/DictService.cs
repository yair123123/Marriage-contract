﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Marriage_contract
{
    internal static class DictService
    {
        /// <summary>
        /// מילון שממיר ערכים ממספר לסארינג של מילים
        /// </summary>
        public static Dictionary<int, string> DaysMonth = new Dictionary<int, string>()
        {
            {1,"יום אחד" },
            {2," שני ימים" },
            {3, "  שלושה ימים"},
            {4, "ארבעה ימים"},
            {5, " חמישה ימים"},
            {6, "שישה ימים"},
            {7, "שבעה ימים"},
            {8, "שמונה ימים"},
            {9, "תשעה ימים"},
            {10, "עשרה ימים"},
            {11, "אחד עשר ימים"},
            {12, "שנים עשר ימים"},
            {13, " שלושה עשר ימים"},
            {14, "ארבעה עשר ימים"},
            {15, "חמישה עשר ימים"},
            {16, "שישה עשר ימים"},
            {17, "שבעה עשר ימים"},
            {18, "שמונה עשר ימים"},
            {19, "תשעה עשר ימים"},
            {20, "עשרים ימים"},
            {21, "עשרים ואחד ימים"},
            {22, "עשרים ושניים ימים"},
            {23, "עשרים ושלושה ימים"},
            {24, "עשרים וארבעה ימים"},
            {25, "עשרים וחמישה ימים"},
            {26, "עשרים ושישה ימים"},
            {27, "עשרים ושבעה ימים"},
            {28, "עשרים ושמונה ימים"},
            {29, "עשרים ותשעה ימים"},
            {30, "שלושים ימים"}
        };
        /// <summary>
        /// מילון שממיר ערכים מסטרינג של השנה בראשי תיבות לסטרינג של מילים
        /// </summary>

        public static Dictionary<string, string> years = new Dictionary<string, string>()
        {
            {"תשע״ד", "חמשת אלפים ושבע מאות ושבעים וארבע"},
            {"תשע״ה", "חמשת אלפים ושבע מאות ושבעים וחמש"},
            {"תשע״ו", "חמשת אלפים ושבע מאות ושבעים ושש"},
            {"תשע״ז", "חמשת אלפים ושבע מאות ושבעים ושבע"},
            {"תשע״ח", "חמשת אלפים ושבע מאות ושבעים ושמונה"},
            {"תשע״ט", "חמשת אלפים ושבע מאות ושבעים ותשע"},
            {"תש״פ", "חמשת אלפים ושבע מאות ושמונים"},
            {"תשפ״א", "חמשת אלפים ושבע מאות ושמונים ואחת"},
            {"תשפ״ב", "חמשת אלפים ושבע מאות ושמונים ושתיים"},
            {"תשפ״ג", "חמשת אלפים ושבע מאות ושמונים ושלוש"},
            {"תשפ״ד", "חמשת אלפים ושבע מאות ושמונים וארבע"},
            {"תשפ״ה", "חמשת אלפים ושבע מאות ושמונים וחמש"},
            {"תשפ״ו", "חמשת אלפים ושבע מאות ושמונים ושש"},
            {"תשפ״ז", "חמשת אלפים ושבע מאות ושמונים ושבע"},
            {"תשפ״ח", "חמשת אלפים ושבע מאות ושמונים ושמונה"},
            {"תשפ״ט", "חמשת אלפים ושבע מאות ושמונים ותשע"},
            {"תש״צ", "חמשת אלפים ושבע מאות ותשעים"}
        };




    }
}
