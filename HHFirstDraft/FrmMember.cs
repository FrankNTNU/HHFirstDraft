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
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }
        MemberDTO dto = new MemberDTO();
        MemberBLL bll = new MemberBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            dto = bll.GetMembers();
            showMembers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            dto = bll.GetMembers(keyword);
            showMembers();
        }

        MemberDetailDTO detail = new MemberDetailDTO();
        private void showMembers()
        {
            dataGridView1.DataSource = dto.Members;
            dataGridView1.Columns["ID"].HeaderText = "編號";
            dataGridView1.Columns["Name"].HeaderText = "姓名";
            dataGridView1.Columns["GenderString"].HeaderText = "性別";
            dataGridView1.Columns["Gender"].Visible = false;
            dataGridView1.Columns["Birthdate"].HeaderText = "生日";
            dataGridView1.Columns["JoinDate"].HeaderText = "加入日期";
            dataGridView1.Columns["Phone"].HeaderText = "電話";
            dataGridView1.Columns["Status"].HeaderText = "狀態";
            dataGridView1.Columns["StatusID"].Visible = false;
            dataGridView1.Columns["TaiwanID"].HeaderText = "身分證字號";
            dataGridView1.Columns["IsAdmin"].HeaderText = "管理員";
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["ActivityLevelID"].Visible = false;
            dataGridView1.Columns["ActivityLevel"].HeaderText = "活動量";
            dataGridView1.Columns["Height"].Visible = false;

        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            detail.Email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            detail.Phone = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            detail.Status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            detail.StatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StatusID"].Value);
            detail.Birthdate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["Birthdate"].Value.ToString());
            detail.JoinDate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["JoinDate"].Value.ToString());
            detail.Gender = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value);
            detail.Password = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            detail.TaiwanID = dataGridView1.Rows[e.RowIndex].Cells["TaiwanID"].Value.ToString();
            detail.Height = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Height"].Value);
            detail.ActivityLevelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ActivityLevelID"].Value);
            detail.ActivityLevel = dataGridView1.Rows[e.RowIndex].Cells["ActivityLevel"].Value.ToString();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("請選擇一名會員");
            }
            else
            {
                FrmAddMember frm = new FrmAddMember();
                frm.detail = detail;
                frm.dto = dto;
                frm.IsUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new MemberBLL();
                dto = bll.GetMembers();
                showMembers();
                this.textBox1.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
            {
                MessageBox.Show("請選擇一名會員");
            }
            else
            {
                DialogResult result = MessageBox.Show("你確定欲刪除該會員 " + detail.Name + " ?", "警告", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail.ID))
                    {
                        MessageBox.Show("會員已刪除");
                        bll = new MemberBLL();
                        dto = bll.GetMembers();
                        showMembers();
                        this.textBox1.Clear();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddMember frm = new FrmAddMember();
            this.Hide();
            frm.dto = dto;
            frm.ShowDialog();
            this.Visible = true;
            bll = new MemberBLL();
            dto = bll.GetMembers();
            showMembers();
            this.textBox1.Clear();
        }
        bool isAscending = true;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<MemberDetailDTO> list = (List<MemberDetailDTO>)dataGridView1.DataSource;
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (isAscending)
            {
                dataGridView1.DataSource = list.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
                isAscending = false;
            }
            else
            {
                isAscending = true;
                dataGridView1.DataSource = list.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
