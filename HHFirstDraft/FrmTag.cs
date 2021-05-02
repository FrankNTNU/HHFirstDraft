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
    public partial class FrmTag : Form
    {
        public FrmTag()
        {
            InitializeComponent();
        }
        TagCategoryBLL bll = new TagCategoryBLL();
        TagCategoryDTO dto = new TagCategoryDTO();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTag_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {
            dto.TagCategories = bll.GetTags();
            dataGridView1.DataSource = dto.TagCategories;
            dataGridView1.Columns["ID"].HeaderText = "標籤編號";
            dataGridView1.Columns["Name"].HeaderText = "標籤名稱";
            dto.Meals = bll.GetMealsWithTagID(detail.ID);
            dataGridView2.DataSource = dto.Meals;
            dataGridView2.Columns["ID"].HeaderText = "餐點編號";
            dataGridView2.Columns["Name"].HeaderText = "餐點名稱";
            dataGridView2.Columns["Calories"].HeaderText = "卡路里";
        }

        TagCategoryDetailDTO detail = new TagCategoryDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            dto.Meals = bll.GetMealsWithTagID(detail.ID);
            dataGridView2.DataSource = dto.Meals;
            textBox1.Text = detail.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入欲新增標籤名稱");
            }
            else if (bll.IsTagExist(textBox1.Text))
            {
                MessageBox.Show("該標籤已經存在");
            }
            else
            {
                TagCategoryDetailDTO detail = new TagCategoryDetailDTO();
                detail.Name = textBox1.Text;
                bll.Add(detail);
                MessageBox.Show("已新增標籤");
                bll = new TagCategoryBLL();
                RefreshPage();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入欲新增標籤名稱");
            }
           
            else
            {
                detail.Name = textBox1.Text;
                bll.Update(detail);
                MessageBox.Show("已修改標籤");
                bll = new TagCategoryBLL();
                RefreshPage();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你確定欲刪除該標籤 " + detail.Name + " ?", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.HasMeals(detail.ID))
                {
                    bll.RemoveAttachedTag(detail.ID);
                    MessageBox.Show("已清除所屬餐點的該附帶標籤");
                }
                bll.Delete(detail.ID);
                MessageBox.Show("已刪除標籤");
                bll = new TagCategoryBLL();
                RefreshPage();
            }
           
        }
    }
}
