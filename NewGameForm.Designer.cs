namespace FinalProject
{
    partial class NewGameForm
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
            gbGamer = new GroupBox();
            lblNameHeading = new Label();
            txtName = new TextBox();
            txtFavoriteGame = new TextBox();
            lblFavoriteHeading = new Label();
            txtPlatform = new TextBox();
            lblPlatformHeading = new Label();
            txtHours = new TextBox();
            lblHoursHeading = new Label();
            btnSave = new Button();
            gbGamer.SuspendLayout();
            SuspendLayout();
            // 
            // gbGamer
            // 
            gbGamer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbGamer.AutoSize = true;
            gbGamer.Controls.Add(btnSave);
            gbGamer.Controls.Add(txtHours);
            gbGamer.Controls.Add(lblHoursHeading);
            gbGamer.Controls.Add(txtPlatform);
            gbGamer.Controls.Add(lblPlatformHeading);
            gbGamer.Controls.Add(txtFavoriteGame);
            gbGamer.Controls.Add(lblFavoriteHeading);
            gbGamer.Controls.Add(txtName);
            gbGamer.Controls.Add(lblNameHeading);
            gbGamer.Location = new Point(12, 12);
            gbGamer.Name = "gbGamer";
            gbGamer.Size = new Size(425, 186);
            gbGamer.TabIndex = 0;
            gbGamer.TabStop = false;
            gbGamer.Text = "Favorite Game";
            // 
            // lblNameHeading
            // 
            lblNameHeading.AutoSize = true;
            lblNameHeading.Location = new Point(10, 25);
            lblNameHeading.Name = "lblNameHeading";
            lblNameHeading.Size = new Size(42, 15);
            lblNameHeading.TabIndex = 0;
            lblNameHeading.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(102, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 23);
            txtName.TabIndex = 1;
            // 
            // txtFavoriteGame
            // 
            txtFavoriteGame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFavoriteGame.Location = new Point(102, 51);
            txtFavoriteGame.Name = "txtFavoriteGame";
            txtFavoriteGame.Size = new Size(314, 23);
            txtFavoriteGame.TabIndex = 3;
            // 
            // lblFavoriteHeading
            // 
            lblFavoriteHeading.AutoSize = true;
            lblFavoriteHeading.Location = new Point(10, 54);
            lblFavoriteHeading.Name = "lblFavoriteHeading";
            lblFavoriteHeading.Size = new Size(86, 15);
            lblFavoriteHeading.TabIndex = 2;
            lblFavoriteHeading.Text = "Favorite Game:";
            // 
            // txtPlatform
            // 
            txtPlatform.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPlatform.Location = new Point(102, 80);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(314, 23);
            txtPlatform.TabIndex = 5;
            // 
            // lblPlatformHeading
            // 
            lblPlatformHeading.AutoSize = true;
            lblPlatformHeading.Location = new Point(10, 83);
            lblPlatformHeading.Name = "lblPlatformHeading";
            lblPlatformHeading.Size = new Size(56, 15);
            lblPlatformHeading.TabIndex = 4;
            lblPlatformHeading.Text = "Platform:";
            // 
            // txtHours
            // 
            txtHours.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHours.Location = new Point(102, 109);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(314, 23);
            txtHours.TabIndex = 7;
            // 
            // lblHoursHeading
            // 
            lblHoursHeading.AutoSize = true;
            lblHoursHeading.Location = new Point(10, 112);
            lblHoursHeading.Name = "lblHoursHeading";
            lblHoursHeading.Size = new Size(70, 15);
            lblHoursHeading.TabIndex = 6;
            lblHoursHeading.Text = "Total Hours:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(344, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 188);
            Controls.Add(gbGamer);
            Name = "NewGameForm";
            Text = "New Game Form";
            gbGamer.ResumeLayout(false);
            gbGamer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbGamer;
        private Label lblNameHeading;
        private TextBox txtName;
        private TextBox txtHours;
        private Label lblHoursHeading;
        private TextBox txtPlatform;
        private Label lblPlatformHeading;
        private TextBox txtFavoriteGame;
        private Label lblFavoriteHeading;
        private Button btnSave;
    }
}