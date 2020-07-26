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
using System.Text.RegularExpressions;

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





                //String xmlString = File.ReadAllText("C:/Users/79042/Desktop/XMLFile1.xml");
                //XDocument xdoc = XDocument.Load(new StringReader(xmlString));

               // var xmlList = (from article in xdoc.Descendants("book")
             //                  select new
            //                   {
             //                      category = article.Attribute("category"),
           //                        title = article.Descendants("title").SingleOrDefault(),
           //                        year = article.Descendants("year").SingleOrDefault(),
           //                        price = article.Descendants("price").SingleOrDefault(),
           //                    }).ToList();

            //    var articleList = (from item in xmlList
              //                     select new
             //                      {
             //                          title = item.title != null ? item.title.Value : null,
             //                         author = item.author != null ? item.author.Value : null,
              //                         year = item.year != null ? item.year.Value : null,
              //                         price = item.price != null ? item.price.Value : null,
              //                         category = item.category != null ? item.category.Value : null,

              //                     });

            //    foreach (var article in articleList)
            //    {
            //        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t",
            //            article.title, article.author, article.year, article.price, article.category);
            //    }


























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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void infoHTML_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.TableName = "Bank";

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                //if (dataGridView1.Columns[i].Visible) // Add's only Visible columns (if you need it)
                //{
                string headerText = dataGridView1.Columns[i].HeaderText;
                headerText = Regex.Replace(headerText, "[-/, ]", "_");

                DataColumn column = new DataColumn(headerText);
                dt.Columns.Add(column);
                //}
            }

            foreach (DataGridViewRow DataGVRow in dataGridView1.Rows)
            {
                DataRow dataRow = dt.NewRow();
                // Add's only the columns that you want
                //dataRow["BLZ"] = DataGVRow.Cells["BLZ"].Value;
                //dataRow["Test_1"] = DataGVRow.Cells["Test 1"].Value;
                dataRow["lang"] = DataGVRow.Cells["lang"].Value;
                //dataRow["PIN_TAN_Test_URL"] = DataGVRow.Cells["PIN/TAN-Test URL"].Value;

                dt.Rows.Add(dataRow); //dt.Columns.Add();
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            //Finally the save part:
            XmlTextWriter xmlSave = new XmlTextWriter("C:/Users/79042/Desktop/XMLFile5.xml", Encoding.UTF8);
            xmlSave.Formatting = Formatting.Indented;
            ds.DataSetName = "Data";
            ds.WriteXml(xmlSave);
            xmlSave.Close();
        }
    }
}
