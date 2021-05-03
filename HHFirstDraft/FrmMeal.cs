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
    public partial class FrmMeal : Form
    {
        public FrmMeal()
        {
            InitializeComponent();
        }
        MealDTO dto = new MealDTO();
        MealBLL bll = new MealBLL();
        private void FrmMeal_Load(object sender, EventArgs e)
        {
            ShowMeals();
        }
        public void ShowMeals()
        {
            bll = new MealBLL();
            if(isSearch) dto = bll.GetMeals(keyword);
            else dto = bll.GetMeals();
            dataGridView1.DataSource = dto.Meals;
            dataGridView1.Columns["ID"].HeaderText = "餐點編號";
            dataGridView1.Columns["Name"].HeaderText = "餐點名稱";
            dataGridView1.Columns["Calories"].HeaderText = "卡路里";
            if (dataGridView2.DataSource != null)
            {
                dataGridView2.Columns["ID"].HeaderText = "標籤編號";
                dataGridView2.Columns["Name"].HeaderText = "標籤名稱";
            }
            isSearch = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddMeal frm = new FrmAddMeal(this);
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.IsUpdate = false;
            frm.Show();
        }
        bool isSearch = false;
        string keyword;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            keyword = textBox1.Text;
            isSearch = true;
            ShowMeals();
        }
        bool isAscending = true;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<MealDetailDTO> list = (List<MealDetailDTO>)dataGridView1.DataSource;
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
        MealDetailDTO detail = new MealDetailDTO();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddMeal frm = new FrmAddMeal(this);
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.detail = detail;
            frm.IsUpdate = true;
            frm.Show();
        }
        List<TagCategoryDetailDTO> categories = new List<TagCategoryDetailDTO>();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            detail.Calories = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Calories"].Value);
            categories = bll.GetTagsWithMealID(detail.ID);
            dataGridView2.DataSource = categories;
            detail.Tags = categories;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你確定欲刪除該餐點 " + detail.Name + " ?", "警告", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (bll.HasTags(detail.ID))
                {
                    bll.RemoveTags(detail.ID); // Delete tags first.
                    MessageBox.Show("附帶餐點標籤已刪除");
                }

                if (bll.Delete(detail.ID)) // Then delete meals.
                {
                    MessageBox.Show("餐點已刪除");
                    bll = new MealBLL();
                    dto = bll.GetMeals();
                    ShowMeals();
                    this.textBox1.Clear();
                }
                
                
            }
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            FrmTag frm = new FrmTag();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            bll = new MealBLL();
            dto = bll.GetMeals();
            ShowMeals();
        }
    }
}
