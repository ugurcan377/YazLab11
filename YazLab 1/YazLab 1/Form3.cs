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
        private const String PATH = @"C:\Program Files\Common Files\ROY\resource.xml";
        String fileName;
        String[] trans;
        String author;
        String editor;
        public Form3()
        {
            InitializeComponent();
            if (!System.IO.File.Exists(PATH))
            {
                MessageBox.Show("XML dosyası bulunamadı. Tekrar Oluşturuyor.","Hata");
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlElement root = doc.CreateElement("Referanslar");
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
            labelVar2.Text = "Cilt No:";
            labelVar3.Text = "Dergi Adı:";
            labelVar5.Text = "Doi:";
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
            labelVar2.Text = "Tarih:";
            labelVar3.Text = "Url:";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            doc.Load(PATH);
            XmlElement root = doc.DocumentElement;
            XmlElement refe = doc.CreateElement("Referans");
            XmlElement id   = doc.CreateElement("ID");
            XmlElement type = doc.CreateElement("Tip");
            XmlElement auth = doc.CreateElement("Yazar");
            XmlElement year = doc.CreateElement("Yil");
            XmlElement name = doc.CreateElement("Baslik");
            XmlElement city = doc.CreateElement("Sehir");
            XmlElement pub = doc.CreateElement("Yayinci");
            XmlElement edi = doc.CreateElement("Editor");
            XmlElement sname = doc.CreateElement("KaynakAdi");
            XmlElement vol = doc.CreateElement("CiltNo");
            XmlElement pgnum = doc.CreateElement("SayfaNo");
            XmlElement url = doc.CreateElement("Url");
            XmlElement date = doc.CreateElement("UrlTarih");
            XmlElement rfile = doc.CreateElement("DosyaYolu");
            XmlElement tag = doc.CreateElement("Etiket");
            XmlElement desc = doc.CreateElement("Aciklama");
            String genid= (root.GetElementsByTagName("Referans").Count+1).ToString();
            id.InnerText = genid;
            if (textBoxName.Text.Contains(";"))
            {
                trans = textBoxName.Text.Split(new char[] {';'});
                for (int i = 0; i < trans.Length; i++) {
                    if (i == trans.Length-1){
                        author += "&" + trans[i];
                    }
                    else{
                        author += trans[i]+",";
                    }
                }
            }
            else
            {
                author = textBoxName.Text;
            }

            if (radioButtonBook.Checked)
            {
                type.InnerText = "Kitap";
                auth.InnerText = author;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                city.InnerText = textBoxVar2.Text;
                pub.InnerText = textBoxVar4.Text;
                edi.InnerText = String.Empty;
                sname.InnerText = String.Empty;
                pgnum.InnerText = String.Empty;
                vol.InnerText = String.Empty;
                date.InnerText = String.Empty;
                url.InnerText = String.Empty;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(edi);
                refe.AppendChild(name);
                refe.AppendChild(sname);
                refe.AppendChild(pgnum);
                refe.AppendChild(vol);
                refe.AppendChild(city);
                refe.AppendChild(pub);
                refe.AppendChild(date);
                refe.AppendChild(url);
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != null){
                    String back = System.IO.Path.GetDirectoryName(fileName);
                    String backup = System.IO.Path.GetFileName(fileName);
                    String test = System.IO.Path.GetExtension(fileName);
                    System.IO.File.Copy(fileName, back + backup + "(1)" + test, true);
                    System.IO.File.Move(fileName, @"C:\Program Files\Common Files\ROY\Files\" + genid + test);
                    rfile.InnerText = @"C:\Program Files\Common Files\ROY\Files\" + genid + test;
                    refe.AppendChild(rfile);
                }
                    root.AppendChild(refe);
                    doc.Save(PATH);
                    MessageBox.Show("Kaynak Ekleme Basarili","Nicee");
                    Clear(sender, e);
            
            }
            else if (radioButtonEbook.Checked)
            {
                if (textBoxName.Text.Contains(";"))
                {
                    trans = textBoxVar3.Text.Split(new char[] { ';' });
                    for (int i = 0; i < trans.Length; i++)
                    {
                        if (i == trans.Length - 1)
                        {
                            editor += "&" + trans[i];
                        }
                        else
                        {
                            editor += trans[i] + ",";
                        }
                    }
                }
                else
                {
                    editor = textBoxVar3.Text;
                }
                type.InnerText = "Ed. Kitap";
                auth.InnerText = author;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                city.InnerText = textBoxVar2.Text;
                edi.InnerText = editor;
                pub.InnerText = textBoxVar4.Text;
                sname.InnerText = textBoxVar5.Text;
                pgnum.InnerText = textBoxPgNum.Text;
                vol.InnerText = String.Empty;
                date.InnerText = String.Empty;
                url.InnerText = String.Empty;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(edi);
                refe.AppendChild(name);
                refe.AppendChild(sname);
                refe.AppendChild(pgnum);
                refe.AppendChild(vol);
                refe.AppendChild(city);
                refe.AppendChild(pub);
                refe.AppendChild(date);
                refe.AppendChild(url);
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != null){
                    String back = System.IO.Path.GetDirectoryName(fileName);
                    String backup = System.IO.Path.GetFileName(fileName);
                    String test = System.IO.Path.GetExtension(fileName);
                    System.IO.File.Copy(fileName,back+backup+"(1)"+test , true);
                    System.IO.File.Move(fileName, @"C:\Program Files\Common Files\ROY\Files\" + genid + test);
                    rfile.InnerText = @"C:\Program Files\Common Files\ROY\Files\" +genid + test;
                    refe.AppendChild(rfile);
                }
                root.AppendChild(refe);
                doc.Save(PATH);
                MessageBox.Show("Kaynak Ekleme Basarili", "Nicee");
                Clear(sender, e);
            }
            else if (radioButtonMagazine.Checked)
            {
                type.InnerText = "Dergi";
                auth.InnerText = author;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                sname.InnerText = textBoxVar3.Text;
                vol.InnerText = textBoxVar2.Text;
                pgnum.InnerText = textBoxPgNum.Text;
                edi.InnerText = String.Empty;
                city.InnerText = String.Empty;
                pub.InnerText = String.Empty;
                date.InnerText = String.Empty;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(edi);
                refe.AppendChild(name);
                refe.AppendChild(sname);
                refe.AppendChild(pgnum);
                refe.AppendChild(vol);
                refe.AppendChild(city);
                refe.AppendChild(pub);
                refe.AppendChild(date);
                if (textBoxTag.Text != String.Empty)
                {
                    url.InnerText = textBoxVar5.Text;
                    refe.AppendChild(url);
                }
                else {
                    url.InnerText = String.Empty;
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
                if (fileName != null){
                    String back = System.IO.Path.GetDirectoryName(fileName);
                    String backup = System.IO.Path.GetFileName(fileName);
                    String test = System.IO.Path.GetExtension(fileName);
                    System.IO.File.Copy(fileName, back + backup + "(1)" + test, true);
                    System.IO.File.Move(fileName, @"C:\Program Files\Common Files\ROY\Files\" + genid + test);
                    rfile.InnerText = @"C:\Program Files\Common Files\ROY\Files\" + genid + test;
                    refe.AppendChild(rfile);
                }
                root.AppendChild(refe);
                doc.Save(PATH);
                MessageBox.Show("Kaynak Ekleme Basarili", "Nicee");
                Clear(sender, e);
                }
            else if (radioButtonNet.Checked)
            {
                type.InnerText = "Internet";
                auth.InnerText = author;
                year.InnerText = textBoxYear.Text;
                name.InnerText = textBoxVar1.Text;
                date.InnerText = textBoxVar2.Text;
                url.InnerText = textBoxVar3.Text;
                edi.InnerText = String.Empty;
                sname.InnerText = String.Empty;
                city.InnerText = String.Empty;
                pub.InnerText = String.Empty;
                vol.InnerText = String.Empty;
                refe.AppendChild(id);
                refe.AppendChild(type);
                refe.AppendChild(auth);
                refe.AppendChild(year);
                refe.AppendChild(edi);
                refe.AppendChild(name);
                refe.AppendChild(sname);
                refe.AppendChild(pgnum);
                refe.AppendChild(vol);
                refe.AppendChild(city);
                refe.AppendChild(pub);
                refe.AppendChild(date);
                refe.AppendChild(url);
                
                if (textBoxTag.Text != String.Empty){
                    tag.InnerText = textBoxTag.Text;
                    refe.AppendChild(tag);
                }
                if (textBoxDesc.Text != String.Empty){
                    desc.InnerText = textBoxDesc.Text;
                    refe.AppendChild(desc);
                }
                if (fileName != null){
                    String back = System.IO.Path.GetDirectoryName(fileName);
                    String backup = System.IO.Path.GetFileName(fileName);
                    String test = System.IO.Path.GetExtension(fileName);
                    System.IO.File.Copy(fileName, back + backup + "(1)" + test, true);
                    System.IO.File.Move(fileName, @"C:\Program Files\Common Files\ROY\Files\" + genid + test);
                    rfile.InnerText = @"C:\Program Files\Common Files\ROY\Files\" + genid + test;
                    refe.AppendChild(rfile);
                }
                root.AppendChild(refe);
                doc.Save(PATH);
                MessageBox.Show("Kaynak Ekleme Basarili", "Nicee");
                Clear(sender,e);
                    
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
        private void Clear(object sender, EventArgs e) 
        {
            textBoxVar1.Text = String.Empty;
            textBoxVar2.Text = String.Empty;
            textBoxVar3.Text = String.Empty;
            textBoxVar4.Text = String.Empty;
            textBoxVar5.Text = String.Empty;
            textBoxYear.Text = String.Empty;
            textBoxTag.Text = String.Empty;
            textBoxName.Text = String.Empty;
            textBoxPath.Text = String.Empty;
            textBoxPgNum.Text = String.Empty;
            textBoxDesc.Text = String.Empty;
        }


    }
}
