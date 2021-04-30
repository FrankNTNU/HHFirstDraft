using HHFirstDraft.BLL;
using HHFirstDraft.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHFirstDraft
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }
        public MemberDetailDTO detail = new MemberDetailDTO();
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            loadComboBox();
            txtName.Text = detail.Name;
            txtEmail.Text = detail.Email;
            txtPhone.Text = detail.Phone;
            txtBirth.Text = detail.Birthdate.ToString();
            rbMale.Checked = detail.Gender;
            rbFemale.Checked = !detail.Gender;
            txtJoindate.Text = detail.JoinDate.ToString();
            cmbStatus.SelectedValue = detail.StatusID;
            txtJoindate.Enabled = false;
        }
        StatusBLL bll = new StatusBLL();
        MemberBLL memberBLL = new MemberBLL();
        public MemberDTO dto = new MemberDTO();
        private void loadComboBox()
        {
            cmbStatus.DataSource = dto.Statuses;
            cmbStatus.DisplayMember = "Description";
            cmbStatus.ValueMember = "ID";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            detail.Name = txtName.Text;
            detail.Email = txtEmail.Text;
            detail.Gender = rbMale.Checked;
            detail.Phone = txtPhone.Text;
            detail.StatusID = Convert.ToInt32(cmbStatus.SelectedValue);
            memberBLL.Update(detail);
            MessageBox.Show("成功更新");
            this.Close();
        }
    }
}
