namespace GUI
{
    partial class frm_ThayDoiMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MKCu = new System.Windows.Forms.TextBox();
            this.txt_XNMK = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_ThayDoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MKMoi = new System.Windows.Forms.TextBox();
            this.ckb_HienThiMK = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác nhận mật khẩu: ";
            // 
            // txt_MKCu
            // 
            this.txt_MKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MKCu.Location = new System.Drawing.Point(231, 25);
            this.txt_MKCu.Name = "txt_MKCu";
            this.txt_MKCu.PasswordChar = '•';
            this.txt_MKCu.Size = new System.Drawing.Size(249, 30);
            this.txt_MKCu.TabIndex = 0;
            // 
            // txt_XNMK
            // 
            this.txt_XNMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XNMK.Location = new System.Drawing.Point(231, 146);
            this.txt_XNMK.Name = "txt_XNMK";
            this.txt_XNMK.PasswordChar = '•';
            this.txt_XNMK.Size = new System.Drawing.Size(249, 30);
            this.txt_XNMK.TabIndex = 2;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(346, 317);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(143, 45);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_ThayDoi
            // 
            this.btn_ThayDoi.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ThayDoi.FlatAppearance.BorderSize = 0;
            this.btn_ThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThayDoi.ForeColor = System.Drawing.Color.White;
            this.btn_ThayDoi.Location = new System.Drawing.Point(576, 317);
            this.btn_ThayDoi.Name = "btn_ThayDoi";
            this.btn_ThayDoi.Size = new System.Drawing.Size(143, 45);
            this.btn_ThayDoi.TabIndex = 4;
            this.btn_ThayDoi.Text = "Thay đổi";
            this.btn_ThayDoi.UseVisualStyleBackColor = false;
            this.btn_ThayDoi.Click += new System.EventHandler(this.btn_ThayDoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới: ";
            // 
            // txt_MKMoi
            // 
            this.txt_MKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MKMoi.Location = new System.Drawing.Point(231, 84);
            this.txt_MKMoi.Name = "txt_MKMoi";
            this.txt_MKMoi.PasswordChar = '•';
            this.txt_MKMoi.Size = new System.Drawing.Size(249, 30);
            this.txt_MKMoi.TabIndex = 1;
            // 
            // ckb_HienThiMK
            // 
            this.ckb_HienThiMK.AutoSize = true;
            this.ckb_HienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_HienThiMK.Location = new System.Drawing.Point(231, 199);
            this.ckb_HienThiMK.Name = "ckb_HienThiMK";
            this.ckb_HienThiMK.Size = new System.Drawing.Size(184, 29);
            this.ckb_HienThiMK.TabIndex = 3;
            this.ckb_HienThiMK.Text = "Hiển thị mật khẩu";
            this.ckb_HienThiMK.UseVisualStyleBackColor = true;
            this.ckb_HienThiMK.CheckedChanged += new System.EventHandler(this.ckb_HienThiMK_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_HienThiMK);
            this.groupBox1.Controls.Add(this.txt_XNMK);
            this.groupBox1.Controls.Add(this.txt_MKMoi);
            this.groupBox1.Controls.Add(this.txt_MKCu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(273, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // frm_ThayDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ThayDoi);
            this.Controls.Add(this.btn_Huy);
            this.Name = "frm_ThayDoiMK";
            this.Text = "Thay đổi mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MKCu;
        private System.Windows.Forms.TextBox txt_XNMK;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_ThayDoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MKMoi;
        private System.Windows.Forms.CheckBox ckb_HienThiMK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}