namespace YazLab_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.radioButtonEbook = new System.Windows.Forms.RadioButton();
            this.radioButtonMagazine = new System.Windows.Forms.RadioButton();
            this.radioButtonNet = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxVar1 = new System.Windows.Forms.TextBox();
            this.textBoxVar3 = new System.Windows.Forms.TextBox();
            this.textBoxVar5 = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxVar2 = new System.Windows.Forms.TextBox();
            this.textBoxVar4 = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.labelVar1 = new System.Windows.Forms.Label();
            this.labelVar3 = new System.Windows.Forms.Label();
            this.labelVar5 = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelVar2 = new System.Windows.Forms.Label();
            this.labelVar4 = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelPgNum = new System.Windows.Forms.Label();
            this.textBoxPgNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Checked = true;
            this.radioButtonBook.Location = new System.Drawing.Point(27, 32);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBook.TabIndex = 0;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Kitap";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            this.radioButtonBook.CheckedChanged += new System.EventHandler(this.radioButtonBook_CheckedChanged);
            // 
            // radioButtonEbook
            // 
            this.radioButtonEbook.AutoSize = true;
            this.radioButtonEbook.Location = new System.Drawing.Point(82, 32);
            this.radioButtonEbook.Name = "radioButtonEbook";
            this.radioButtonEbook.Size = new System.Drawing.Size(140, 17);
            this.radioButtonEbook.TabIndex = 1;
            this.radioButtonEbook.Text = "Editörlü Kitap/Konferans";
            this.radioButtonEbook.UseVisualStyleBackColor = true;
            this.radioButtonEbook.CheckedChanged += new System.EventHandler(this.radioButtonEbook_CheckedChanged);
            // 
            // radioButtonMagazine
            // 
            this.radioButtonMagazine.AutoSize = true;
            this.radioButtonMagazine.Location = new System.Drawing.Point(228, 32);
            this.radioButtonMagazine.Name = "radioButtonMagazine";
            this.radioButtonMagazine.Size = new System.Drawing.Size(50, 17);
            this.radioButtonMagazine.TabIndex = 2;
            this.radioButtonMagazine.Text = "Dergi";
            this.radioButtonMagazine.UseVisualStyleBackColor = true;
            this.radioButtonMagazine.CheckedChanged += new System.EventHandler(this.radioButtonMagazine_CheckedChanged);
            // 
            // radioButtonNet
            // 
            this.radioButtonNet.AutoSize = true;
            this.radioButtonNet.Location = new System.Drawing.Point(284, 32);
            this.radioButtonNet.Name = "radioButtonNet";
            this.radioButtonNet.Size = new System.Drawing.Size(61, 17);
            this.radioButtonNet.TabIndex = 3;
            this.radioButtonNet.Text = "İnternet";
            this.radioButtonNet.UseVisualStyleBackColor = true;
            this.radioButtonNet.CheckedChanged += new System.EventHandler(this.radioButtonNet_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaynak Türü :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Yazar Adı:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(278, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxVar1
            // 
            this.textBoxVar1.Location = new System.Drawing.Point(82, 115);
            this.textBoxVar1.Name = "textBoxVar1";
            this.textBoxVar1.Size = new System.Drawing.Size(278, 20);
            this.textBoxVar1.TabIndex = 8;
            // 
            // textBoxVar3
            // 
            this.textBoxVar3.Location = new System.Drawing.Point(82, 163);
            this.textBoxVar3.Name = "textBoxVar3";
            this.textBoxVar3.Size = new System.Drawing.Size(278, 20);
            this.textBoxVar3.TabIndex = 9;
            // 
            // textBoxVar5
            // 
            this.textBoxVar5.Location = new System.Drawing.Point(82, 203);
            this.textBoxVar5.Name = "textBoxVar5";
            this.textBoxVar5.Size = new System.Drawing.Size(278, 20);
            this.textBoxVar5.TabIndex = 10;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(82, 308);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(356, 62);
            this.textBoxDesc.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(444, 67);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(165, 20);
            this.textBoxYear.TabIndex = 12;
            // 
            // textBoxVar2
            // 
            this.textBoxVar2.Location = new System.Drawing.Point(444, 115);
            this.textBoxVar2.Name = "textBoxVar2";
            this.textBoxVar2.Size = new System.Drawing.Size(165, 20);
            this.textBoxVar2.TabIndex = 13;
            // 
            // textBoxVar4
            // 
            this.textBoxVar4.Location = new System.Drawing.Point(444, 163);
            this.textBoxVar4.Name = "textBoxVar4";
            this.textBoxVar4.Size = new System.Drawing.Size(165, 20);
            this.textBoxVar4.TabIndex = 14;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(82, 240);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(278, 20);
            this.textBoxTag.TabIndex = 15;
            // 
            // labelVar1
            // 
            this.labelVar1.AutoSize = true;
            this.labelVar1.Location = new System.Drawing.Point(21, 122);
            this.labelVar1.Name = "labelVar1";
            this.labelVar1.Size = new System.Drawing.Size(55, 13);
            this.labelVar1.TabIndex = 17;
            this.labelVar1.Text = "Kitap Adı :";
            // 
            // labelVar3
            // 
            this.labelVar3.AutoSize = true;
            this.labelVar3.Location = new System.Drawing.Point(21, 166);
            this.labelVar3.Name = "labelVar3";
            this.labelVar3.Size = new System.Drawing.Size(55, 13);
            this.labelVar3.TabIndex = 18;
            this.labelVar3.Text = "Editör Adı:";
            // 
            // labelVar5
            // 
            this.labelVar5.AutoSize = true;
            this.labelVar5.Location = new System.Drawing.Point(21, 206);
            this.labelVar5.Name = "labelVar5";
            this.labelVar5.Size = new System.Drawing.Size(52, 13);
            this.labelVar5.TabIndex = 19;
            this.labelVar5.Text = "Kitap Adı:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(21, 311);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(50, 13);
            this.labelDesc.TabIndex = 20;
            this.labelDesc.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Yayın Yılı :";
            // 
            // labelVar2
            // 
            this.labelVar2.AutoSize = true;
            this.labelVar2.Location = new System.Drawing.Point(374, 118);
            this.labelVar2.Name = "labelVar2";
            this.labelVar2.Size = new System.Drawing.Size(37, 13);
            this.labelVar2.TabIndex = 22;
            this.labelVar2.Text = "Şehir :";
            // 
            // labelVar4
            // 
            this.labelVar4.AutoSize = true;
            this.labelVar4.Location = new System.Drawing.Point(374, 166);
            this.labelVar4.Name = "labelVar4";
            this.labelVar4.Size = new System.Drawing.Size(47, 13);
            this.labelVar4.TabIndex = 23;
            this.labelVar4.Text = "Yayınevi";
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(24, 243);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(34, 13);
            this.labelTag.TabIndex = 25;
            this.labelTag.Text = "Etiket";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Yazar adlarını Soyadı,Adı veya Soyadı,A şeklinde yazınız";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Varsa alt başlığı başlık:altbaşlık şeklinde yazınız";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Varsa sayı noyu cilt no(sayı no) şeklinde yazınız";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(489, 265);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 33);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(489, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 33);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "İptal";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Not : * ile işaretlenmiş alanlar isteğe bağlıdır.  Çoklu isim girişi için + karek" +
                "terini kullanınız";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 279);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(67, 13);
            this.labelPath.TabIndex = 32;
            this.labelPath.Text = "Kaynak Yolu";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(83, 272);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(330, 20);
            this.textBoxPath.TabIndex = 33;
            // 
            // buttonSel
            // 
            this.buttonSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSel.Location = new System.Drawing.Point(419, 272);
            this.buttonSel.Name = "buttonSel";
            this.buttonSel.Size = new System.Drawing.Size(20, 20);
            this.buttonSel.TabIndex = 34;
            this.buttonSel.UseVisualStyleBackColor = true;
            this.buttonSel.Click += new System.EventHandler(this.buttonSel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelPgNum
            // 
            this.labelPgNum.AutoSize = true;
            this.labelPgNum.Location = new System.Drawing.Point(374, 207);
            this.labelPgNum.Name = "labelPgNum";
            this.labelPgNum.Size = new System.Drawing.Size(51, 13);
            this.labelPgNum.TabIndex = 24;
            this.labelPgNum.Text = "Sayfa No";
            // 
            // textBoxPgNum
            // 
            this.textBoxPgNum.Location = new System.Drawing.Point(444, 203);
            this.textBoxPgNum.Name = "textBoxPgNum";
            this.textBoxPgNum.Size = new System.Drawing.Size(165, 20);
            this.textBoxPgNum.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 395);
            this.Controls.Add(this.buttonSel);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelPgNum);
            this.Controls.Add(this.labelVar4);
            this.Controls.Add(this.labelVar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelVar5);
            this.Controls.Add(this.labelVar3);
            this.Controls.Add(this.labelVar1);
            this.Controls.Add(this.textBoxPgNum);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.textBoxVar4);
            this.Controls.Add(this.textBoxVar2);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxVar5);
            this.Controls.Add(this.textBoxVar3);
            this.Controls.Add(this.textBoxVar1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonNet);
            this.Controls.Add(this.radioButtonMagazine);
            this.Controls.Add(this.radioButtonEbook);
            this.Controls.Add(this.radioButtonBook);
            this.Name = "Form3";
            this.Text = "Referans Ekle";
            this.Load += new System.EventHandler(this.radioButtonBook_CheckedChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBook;
        private System.Windows.Forms.RadioButton radioButtonEbook;
        private System.Windows.Forms.RadioButton radioButtonMagazine;
        private System.Windows.Forms.RadioButton radioButtonNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxVar1;
        private System.Windows.Forms.TextBox textBoxVar3;
        private System.Windows.Forms.TextBox textBoxVar5;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxVar2;
        private System.Windows.Forms.TextBox textBoxVar4;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Label labelVar1;
        private System.Windows.Forms.Label labelVar3;
        private System.Windows.Forms.Label labelVar5;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelVar2;
        private System.Windows.Forms.Label labelVar4;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelPgNum;
        private System.Windows.Forms.TextBox textBoxPgNum;
    }
}