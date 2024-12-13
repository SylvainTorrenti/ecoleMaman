using System.ComponentModel;

namespace ecoleMaman
{
    public partial class FormPrincipal : Form
    {
        Db _db = new Db();
        BindingList<Word> _words = new BindingList<Word>();
        public FormPrincipal()
        {
            InitializeComponent();
            InitializeBinding();
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
        private void btTest_Click(object sender, EventArgs e)
        {
            var words = _db.GetWords();

            foreach (Word word in words)
                _words.Add(word);
        }
        private void InitializeBinding()
        {
            _words = new BindingList<Word>();
            bsMot.DataSource = _words;
            dgvListmot.DataSource = bsMot;
        }

    }
}
