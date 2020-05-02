using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Components
{
    public partial class Floor : UserControl
    {
        public delegate void AddDelegate();
        public Floor()
        {
            InitializeComponent();
        }

        public void AddTile(Color color, int penalty)
        {
            Thread paintThread = new Thread(() =>
                {
                    Tile Tile = new Tile();
                    Tile.BackColor = color;
                    Tile.ForeColor = Color.FromArgb(179, 179, 179);
                    Tile.Name = $"Tile{this.flpFloor.Controls.Count}";
                    Tile.Size = new Size(50, 50);
                    Tile.Penalty = penalty;

                    this.flpFloor.Invoke((MethodInvoker) delegate
                    {
                        this.flpFloor.Controls.Add(Tile);
                    });
                })
                { IsBackground = true };

            paintThread.Start();
        }

        public void Clear()
        {
            Thread paintThread = new Thread(() =>
                {
                    this.flpFloor.Invoke((MethodInvoker)delegate
                    {
                        this.flpFloor.Controls.Clear();
                    });
                })
                { IsBackground = true };

            paintThread.Start();
        }
    }
}
