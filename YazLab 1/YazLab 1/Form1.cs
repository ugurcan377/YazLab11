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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private XmlDocument doc;
        private XmlElement root;
        private XmlElement user;
        private const string PATH = @"C:\Program Files\Common Files\ROY\user.xml";

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == user.GetElementsByTagName("Username")[0].InnerText && textBoxPass.Text == user.GetElementsByTagName("Password")[0].InnerText)
            {
                
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adi/Sifre", "", MessageBoxButtons.OK);
                textBoxPass.Text = String.Empty;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = String.Empty;
            textBoxPass.Text = String.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            if (!System.IO.File.Exists(PATH))
            {
                MessageBox.Show("Kayıtlı Kullanıcı Bulunamadı Lütfen Yeni Kullanıcı Giriniz", "Hata");
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();

            }
            else
            {
                doc.Load(PATH);
                root = doc.DocumentElement;
                user = (XmlElement)root.FirstChild;
            }
        }
    }
}
