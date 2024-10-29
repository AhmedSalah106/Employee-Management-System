namespace ADOWindowForm
{
    partial class FormBirthDate
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblChooseDepart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LstBoxDepartEmp = new System.Windows.Forms.ListBox();
            this.LblSSn = new System.Windows.Forms.Label();
            this.SsnTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.DeptNumTxt = new System.Windows.Forms.TextBox();
            this.SalaryTxt = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDeptNum = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // LblChooseDepart
            // 
            this.LblChooseDepart.AutoSize = true;
            this.LblChooseDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChooseDepart.Location = new System.Drawing.Point(22, 23);
            this.LblChooseDepart.Name = "LblChooseDepart";
            this.LblChooseDepart.Size = new System.Drawing.Size(176, 20);
            this.LblChooseDepart.TabIndex = 1;
            this.LblChooseDepart.Text = "Chooce Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department Employee";
            // 
            // LstBoxDepartEmp
            // 
            this.LstBoxDepartEmp.FormattingEnabled = true;
            this.LstBoxDepartEmp.ItemHeight = 16;
            this.LstBoxDepartEmp.Location = new System.Drawing.Point(27, 146);
            this.LstBoxDepartEmp.Name = "LstBoxDepartEmp";
            this.LstBoxDepartEmp.Size = new System.Drawing.Size(190, 164);
            this.LstBoxDepartEmp.TabIndex = 3;
            // 
            // LblSSn
            // 
            this.LblSSn.AutoSize = true;
            this.LblSSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSSn.Location = new System.Drawing.Point(358, 25);
            this.LblSSn.Name = "LblSSn";
            this.LblSSn.Size = new System.Drawing.Size(46, 20);
            this.LblSSn.TabIndex = 4;
            this.LblSSn.Text = "SSN";
            // 
            // SsnTxt
            // 
            this.SsnTxt.Location = new System.Drawing.Point(569, 21);
            this.SsnTxt.Name = "SsnTxt";
            this.SsnTxt.Size = new System.Drawing.Size(175, 22);
            this.SsnTxt.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(569, 74);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(175, 22);
            this.FirstNameTxt.TabIndex = 7;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(569, 122);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(175, 22);
            this.LastNameTxt.TabIndex = 8;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(569, 170);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(175, 22);
            this.AddressTxt.TabIndex = 9;
            // 
            // DeptNumTxt
            // 
            this.DeptNumTxt.Location = new System.Drawing.Point(569, 221);
            this.DeptNumTxt.Name = "DeptNumTxt";
            this.DeptNumTxt.Size = new System.Drawing.Size(175, 22);
            this.DeptNumTxt.TabIndex = 10;
            // 
            // SalaryTxt
            // 
            this.SalaryTxt.Location = new System.Drawing.Point(569, 274);
            this.SalaryTxt.Name = "SalaryTxt";
            this.SalaryTxt.Size = new System.Drawing.Size(175, 22);
            this.SalaryTxt.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(358, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 20);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(358, 124);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 20);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(357, 172);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // lblDeptNum
            // 
            this.lblDeptNum.AutoSize = true;
            this.lblDeptNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptNum.Location = new System.Drawing.Point(357, 223);
            this.lblDeptNum.Name = "lblDeptNum";
            this.lblDeptNum.Size = new System.Drawing.Size(178, 20);
            this.lblDeptNum.TabIndex = 15;
            this.lblDeptNum.Text = "Department Number";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(357, 276);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(62, 20);
            this.lblSalary.TabIndex = 16;
            this.lblSalary.Text = "Salary";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(357, 329);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(96, 20);
            this.lblBirthDate.TabIndex = 17;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDatePicker.Location = new System.Drawing.Point(569, 322);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(175, 27);
            this.BirthDatePicker.TabIndex = 18;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Location = new System.Drawing.Point(362, 390);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 30);
            this.ButtonAdd.TabIndex = 19;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.Location = new System.Drawing.Point(516, 390);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(78, 30);
            this.ButtonUpdate.TabIndex = 20;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(669, 390);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 30);
            this.ButtonDelete.TabIndex = 21;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // FormBirthDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDeptNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.SalaryTxt);
            this.Controls.Add(this.DeptNumTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.SsnTxt);
            this.Controls.Add(this.LblSSn);
            this.Controls.Add(this.LstBoxDepartEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblChooseDepart);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormBirthDate";
            this.Text = "BirthDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblChooseDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstBoxDepartEmp;
        private System.Windows.Forms.Label LblSSn;
        private System.Windows.Forms.TextBox SsnTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox DeptNumTxt;
        private System.Windows.Forms.TextBox SalaryTxt;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDeptNum;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

