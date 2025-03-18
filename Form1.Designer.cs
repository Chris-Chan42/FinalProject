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
            components = new System.ComponentModel.Container();
            btnNew = new Button();
            dgvGames = new DataGridView();
            gamerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favoriteGameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            platformDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gamerBindingSource = new BindingSource(components);
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamerBindingSource).BeginInit();
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
            dgvGames.AutoGenerateColumns = false;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Columns.AddRange(new DataGridViewColumn[] { gamerIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, favoriteGameDataGridViewTextBoxColumn, hoursDataGridViewTextBoxColumn, platformDataGridViewTextBoxColumn });
            dgvGames.DataSource = gamerBindingSource;
            dgvGames.Location = new Point(12, 41);
            dgvGames.MultiSelect = false;
            dgvGames.Name = "dgvGames";
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(776, 397);
            dgvGames.TabIndex = 1;
            // 
            // gamerIdDataGridViewTextBoxColumn
            // 
            gamerIdDataGridViewTextBoxColumn.DataPropertyName = "GamerId";
            gamerIdDataGridViewTextBoxColumn.HeaderText = "GamerId";
            gamerIdDataGridViewTextBoxColumn.Name = "gamerIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // favoriteGameDataGridViewTextBoxColumn
            // 
            favoriteGameDataGridViewTextBoxColumn.DataPropertyName = "FavoriteGame";
            favoriteGameDataGridViewTextBoxColumn.HeaderText = "FavoriteGame";
            favoriteGameDataGridViewTextBoxColumn.Name = "favoriteGameDataGridViewTextBoxColumn";
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // platformDataGridViewTextBoxColumn
            // 
            platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            // 
            // gamerBindingSource
            // 
            gamerBindingSource.DataSource = typeof(Gamer);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(627, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Game";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(dgvGames);
            Controls.Add(btnNew);
            Name = "Form1";
            Text = "Favorite Games";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNew;
        private DataGridView dgvGames;
        private DataGridViewTextBoxColumn gamerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn favoriteGameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private BindingSource gamerBindingSource;
        private Button btnEdit;
    }
}
