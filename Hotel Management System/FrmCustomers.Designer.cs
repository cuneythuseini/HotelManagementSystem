namespace Hotel_Management_System
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowInfos = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbNumberOfRooms = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmailAdress = new System.Windows.Forms.MaskedTextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReleaseDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIDNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 417);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1251, 176);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No";
            this.columnHeader8.Width = 38;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Име";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Презиме";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Пол";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефонски Број";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Матичен Број";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Број на соба";
            this.columnHeader11.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "И-Мејл";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Цена";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Датум на влегување";
            this.columnHeader9.Width = 171;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Датум на излегување";
            this.columnHeader10.Width = 184;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(699, 320);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 57);
            this.btnEdit.TabIndex = 99;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.Location = new System.Drawing.Point(789, 320);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(67, 57);
            this.btnFind.TabIndex = 98;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(600, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 55);
            this.btnDelete.TabIndex = 97;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowInfos
            // 
            this.btnShowInfos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowInfos.BackgroundImage")));
            this.btnShowInfos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowInfos.Location = new System.Drawing.Point(507, 323);
            this.btnShowInfos.Name = "btnShowInfos";
            this.btnShowInfos.Size = new System.Drawing.Size(68, 55);
            this.btnShowInfos.TabIndex = 95;
            this.btnShowInfos.UseVisualStyleBackColor = true;
            this.btnShowInfos.Click += new System.EventHandler(this.btnShowInfos_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(694, 383);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 26);
            this.label28.TabIndex = 108;
            this.label28.Text = "Уредувај";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(800, 381);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 26);
            this.label27.TabIndex = 107;
            this.label27.Text = "Барај";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(595, 384);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 26);
            this.label26.TabIndex = 106;
            this.label26.Text = "Избриши";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(502, 384);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 26);
            this.label24.TabIndex = 104;
            this.label24.Text = "Покажи";
            // 
            // tbNumberOfRooms
            // 
            this.tbNumberOfRooms.BackColor = System.Drawing.SystemColors.Info;
            this.tbNumberOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfRooms.Location = new System.Drawing.Point(188, 193);
            this.tbNumberOfRooms.Name = "tbNumberOfRooms";
            this.tbNumberOfRooms.Size = new System.Drawing.Size(205, 24);
            this.tbNumberOfRooms.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 129;
            this.label10.Text = "Број на соба:";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.Info;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Маж",
            "Жена"});
            this.cbGender.Location = new System.Drawing.Point(186, 77);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(205, 26);
            this.cbGender.TabIndex = 127;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Info;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(186, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 24);
            this.tbName.TabIndex = 111;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.Info;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(188, 276);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(205, 24);
            this.tbPrice.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 110;
            this.label1.Text = "Име:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(115, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 125;
            this.label9.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 112;
            this.label2.Text = "Презиме:";
            // 
            // tbEmailAdress
            // 
            this.tbEmailAdress.BackColor = System.Drawing.SystemColors.Info;
            this.tbEmailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAdress.Location = new System.Drawing.Point(188, 237);
            this.tbEmailAdress.Name = "tbEmailAdress";
            this.tbEmailAdress.Size = new System.Drawing.Size(205, 24);
            this.tbEmailAdress.TabIndex = 124;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.Info;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(186, 47);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(205, 24);
            this.tbLastName.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 123;
            this.label8.Text = "И-Мејл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 114;
            this.label3.Text = "Пол:";
            // 
            // dtpReleaseDay
            // 
            this.dtpReleaseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleaseDay.Location = new System.Drawing.Point(190, 364);
            this.dtpReleaseDay.Name = "dtpReleaseDay";
            this.dtpReleaseDay.Size = new System.Drawing.Size(260, 24);
            this.dtpReleaseDay.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "Датум на излегување:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 115;
            this.label4.Text = "Телефон.Бр:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 18);
            this.label6.TabIndex = 120;
            this.label6.Text = "Датум на влегување:";
            // 
            // mtPhoneNumber
            // 
            this.mtPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.mtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtPhoneNumber.Location = new System.Drawing.Point(186, 111);
            this.mtPhoneNumber.Mask = "(999) 000-000";
            this.mtPhoneNumber.Name = "mtPhoneNumber";
            this.mtPhoneNumber.Size = new System.Drawing.Size(205, 24);
            this.mtPhoneNumber.TabIndex = 116;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntryDate.Location = new System.Drawing.Point(190, 325);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(260, 24);
            this.dtpEntryDate.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 117;
            this.label5.Text = "Матичен Број:";
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.BackColor = System.Drawing.SystemColors.Info;
            this.tbIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDNumber.Location = new System.Drawing.Point(186, 154);
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(205, 24);
            this.tbIDNumber.TabIndex = 118;
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFind.ForeColor = System.Drawing.Color.White;
            this.tbFind.Location = new System.Drawing.Point(540, 24);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(265, 26);
            this.tbFind.TabIndex = 132;
            this.tbFind.Text = "Внесете име за пребарување";
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            this.tbFind.MouseHover += new System.EventHandler(this.tbFind_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(473, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 22);
            this.label11.TabIndex = 131;
            this.label11.Text = "Барај:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(882, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 57);
            this.btnClear.TabIndex = 133;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(884, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 26);
            this.label12.TabIndex = 134;
            this.label12.Text = "Чисти";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 605);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNumberOfRooms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmailAdress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpReleaseDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtPhoneNumber);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIDNumber);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowInfos);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCustomers";
            this.Text = "Муштерии";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowInfos;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox tbNumberOfRooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox tbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbEmailAdress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReleaseDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbIDNumber;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
    }
}