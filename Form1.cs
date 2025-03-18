namespace FinalProject
{
    public partial class Form1 : Form
    {
        private NewGameForm _gameForm;
        private List<Gamer> _gamerList;
        public Form1()
        {
            InitializeComponent();
            _gameForm = new NewGameForm();
            _gamerList = new List<Gamer>();

            _gamerList.Add(new Gamer
            {
                GamerName = "John",
                FavoriteGame = "Halo",
                Hours = "100",
                Platform = "Xbox"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gameForm.ShowDialog();
        }

        public void AddGamer(Gamer game)
        {
            _gamerList.Add(game);
            
        }
    }
}
