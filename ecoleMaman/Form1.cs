namespace ecoleMaman
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btExo1_Click(object sender, EventArgs e)
        {
            using frmExercice1 frmExercice1 = new();
            frmExercice1.ShowDialog();
        }

        private void btExo2_Click(object sender, EventArgs e)
        {
            using frmExercice2 frmExercice2 = new();
            frmExercice2.ShowDialog();
        }

        private void btExo3_Click(object sender, EventArgs e)
        {
            using frmExercice3 frmExercice3 = new();
            frmExercice3.ShowDialog();
        }

        private void btExo4_Click(object sender, EventArgs e)
        {
            using frmExercice4 frmExercice4 = new();
            frmExercice4.ShowDialog();
        }
    }
}
