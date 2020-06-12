using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Alexandria.Logic.Match;
using Alexandria.Logic.Player;

namespace Alexandria.Screens
{
    public partial class Result : Form
    {
        public List<IPlayer> Players { get; set; }
        public Lobby Lobby { get; set; }

        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, System.EventArgs e)
        {
            this.dgvPlayers.DataSource = this.Players;
            this.lblPlayerWinner.Text = this.Players[0].name;
        }

        private void btnLobby_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
