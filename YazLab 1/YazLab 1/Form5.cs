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
    public partial class Form5 : Form
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        XmlElement user;
        private const string PATH = @"C:\Program Files\Common Files\ROY\user.xml";
        public Form5()
        {
            InitializeComponent();
            doc.Load(PATH);
            root = doc.DocumentElement;
            user = (XmlElement)root.FirstChild;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.GetElementsByTagName("Password")[0].InnerText == textBox1.Text && textBox1.Text == textBox2.Text && textBox3.Text == textBox4.Text && textBox3.Text != String.Empty)
            {
                user.GetElementsByTagName("Password")[0].InnerText = textBox3.Text;
                doc.Save(PATH);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            String username;
            username = user.GetElementsByTagName("Username")[0].InnerText;
            listBox1.Items.Add(username);
            
        }
    }
}
