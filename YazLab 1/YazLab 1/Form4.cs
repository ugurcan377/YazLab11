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
        String[] type = {"Genel","Kitap","Ed. Kitap","Dergi","Internet Kaynagi"};
        String[] gen = { "Yazar", "Yil", "Baslik", "Sehir", "Editor", "Baslik", "KaynakAdi", "Yayinci","Tarih","Url","Etiket", "Aciklama"};
        String[] book = {"Yazar","Yil","Baslik","Sehir","Yayinci","Etiket","Aciklama"};
        String[] ebook = { "Yazar","Yil", "Baslik","Sehir","Editor","Baslik","KaynakAdi","Yayinci","Etiket","Aciklama" };
        String[] mag = {"Yazar","Yil","Baslik","KaynakAdi","Url","Etiket","Aciklama" };
        String[] net = { "Yazar", "Yil", "Baslik", "KaynakAdi","Tarih", "Url", "Etiket", "Aciklama" };
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxType.DataSource = type;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedValue == "Kitap")
                comboBoxCategory.DataSource = book;
        } 

        }
    }
