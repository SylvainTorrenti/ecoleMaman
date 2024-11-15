namespace ecoleMaman
{
    partial class FormPrincipal
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
            tlpMain = new TableLayoutPanel();
            tlpChoixExercice = new TableLayoutPanel();
            lablistExe = new Label();
            tlpListExo = new TableLayoutPanel();
            btExo1 = new Button();
            btExo2 = new Button();
            btExo3 = new Button();
            btExo4 = new Button();
            tlpListMot = new TableLayoutPanel();
            tlpAddMot = new TableLayoutPanel();
            labAddMot = new Label();
            tbAddMot = new TextBox();
            labListMot = new Label();
            dtgListmot = new DataGridView();
            bsMot = new BindingSource(components);
            tlpMain.SuspendLayout();
            tlpChoixExercice.SuspendLayout();
            tlpListExo.SuspendLayout();
            tlpListMot.SuspendLayout();
            tlpAddMot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListmot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMot).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.0075569F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.9924431F));
            tlpMain.Controls.Add(tlpChoixExercice, 0, 0);
            tlpMain.Controls.Add(tlpListMot, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 53.8802643F));
            tlpMain.Size = new Size(794, 451);
            tlpMain.TabIndex = 0;
            // 
            // tlpChoixExercice
            // 
            tlpChoixExercice.ColumnCount = 1;
            tlpChoixExercice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpChoixExercice.Controls.Add(lablistExe, 0, 0);
            tlpChoixExercice.Controls.Add(tlpListExo, 0, 1);
            tlpChoixExercice.Dock = DockStyle.Fill;
            tlpChoixExercice.Location = new Point(3, 3);
            tlpChoixExercice.Name = "tlpChoixExercice";
            tlpChoixExercice.RowCount = 2;
            tlpChoixExercice.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5617981F));
            tlpChoixExercice.RowStyles.Add(new RowStyle(SizeType.Percent, 69.4382F));
            tlpChoixExercice.Size = new Size(399, 445);
            tlpChoixExercice.TabIndex = 0;
            // 
            // lablistExe
            // 
            lablistExe.AutoSize = true;
            lablistExe.Dock = DockStyle.Bottom;
            lablistExe.Location = new Point(3, 121);
            lablistExe.Name = "lablistExe";
            lablistExe.Size = new Size(393, 15);
            lablistExe.TabIndex = 0;
            lablistExe.Text = "Liste des exercices";
            // 
            // tlpListExo
            // 
            tlpListExo.ColumnCount = 1;
            tlpListExo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListExo.Controls.Add(btExo1, 0, 0);
            tlpListExo.Controls.Add(btExo2, 0, 1);
            tlpListExo.Controls.Add(btExo3, 0, 2);
            tlpListExo.Controls.Add(btExo4, 0, 3);
            tlpListExo.Dock = DockStyle.Fill;
            tlpListExo.Location = new Point(3, 139);
            tlpListExo.Name = "tlpListExo";
            tlpListExo.RowCount = 4;
            tlpListExo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpListExo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpListExo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpListExo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpListExo.Size = new Size(393, 303);
            tlpListExo.TabIndex = 1;
            // 
            // btExo1
            // 
            btExo1.Location = new Point(3, 3);
            btExo1.Name = "btExo1";
            btExo1.Size = new Size(75, 23);
            btExo1.TabIndex = 0;
            btExo1.Text = "Exercice 1";
            btExo1.UseVisualStyleBackColor = true;
            btExo1.Click += btExo1_Click;
            // 
            // btExo2
            // 
            btExo2.Location = new Point(3, 78);
            btExo2.Name = "btExo2";
            btExo2.Size = new Size(75, 23);
            btExo2.TabIndex = 1;
            btExo2.Text = "Exercice 2";
            btExo2.UseVisualStyleBackColor = true;
            btExo2.Click += btExo2_Click;
            // 
            // btExo3
            // 
            btExo3.Location = new Point(3, 153);
            btExo3.Name = "btExo3";
            btExo3.Size = new Size(75, 23);
            btExo3.TabIndex = 2;
            btExo3.Text = "Exerecice 3";
            btExo3.UseVisualStyleBackColor = true;
            btExo3.Click += btExo3_Click;
            // 
            // btExo4
            // 
            btExo4.Location = new Point(3, 228);
            btExo4.Name = "btExo4";
            btExo4.Size = new Size(75, 23);
            btExo4.TabIndex = 3;
            btExo4.Text = "Exercice 4";
            btExo4.UseVisualStyleBackColor = true;
            btExo4.Click += btExo4_Click;
            // 
            // tlpListMot
            // 
            tlpListMot.ColumnCount = 1;
            tlpListMot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpListMot.Controls.Add(tlpAddMot, 0, 0);
            tlpListMot.Controls.Add(dtgListmot, 0, 1);
            tlpListMot.Dock = DockStyle.Fill;
            tlpListMot.Location = new Point(408, 3);
            tlpListMot.Name = "tlpListMot";
            tlpListMot.RowCount = 2;
            tlpListMot.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5617981F));
            tlpListMot.RowStyles.Add(new RowStyle(SizeType.Percent, 69.4382F));
            tlpListMot.Size = new Size(383, 445);
            tlpListMot.TabIndex = 1;
            // 
            // tlpAddMot
            // 
            tlpAddMot.ColumnCount = 1;
            tlpAddMot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAddMot.Controls.Add(labAddMot, 0, 0);
            tlpAddMot.Controls.Add(tbAddMot, 0, 1);
            tlpAddMot.Controls.Add(labListMot, 0, 2);
            tlpAddMot.Dock = DockStyle.Fill;
            tlpAddMot.Location = new Point(3, 3);
            tlpAddMot.Name = "tlpAddMot";
            tlpAddMot.RowCount = 3;
            tlpAddMot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAddMot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAddMot.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAddMot.Size = new Size(377, 130);
            tlpAddMot.TabIndex = 0;
            // 
            // labAddMot
            // 
            labAddMot.AutoSize = true;
            labAddMot.Dock = DockStyle.Bottom;
            labAddMot.Location = new Point(3, 40);
            labAddMot.Name = "labAddMot";
            labAddMot.Size = new Size(371, 15);
            labAddMot.TabIndex = 0;
            labAddMot.Text = "Ajouter un mot";
            // 
            // tbAddMot
            // 
            tbAddMot.Location = new Point(3, 58);
            tbAddMot.Name = "tbAddMot";
            tbAddMot.Size = new Size(100, 23);
            tbAddMot.TabIndex = 1;
            // 
            // labListMot
            // 
            labListMot.AutoSize = true;
            labListMot.Location = new Point(3, 110);
            labListMot.Name = "labListMot";
            labListMot.Size = new Size(82, 15);
            labListMot.TabIndex = 2;
            labListMot.Text = "Liste des mots";
            // 
            // dtgListmot
            // 
            dtgListmot.AllowUserToAddRows = false;
            dtgListmot.AllowUserToDeleteRows = false;
            dtgListmot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListmot.Dock = DockStyle.Fill;
            dtgListmot.Location = new Point(3, 139);
            dtgListmot.Name = "dtgListmot";
            dtgListmot.ReadOnly = true;
            dtgListmot.Size = new Size(377, 303);
            dtgListmot.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 451);
            Controls.Add(tlpMain);
            MinimumSize = new Size(810, 490);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercice";
            tlpMain.ResumeLayout(false);
            tlpChoixExercice.ResumeLayout(false);
            tlpChoixExercice.PerformLayout();
            tlpListExo.ResumeLayout(false);
            tlpListMot.ResumeLayout(false);
            tlpAddMot.ResumeLayout(false);
            tlpAddMot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListmot).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpChoixExercice;
        private TableLayoutPanel tlpListMot;
        private TableLayoutPanel tlpAddMot;
        private Label labAddMot;
        private Label lablistExe;
        private TableLayoutPanel tlpListExo;
        private Button btExo1;
        private Button btExo2;
        private Button btExo3;
        private Button btExo4;
        private TextBox tbAddMot;
        private DataGridView dtgListmot;
        private BindingSource bsMot;
        private Label labListMot;
    }
}
