using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Alexandria.Logic;
using Alexandria.Logic.Match;
using Alexandria.Logic.Player;

namespace Alexandria.Screens
{
    public partial class Lobby : Form
    {
        private readonly ILobby LobbyLogic;
        private readonly Board Board;

        public Lobby(ILobby lobbyLogic, Board board)
        {
            this.Board = board;
            this.LobbyLogic = lobbyLogic;
            InitializeComponent();
        }

        private void frmLobby_Load(object sender, System.EventArgs e)
        {
            this.Fetch_Matches();
        }

        private void Fetch_Matches()
        {
            this.LobbyLogic.ListOpenMatches();
            this.Update_Matches_DataSource();
        }

        private void Update_Matches_DataSource()
        {
            BindingList<IMatch> matches = new BindingList<IMatch>(this.LobbyLogic.Matches);
            this.lstMatches.DataSource = matches;
            this.lstMatches.ValueMember = "id";
            this.lstMatches.DisplayMember = "name";
        }

        private void Clear_Create_Match_Form()
        {
            this.txtName.Clear();
            this.txtPassword.Clear();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            String name = this.txtName.Text;
            String password = this.txtPassword.Text;

            this.LobbyLogic.CreateMatch(name, password);
            this.Update_Matches_DataSource();
            this.Clear_Create_Match_Form();
        }

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstMatches = sender as ListBox;
            IMatch match = (Match)lstMatches.SelectedItem;

            this.LobbyLogic.ListPlayers(match);
            this.Update_Players_DataSource(match);
        }

        private void Update_Players_DataSource(IMatch match)
        {
            BindingList<IPlayer> players = new BindingList<IPlayer>(match.players);
            this.lstPlayers.DataSource = players;
            this.lstPlayers.ValueMember = "id";
            this.lstPlayers.DisplayMember = "name";
        }

        private void btnRefreshMatch_Click(object sender, EventArgs e)
        {
            this.LobbyLogic.ListOpenMatches();
            this.Update_Matches_DataSource();
        }

        private void btnRefreshPlayers_Click(object sender, EventArgs e)
        {
            IMatch match = (Match)this.lstMatches.SelectedItem;

            this.LobbyLogic.ListPlayers(match);
            this.Update_Players_DataSource(match);
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            IMatch match = (Match)this.lstMatches.SelectedItem;
            String name = this.txtName.Text;
            String password = this.txtPassword.Text;

            IPlayer player = this.LobbyLogic.JoinMatch(match, name, password);

            this.Hide();
            this.Board.Match = match;
            this.Board.Player = player;
            this.Board.Closed += (s, args) => this.Close();
            this.Board.Show();
        }
    }
}
