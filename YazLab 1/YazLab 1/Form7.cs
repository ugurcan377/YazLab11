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
    public partial class Form7 : Form
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        XmlNode refe;
        String id;
        String fileName;
        private const String PATH = @"C:\Program Files\Common Files\ROY\resource.xml";
        public Form7(string fid)
        {
            InitializeComponent();
            doc.Load(PATH);
            root = doc.DocumentElement;
            id = fid;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            refe = doc.SelectSingleNode("//Referans[ID = '" + id + "']");
            if (refe.ChildNodes[1].InnerText == "Kitap")
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
                textBoxName.Text = refe.ChildNodes[2].InnerText;
                textBoxYear.Text = refe.ChildNodes[3].InnerText;
                textBoxVar1.Text = refe.ChildNodes[5].InnerText;
                textBoxVar2.Text = refe.ChildNodes[9].InnerText;
                textBoxVar4.Text = refe.ChildNodes[10].InnerText;
                textBoxTag.Text = refe.ChildNodes[13].InnerText;
                textBoxDesc.Text = refe.ChildNodes[14].InnerText;
                textBoxPath.Text = refe.ChildNodes[15].InnerText;


            }
            if (refe.ChildNodes[1].InnerText == "Ed.Kitap")
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
                textBoxName.Text = refe.ChildNodes[2].InnerText;
                textBoxYear.Text = refe.ChildNodes[3].InnerText;
                textBoxVar1.Text = refe.ChildNodes[5].InnerText;
                textBoxVar2.Text = refe.ChildNodes[9].InnerText;
                textBoxVar3.Text = refe.ChildNodes[4].InnerText;
                textBoxVar4.Text = refe.ChildNodes[10].InnerText;
                textBoxVar5.Text = refe.ChildNodes[6].InnerText;
                textBoxPgNum.Text = refe.ChildNodes[7].InnerText;
                textBoxTag.Text = refe.ChildNodes[13].InnerText;
                textBoxDesc.Text = refe.ChildNodes[14].InnerText;
                textBoxPath.Text = refe.ChildNodes[15].InnerText;
            }
            if (refe.ChildNodes[1].InnerText == "Dergi")
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
                textBoxName.Text = refe.ChildNodes[2].InnerText;
                textBoxYear.Text = refe.ChildNodes[3].InnerText;
                textBoxVar1.Text = refe.ChildNodes[5].InnerText;
                textBoxVar2.Text = refe.ChildNodes[8].InnerText;
                textBoxVar3.Text = refe.ChildNodes[6].InnerText;
                textBoxVar5.Text = refe.ChildNodes[12].InnerText;
                textBoxPgNum.Text = refe.ChildNodes[7].InnerText;
                textBoxTag.Text = refe.ChildNodes[13].InnerText;
                textBoxDesc.Text = refe.ChildNodes[14].InnerText;
                textBoxPath.Text = refe.ChildNodes[15].InnerText;
            }
            if (refe.ChildNodes[1].InnerText == "Internet")
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
                textBoxName.Text = refe.ChildNodes[2].InnerText;
                textBoxYear.Text = refe.ChildNodes[3].InnerText;
                textBoxVar1.Text = refe.ChildNodes[5].InnerText;
                textBoxVar2.Text = refe.ChildNodes[11].InnerText;
                textBoxVar3.Text = refe.ChildNodes[12].InnerText;
                textBoxTag.Text = refe.ChildNodes[13].InnerText;
                textBoxDesc.Text = refe.ChildNodes[14].InnerText;
                textBoxPath.Text = refe.ChildNodes[15].InnerText;
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (refe.ChildNodes[1].InnerText == "Kitap")
            {
                if (textBoxName.Modified && textBoxName.Text != String.Empty)
                {
                    refe.ChildNodes[2].InnerText = textBoxName.Text;
                }
                if (textBoxYear.Modified && textBoxYear.Text != String.Empty)
                {
                    refe.ChildNodes[3].InnerText = textBoxYear.Text;
                }
                if (textBoxVar1.Modified && textBoxVar1.Text != String.Empty)
                {
                    refe.ChildNodes[5].InnerText = textBoxVar1.Text;
                }
                if (textBoxVar2.Modified && textBoxVar2.Text != String.Empty)
                {
                    refe.ChildNodes[9].InnerText = textBoxVar2.Text;
                }
                if (textBoxVar4.Modified && textBoxVar4.Text != String.Empty)
                {
                    refe.ChildNodes[10].InnerText = textBoxVar4.Text;
                }
                if (textBoxTag.Modified)
                {
                    refe.ChildNodes[13].InnerText = textBoxTag.Text;
                }
                if (textBoxDesc.Modified)
                {
                    refe.ChildNodes[14].InnerText = textBoxDesc.Text;
                }
                if (textBoxPath.Modified)
                {
                    refe.ChildNodes[15].InnerText = textBoxPath.Text;
                }
                doc.Save(PATH);
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
            if (refe.ChildNodes[1].InnerText == "Ed.Kitap")
            {
                if (textBoxName.Modified && textBoxName.Text != String.Empty)
                {
                    refe.ChildNodes[2].InnerText = textBoxName.Text;
                }
                if (textBoxYear.Modified && textBoxYear.Text != String.Empty)
                {
                    refe.ChildNodes[3].InnerText = textBoxYear.Text;
                }
                if (textBoxVar1.Modified && textBoxVar1.Text != String.Empty)
                {
                    refe.ChildNodes[5].InnerText = textBoxVar1.Text;
                }
                if (textBoxVar2.Modified && textBoxVar2.Text != String.Empty)
                {
                    refe.ChildNodes[9].InnerText = textBoxVar2.Text;
                }
                if (textBoxVar3.Modified && textBoxVar4.Text != String.Empty)
                {
                    refe.ChildNodes[4].InnerText = textBoxVar4.Text;
                }
                if (textBoxVar4.Modified && textBoxVar4.Text != String.Empty)
                {
                    refe.ChildNodes[10].InnerText = textBoxVar4.Text;
                }
                if (textBoxVar5.Modified && textBoxVar3.Text != String.Empty)
                {
                    refe.ChildNodes[6].InnerText = textBoxVar3.Text;
                }
                if (textBoxPgNum.Modified && textBoxPgNum.Text != String.Empty)
                {
                    refe.ChildNodes[7].InnerText = textBoxPgNum.Text;
                }
                if (textBoxTag.Modified)
                {
                    refe.ChildNodes[13].InnerText = textBoxTag.Text;
                }
                if (textBoxDesc.Modified)
                {
                    refe.ChildNodes[14].InnerText = textBoxDesc.Text;
                }
                if (textBoxPath.Modified)
                {
                    refe.ChildNodes[15].InnerText = textBoxPath.Text;
                }
                doc.Save(PATH);
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
            if (refe.ChildNodes[1].InnerText == "Dergi")
            {
                if (textBoxName.Modified && textBoxName.Text != String.Empty)
                {
                    refe.ChildNodes[2].InnerText = textBoxName.Text;
                }
                if (textBoxYear.Modified && textBoxYear.Text != String.Empty)
                {
                    refe.ChildNodes[3].InnerText = textBoxYear.Text;
                }
                if (textBoxVar1.Modified && textBoxVar1.Text != String.Empty)
                {
                    refe.ChildNodes[5].InnerText = textBoxVar1.Text;
                }
                if (textBoxVar2.Modified && textBoxVar2.Text != String.Empty)
                {
                    refe.ChildNodes[8].InnerText = textBoxVar2.Text;
                }
                if (textBoxVar3.Modified && textBoxVar4.Text != String.Empty)
                {
                    refe.ChildNodes[6].InnerText = textBoxVar4.Text;
                }
                if (textBoxVar5.Modified && textBoxVar3.Text != String.Empty)
                {
                    refe.ChildNodes[12].InnerText = textBoxVar3.Text;
                }
                if (textBoxPgNum.Modified && textBoxPgNum.Text != String.Empty)
                {
                    refe.ChildNodes[7].InnerText = textBoxPgNum.Text;
                }
                if (textBoxTag.Modified)
                {
                    refe.ChildNodes[13].InnerText = textBoxTag.Text;
                }
                if (textBoxDesc.Modified)
                {
                    refe.ChildNodes[14].InnerText = textBoxDesc.Text;
                }
                if (textBoxPath.Modified)
                {
                    refe.ChildNodes[15].InnerText = textBoxPath.Text;
                }
                doc.Save(PATH);
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
            if (refe.ChildNodes[1].InnerText == "Internet")
            {
                if (textBoxName.Modified && textBoxName.Text != String.Empty)
                {
                    refe.ChildNodes[2].InnerText = textBoxName.Text;
                }
                if (textBoxYear.Modified && textBoxYear.Text != String.Empty)
                {
                    refe.ChildNodes[3].InnerText = textBoxYear.Text;
                }
                if (textBoxVar1.Modified && textBoxVar1.Text != String.Empty)
                {
                    refe.ChildNodes[5].InnerText = textBoxVar1.Text;
                }
                if (textBoxVar2.Modified && textBoxVar2.Text != String.Empty)
                {
                    refe.ChildNodes[11].InnerText = textBoxVar2.Text;
                }
                if (textBoxVar3.Modified && textBoxVar3.Text != String.Empty)
                {
                    refe.ChildNodes[12].InnerText = textBoxVar3.Text;
                }
                if (textBoxTag.Modified)
                {
                    refe.ChildNodes[13].InnerText = textBoxTag.Text;
                }
                if (textBoxDesc.Modified)
                {
                    refe.ChildNodes[14].InnerText = textBoxDesc.Text;
                }
                if (textBoxPath.Modified)
                {
                    refe.ChildNodes[15].InnerText = textBoxPath.Text;
                }
                doc.Save(PATH);
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
            }
        }

    }
}
