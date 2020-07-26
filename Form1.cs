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

               

                XmlTextReader xml = new XmlTextReader("C:/Users/79042/Desktop/lol.xml");
                xml.WhitespaceHandling = WhitespaceHandling.None;
                int i = 0;
                while (xml.Read())
                {
                    if ((xml.NodeType == XmlNodeType.Element) &
                     (xml.Name == "subelement"))
                    {
                        listBox1.Items.Add("subelement " + i + " found");
                        i++;
                        listBox1.Items.Add(" " + xml.GetAttribute("attrib1"));
                        listBox1.Items.Add(" " + xml.GetAttribute("attrib2"));
                        while (xml.Read() & (xml.Name == "subsubelement"))
                        {
                            listBox1.Items.Add(" " + xml.GetAttribute("attr"));
                        }
                    }
                }
                xml.Close();










































            }




        }








        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
