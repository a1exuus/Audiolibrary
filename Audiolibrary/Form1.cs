namespace Audiolibrary
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadView(new LibraryView());
        }

        private void LoadView(UserControl view)
        {
            panelContent.Controls.Clear();

            view.Dock = DockStyle.Fill;

            panelContent.Controls.Add(view);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLibrary_Click(object sender, EventArgs e)
        {
            LoadView(new LibraryView());
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            LoadView(new AddBookView());
        }
    }
}