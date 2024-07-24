using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Marriage_contract
{
    internal class XmlService
    {
        string _Path;
        public XmlService(string path)
        {
            _Path = path;
            Check();
        }
        /// <summary>
        /// פונקציה שמופעלת בכל יצירת המופע שבודקת האם קיים כבר קובץ כזה או לא ואז יוצרת אותו
        /// </summary>
        private void Check()
        {
            if (!File.Exists(_Path))
            {
                XElement XmlTree = new XElement("Queries");
                XmlTree.Save(_Path);
            }
        }
        /// <summary>
        /// פונקציה שמוסיפה ערכים לקובץ XML
        /// </summary>
        public void add(XElement item)
        {
            XElement MyFile = XElement.Load(_Path);
            MyFile.Add(item);
            MyFile.Save(_Path);
        }
        /// <summary>
        /// פונקציה שמוחקת ערכים מקובץ XML
        /// </summary>
        public void remove(string item)
        {
            XElement MyFile = XElement.Load(_Path);
            MyFile.Element(item).Remove();
            MyFile.Save(_Path);
        }
        public XElement SelectLastItem()
        {
            XElement select = null;
            XElement MyFile = XElement.Load(_Path);
            var items = MyFile.Descendants("Query").ToList();
            select = items.Last();
            return select;
        }



    }
}
