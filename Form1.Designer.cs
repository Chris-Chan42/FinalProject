namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNew = new Button();
            dgvGames = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(708, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(80, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Game";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += button1_Click;
            // 
            // dgvGames
            // 
            dgvGames.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Location = new Point(12, 41);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(776, 397);
            dgvGames.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGames);
            Controls.Add(btnNew);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNew;
        private DataGridView dgvGames;
    }
}
