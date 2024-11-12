namespace ecoleMaman
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btEx1_Click(object sender, EventArgs e)
        {
            using Exercice1 exercice1 = new Exercice1();
            DialogResult res = exercice1.ShowDialog();
        }
    }
}
