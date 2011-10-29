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
    public partial class Form4 : Form
    {
        String[] type = {"Genel","Kitap","Ed. Kitap","Dergi","Internet"};
        String[] gen = { "ID", "Tip", "Yazar", "Yil", "Editor","Baslik","KaynakAdi","SayfaNo","CiltNo","Sehir", "Yayinci", "Tarih", "Url", "Etiket", "Aciklama", "DosyaYolu" };
        String[] book = { "ID", "Tip", "Yazar", "Yil", "Baslik", "Sehir", "Yayinci", "Etiket", "Aciklama", "DosyaYolu" };
        String[] ebook = { "ID", "Tip", "Yazar", "Yil", "Baslik", "KaynakAdi", "SayfaNo","CiltNo", "Sehir", "Yayinci", "Etiket", "Aciklama", "DosyaYolu" };
        String[] mag = { "ID", "Tip", "Yazar", "Yil", "Baslik", "KaynakAdi","SayfaNo", "Url", "Etiket", "Aciklama","DosyaYolu" };
        String[] net = { "ID", "Tip", "Yazar", "Yil", "Baslik", "KaynakAdi", "Tarih", "Url", "Etiket", "Aciklama", "DosyaYolu" };
        String[] temp;
        XmlDocument doc = new XmlDocument();
        XmlDocument sepet = new XmlDocument();
        XmlElement root;
        XmlNodeList list;
        private const String PATH = (@"C:\resource.xml");
        private const String BPATH = (@"C:\basket.xml");
        public Form4()
        {
            InitializeComponent();
            if (!System.IO.File.Exists(PATH))
            {
              MessageBox.Show("XML dosyası bulunamadı. Lütfen bir kaynak ekleyin", "Hata");
              Form3 form3 = new Form3();
              form3.Show();
            
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxType.DataSource = type;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)comboBoxType.SelectedItem == "Genel")
                comboBoxCategory.DataSource = gen;
            if ((String)comboBoxType.SelectedItem == "Kitap")
                comboBoxCategory.DataSource = book;
            if ((String)comboBoxType.SelectedItem == "Ed. Kitap")
                comboBoxCategory.DataSource = ebook;
            if ((String)comboBoxType.SelectedItem == "Dergi")
                comboBoxCategory.DataSource = mag;
            if ((String)comboBoxType.SelectedItem == "Internet")
                comboBoxCategory.DataSource = net;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            doc.Load(PATH);
            listView1.Columns.Clear();
            if (comboBoxType.SelectedItem == "Genel")
                temp = gen;
            if (comboBoxType.SelectedItem == "Kitap")
                temp = book;
            if (comboBoxType.SelectedItem == "Ed. Kitap")
                temp = ebook;
            if (comboBoxType.SelectedItem == "Dergi")
                temp = mag;
            if (comboBoxType.SelectedItem == "Internet")
                temp = net;
            foreach (String i in temp)
            {
                listView1.Columns.Add(i,120);
            }

            if (textBoxSearch.Text == String.Empty)
            {
                if (comboBoxType.SelectedItem == "Genel")
                       list = doc.DocumentElement.SelectNodes("//Referans"); 
                if (comboBoxType.SelectedItem == "Kitap")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Kitap']");
                if (comboBoxType.SelectedItem == "Ed.Kitap")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Ed.Kitap']");
                if (comboBoxType.SelectedItem == "Dergi")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Dergi']");
                if (comboBoxType.SelectedItem == "Internet")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Internet']");

                foreach (XmlNode node in list)
                {
                    int i = 0;
                    ListViewItem item = new ListViewItem();
                    foreach (XmlNode nodee in node.ChildNodes)
                    {
                        if (nodee.InnerText != String.Empty)
                        {
                            if (i == 0)
                            {
                                item.Text = nodee.InnerText;
                                i++;
                                continue;
                            }
                            item.SubItems.Add(nodee.InnerText);
                            

                        }
                        else
                        {
                            if (comboBoxType.SelectedItem == "Genel")
                            {
                                item.SubItems.Add("");
                            }
                            
                        }
                    }
                    listView1.Items.Add(item);
                }

            }
            else {
                if (comboBoxType.SelectedItem == "Genel")
                    list = doc.DocumentElement.SelectNodes("//Referans"); 
                if (comboBoxType.SelectedItem == "Kitap")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Kitap']");
                if (comboBoxType.SelectedItem == "Ed.Kitap")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Ed.Kitap']");
                if (comboBoxType.SelectedItem == "Dergi")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Dergi']");
                if (comboBoxType.SelectedItem == "Internet")
                    list = doc.DocumentElement.SelectNodes("//Referans[Tip='Internet']");
                foreach (XmlNode node in list)
                {
                    if (node.ChildNodes[comboBoxCategory.SelectedIndex].InnerText.Contains(textBoxSearch.Text))
                    {
                    int i = 0;
                    ListViewItem item = new ListViewItem();
                    foreach (XmlNode nodee in node.ChildNodes)
                    {
                        if (nodee.InnerText != String.Empty)
                        {
                            if (i == 0)
                            {
                                item.Text = nodee.InnerText;
                                i++;
                                continue;
                            }
                            item.SubItems.Add(nodee.InnerText);
                            
                        }
                        else {
                            if (comboBoxType.SelectedItem == "Genel")
                            {
                                item.SubItems.Add("");
                            }
                            
                        }
                    }
                    listView1.Items.Add(item); }
                }

            
            
            
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {

            
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(BPATH))
            {
                XmlDeclaration dec = sepet.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                root = sepet.CreateElement("Referanslar");
                sepet.AppendChild(dec);
                sepet.AppendChild(root);
                sepet.Save(BPATH);
            }
            else
            {
                sepet.Load(BPATH);
                root = sepet.DocumentElement;

                foreach (ListViewItem it in listView1.Items)
                {
                    if (it.Checked)
                    {
                        XmlNode add =  doc.SelectSingleNode("//Referans[ID = '"+listView1.Items[it.Index].SubItems[0].Text+ "']");
                        XmlNode imp = sepet.ImportNode(add,true);
                        root.AppendChild(imp);
                        sepet.Save(BPATH);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Clear();
            temp = gen;
            foreach (String i in temp)
            {
                listView1.Columns.Add(i, 120);
            }
            list = sepet.DocumentElement.SelectNodes("//Referans");
            foreach (XmlNode node in list)
            {
                int i = 0;
                ListViewItem item = new ListViewItem();
                foreach (XmlNode nodee in node.ChildNodes)
                {
                    if (nodee.InnerText != String.Empty)
                    {
                        if (i == 0)
                        {
                            item.Text = nodee.InnerText;
                            i++;
                            continue;
                        }
                        item.SubItems.Add(nodee.InnerText);


                    }
                    else
                    {
                            item.SubItems.Add("");
                    }
                }
                listView1.Items.Add(item);
            }
        }
        }
    }
