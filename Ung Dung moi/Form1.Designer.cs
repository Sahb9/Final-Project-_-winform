namespace Ung_Dung_moi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonQLNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonQLSach = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.quanLySach1 = new Ung_Dung_moi.QuanLySach();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.guna2ButtonQLNhanVien);
            this.guna2Panel1.Controls.Add(this.guna2ButtonQLSach);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(167, 579);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ButtonQLNhanVien
            // 
            this.guna2ButtonQLNhanVien.CheckedState.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.CustomImages.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonQLNhanVien.HoverState.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.Location = new System.Drawing.Point(-23, 217);
            this.guna2ButtonQLNhanVien.Name = "guna2ButtonQLNhanVien";
            this.guna2ButtonQLNhanVien.ShadowDecoration.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.Size = new System.Drawing.Size(193, 42);
            this.guna2ButtonQLNhanVien.TabIndex = 4;
            this.guna2ButtonQLNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // guna2ButtonQLSach
            // 
            this.guna2ButtonQLSach.CheckedState.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.CustomImages.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonQLSach.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonQLSach.HoverState.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.Location = new System.Drawing.Point(-29, 169);
            this.guna2ButtonQLSach.Name = "guna2ButtonQLSach";
            this.guna2ButtonQLSach.ShadowDecoration.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.Size = new System.Drawing.Size(196, 42);
            this.guna2ButtonQLSach.TabIndex = 3;
            this.guna2ButtonQLSach.Text = "Quản Lý Sách";
            this.guna2ButtonQLSach.Click += new System.EventHandler(this.guna2ButtonQLSach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this.guna2ButtonQLSach;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.guna2ButtonQLNhanVien;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(167, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(849, 579);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.quanLySach1);
            this.guna2Panel3.Location = new System.Drawing.Point(3, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(843, 572);
            this.guna2Panel3.TabIndex = 1;
            // 
            // quanLySach1
            // 
            this.quanLySach1.Location = new System.Drawing.Point(3, -1);
            this.quanLySach1.Name = "quanLySach1";
            this.quanLySach1.Size = new System.Drawing.Size(834, 564);
            this.quanLySach1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1016, 579);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonQLSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonQLNhanVien;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private QuanLySach quanLySach1;
    }
}

