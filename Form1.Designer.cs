﻿namespace StMana_Nhap
{
    partial class frmStudent
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
            this.lblKw = new System.Windows.Forms.Label();
            this.txtKw = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.grbStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKw
            // 
            this.lblKw.AutoSize = true;
            this.lblKw.Location = new System.Drawing.Point(576, 26);
            this.lblKw.Name = "lblKw";
            this.lblKw.Size = new System.Drawing.Size(56, 16);
            this.lblKw.TabIndex = 25;
            this.lblKw.Text = "Từ khóa";
            // 
            // txtKw
            // 
            this.txtKw.Location = new System.Drawing.Point(651, 23);
            this.txtKw.Name = "txtKw";
            this.txtKw.Size = new System.Drawing.Size(200, 22);
            this.txtKw.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(857, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 36);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(299, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 36);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(155, 466);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 36);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(382, 67);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(588, 474);
            this.dgvStudent.TabIndex = 20;
            // 
            // grbStudent
            // 
            this.grbStudent.Controls.Add(this.rdbWoman);
            this.grbStudent.Controls.Add(this.rdbMan);
            this.grbStudent.Controls.Add(this.txtCCCD);
            this.grbStudent.Controls.Add(this.txtPhone);
            this.grbStudent.Controls.Add(this.txtAddress);
            this.grbStudent.Controls.Add(this.txtEmail);
            this.grbStudent.Controls.Add(this.txtName);
            this.grbStudent.Controls.Add(this.dtpBirthday);
            this.grbStudent.Controls.Add(this.txtId);
            this.grbStudent.Controls.Add(this.lblBirthday);
            this.grbStudent.Controls.Add(this.lblCCCD);
            this.grbStudent.Controls.Add(this.lblPhone);
            this.grbStudent.Controls.Add(this.lblAddress);
            this.grbStudent.Controls.Add(this.lblSex);
            this.grbStudent.Controls.Add(this.lblEmail);
            this.grbStudent.Controls.Add(this.lblName);
            this.grbStudent.Controls.Add(this.lblId);
            this.grbStudent.Location = new System.Drawing.Point(12, 67);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Size = new System.Drawing.Size(364, 364);
            this.grbStudent.TabIndex = 19;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "Dữ liệu sinh viên";
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(248, 150);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(45, 20);
            this.rdbWoman.TabIndex = 17;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "Nữ";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(158, 150);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(57, 20);
            this.rdbMan.TabIndex = 16;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "Nam";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(158, 270);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 22);
            this.txtCCCD.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(158, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(158, 184);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 10;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(158, 309);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthday.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(158, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 8;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(6, 316);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(132, 16);
            this.lblBirthday.TabIndex = 7;
            this.lblBirthday.Text = "Ngày tháng năm sinh";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(6, 276);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(122, 16);
            this.lblCCCD.TabIndex = 6;
            this.lblCCCD.Text = "Căn cước công dân";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 233);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 16);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 190);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(6, 150);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(54, 16);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Giới tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblKw);
            this.Controls.Add(this.txtKw);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.grbStudent);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.grbStudent.ResumeLayout(false);
            this.grbStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKw;
        private System.Windows.Forms.TextBox txtKw;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
    }
}

