namespace SimpleInvoice
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInvoiceUpdate = new System.Windows.Forms.Button();
            this.btnInvoiceAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.listInvoiceItems = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListBox();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnList = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.listboxItems = new System.Windows.Forms.ListBox();
            this.applicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.steelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.goldToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.steelToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Number:";
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Location = new System.Drawing.Point(108, 55);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerNumber.TabIndex = 2;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(108, 81);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerFirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(108, 107);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Location = new System.Drawing.Point(108, 133);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerContact.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact Number:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(108, 159);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(143, 78);
            this.txtCustomerAddress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address:";
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(189, 243);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(62, 23);
            this.btnCustomerAdd.TabIndex = 11;
            this.btnCustomerAdd.Text = "Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(108, 243);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnCustomerUpdate.TabIndex = 12;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Invoice";
            // 
            // btnInvoiceUpdate
            // 
            this.btnInvoiceUpdate.Location = new System.Drawing.Point(108, 392);
            this.btnInvoiceUpdate.Name = "btnInvoiceUpdate";
            this.btnInvoiceUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnInvoiceUpdate.TabIndex = 25;
            this.btnInvoiceUpdate.Text = "Update";
            this.btnInvoiceUpdate.UseVisualStyleBackColor = true;
            this.btnInvoiceUpdate.Click += new System.EventHandler(this.btnInvoiceUpdate_Click);
            // 
            // btnInvoiceAdd
            // 
            this.btnInvoiceAdd.Location = new System.Drawing.Point(189, 392);
            this.btnInvoiceAdd.Name = "btnInvoiceAdd";
            this.btnInvoiceAdd.Size = new System.Drawing.Size(62, 23);
            this.btnInvoiceAdd.TabIndex = 24;
            this.btnInvoiceAdd.Text = "Add";
            this.btnInvoiceAdd.UseVisualStyleBackColor = true;
            this.btnInvoiceAdd.Click += new System.EventHandler(this.btnInvoiceAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Payment Date:";
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(108, 339);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(143, 20);
            this.txtInvoiceTotal.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total Cost:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(108, 313);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(143, 20);
            this.txtInvoiceNumber.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Invoice Number:";
            // 
            // datePayment
            // 
            this.datePayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePayment.Location = new System.Drawing.Point(108, 366);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(143, 20);
            this.datePayment.TabIndex = 27;
            // 
            // picBackground
            // 
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(803, 503);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 32;
            this.picBackground.TabStop = false;
            // 
            // listInvoiceItems
            // 
            this.listInvoiceItems.FormattingEnabled = true;
            this.listInvoiceItems.Location = new System.Drawing.Point(286, 58);
            this.listInvoiceItems.Name = "listInvoiceItems";
            this.listInvoiceItems.Size = new System.Drawing.Size(495, 355);
            this.listInvoiceItems.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Invoice Items: ";
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.Location = new System.Drawing.Point(286, 58);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(495, 355);
            this.listItems.TabIndex = 29;
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // goldToolStripMenuItem
            // 
            this.goldToolStripMenuItem.Name = "goldToolStripMenuItem";
            this.goldToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.goldToolStripMenuItem.Text = "Gold";
            this.goldToolStripMenuItem.Click += new System.EventHandler(this.goldToolStripMenuItem_Click);
            // 
            // steelToolStripMenuItem
            // 
            this.steelToolStripMenuItem.Name = "steelToolStripMenuItem";
            this.steelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.steelToolStripMenuItem.Text = "Steel";
            this.steelToolStripMenuItem.Click += new System.EventHandler(this.steelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(719, 419);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(62, 23);
            this.btnList.TabIndex = 33;
            this.btnList.Text = "Add";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(283, 33);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(76, 13);
            this.listLabel.TabIndex = 30;
            this.listLabel.Text = "Invoice Items: ";
            // 
            // listboxItems
            // 
            this.listboxItems.FormattingEnabled = true;
            this.listboxItems.Location = new System.Drawing.Point(286, 58);
            this.listboxItems.Name = "listboxItems";
            this.listboxItems.Size = new System.Drawing.Size(495, 355);
            this.listboxItems.TabIndex = 29;
            // 
            // applicationToolStripMenuItem1
            // 
            this.applicationToolStripMenuItem1.Name = "applicationToolStripMenuItem1";
            this.applicationToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem1.Text = "Application";
            // 
            // backgroundToolStripMenuItem1
            // 
            this.backgroundToolStripMenuItem1.Name = "backgroundToolStripMenuItem1";
            this.backgroundToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.backgroundToolStripMenuItem1.Text = "Background";
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem1.Text = "Green";
            // 
            // goldToolStripMenuItem1
            // 
            this.goldToolStripMenuItem1.Name = "goldToolStripMenuItem1";
            this.goldToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.goldToolStripMenuItem1.Text = "Gold";
            // 
            // steelToolStripMenuItem1
            // 
            this.steelToolStripMenuItem1.Name = "steelToolStripMenuItem1";
            this.steelToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.steelToolStripMenuItem1.Text = "Steel";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem2
            // 
            this.applicationToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem2,
            this.exitToolStripMenuItem2});
            this.applicationToolStripMenuItem2.Name = "applicationToolStripMenuItem2";
            this.applicationToolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem2.Text = "Application";
            // 
            // backgroundToolStripMenuItem2
            // 
            this.backgroundToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goldToolStripMenuItem2,
            this.greenToolStripMenuItem2,
            this.steelToolStripMenuItem2});
            this.backgroundToolStripMenuItem2.Name = "backgroundToolStripMenuItem2";
            this.backgroundToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.backgroundToolStripMenuItem2.Text = "Background";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // goldToolStripMenuItem2
            // 
            this.goldToolStripMenuItem2.Name = "goldToolStripMenuItem2";
            this.goldToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.goldToolStripMenuItem2.Text = "Gold";
            this.goldToolStripMenuItem2.Click += new System.EventHandler(this.goldToolStripMenuItem2_Click);
            // 
            // greenToolStripMenuItem2
            // 
            this.greenToolStripMenuItem2.Name = "greenToolStripMenuItem2";
            this.greenToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem2.Text = "Green";
            this.greenToolStripMenuItem2.Click += new System.EventHandler(this.greenToolStripMenuItem2_Click);
            // 
            // steelToolStripMenuItem2
            // 
            this.steelToolStripMenuItem2.Name = "steelToolStripMenuItem2";
            this.steelToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.steelToolStripMenuItem2.Text = "Steel";
            this.steelToolStripMenuItem2.Click += new System.EventHandler(this.steelToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 501);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.listboxItems);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInvoiceUpdate);
            this.Controls.Add(this.btnInvoiceAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picBackground);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInvoiceUpdate;
        private System.Windows.Forms.Button btnInvoiceAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.ListBox listInvoiceItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem steelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ListBox listboxItems;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem steelToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

