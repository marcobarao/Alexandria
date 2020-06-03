using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Components
{
    public partial class Bucket : UserControl
    {
        public Bucket()
        {
            InitializeComponent();
        }

        public String BucketName
        {
            get { return lblBucketName.Text; }
            set { lblBucketName.Text = value; }
        }

        public void PaintTile(int id, int quantity)
        {
            Tile tile = (Tile)this.flpTiles.Controls[5 - id];

            if (quantity > 0)
            {
                tile.BackColor = Color.FromArgb(255, tile.BackColor.R, tile.BackColor.G, tile.BackColor.B);
                tile.Penalty = quantity;
            }
        }
    }
}
