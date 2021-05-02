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
    public partial class FrmAddMeal : Form
    {
        private FrmMeal mealForm;
        public FrmAddMeal(FrmMeal _mealForm)
        {
            mealForm = _mealForm;
            InitializeComponent();
        }
        MealBLL bll = new MealBLL();
        public MealDetailDTO detail = new MealDetailDTO();
        public bool IsUpdate = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCalories.Text == "")
            {
                MessageBox.Show("請輸入所有欄位");
            }
            else
            {
                detail.Name = txtName.Text;
                detail.Calories = Convert.ToInt32(txtCalories.Text);
                if (IsUpdate)
                {
                    int mealID = detail.ID;
                    for (int i = 0; i < clbTag.Items.Count; i++)
                    {
                        TagCategoryDetailDTO dto = clbTag.Items[i] as TagCategoryDetailDTO;
                        int categoryID = dto.ID;
                        if (clbTag.GetItemChecked(i)) // Checked.
                        {
                            if (!bll.HasTag(mealID, categoryID)) // Had not been checked.
                            {
                                bll.AddTag(mealID, categoryID); // Check it!
                            }
                        }
                        else // Not checked.
                        {
                            if (bll.HasTag(mealID, categoryID)) // But it WAS checked.
                            {
                                bll.RemoveTag(mealID, categoryID); // Uncheck it.
                            }
                        }
                    }
                    //detail.Tags = bll.GetTagsWithMealID(mealID);
                    bll.Update(detail);
                    MessageBox.Show("已更新餐點資訊");
                    this.Close();
                }
                else
                {
                    if (bll.IsMealExist(detail.Name))
                    {
                        MessageBox.Show("餐點名稱已存在");
                    }
                    else
                    {
                        int mealID = bll.Add(detail);
                        for (int i = 0; i < clbTag.Items.Count; i++)
                        {
                            TagCategoryDetailDTO dto = clbTag.Items[i] as TagCategoryDetailDTO;
                            int categoryID = dto.ID;
                            if (clbTag.GetItemChecked(i)) // Checked.
                            {
                                if (!bll.HasTag(mealID, categoryID)) // Had not been checked.
                                {
                                    bll.AddTag(mealID, categoryID); // Check it!
                                }
                            }
                        }
                        MessageBox.Show("已新增餐點");
                        this.Close();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TagCategoryBLL tagBLL = new TagCategoryBLL();
        TagCategoryDTO tagDTO = new TagCategoryDTO();
        private void FrmAddMeal_Load(object sender, EventArgs e)
        {
            tagDTO.TagCategories = tagBLL.GetTags();
            clbTag.DataSource = tagDTO.TagCategories;
            clbTag.DisplayMember = "Name";
            clbTag.ValueMember = "ID";

            if (IsUpdate)
            {
                lbTitle.Text = "修改餐點頁面";
                btnAdd.Text = "修改";
                btnAdd.BackColor = Color.LightSkyBlue;
                txtName.Text = detail.Name;
                txtCalories.Text = detail.Calories.ToString();
                foreach (var item in detail.Tags)
                {
                    int index = clbTag.FindStringExact(item.Name);
                    clbTag.SetItemChecked(index, true);
                }
            }
        }

        private void FrmAddMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
            mealForm.ShowMeals();
        }
    }
}
