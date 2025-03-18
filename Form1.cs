namespace FinalProject
{
    public partial class Form1 : Form
    {
        private NewGameForm _gameForm;
        private List<Gamer> _gamerList;
        public Form1()
        {
            InitializeComponent();
            _gameForm = new NewGameForm(this);
            _gamerList = new List<Gamer>();

            _gamerList.Add(new Gamer
            {
                Name = "John",
                FavoriteGame = "Halo",
                Platform = "Xbox",
                Hours = "100"
            });

            ReloadDataGrid();
        }

        private void ReloadDataGrid()
        {
            dgvGames.DataSource = null;
            dgvGames.DataSource = _gamerList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gameForm.ShowDialog();
        }

        public void AddGamer(Gamer game)
        {
            _gamerList.Add(game);
            ReloadDataGrid();
        }

        public void EditGamer(int id, Gamer updatedGame)
        {
           var game = _gamerList.Find(g => g.GamerId == id);

            if(game != null)
            {
                game.Name = updatedGame.Name;
                game.FavoriteGame = updatedGame.FavoriteGame;
                game.Platform = updatedGame.Platform;
                game.Hours = updatedGame.Hours;

                ReloadDataGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Gamer Game;

            var index = dgvGames.SelectedRows[0].Index;

            Game = _gamerList[index];

            _gameForm.LoadGamer(Game);

            _gameForm.ToggleEdit(true);

            _gameForm.ShowDialog();
        }
    }
}
