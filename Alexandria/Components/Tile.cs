using System;
using System.Windows.Forms;

namespace Alexandria.Components
{
    public partial class Tile : UserControl
    {
        public Tile()
        {
            InitializeComponent();
        }

        public int Penalty
        {
            get { return Convert.ToInt32(lblTile.Text); }
            set { lblTile.Text = value.ToString(); }
        }
    }
}
