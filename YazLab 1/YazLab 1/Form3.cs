using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace YazLab_1
{
    public partial class Form3 : Form
    {
        private XmlDocument doc = new XmlDocument();
        private const String PATH = @"C:\resource.xml";
        String fileName;
        public Form3()
        {
            InitializeComponent();
            if (!System.IO.File.Exists(PATH))
            {
                MessageBox.Show("XML dosyası bulunamadı. Tekrar Oluşturuyor.","Hata");
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlElement root = doc.CreateElement("Resources");
                doc.AppendChild(declaration);
                doc.AppendChild(root);
                doc.Save(PATH);
            }
        }
        /* Arayüzü biraz boktan oldu
         * Açıklayayım
         * Becerebilirsen düzeltirsin :D
         * 
         * Ad,Yıl,Yol,Etiket,Açıklama sabit
         * Var1 
         * Kitap-> Kitap Adı Ed. Kitap -> Bölüm Adı Dergi,İnternet Adı -> Makale Adı
         * Var2
         * Kitap,Ed. Kitap -> Şehir Dergi->Cilt No İnternet -> Tarih
         * label14 sadece dergi için visible
         * Var3
         * Ed. Dergi -> Editör Adı Dergi -> Dergi Adı İnternet -> Url
         * Var4
         * Kitap,Ed. Kitap -> Yayınevi
         * Var5
         * Ed. Kitap ->Kitap Adı Dergi->Url         
         */


        private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            labelVar3.Hide();
            labelVar5.Hide();
            labelPgNum.Hide();
            textBoxVar3.Hide();
            textBoxVar5.Hide();
            textBoxPgNum.Hide();
            textBoxVar4.Show();
            labelVar4.Show();
            label14.Hide();
            labelVar1.Text = "Kitap Adı:";
            labelVar2.Text = "Şehir:";
            labelVar4.Text = "Yayıncı:";

        }

        private void radioButtonEbook_CheckedChanged(object sender, EventArgs e)
        {
            labelVar3.Show();
            labelVar5.Show();
            labelPgNum.Show();
            textBoxVar3.Show();
            textBoxVar5.Show();
            textBoxPgNum.Show();
            textBoxVar4.Show();
            labelVar4.Show();
            label14.Hide();
            labelVar1.Text = "Makale Adı:";
            labelVar2.Text = "Şehir:";
            labelVar3.Text = "Editör Adı:";
            labelVar4.Text = "Yayıncı:";
            labelVar5.Text = "Kitap Adı:";
        }

        private void radioButtonMagazine_CheckedChanged(object sender, EventArgs e)
        {
            labelVar3.Show();
            labelVar5.Show();
            labelPgNum.Show();
            textBoxVar3.Show();
            textBoxVar5.Show();
            textBoxPgNum.Show();
            textBoxVar4.Hide();
            labelVar4.Hide();
            label14.Show();
            labelVar1.Text = "Makale Adı:";
            labelVar2.Text = "Cilt No";
            labelVar3.Text = "Dergi Adı";
            labelVar5.Text = "Url";
        }

        private void radioButtonNet_CheckedChanged(object sender, EventArgs e)
        {
            labelVar3.Show();
            labelVar4.Hide();
            labelVar5.Hide();
            labelPgNum.Hide();
            textBoxVar3.Show();
            textBoxVar4.Hide();
            textBoxVar5.Hide();
            textBoxPgNum.Hide();
            labelVar1.Text = "Makale Adı:";
            labelVar2.Text = "Tarih";
            labelVar3.Text = "Url";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            doc.Load(PATH);
            XmlElement root = doc.DocumentElement;
            XmlElement refe = doc.CreateElement("Referance");
            XmlElement id   = doc.CreateElement("ID");
            XmlElement type = doc.CreateElement("Type");
            XmlElement auth = doc.CreateElement("Author");
            XmlElement year = doc.CreateElement("Year");
            XmlElement name = doc.CreateElement("Name");
            XmlElement city = doc.CreateElement("City");
            XmlElement pub = doc.CreateElement("Publisher");
            XmlElement edi = doc.CreateElement("Editors");
            XmlElement sname = doc.CreateElement("SourceName");
            XmlElement vol = doc.CreateElement("Volume");
            XmlElement pgnum = doc.CreateElement("PageNumber");
            XmlElement url = doc.CreateElement("Url");
            XmlElement date = doc.CreateElement("UrlDate");
            XmlElement rfile = doc.CreateElement("ResourceFile");
            XmlElement tag = doc.CreateElement("Tag");
            XmlElement desc = doc.CreateElement("Description");
            id.InnerText= (root.GetElementsByTagName("Referance").Count+1).ToString();
            if (radioButtonBook.Checked)
            {
                type.InnerText = "Book";
                auth.InnerText = textBoxName.Text;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                city.InnerText = textBoxVar2.Text;
                pub.InnerText = textBoxVar4.Text;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(name);
                refe.AppendChild(city);
                refe.AppendChild(pub);
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != String.Empty){
                    rfile.InnerText = fileName;
                    refe.AppendChild(rfile);
                }
                    root.AppendChild(refe);
                    doc.Save(PATH);
            
            }
            else if (radioButtonEbook.Checked)
            {
                type.InnerText = "Ed. Book";
                auth.InnerText = textBoxName.Text;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                city.InnerText = textBoxVar2.Text;
                edi.InnerText = textBoxVar3.Text;
                pub.InnerText = textBoxVar4.Text;
                sname.InnerText = textBoxVar5.Text;
                pgnum.InnerText = textBoxPgNum.Text;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(edi);
                refe.AppendChild(name);
                refe.AppendChild(sname);
                refe.AppendChild(pgnum);
                refe.AppendChild(city);
                refe.AppendChild(pub);
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != String.Empty){
                    rfile.InnerText = fileName;
                    refe.AppendChild(rfile);
                }
                root.AppendChild(refe);
                doc.Save(PATH);
            }
            else if (radioButtonMagazine.Checked)
            {
                type.InnerText = "Magazine";
                auth.InnerText = textBoxName.Text;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                sname.InnerText = textBoxVar3.Text;
                vol.InnerText = textBoxVar2.Text;
                pgnum.InnerText = textBoxPgNum.Text;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(name);
                refe.AppendChild(sname);
                refe.AppendChild(pgnum);
                if (textBoxTag.Text != String.Empty){
                    url.InnerText = textBoxVar5.Text;
                    refe.AppendChild(url);
                }
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != String.Empty){
                    rfile.InnerText = fileName;
                    refe.AppendChild(rfile);
                }
                root.AppendChild(refe);
                doc.Save(PATH);
                }
            else if (radioButtonNet.Checked)
            {
                type.InnerText = "Internet Referance";
                auth.InnerText = textBoxName.Text;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                date.InnerText = textBoxVar2.Text;
                url.InnerText = textBoxVar3.Text;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(name);
                refe.AppendChild(date);
                refe.AppendChild(pgnum);
                refe.AppendChild(url);
                
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != String.Empty){
                    rfile.InnerText = fileName;
                    refe.AppendChild(rfile);
                }
                root.AppendChild(refe);
                doc.Save(PATH);
                    
            }

            
        }

        private void buttonSel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                textBoxPath.Text = fileName;
            }
        }


    }
}
