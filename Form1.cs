using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StMana_Nhap
{
    public partial class frmStudent : Form
    {
        StudentsDAO stDAO = new StudentsDAO();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = stDAO.LoadDataForSt();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            stDAO.AddSt(st);
            dgvStudent.DataSource = stDAO.LoadDataForSt();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool gt = rdbWoman.Checked ? true : false;
            Students st = new Students(txtId.Text, txtName.Text, txtEmail.Text, gt, txtAddress.Text, txtPhone.Text, txtCCCD.Text, dtpBirthday.Value);
            stDAO.RemoveSt(st);
            dgvStudent.DataSource = stDAO.LoadDataForSt();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = stDAO.LoadDataForSt();
        }
    }
}
