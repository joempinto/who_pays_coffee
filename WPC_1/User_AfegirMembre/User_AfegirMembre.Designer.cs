﻿namespace WPC_1
{
    partial class User_AfegirMembre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_AfegirMembre));
            labelCancelAddMembre = new Label();
            confirmaAddMembreBtn = new Button();
            nicknameMembreTxt = new TextBox();
            labelNickname = new Label();
            idGrupTxt = new TextBox();
            labelGrupID = new Label();
            labelAfegir = new Label();
            checkUsername = new CheckBox();
            usernameTxt = new TextBox();
            labelUsername = new Label();
            SuspendLayout();
            // 
            // labelCancelAddMembre
            // 
            labelCancelAddMembre.Anchor = AnchorStyles.None;
            labelCancelAddMembre.AutoSize = true;
            labelCancelAddMembre.BackColor = Color.Transparent;
            labelCancelAddMembre.Cursor = Cursors.Hand;
            labelCancelAddMembre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelCancelAddMembre.ForeColor = Color.FromArgb(107, 55, 35);
            labelCancelAddMembre.Location = new Point(253, 389);
            labelCancelAddMembre.Name = "labelCancelAddMembre";
            labelCancelAddMembre.Size = new Size(109, 30);
            labelCancelAddMembre.TabIndex = 47;
            labelCancelAddMembre.Text = "Cancel.lar";
            labelCancelAddMembre.Click += labelCancelAddMembre_Click;
            // 
            // confirmaAddMembreBtn
            // 
            confirmaAddMembreBtn.Anchor = AnchorStyles.None;
            confirmaAddMembreBtn.BackColor = Color.FromArgb(107, 55, 35);
            confirmaAddMembreBtn.FlatStyle = FlatStyle.Popup;
            confirmaAddMembreBtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            confirmaAddMembreBtn.ForeColor = Color.FromArgb(64, 0, 0);
            confirmaAddMembreBtn.Location = new Point(216, 315);
            confirmaAddMembreBtn.Name = "confirmaAddMembreBtn";
            confirmaAddMembreBtn.Size = new Size(192, 67);
            confirmaAddMembreBtn.TabIndex = 46;
            confirmaAddMembreBtn.Text = "Confirmar";
            confirmaAddMembreBtn.UseVisualStyleBackColor = false;
            confirmaAddMembreBtn.Click += confirmaAddMembreBtn_Click;
            // 
            // nicknameMembreTxt
            // 
            nicknameMembreTxt.Anchor = AnchorStyles.None;
            nicknameMembreTxt.Location = new Point(259, 160);
            nicknameMembreTxt.Name = "nicknameMembreTxt";
            nicknameMembreTxt.Size = new Size(274, 31);
            nicknameMembreTxt.TabIndex = 45;
            // 
            // labelNickname
            // 
            labelNickname.Anchor = AnchorStyles.None;
            labelNickname.AutoSize = true;
            labelNickname.BackColor = Color.Transparent;
            labelNickname.ForeColor = Color.FromArgb(107, 55, 35);
            labelNickname.Location = new Point(74, 163);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(162, 25);
            labelNickname.TabIndex = 44;
            labelNickname.Text = "Nickname Membre";
            // 
            // idGrupTxt
            // 
            idGrupTxt.Anchor = AnchorStyles.None;
            idGrupTxt.Location = new Point(259, 106);
            idGrupTxt.Name = "idGrupTxt";
            idGrupTxt.Size = new Size(274, 31);
            idGrupTxt.TabIndex = 43;
            // 
            // labelGrupID
            // 
            labelGrupID.Anchor = AnchorStyles.None;
            labelGrupID.AutoSize = true;
            labelGrupID.BackColor = Color.Transparent;
            labelGrupID.ForeColor = Color.FromArgb(107, 55, 35);
            labelGrupID.Location = new Point(74, 109);
            labelGrupID.Name = "labelGrupID";
            labelGrupID.Size = new Size(74, 25);
            labelGrupID.TabIndex = 42;
            labelGrupID.Text = "ID Grup";
            // 
            // labelAfegir
            // 
            labelAfegir.Anchor = AnchorStyles.None;
            labelAfegir.AutoSize = true;
            labelAfegir.BackColor = Color.Transparent;
            labelAfegir.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelAfegir.ForeColor = Color.FromArgb(107, 55, 35);
            labelAfegir.Location = new Point(139, 13);
            labelAfegir.Name = "labelAfegir";
            labelAfegir.Size = new Size(357, 60);
            labelAfegir.TabIndex = 41;
            labelAfegir.Text = "Afegir Membre";
            labelAfegir.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkUsername
            // 
            checkUsername.AutoSize = true;
            checkUsername.BackColor = Color.Transparent;
            checkUsername.ForeColor = Color.FromArgb(107, 55, 35);
            checkUsername.Location = new Point(105, 207);
            checkUsername.Name = "checkUsername";
            checkUsername.Size = new Size(135, 29);
            checkUsername.TabIndex = 48;
            checkUsername.Text = "Ja Registrat?";
            checkUsername.UseVisualStyleBackColor = false;
            checkUsername.CheckedChanged += checkUsername_CheckedChanged;
            // 
            // usernameTxt
            // 
            usernameTxt.Anchor = AnchorStyles.None;
            usernameTxt.Location = new Point(259, 249);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(274, 31);
            usernameTxt.TabIndex = 49;
            usernameTxt.Visible = false;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.ForeColor = Color.FromArgb(107, 55, 35);
            labelUsername.Location = new Point(145, 252);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 50;
            labelUsername.Text = "Username";
            labelUsername.Visible = false;
            // 
            // User_AfegirMembre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(607, 427);
            Controls.Add(labelUsername);
            Controls.Add(usernameTxt);
            Controls.Add(checkUsername);
            Controls.Add(labelCancelAddMembre);
            Controls.Add(confirmaAddMembreBtn);
            Controls.Add(nicknameMembreTxt);
            Controls.Add(labelNickname);
            Controls.Add(idGrupTxt);
            Controls.Add(labelGrupID);
            Controls.Add(labelAfegir);
            Name = "User_AfegirMembre";
            Text = "User_AfegirMembre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCancelAddMembre;
        private Button confirmaAddMembreBtn;
        private TextBox nicknameMembreTxt;
        private Label labelNickname;
        private TextBox idGrupTxt;
        private Label labelGrupID;
        private Label labelAfegir;
        private CheckBox checkUsername;
        private TextBox usernameTxt;
        private Label labelUsername;
    }
}