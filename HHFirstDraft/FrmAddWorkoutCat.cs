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
    public partial class FrmAddWorkoutCat : Form
    {
        public FrmAddWorkoutCat()
        {
            InitializeComponent();
        }
        WorkoutCategoryBLL bll = new WorkoutCategoryBLL();

        WorkoutCategoryDTO dto = new WorkoutCategoryDTO();
        private void FrmAddWorkoutCat_Load(object sender, EventArgs e)
        {

            dto = bll.GetCategories();
            dataGridView1.DataSource = dto.Categories;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            WorkoutCategoryDetailDTO detail = new WorkoutCategoryDetailDTO();
            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入名稱");
            }
            else if (bll.IsCategoryExist(txtName.Text))
            {
                MessageBox.Show("該類別名稱已存在");

            }
            else
            {
                detail.Name = txtName.Text;
                if (bll.Add(detail))
                {
                    MessageBox.Show("已新增運動類別");
                    dto = bll.GetCategories();
                    dataGridView1.DataSource = dto.Categories;
                    txtName.Clear();
                }
            }
        }
        WorkoutCategoryDetailDTO selectedDetail = new WorkoutCategoryDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedDetail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            selectedDetail.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtName.Text = selectedDetail.Name;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("名稱不得為空白");
            }
            else if (txtName.Text == selectedDetail.Name)
            {
                MessageBox.Show("若欲修改，請輸入一個新的名稱");
            }
            else
            {
                selectedDetail.Name = txtName.Text;
                bll.Update(selectedDetail);
                MessageBox.Show("已修改類別名稱");
                dto = bll.GetCategories();
                dataGridView1.DataSource = dto.Categories;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你確定欲刪除該類別 " + selectedDetail.Name + " ?", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.HasWorkouts(selectedDetail.ID))
                {
                    MessageBox.Show("該類別已存在運動項目，請先刪除運動項目再行刪除");
                }
                else
                {
                    bll.Delete(selectedDetail.ID);
                    MessageBox.Show("已刪除類別");
                    dto = bll.GetCategories();
                    dataGridView1.DataSource = dto.Categories;
                }
            }
        }
    }
}
