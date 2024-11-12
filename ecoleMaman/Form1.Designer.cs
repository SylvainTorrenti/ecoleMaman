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
            tlpMain = new TableLayoutPanel();
            btEx1 = new Button();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(btEx1, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(794, 451);
            tlpMain.TabIndex = 0;
            // 
            // btEx1
            // 
            btEx1.Anchor = AnchorStyles.None;
            btEx1.Location = new Point(161, 101);
            btEx1.Name = "btEx1";
            btEx1.Size = new Size(75, 23);
            btEx1.TabIndex = 1;
            btEx1.Text = "Exercice 1";
            btEx1.UseVisualStyleBackColor = true;
            btEx1.Click += btEx1_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Button btEx1;
    }
}
