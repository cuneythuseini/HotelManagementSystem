namespace Hotel_Management_System
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnNewspaper = new System.Windows.Forms.Button();
            this.btnCustomerMessages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdminLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(46, 27);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(162, 82);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Најава За Администратор";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNewCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(297, 27);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(162, 82);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "Нов Муштерија";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.Plum;
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(546, 27);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(162, 82);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "Соби";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.LightBlue;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(46, 164);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(162, 82);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Муштерии";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(297, 293);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(162, 82);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "За Нас";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(788, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(823, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(546, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 82);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Излез";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadio.Location = new System.Drawing.Point(297, 164);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(162, 82);
            this.btnRadio.TabIndex = 8;
            this.btnRadio.Text = "Слушајте Радио";
            this.btnRadio.UseVisualStyleBackColor = false;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnNewspaper
            // 
            this.btnNewspaper.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewspaper.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewspaper.Location = new System.Drawing.Point(546, 164);
            this.btnNewspaper.Name = "btnNewspaper";
            this.btnNewspaper.Size = new System.Drawing.Size(162, 82);
            this.btnNewspaper.TabIndex = 9;
            this.btnNewspaper.Text = "Прочитајте весник";
            this.btnNewspaper.UseVisualStyleBackColor = false;
            this.btnNewspaper.Click += new System.EventHandler(this.btnNewspaper_Click);
            // 
            // btnCustomerMessages
            // 
            this.btnCustomerMessages.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCustomerMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerMessages.Location = new System.Drawing.Point(46, 293);
            this.btnCustomerMessages.Name = "btnCustomerMessages";
            this.btnCustomerMessages.Size = new System.Drawing.Size(162, 82);
            this.btnCustomerMessages.TabIndex = 10;
            this.btnCustomerMessages.Text = "Пораки од клиенти";
            this.btnCustomerMessages.UseVisualStyleBackColor = false;
            this.btnCustomerMessages.Click += new System.EventHandler(this.btnCustomerMessages_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1021, 398);
            this.Controls.Add(this.btnCustomerMessages);
            this.Controls.Add(this.btnNewspaper);
            this.Controls.Add(this.btnRadio);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.Text = "Почетна страница";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnNewspaper;
        private System.Windows.Forms.Button btnCustomerMessages;
    }
}