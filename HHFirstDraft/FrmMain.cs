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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FrmMember frm = new FrmMember();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            FrmWorkout frm = new FrmWorkout();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            FrmMeal frm = new FrmMeal();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            FrmTag frm = new FrmTag();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmAddWorkoutCat frm = new FrmAddWorkoutCat();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
    }
}
