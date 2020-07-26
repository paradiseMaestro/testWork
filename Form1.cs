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
using System.IO;

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





                String xmlString = File.ReadAllText("C:/Users/79042/Desktop/XMLFile1.xml");
                XDocument xdoc = XDocument.Load(new StringReader(xmlString));

                var xmlList = (from article in xdoc.Descendants("article")
                               select new
                               {
                                   id = article.Descendants("id").SingleOrDefault(),
                                   name = article.Descendants("name").SingleOrDefault(),
                                   photo_s = article.Descendants("photo_s").SingleOrDefault(),
                                   photo_m = article.Descendants("photo_m").SingleOrDefault(),
                                   photo_l = article.Descendants("photo_l").SingleOrDefault(),
                                   date = article.Descendants("id").SingleOrDefault()
                               }).ToList();

                var articleList = (from item in xmlList
                                   select new
                                   {
                                       id = item.id != null ? item.id.Value : null,
                                       name = item.name != null ? item.name.Value : null,
                                       photo_s = item.photo_s != null ? item.photo_s.Value : null,
                                       photo_m = item.photo_m != null ? item.photo_m.Value : null,
                                       photo_l = item.photo_l != null ? item.photo_l.Value : null,
                                       date = item.date != null ? item.date.Value : null
                                   });

                foreach (var article in articleList)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                        article.id, article.date, article.name, article.photo_l, article.photo_m, article.photo_s);
                }
                






























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
