using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Office.Interop.Word;
namespace YazLab_1
{
    public partial class Form8 : Form
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        private const String PATH = @"C:\Program Files\Common Files\ROY\basket.xml";
        String filename;
        StringBuilder sb = new StringBuilder();
        public Form8()
        {
            InitializeComponent();
            if (!System.IO.File.Exists(PATH))
            {
                MessageBox.Show("Sepet Bulunamadı", "Hata");
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                doc.Load(PATH);
                root = doc.DocumentElement;
                if (root.ChildNodes.Count < 1)
                {
                    MessageBox.Show("Sepet Boş !", "Hata");
                    Form4 form4 = new Form4();
                    form4.Show();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc = new Microsoft.Office.Interop.Word.Document();
            Object oMissing = System.Reflection.Missing.Value;
            wordDoc = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            word.Visible = false;
            Object filepath = filename + ".html";
            Object confirmconversion = System.Reflection.Missing.Value;
            Object readOnly = false;
            Object saveto = filename + ".doc";
            Object oallowsubstitution = System.Reflection.Missing.Value;

            wordDoc = word.Documents.Open(ref filepath, ref confirmconversion, ref readOnly, ref oMissing,
                                          ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                          ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                          ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            object fileFormat = WdSaveFormat.wdFormatDocument;
            wordDoc.SaveAs(ref saveto,ref fileFormat,ref oMissing,ref oMissing,ref oMissing,ref oMissing,ref oMissing,ref oMissing,ref oMissing,ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oallowsubstitution, ref oMissing, ref oMissing);
            wordDoc.Close(ref oMissing,ref oMissing,ref oMissing);
            if (System.IO.File.Exists(saveto.ToString())) {
                MessageBox.Show("Aktarma Başarılı","Basarili"); }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                textBox1.Text = filename;
            }
            htmlout();
            webBrowser1.Navigate(filename+".html");
        }

        private void htmlout()
        {
            XmlNodeList list = doc.SelectNodes("//Referans");
            sb.AppendLine("<html>");
            sb.AppendLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            sb.AppendLine("<body>");
            sb.AppendLine("<h1>Kaynakça</h1>");
            foreach(XmlNode node in list)
            {
                if (node.ChildNodes[1].InnerText == "Kitap")
                {
                    sb.AppendLine("<p>"+node.ChildNodes[2].InnerText+" ("+node.ChildNodes[3].InnerText+"). <i>"+ node.ChildNodes[5].InnerText +",</i> "
                       + node.ChildNodes[9].InnerText+","+node.ChildNodes[10].InnerText +"." + "</p>");
                
                }
                if (node.ChildNodes[1].InnerText == "Ed.Kitap")
                {
                    sb.AppendLine("<p>" + node.ChildNodes[2].InnerText + " (" + node.ChildNodes[3].InnerText + "). " + node.ChildNodes[5].InnerText + ",In "+
                    node.ChildNodes[4]+ "(Ed.), <i>" + node.ChildNodes[6].InnerText +",</i>(pp. "+node.ChildNodes[7].InnerText +"),"+ node.ChildNodes[9].InnerText +
                    "," + node.ChildNodes[10].InnerText + "." + "</p>");
                
                }
                if (node.ChildNodes[1].InnerText == "Dergi")
                {
                    sb.AppendLine("<p>" + node.ChildNodes[2].InnerText + " (" + node.ChildNodes[3].InnerText + "). " + node.ChildNodes[5].InnerText +
                    ". <i>" + node.ChildNodes[6].InnerText + ",</i>"+node.ChildNodes[8].InnerText+"( " + node.ChildNodes[7].InnerText + ")," + "." + "</p>");
                }
                if (node.ChildNodes[1].InnerText == "Internet")
                {
                    sb.AppendLine("<p>" + node.ChildNodes[2].InnerText + " (" + node.ChildNodes[3].InnerText + "). <i>" + node.ChildNodes[5].InnerText + ",</i> "
                       +"Retrieved, " +node.ChildNodes[11].InnerText+ ", from,"+node.ChildNodes[12].InnerText + "." + "</p>");

                }
            }
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            using (StreamWriter outfile = new StreamWriter(filename +".html"))
            {
                outfile.Write(sb.ToString());
            }
            
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                textBox1.Text = filename;
            }
        }
    }
}
