using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
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
            this.Cursor = Cursors.WaitCursor;
            this.Fetch_Matches();
        }

        private void Fetch_Matches()
        {
            Thread updateUi = new Thread(() =>
                {
                    this.LobbyLogic.ListOpenMatches();
                    this.Update_Matches_DataSource();
                })
                { IsBackground = true };
            updateUi.Start();
        }

        private void Update_Matches_DataSource()
        {
            BindingList<IMatch> matches = new BindingList<IMatch>(this.LobbyLogic.Matches);

            this.lstMatches.Invoke((MethodInvoker) delegate
            {
                this.lstMatches.DataSource = matches;
                this.Cursor = Cursors.Arrow;
            });
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

            this.Cursor = Cursors.WaitCursor;
            this.Fetch_Players(match);
        }

        private void Fetch_Players(IMatch match)
        {
            Thread updateUi = new Thread(() =>
                {
                    this.LobbyLogic.ListPlayers(match);
                    this.Update_Players_DataSource(match);
                })
                { IsBackground = true };
            updateUi.Start();
        }

        private void Update_Players_DataSource(IMatch match)
        {
            BindingList<IPlayer> players = new BindingList<IPlayer>(match.players);

            this.lstPlayers.Invoke((MethodInvoker) delegate
            {
                this.lstPlayers.DataSource = players;
                this.Cursor = Cursors.Arrow;
            });
        }

        private void btnRefreshMatch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Fetch_Matches();
        }

        private void btnRefreshPlayers_Click(object sender, EventArgs e)
        {
            IMatch match = (Match)this.lstMatches.SelectedItem;
            this.Cursor = Cursors.WaitCursor;

            this.Fetch_Players(match);
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            IMatch match = (Match)this.lstMatches.SelectedItem;
            String name = this.txtName.Text;
            String password = this.txtPassword.Text;
            
            IPlayer player = this.LobbyLogic.JoinMatch(match, name, password);


            match.players.Clear();
            this.Clear_Create_Match_Form();

            this.Hide();
            this.Board.Lobby = this;
            this.Board.Match = match;
            this.Board.Player = player;
            this.Board.Closed += (s, args) => this.Close();
            this.Board.Show();
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox) sender;
            e.DrawBackground();
            Brush myBrush = new SolidBrush(Color.FromArgb(250, 250, 250));

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(29, 185, 84)), e.Bounds);
            }

            else
            {
                e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds);
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds,
                StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }
    }
}
