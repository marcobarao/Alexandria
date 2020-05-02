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
    public partial class Wall : UserControl
    {
        public Wall()
        {
            InitializeComponent();
        }

        public void PaintTile(int line, int column)
        {
            Thread paintThread = new Thread(() =>
                {
                    int lineIndex = line - 1;
                    int columnIndex = column - 1;
                    int tileIndex = columnIndex + lineIndex * 5;

                    Control tile = this.flpWall.Controls[tileIndex];
                    tile.BackColor = Color.FromArgb(255, tile.BackColor.R, tile.BackColor.G, tile.BackColor.B);
                })
                { IsBackground = true };

            paintThread.Start();
        }

        public void Clear()
        {
            Thread paintThread = new Thread(() =>
                {
                    foreach (Control flpWallControl in this.flpWall.Controls)
                    {
                        flpWallControl.BackColor = Color.FromArgb(50, flpWallControl.BackColor.R, flpWallControl.BackColor.G, flpWallControl.BackColor.B);
                    }
                })
                { IsBackground = true };

            paintThread.Start();
        }
    }
}
