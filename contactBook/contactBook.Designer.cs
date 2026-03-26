
namespace Contact_Book
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameClear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NumberClear = new System.Windows.Forms.Label();
            this.AddressClear = new System.Windows.Forms.Label();
            this.ContactExistFrame = new System.Windows.Forms.PictureBox();
            this.ContactExists = new System.Windows.Forms.Label();
            this.ExistClose = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ContactViewer = new System.Windows.Forms.Button();
            this.CloseContactTab = new System.Windows.Forms.Label();
            this.ContactBar = new System.Windows.Forms.PictureBox();
            this.ContactXBack = new System.Windows.Forms.PictureBox();
            this.ContactTab = new System.Windows.Forms.Label();
            this.ContactTabBack = new System.Windows.Forms.PictureBox();
            this.ContactViewerBorder = new System.Windows.Forms.PictureBox();
            this.ContactViewerMain = new System.Windows.Forms.PictureBox();
            this.ContactViewerSplit = new System.Windows.Forms.PictureBox();
            this.Contacts = new System.Windows.Forms.DataGridView();
            this.RefreshBack = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.Label();
            this.DeleteContactBorder = new System.Windows.Forms.PictureBox();
            this.DeleteNo = new System.Windows.Forms.Button();
            this.DeleteYes = new System.Windows.Forms.Button();
            this.DeleteContactText = new System.Windows.Forms.Label();
            this.DeleteContactMain = new System.Windows.Forms.PictureBox();
            this.ContactString = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactExistFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactXBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTabBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViewerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViewerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViewerSplit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactMain)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(458, 148);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(271, 23);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(458, 205);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(271, 23);
            this.NumberBox.TabIndex = 1;
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.DarkGray;
            this.NameLabel.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(458, 120);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(458, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(458, 259);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(271, 23);
            this.AddressBox.TabIndex = 4;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(458, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(512, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameClear
            // 
            this.NameClear.AutoSize = true;
            this.NameClear.BackColor = System.Drawing.Color.White;
            this.NameClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameClear.Font = new System.Drawing.Font("Agrandir Narrow", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameClear.Location = new System.Drawing.Point(735, 151);
            this.NameClear.Name = "NameClear";
            this.NameClear.Size = new System.Drawing.Size(14, 16);
            this.NameClear.TabIndex = 7;
            this.NameClear.Text = "X";
            this.NameClear.Click += new System.EventHandler(this.NameClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(435, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 241);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // NumberClear
            // 
            this.NumberClear.AutoSize = true;
            this.NumberClear.BackColor = System.Drawing.Color.White;
            this.NumberClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberClear.Font = new System.Drawing.Font("Agrandir Narrow", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberClear.Location = new System.Drawing.Point(735, 208);
            this.NumberClear.Name = "NumberClear";
            this.NumberClear.Size = new System.Drawing.Size(14, 16);
            this.NumberClear.TabIndex = 9;
            this.NumberClear.Text = "X";
            this.NumberClear.Click += new System.EventHandler(this.NumberClear_Click);
            // 
            // AddressClear
            // 
            this.AddressClear.AutoSize = true;
            this.AddressClear.BackColor = System.Drawing.Color.White;
            this.AddressClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddressClear.Font = new System.Drawing.Font("Agrandir Narrow", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressClear.Location = new System.Drawing.Point(735, 262);
            this.AddressClear.Name = "AddressClear";
            this.AddressClear.Size = new System.Drawing.Size(14, 16);
            this.AddressClear.TabIndex = 10;
            this.AddressClear.Text = "X";
            this.AddressClear.Click += new System.EventHandler(this.AddressClear_Click);
            // 
            // ContactExistFrame
            // 
            this.ContactExistFrame.BackColor = System.Drawing.Color.DarkGray;
            this.ContactExistFrame.Location = new System.Drawing.Point(435, 74);
            this.ContactExistFrame.Name = "ContactExistFrame";
            this.ContactExistFrame.Size = new System.Drawing.Size(324, 30);
            this.ContactExistFrame.TabIndex = 11;
            this.ContactExistFrame.TabStop = false;
            this.ContactExistFrame.Visible = false;
            // 
            // ContactExists
            // 
            this.ContactExists.AutoSize = true;
            this.ContactExists.BackColor = System.Drawing.Color.DarkGray;
            this.ContactExists.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactExists.ForeColor = System.Drawing.Color.Red;
            this.ContactExists.Location = new System.Drawing.Point(498, 77);
            this.ContactExists.Name = "ContactExists";
            this.ContactExists.Size = new System.Drawing.Size(208, 25);
            this.ContactExists.TabIndex = 14;
            this.ContactExists.Text = "Contact already exists.";
            this.ContactExists.Visible = false;
            // 
            // ExistClose
            // 
            this.ExistClose.AutoSize = true;
            this.ExistClose.BackColor = System.Drawing.Color.DarkGray;
            this.ExistClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExistClose.Font = new System.Drawing.Font("Agrandir Narrow", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExistClose.Location = new System.Drawing.Point(743, 75);
            this.ExistClose.Name = "ExistClose";
            this.ExistClose.Size = new System.Drawing.Size(14, 16);
            this.ExistClose.TabIndex = 15;
            this.ExistClose.Text = "X";
            this.ExistClose.Visible = false;
            this.ExistClose.Click += new System.EventHandler(this.ExistClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(44, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 241);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // ContactViewer
            // 
            this.ContactViewer.BackColor = System.Drawing.Color.White;
            this.ContactViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactViewer.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactViewer.Location = new System.Drawing.Point(120, 169);
            this.ContactViewer.Name = "ContactViewer";
            this.ContactViewer.Size = new System.Drawing.Size(178, 113);
            this.ContactViewer.TabIndex = 17;
            this.ContactViewer.Text = "View Contacts";
            this.ContactViewer.UseVisualStyleBackColor = false;
            this.ContactViewer.Click += new System.EventHandler(this.ContactViewer_Click);
            // 
            // CloseContactTab
            // 
            this.CloseContactTab.AutoSize = true;
            this.CloseContactTab.BackColor = System.Drawing.Color.DarkGray;
            this.CloseContactTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseContactTab.Font = new System.Drawing.Font("Agrandir Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseContactTab.Location = new System.Drawing.Point(733, 41);
            this.CloseContactTab.Name = "CloseContactTab";
            this.CloseContactTab.Size = new System.Drawing.Size(25, 28);
            this.CloseContactTab.TabIndex = 30;
            this.CloseContactTab.Text = "X";
            this.CloseContactTab.Visible = false;
            this.CloseContactTab.Click += new System.EventHandler(this.CloseContactTab_Click);
            // 
            // ContactBar
            // 
            this.ContactBar.Location = new System.Drawing.Point(44, 36);
            this.ContactBar.Name = "ContactBar";
            this.ContactBar.Size = new System.Drawing.Size(724, 38);
            this.ContactBar.TabIndex = 24;
            this.ContactBar.TabStop = false;
            this.ContactBar.Visible = false;
            // 
            // ContactXBack
            // 
            this.ContactXBack.BackColor = System.Drawing.Color.DarkGray;
            this.ContactXBack.Location = new System.Drawing.Point(723, 39);
            this.ContactXBack.Name = "ContactXBack";
            this.ContactXBack.Size = new System.Drawing.Size(40, 31);
            this.ContactXBack.TabIndex = 25;
            this.ContactXBack.TabStop = false;
            this.ContactXBack.Visible = false;
            // 
            // ContactTab
            // 
            this.ContactTab.AutoSize = true;
            this.ContactTab.BackColor = System.Drawing.Color.DarkGray;
            this.ContactTab.Font = new System.Drawing.Font("Agrandir Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactTab.Location = new System.Drawing.Point(61, 41);
            this.ContactTab.Name = "ContactTab";
            this.ContactTab.Size = new System.Drawing.Size(151, 27);
            this.ContactTab.TabIndex = 23;
            this.ContactTab.Text = "Contact Viewer";
            this.ContactTab.Visible = false;
            // 
            // ContactTabBack
            // 
            this.ContactTabBack.BackColor = System.Drawing.Color.DarkGray;
            this.ContactTabBack.Location = new System.Drawing.Point(50, 39);
            this.ContactTabBack.Name = "ContactTabBack";
            this.ContactTabBack.Size = new System.Drawing.Size(169, 31);
            this.ContactTabBack.TabIndex = 22;
            this.ContactTabBack.TabStop = false;
            this.ContactTabBack.Visible = false;
            // 
            // ContactViewerBorder
            // 
            this.ContactViewerBorder.BackColor = System.Drawing.Color.DarkGray;
            this.ContactViewerBorder.Location = new System.Drawing.Point(36, 30);
            this.ContactViewerBorder.Name = "ContactViewerBorder";
            this.ContactViewerBorder.Size = new System.Drawing.Size(740, 420);
            this.ContactViewerBorder.TabIndex = 20;
            this.ContactViewerBorder.TabStop = false;
            this.ContactViewerBorder.Visible = false;
            // 
            // ContactViewerMain
            // 
            this.ContactViewerMain.Location = new System.Drawing.Point(44, 72);
            this.ContactViewerMain.Name = "ContactViewerMain";
            this.ContactViewerMain.Size = new System.Drawing.Size(724, 372);
            this.ContactViewerMain.TabIndex = 29;
            this.ContactViewerMain.TabStop = false;
            this.ContactViewerMain.Visible = false;
            // 
            // ContactViewerSplit
            // 
            this.ContactViewerSplit.BackColor = System.Drawing.Color.DarkGray;
            this.ContactViewerSplit.Location = new System.Drawing.Point(44, 72);
            this.ContactViewerSplit.Name = "ContactViewerSplit";
            this.ContactViewerSplit.Size = new System.Drawing.Size(724, 8);
            this.ContactViewerSplit.TabIndex = 26;
            this.ContactViewerSplit.TabStop = false;
            this.ContactViewerSplit.Visible = false;
            // 
            // Contacts
            // 
            this.Contacts.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contacts.Location = new System.Drawing.Point(50, 85);
            this.Contacts.Name = "Contacts";
            this.Contacts.RowTemplate.Height = 25;
            this.Contacts.Size = new System.Drawing.Size(713, 352);
            this.Contacts.TabIndex = 30;
            this.Contacts.Visible = false;
            this.Contacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Contacts_CellDoubleClick);
            // 
            // RefreshBack
            // 
            this.RefreshBack.BackColor = System.Drawing.Color.DarkGray;
            this.RefreshBack.Location = new System.Drawing.Point(625, 39);
            this.RefreshBack.Name = "RefreshBack";
            this.RefreshBack.Size = new System.Drawing.Size(92, 31);
            this.RefreshBack.TabIndex = 35;
            this.RefreshBack.TabStop = false;
            this.RefreshBack.Visible = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.Font = new System.Drawing.Font("Agrandir Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.Location = new System.Drawing.Point(638, 44);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(65, 21);
            this.RefreshButton.TabIndex = 40;
            this.RefreshButton.Text = "refresh";
            this.RefreshButton.Visible = false;
            this.RefreshButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeleteContactBorder
            // 
            this.DeleteContactBorder.BackColor = System.Drawing.Color.Gray;
            this.DeleteContactBorder.Location = new System.Drawing.Point(160, 132);
            this.DeleteContactBorder.Name = "DeleteContactBorder";
            this.DeleteContactBorder.Size = new System.Drawing.Size(465, 210);
            this.DeleteContactBorder.TabIndex = 49;
            this.DeleteContactBorder.TabStop = false;
            this.DeleteContactBorder.Visible = false;
            // 
            // DeleteNo
            // 
            this.DeleteNo.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNo.Font = new System.Drawing.Font("Agrandir Narrow", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteNo.Location = new System.Drawing.Point(500, 292);
            this.DeleteNo.Name = "DeleteNo";
            this.DeleteNo.Size = new System.Drawing.Size(87, 31);
            this.DeleteNo.TabIndex = 53;
            this.DeleteNo.Text = "No";
            this.DeleteNo.UseVisualStyleBackColor = false;
            this.DeleteNo.Visible = false;
            this.DeleteNo.Click += new System.EventHandler(this.DeleteNo_Click);
            this.DeleteNo.MouseLeave += new System.EventHandler(this.DeleteNo_MouseLeave);
            this.DeleteNo.MouseHover += new System.EventHandler(this.DeleteNo_MouseHover);
            // 
            // DeleteYes
            // 
            this.DeleteYes.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteYes.Font = new System.Drawing.Font("Agrandir Narrow", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteYes.Location = new System.Drawing.Point(407, 292);
            this.DeleteYes.Name = "DeleteYes";
            this.DeleteYes.Size = new System.Drawing.Size(87, 31);
            this.DeleteYes.TabIndex = 52;
            this.DeleteYes.Text = "Yes";
            this.DeleteYes.UseVisualStyleBackColor = false;
            this.DeleteYes.Visible = false;
            this.DeleteYes.Click += new System.EventHandler(this.DeleteYes_Click);
            this.DeleteYes.MouseLeave += new System.EventHandler(this.DeleteYes_MouseLeave);
            this.DeleteYes.MouseHover += new System.EventHandler(this.DeleteYes_MouseHover);
            // 
            // DeleteContactText
            // 
            this.DeleteContactText.AutoSize = true;
            this.DeleteContactText.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteContactText.Font = new System.Drawing.Font("Agrandir Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteContactText.Location = new System.Drawing.Point(193, 154);
            this.DeleteContactText.Name = "DeleteContactText";
            this.DeleteContactText.Size = new System.Drawing.Size(403, 25);
            this.DeleteContactText.TabIndex = 51;
            this.DeleteContactText.Text = "Are you sure you want to delete this contact?";
            this.DeleteContactText.Visible = false;
            // 
            // DeleteContactMain
            // 
            this.DeleteContactMain.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteContactMain.Location = new System.Drawing.Point(165, 137);
            this.DeleteContactMain.Name = "DeleteContactMain";
            this.DeleteContactMain.Size = new System.Drawing.Size(455, 200);
            this.DeleteContactMain.TabIndex = 50;
            this.DeleteContactMain.TabStop = false;
            this.DeleteContactMain.Visible = false;
            // 
            // ContactString
            // 
            this.ContactString.AutoSize = true;
            this.ContactString.BackColor = System.Drawing.Color.DarkGray;
            this.ContactString.Font = new System.Drawing.Font("Agrandir Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactString.Location = new System.Drawing.Point(193, 186);
            this.ContactString.Name = "ContactString";
            this.ContactString.Size = new System.Drawing.Size(49, 21);
            this.ContactString.TabIndex = 60;
            this.ContactString.Text = "label1";
            this.ContactString.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ContactString);
            this.Controls.Add(this.DeleteContactText);
            this.Controls.Add(this.DeleteYes);
            this.Controls.Add(this.DeleteNo);
            this.Controls.Add(this.DeleteContactMain);
            this.Controls.Add(this.DeleteContactBorder);
            this.Controls.Add(this.ContactTab);
            this.Controls.Add(this.CloseContactTab);
            this.Controls.Add(this.ContactXBack);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RefreshBack);
            this.Controls.Add(this.ContactTabBack);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.ContactViewerSplit);
            this.Controls.Add(this.ContactViewerMain);
            this.Controls.Add(this.ContactBar);
            this.Controls.Add(this.ContactViewerBorder);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ContactViewer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddressClear);
            this.Controls.Add(this.NumberClear);
            this.Controls.Add(this.NameClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContactExists);
            this.Controls.Add(this.ExistClose);
            this.Controls.Add(this.ContactExistFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactExistFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactXBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTabBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViewerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViewerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViewerSplit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NumberClear;
        private System.Windows.Forms.Label AddressClear;
        private System.Windows.Forms.PictureBox ContactExistFrame;
        private System.Windows.Forms.Label ContactExists;
        private System.Windows.Forms.Label ExistClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ContactViewer;
        private System.Windows.Forms.Label CloseContactTab;
        private System.Windows.Forms.PictureBox ContactBar;
        private System.Windows.Forms.PictureBox ContactXBack;
        private System.Windows.Forms.Label ContactTab;
        private System.Windows.Forms.PictureBox ContactTabBack;
        private System.Windows.Forms.PictureBox ContactViewerBorder;
        private System.Windows.Forms.PictureBox ContactViewerMain;
        private System.Windows.Forms.PictureBox ContactViewerSplit;
        private System.Windows.Forms.DataGridView Contacts;
        private System.Windows.Forms.PictureBox RefreshBack;
        private System.Windows.Forms.Label RefreshButton;
        private System.Windows.Forms.PictureBox DeleteContactBorder;
        private System.Windows.Forms.Button DeleteNo;
        private System.Windows.Forms.Button DeleteYes;
        private System.Windows.Forms.Label DeleteContactText;
        private System.Windows.Forms.PictureBox DeleteContactMain;
        private System.Windows.Forms.Label ContactString;
    }
}
