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
    public partial class FrmFrontendMain : Form
    {
        public FrmFrontendMain()
        {
            InitializeComponent();
        }

        private void btnWorkoutLog_Click(object sender, EventArgs e)
        {
            FrmFrontendWorkoutLog frm = new FrmFrontendWorkoutLog();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFrontendWorkoutLog frm = new FrmFrontendWorkoutLog();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
    }
}
