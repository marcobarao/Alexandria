using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Alexandria.Logic;
using Alexandria.Logic.Match;
using Alexandria.Logic.Player;
using Timer = System.Threading.Timer;

namespace Alexandria.Screens
{
    public partial class Board : Form
    {
        public IMatch Match { get; set; }
        public IPlayer Player { get; set; }
        private readonly IBoard BoardLogic;
        private Timer Timer;

        public Board(IBoard board)
        {
            this.BoardLogic = board;
            InitializeComponent();
        }

        private void Tick_Timer(object timerState)
        {
            this.BoardLogic.CheckTurn(Match, Player);

            if (this.BoardLogic.Turn != null)
            {
                this.btnStart.Invoke((MethodInvoker) delegate
                    {
                        this.btnStart.Visible = false;
                    });
            }
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {

        }

        private void Board_Load(object sender, EventArgs e)
        {
            this.Timer = new Timer(new TimerCallback(this.Tick_Timer), null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(2));
        }
    }
}
