﻿namespace WPC_1
{
    partial class CanviContrasenya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanviContrasenya));
            buttonConfirmaCanviPwd = new Button();
            newPassword2 = new TextBox();
            label3 = new Label();
            newPassword1 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            labelCancelCanviPwd = new Label();
            SuspendLayout();
            // 
            // buttonConfirmaCanviPwd
            // 
            buttonConfirmaCanviPwd.Anchor = AnchorStyles.None;
            buttonConfirmaCanviPwd.BackColor = Color.FromArgb(107, 55, 35);
            buttonConfirmaCanviPwd.FlatStyle = FlatStyle.Popup;
            buttonConfirmaCanviPwd.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirmaCanviPwd.ForeColor = Color.FromArgb(64, 0, 0);
            buttonConfirmaCanviPwd.Location = new Point(320, 226);
            buttonConfirmaCanviPwd.Name = "buttonConfirmaCanviPwd";
            buttonConfirmaCanviPwd.Size = new Size(202, 78);
            buttonConfirmaCanviPwd.TabIndex = 32;
            buttonConfirmaCanviPwd.Text = "Confirmar";
            buttonConfirmaCanviPwd.UseVisualStyleBackColor = false;
            buttonConfirmaCanviPwd.Click += buttonConfirmaRegister_Click;
            // 
            // newPassword2
            // 
            newPassword2.Anchor = AnchorStyles.None;
            newPassword2.Location = new Point(370, 162);
            newPassword2.Name = "newPassword2";
            newPassword2.Size = new Size(274, 31);
            newPassword2.TabIndex = 31;
            newPassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(107, 55, 35);
            label3.Location = new Point(185, 165);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 30;
            label3.Text = "Repetir contrasenya";
            // 
            // newPassword1
            // 
            newPassword1.Anchor = AnchorStyles.None;
            newPassword1.Location = new Point(370, 108);
            newPassword1.Name = "newPassword1";
            newPassword1.Size = new Size(274, 31);
            newPassword1.TabIndex = 29;
            newPassword1.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.FromArgb(107, 55, 35);
            label6.Location = new Point(185, 111);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 28;
            label6.Text = "Nova contrasenya";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 55, 35);
            label2.Location = new Point(163, 21);
            label2.Name = "label2";
            label2.Size = new Size(517, 60);
            label2.TabIndex = 22;
            label2.Text = "Canviar la contrasenya";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCancelCanviPwd
            // 
            labelCancelCanviPwd.Anchor = AnchorStyles.None;
            labelCancelCanviPwd.AutoSize = true;
            labelCancelCanviPwd.BackColor = Color.Transparent;
            labelCancelCanviPwd.Cursor = Cursors.Hand;
            labelCancelCanviPwd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelCanviPwd.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelCanviPwd.Location = new Point(367, 314);
            labelCancelCanviPwd.Name = "labelCancelCanviPwd";
            labelCancelCanviPwd.Size = new Size(109, 30);
            labelCancelCanviPwd.TabIndex = 33;
            labelCancelCanviPwd.Text = "Cancel.lar";
            labelCancelCanviPwd.Click += labelCancelCanviPwd_Click;
            // 
            // CanviContrasenya
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 378);
            Controls.Add(labelCancelCanviPwd);
            Controls.Add(buttonConfirmaCanviPwd);
            Controls.Add(newPassword2);
            Controls.Add(label3);
            Controls.Add(newPassword1);
            Controls.Add(label6);
            Controls.Add(label2);
            Name = "CanviContrasenya";
            Text = "Canvi de Contrasenya";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonConfirmaCanviPwd;
        private TextBox newPassword2;
        private Label label3;
        private TextBox newPassword1;
        private Label label6;
        private Label label2;
        private Label labelCancelCanviPwd;
    }
}