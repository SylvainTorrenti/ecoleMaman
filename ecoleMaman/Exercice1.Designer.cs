namespace ecoleMaman
{
    partial class Exercice1
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
            tlpExercice1 = new TableLayoutPanel();
            tlpAjoutMot = new TableLayoutPanel();
            ajoutMot = new Label();
            tbAjoutMot = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbMotPresent = new Label();
            dtgMotDejaPresent = new DataGridView();
            tlpExercice1.SuspendLayout();
            tlpAjoutMot.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMotDejaPresent).BeginInit();
            SuspendLayout();
            // 
            // tlpExercice1
            // 
            tlpExercice1.ColumnCount = 2;
            tlpExercice1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpExercice1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpExercice1.Controls.Add(tlpAjoutMot, 0, 0);
            tlpExercice1.Controls.Add(tableLayoutPanel1, 1, 0);
            tlpExercice1.Dock = DockStyle.Fill;
            tlpExercice1.Location = new Point(0, 0);
            tlpExercice1.Name = "tlpExercice1";
            tlpExercice1.RowCount = 2;
            tlpExercice1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.7051F));
            tlpExercice1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2949F));
            tlpExercice1.Size = new Size(794, 451);
            tlpExercice1.TabIndex = 0;
            // 
            // tlpAjoutMot
            // 
            tlpAjoutMot.ColumnCount = 2;
            tlpAjoutMot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAjoutMot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAjoutMot.Controls.Add(ajoutMot, 0, 0);
            tlpAjoutMot.Controls.Add(tbAjoutMot, 0, 1);
            tlpAjoutMot.Dock = DockStyle.Fill;
            tlpAjoutMot.Location = new Point(3, 3);
            tlpAjoutMot.Name = "tlpAjoutMot";
            tlpAjoutMot.RowCount = 2;
            tlpAjoutMot.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4383564F));
            tlpAjoutMot.RowStyles.Add(new RowStyle(SizeType.Percent, 83.5616455F));
            tlpAjoutMot.Size = new Size(391, 367);
            tlpAjoutMot.TabIndex = 0;
            // 
            // ajoutMot
            // 
            ajoutMot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ajoutMot.AutoSize = true;
            ajoutMot.Location = new Point(3, 45);
            ajoutMot.Name = "ajoutMot";
            ajoutMot.Size = new Size(89, 15);
            ajoutMot.TabIndex = 0;
            ajoutMot.Text = "Ajoutez un mot";
            // 
            // tbAjoutMot
            // 
            tbAjoutMot.Location = new Point(3, 63);
            tbAjoutMot.Name = "tbAjoutMot";
            tbAjoutMot.Size = new Size(100, 23);
            tbAjoutMot.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbMotPresent, 0, 0);
            tableLayoutPanel1.Controls.Add(dtgMotDejaPresent, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(400, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.6575336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.34247F));
            tableLayoutPanel1.Size = new Size(391, 367);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbMotPresent
            // 
            lbMotPresent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbMotPresent.AutoSize = true;
            lbMotPresent.Location = new Point(292, 75);
            lbMotPresent.Name = "lbMotPresent";
            lbMotPresent.Size = new Size(96, 15);
            lbMotPresent.TabIndex = 0;
            lbMotPresent.Text = "Mot déjà présent";
            // 
            // dtgMotDejaPresent
            // 
            dtgMotDejaPresent.AllowUserToAddRows = false;
            dtgMotDejaPresent.AllowUserToDeleteRows = false;
            dtgMotDejaPresent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMotDejaPresent.Dock = DockStyle.Fill;
            dtgMotDejaPresent.Location = new Point(3, 93);
            dtgMotDejaPresent.Name = "dtgMotDejaPresent";
            dtgMotDejaPresent.ReadOnly = true;
            dtgMotDejaPresent.Size = new Size(385, 271);
            dtgMotDejaPresent.TabIndex = 1;
            // 
            // Exercice1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 451);
            Controls.Add(tlpExercice1);
            MinimumSize = new Size(810, 490);
            Name = "Exercice1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercice1";
            tlpExercice1.ResumeLayout(false);
            tlpAjoutMot.ResumeLayout(false);
            tlpAjoutMot.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMotDejaPresent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpExercice1;
        private TableLayoutPanel tlpAjoutMot;
        private Label ajoutMot;
        private TextBox tbAjoutMot;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbMotPresent;
        private DataGridView dtgMotDejaPresent;
    }
}