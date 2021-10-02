
namespace Complet.newCrud.GUI
{
    partial class Customer_Form
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
            this.textBoxCustomerid = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxphoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelComboBox = new System.Windows.Forms.Label();
            this.textBoxInputinfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textBoxCustomerid
            // 
            this.textBoxCustomerid.Location = new System.Drawing.Point(44, 61);
            this.textBoxCustomerid.Name = "textBoxCustomerid";
            this.textBoxCustomerid.Size = new System.Drawing.Size(125, 27);
            this.textBoxCustomerid.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(207, 61);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 27);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "ww";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(371, 61);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 2;
            // 
            // maskedTextBoxphoneNumber
            // 
            this.maskedTextBoxphoneNumber.Location = new System.Drawing.Point(537, 61);
            this.maskedTextBoxphoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxphoneNumber.Name = "maskedTextBoxphoneNumber";
            this.maskedTextBoxphoneNumber.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxphoneNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer ID";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(862, 59);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(862, 112);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(862, 166);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(94, 29);
            this.buttonList.TabIndex = 10;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Location = new System.Drawing.Point(862, 230);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(94, 29);
            this.buttonUpDate.TabIndex = 11;
            this.buttonUpDate.Text = "UpDate";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(862, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(862, 355);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(862, 420);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(711, 230);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Customer ID",
            "First Name",
            "Last Name",
            "Phone Number"});
            this.comboBox.Location = new System.Drawing.Point(63, 147);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(151, 28);
            this.comboBox.TabIndex = 16;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // labelComboBox
            // 
            this.labelComboBox.AutoSize = true;
            this.labelComboBox.Location = new System.Drawing.Point(63, 112);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(87, 20);
            this.labelComboBox.TabIndex = 17;
            this.labelComboBox.Text = "Combo Box";
            // 
            // textBoxInputinfo
            // 
            this.textBoxInputinfo.Location = new System.Drawing.Point(371, 148);
            this.textBoxInputinfo.Name = "textBoxInputinfo";
            this.textBoxInputinfo.Size = new System.Drawing.Size(125, 27);
            this.textBoxInputinfo.TabIndex = 18;
            this.textBoxInputinfo.TextChanged += new System.EventHandler(this.textBoxInputinfo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Input Info";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 217);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(423, 264);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone Number";
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 493);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInputinfo);
            this.Controls.Add(this.labelComboBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpDate);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxphoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxCustomerid);
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerid;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxphoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelComboBox;
        private System.Windows.Forms.TextBox textBoxInputinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}