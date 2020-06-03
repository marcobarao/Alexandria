using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Alexandria.Components;
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
        public Lobby Lobby { get; set; }

        private readonly IBoard BoardLogic;
        private Timer Timer;
        private bool isRunning;
        private readonly Result Result;

        public Board(IBoard board, Result result)
        {
            this.Result = result;
            this.BoardLogic = board;
            InitializeComponent();
        }

        private void Tick_Timer(object timerState)
        {
            if (!this.isRunning) return;
            this.BoardLogic.ListPlayers(this.Match);
            this.BoardLogic.CheckTurn(Match, Player);

            if (this.BoardLogic.Finished)
            {
                this.FinishMatch();
                return;
            }

            if (this.BoardLogic.Turn == null) return;

            this.btnStart.Invoke((MethodInvoker)delegate
            {
                this.btnStart.Visible = false;
            });

            this.Score.Invoke((MethodInvoker) delegate
            {
                this.Score.ScorePoints = this.Player.score;
                this.Score.Visible = true;
            });

            this.Turn.Invoke((MethodInvoker)delegate
            {
                this.Turn.Player = this.BoardLogic.Turn.Player.name;
                this.Turn.Visible = true;
            });

            if (this.BoardLogic.Turn.Player.id == this.Player.id)
            {
                this.isRunning = false;
                this.Play();
                this.isRunning = true;
            }
        }

        private void Play()
        {
            this.BoardLogic.ReadFactories(this.Player, this.Match);
            this.BoardLogic.ReadCenter(this.Player);
            this.BoardLogic.AutoPlay(this.Match, this.Player);
            Thread updateUi = new Thread(() =>
            {
                this.BoardLogic.ReadBoard(this.Match, this.Player, this.Player);
                var model = this.BoardLogic.Model;
                var wall = this.BoardLogic.Wall;
                var floor = this.BoardLogic.Floor;
                var factories = this.BoardLogic.Factories;
                var center = this.BoardLogic.Center;

                this.flpBuckets.Invoke((MethodInvoker) delegate
                {
                    List<Control> controls = new List<Control>();
                    foreach (var keyValuePair in factories)
                    {
                        Bucket factory = new Bucket();
                        factory.BucketName = $"Fábrica {keyValuePair.Key}";

                        foreach (var valuePair in keyValuePair.Value)
                        {
                            factory.PaintTile(valuePair.Key, valuePair.Value.Quantity);
                        }

                        controls.Add(factory);
                    }

                    Bucket bucket = new Bucket();
                    bucket.BucketName = "Centro";

                    foreach (var keyValuePair in center)
                    {
                        bucket.PaintTile(keyValuePair.Key, keyValuePair.Value.Quantity);
                    }
                    controls.Add(bucket);

                    this.flpBuckets.Controls.Clear();
                    this.flpBuckets.Controls.AddRange(controls.ToArray());
                });


                this.Wall.Clear();
                foreach (var position in wall)
                {
                    this.Wall.PaintTile(position.Y, position.X);
                }

                this.Model.Clear();
                foreach (var kv in model)
                {
                    var line = kv.Value;
                    this.Model.PaintTiles(line.color, line.line, line.quantity);
                }

                this.Floor.Clear();
                foreach (var penalty in floor)
                {
                    this.Floor.AddTile(penalty.color, penalty.penalty);
                }

                this.Score.ScorePoints = this.Player.score;

            }) { IsBackground = true};
            updateUi.Start();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            this.btnStart.Visible = false;

            Thread startThread = new Thread(() =>
                {
                    this.BoardLogic.ListPlayers(this.Match);
                    this.BoardLogic.StartGame(this.Player);
                })
                {IsBackground = true};
            startThread.Start();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            this.Timer = new Timer(new TimerCallback(this.Tick_Timer), null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(3));

            this.isRunning = true;
        }

        private void FinishMatch()
        {
            this.isRunning = false;
            this.Timer = null;
            this.BoardLogic.ListPlayers(this.Match);

            this.Invoke((MethodInvoker)delegate
            {
                this.Hide();
                this.Result.Lobby = this.Lobby;
                this.Result.Players = this.Match.players.OrderByDescending(player => player.score).ToList();
                this.Result.Closed += (s, args) => this.Close();
                this.Result.Show();
            });
        }
    }
}
