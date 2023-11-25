namespace ProyectoEstructura
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            this.Hide();
            arbol.ShowDialog();
            this.Show();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            Grafo grafo = new Grafo();
            this.Hide();
            grafo.ShowDialog();
            this.Show();
        }
    }
}