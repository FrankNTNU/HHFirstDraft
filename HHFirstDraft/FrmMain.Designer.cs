namespace HHFirstDraft
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTag = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnWorkout = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnWeightLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 97);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans TC", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 75);
            this.label2.TabIndex = 6;
            this.label2.Text = "後台管理主頁面\r\n";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 97);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.btnWeightLog);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnTag);
            this.splitContainer1.Panel1.Controls.Add(this.btnMeal);
            this.splitContainer1.Panel1.Controls.Add(this.btnCategory);
            this.splitContainer1.Panel1.Controls.Add(this.btnWorkout);
            this.splitContainer1.Panel1.Controls.Add(this.btnMember);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 686);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 480);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(261, 96);
            this.button1.TabIndex = 9;
            this.button1.Text = "會員留言";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTag.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnTag.FlatAppearance.BorderSize = 0;
            this.btnTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTag.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTag.Location = new System.Drawing.Point(0, 384);
            this.btnTag.Name = "btnTag";
            this.btnTag.Padding = new System.Windows.Forms.Padding(5);
            this.btnTag.Size = new System.Drawing.Size(261, 96);
            this.btnTag.TabIndex = 7;
            this.btnTag.Text = "餐點標籤";
            this.btnTag.UseVisualStyleBackColor = false;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnMeal
            // 
            this.btnMeal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMeal.FlatAppearance.BorderSize = 0;
            this.btnMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeal.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeal.Location = new System.Drawing.Point(0, 288);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Padding = new System.Windows.Forms.Padding(5);
            this.btnMeal.Size = new System.Drawing.Size(261, 96);
            this.btnMeal.TabIndex = 6;
            this.btnMeal.Text = "餐點";
            this.btnMeal.UseVisualStyleBackColor = false;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 192);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(5);
            this.btnCategory.Size = new System.Drawing.Size(261, 96);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "運動分類";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnWorkout
            // 
            this.btnWorkout.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWorkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWorkout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnWorkout.FlatAppearance.BorderSize = 0;
            this.btnWorkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkout.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkout.Location = new System.Drawing.Point(0, 96);
            this.btnWorkout.Name = "btnWorkout";
            this.btnWorkout.Padding = new System.Windows.Forms.Padding(5);
            this.btnWorkout.Size = new System.Drawing.Size(261, 96);
            this.btnWorkout.TabIndex = 4;
            this.btnWorkout.Text = "運動";
            this.btnWorkout.UseVisualStyleBackColor = false;
            this.btnWorkout.Click += new System.EventHandler(this.btnWorkout_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMember.ForeColor = System.Drawing.Color.Black;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 0);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(5);
            this.btnMember.Size = new System.Drawing.Size(261, 96);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "會員";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnWeightLog
            // 
            this.btnWeightLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnWeightLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWeightLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeightLog.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnWeightLog.FlatAppearance.BorderSize = 0;
            this.btnWeightLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWeightLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeightLog.Font = new System.Drawing.Font("Noto Sans TC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWeightLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeightLog.Location = new System.Drawing.Point(0, 576);
            this.btnWeightLog.Name = "btnWeightLog";
            this.btnWeightLog.Padding = new System.Windows.Forms.Padding(5);
            this.btnWeightLog.Size = new System.Drawing.Size(261, 96);
            this.btnWeightLog.TabIndex = 10;
            this.btnWeightLog.Text = "體重記錄";
            this.btnWeightLog.UseVisualStyleBackColor = false;
            this.btnWeightLog.Click += new System.EventHandler(this.btnWeightLog_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 783);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnWorkout;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.Button btnMeal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWeightLog;
    }
}