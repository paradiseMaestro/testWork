using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
namespace test
{

   











    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //XmlTextWriter textWritter = new XmlTextWriter("C:/Users/79042/Desktop/i.xml", Encoding.UTF8);

        private void openXML_Click(object sender, EventArgs e)
        {
            //String srcFile = "";
            //OpenFileDialog fl = new OpenFileDialo();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //User user = new User("SYKa", 34, 45);
                //var xml = new XmlTextWriter("C:/Users/79042/Desktop/lol.xml", null);

                // XDocument xdoc = new XDocument();

                //XElement el1 = new XElement("MyCont");
                //XAttribute attr = new XAttribute("huet","hk");
                // XElement el2 = new XElement("Contact", "Alex");
                //el2.Add(attr);
                //el1.Add(el2);
                //xdoc.Add(el1);
                //xdoc.Save("C:/Users/79042/Desktop/lol.xml");


            XDocument xdoc = new XDocument();
                // создаем корневой элемент
                XElement el1 = new XElement("MyContacts");
                // создаем атрибут
                XAttribute attr = new XAttribute("TelephoneNumber", "906181733");
                //создает элемент
                XElement el2 = new XElement("Contact", "Alex");

                //помещаем в элемент, атрибут
                el2.Add(attr);
                //помещаем элелемент в корневой элемент
                el1.Add(el2);
                //помещаем элелементы в документ
                xdoc.Add(el1);
                //сохраняем документ
                xdoc.Save("C:/Users/79042/Desktop/lol5.xml");



































            }




        }








        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
        }
    }
}
