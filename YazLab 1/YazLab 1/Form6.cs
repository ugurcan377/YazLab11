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
    public partial class Form6 : Form
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        private const String PATH = @"C:\Program Files\Common Files\ROY\user.xml";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                                  root = doc.CreateElement("Users");
            doc.AppendChild(declaration);
            doc.AppendChild(root);
            doc.Save(PATH);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            XmlElement fword = doc.CreateElement("User");
            XmlElement username = doc.CreateElement("Username");
            XmlElement pass = doc.CreateElement("Password");
            if (textBoxUser.Text != String.Empty && textBoxPass.Text != String.Empty && textBoxPass.Text == textBoxPass1.Text)
            {
                username.InnerText = textBoxUser.Text;
                pass.InnerText = textBoxPass.Text;
                fword.AppendChild(username);
                fword.AppendChild(pass);
                root.AppendChild(fword);
                doc.Save(PATH);
                MessageBox.Show("Kayıt Başarılı", "ROY");
                this.Hide();
            }
            else
            { MessageBox.Show("Kayıt Başarısız Lütfen Tekrar Deneyiniz","Hata");
                textBoxUser.Text = String.Empty;
                textBoxPass.Text = String.Empty;
                textBoxPass1.Text = String.Empty;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = String.Empty;
            textBoxPass.Text = String.Empty;
            textBoxPass1.Text = String.Empty;

        }
    }
}
