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
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
        }
        public MemberDTO dto = new MemberDTO();
        MemberBLL bll = new MemberBLL();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            LoadcomboBox();
        }

        private void LoadcomboBox()
        {
            cmbActivities.DataSource = dto.ActivityLevels;
            cmbActivities.DisplayMember = "Description";
            cmbActivities.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberDetailDTO detail = new MemberDetailDTO();
            if (txtName.Text == "" ||
                txtEmail.Text == "" ||
                txtPhone.Text == "" ||
                dpBirth.Value == DateTime.Now ||
                txtPassword.Text == "" ||
                (!rbMale.Checked && !rbFemale.Checked) ||
                txtHeight.Text == "" ||
                cmbActivities.SelectedIndex == -1 ||
                txtTaiwanID.Text == ""
                )
            {
                MessageBox.Show("請填寫所有欄位");
            }
            else
            {
                detail.Name = txtName.Text;
                detail.Email = txtEmail.Text;
                detail.Phone = txtPhone.Text;
                detail.Birthdate = dpBirth.Value;
                detail.Password = txtPassword.Text;
                if (rbMale.Checked)
                {
                    detail.Gender = true;
                }
                else
                {
                    detail.Gender = false;
                }
                detail.TaiwanID = txtTaiwanID.Text;
                detail.Height = Convert.ToInt32(txtHeight.Text);
                detail.ActivityLevelID = Convert.ToInt32(cmbActivities.SelectedValue);
                detail.IsAdmin = cbIsAdmin.Checked;
                detail.StatusID = General.Status.active;
                detail.JoinDate = DateTime.Now;
                if (bll.Add(detail))
                {
                    MessageBox.Show("已新增會員");
                    this.Close();
                }
            }
           

        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
    }
}
