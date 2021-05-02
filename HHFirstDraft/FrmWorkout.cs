﻿using HHFirstDraft.BLL;
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
    public partial class FrmWorkout : Form
    {
        public FrmWorkout()
        {
            InitializeComponent();
        }
        WorkoutBLL bll = new WorkoutBLL();
        WorkoutDTO dto = new WorkoutDTO();
        WorkoutCategoryBLL categoryBLL = new WorkoutCategoryBLL();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWorkout_Load(object sender, EventArgs e)
        {
            dto = bll.GetWorkouts();
            ShowWorkouts();
        }

        private void ShowWorkouts()
        {
            dataGridView1.DataSource = dto.Workouts;
            dataGridView1.Columns["ID"].HeaderText = "編號";
            dataGridView1.Columns["Name"].HeaderText = "名稱";
            dataGridView1.Columns["Calories"].HeaderText = "卡路里";
            dataGridView1.Columns["ActivityLevel"].HeaderText = "活動強度";
            dataGridView1.Columns["CategoryName"].HeaderText = "類別";
            dataGridView1.Columns["CategoryID"].Visible = false;
            dataGridView1.Columns["ActivityLevelID"].Visible = false;
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            FrmAddWorkoutCat frm = new FrmAddWorkoutCat();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            bll = new WorkoutBLL();
            dto = bll.GetWorkouts();
            ShowWorkouts();
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            FrmAddWorkout frm = new FrmAddWorkout();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            bll = new WorkoutBLL();
            dto = bll.GetWorkouts();
            ShowWorkouts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dto = bll.GetWorkouts(textBox1.Text);
            ShowWorkouts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddWorkout frm = new FrmAddWorkout();
            frm.detail = detail;
            frm.dto = dto;
            frm.IsUpdate = true;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            bll = new WorkoutBLL();
            dto = bll.GetWorkouts();
            ShowWorkouts();
        }
        WorkoutDetailDTO detail = new WorkoutDetailDTO();

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            detail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CategoryID"].Value);
            detail.ActivityLevelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ActivityLevelID"].Value);
            detail.Calories = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Calories"].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你確定欲刪除該運動 " + detail.Name + " ?", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.Delete(detail.ID))
                {
                    MessageBox.Show("已刪除該運動項目");
                    bll = new WorkoutBLL();
                    dto = bll.GetWorkouts();
                    ShowWorkouts();
                    this.textBox1.Clear();
                }
            }
        }
        bool isAscending = false;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<WorkoutDetailDTO> list = (List<WorkoutDetailDTO>)dataGridView1.DataSource;
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
    }
}