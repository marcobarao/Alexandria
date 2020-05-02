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
