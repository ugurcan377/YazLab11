namespace YazLab_1
{
    partial class Form7
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
            this.buttonSel = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelPgNum = new System.Windows.Forms.Label();
            this.labelVar4 = new System.Windows.Forms.Label();
            this.labelVar2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelVar5 = new System.Windows.Forms.Label();
            this.labelVar3 = new System.Windows.Forms.Label();
            this.labelVar1 = new System.Windows.Forms.Label();
            this.textBoxPgNum = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.textBoxVar4 = new System.Windows.Forms.TextBox();
            this.textBoxVar2 = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxVar5 = new System.Windows.Forms.TextBox();
            this.textBoxVar3 = new System.Windows.Forms.TextBox();
            this.textBoxVar1 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonSel
            // 
            this.buttonSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSel.Location = new System.Drawing.Point(427, 226);
            this.buttonSel.Name = "buttonSel";
            this.buttonSel.Size = new System.Drawing.Size(20, 20);
            this.buttonSel.TabIndex = 62;
            this.buttonSel.Text = "...";
            this.buttonSel.UseVisualStyleBackColor = true;
            this.buttonSel.Click += new System.EventHandler(this.buttonSel_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(91, 226);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(330, 20);
            this.textBoxPath.TabIndex = 61;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(14, 233);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(67, 13);
            this.labelPath.TabIndex = 60;
            this.labelPath.Text = "Kaynak Yolu";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(497, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 33);
            this.buttonCancel.TabIndex = 59;
            this.buttonCancel.Text = "İptal";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(497, 219);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 33);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Varsa sayı noyu cilt no(sayı no) şeklinde yazınız";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Varsa alt başlığı başlık:altbaşlık şeklinde yazınız";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Yazar adlarını Soyadı,Adı veya Soyadı,A şeklinde yazınız";
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(32, 197);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(34, 13);
            this.labelTag.TabIndex = 54;
            this.labelTag.Text = "Etiket";
            // 
            // labelPgNum
            // 
            this.labelPgNum.AutoSize = true;
            this.labelPgNum.Location = new System.Drawing.Point(382, 161);
            this.labelPgNum.Name = "labelPgNum";
            this.labelPgNum.Size = new System.Drawing.Size(51, 13);
            this.labelPgNum.TabIndex = 53;
            this.labelPgNum.Text = "Sayfa No";
            // 
            // labelVar4
            // 
            this.labelVar4.AutoSize = true;
            this.labelVar4.Location = new System.Drawing.Point(382, 120);
            this.labelVar4.Name = "labelVar4";
            this.labelVar4.Size = new System.Drawing.Size(47, 13);
            this.labelVar4.TabIndex = 52;
            this.labelVar4.Text = "Yayınevi";
            // 
            // labelVar2
            // 
            this.labelVar2.AutoSize = true;
            this.labelVar2.Location = new System.Drawing.Point(382, 72);
            this.labelVar2.Name = "labelVar2";
            this.labelVar2.Size = new System.Drawing.Size(37, 13);
            this.labelVar2.TabIndex = 51;
            this.labelVar2.Text = "Şehir :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Yayın Yılı :";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(29, 265);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(50, 13);
            this.labelDesc.TabIndex = 49;
            this.labelDesc.Text = "Açıklama";
            // 
            // labelVar5
            // 
            this.labelVar5.AutoSize = true;
            this.labelVar5.Location = new System.Drawing.Point(29, 160);
            this.labelVar5.Name = "labelVar5";
            this.labelVar5.Size = new System.Drawing.Size(52, 13);
            this.labelVar5.TabIndex = 48;
            this.labelVar5.Text = "Kitap Adı:";
            // 
            // labelVar3
            // 
            this.labelVar3.AutoSize = true;
            this.labelVar3.Location = new System.Drawing.Point(29, 120);
            this.labelVar3.Name = "labelVar3";
            this.labelVar3.Size = new System.Drawing.Size(55, 13);
            this.labelVar3.TabIndex = 47;
            this.labelVar3.Text = "Editör Adı:";
            // 
            // labelVar1
            // 
            this.labelVar1.AutoSize = true;
            this.labelVar1.Location = new System.Drawing.Point(29, 76);
            this.labelVar1.Name = "labelVar1";
            this.labelVar1.Size = new System.Drawing.Size(55, 13);
            this.labelVar1.TabIndex = 46;
            this.labelVar1.Text = "Kitap Adı :";
            // 
            // textBoxPgNum
            // 
            this.textBoxPgNum.Location = new System.Drawing.Point(452, 157);
            this.textBoxPgNum.Name = "textBoxPgNum";
            this.textBoxPgNum.Size = new System.Drawing.Size(165, 20);
            this.textBoxPgNum.TabIndex = 45;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(90, 194);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(278, 20);
            this.textBoxTag.TabIndex = 44;
            // 
            // textBoxVar4
            // 
            this.textBoxVar4.Location = new System.Drawing.Point(452, 117);
            this.textBoxVar4.Name = "textBoxVar4";
            this.textBoxVar4.Size = new System.Drawing.Size(165, 20);
            this.textBoxVar4.TabIndex = 43;
            // 
            // textBoxVar2
            // 
            this.textBoxVar2.Location = new System.Drawing.Point(452, 69);
            this.textBoxVar2.Name = "textBoxVar2";
            this.textBoxVar2.Size = new System.Drawing.Size(165, 20);
            this.textBoxVar2.TabIndex = 42;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(452, 21);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(165, 20);
            this.textBoxYear.TabIndex = 41;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(90, 262);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(356, 62);
            this.textBoxDesc.TabIndex = 40;
            // 
            // textBoxVar5
            // 
            this.textBoxVar5.Location = new System.Drawing.Point(90, 157);
            this.textBoxVar5.Name = "textBoxVar5";
            this.textBoxVar5.Size = new System.Drawing.Size(278, 20);
            this.textBoxVar5.TabIndex = 39;
            // 
            // textBoxVar3
            // 
            this.textBoxVar3.Location = new System.Drawing.Point(90, 117);
            this.textBoxVar3.Name = "textBoxVar3";
            this.textBoxVar3.Size = new System.Drawing.Size(278, 20);
            this.textBoxVar3.TabIndex = 38;
            // 
            // textBoxVar1
            // 
            this.textBoxVar1.Location = new System.Drawing.Point(90, 69);
            this.textBoxVar1.Name = "textBoxVar1";
            this.textBoxVar1.Size = new System.Drawing.Size(278, 20);
            this.textBoxVar1.TabIndex = 37;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(278, 20);
            this.textBoxName.TabIndex = 36;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 13);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Yazar Adı:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 338);
            this.Controls.Add(this.buttonSel);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
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
            this.Name = "Form7";
            this.Text = "Referans Düzenle";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSel;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelPgNum;
        private System.Windows.Forms.Label labelVar4;
        private System.Windows.Forms.Label labelVar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelVar5;
        private System.Windows.Forms.Label labelVar3;
        private System.Windows.Forms.Label labelVar1;
        private System.Windows.Forms.TextBox textBoxPgNum;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.TextBox textBoxVar4;
        private System.Windows.Forms.TextBox textBoxVar2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxVar5;
        private System.Windows.Forms.TextBox textBoxVar3;
        private System.Windows.Forms.TextBox textBoxVar1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}