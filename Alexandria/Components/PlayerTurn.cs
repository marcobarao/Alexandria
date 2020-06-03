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
    public partial class PlayerTurn : UserControl
    {
        public PlayerTurn()
        {
            InitializeComponent();
        }

        public String Player
        {
            get { return this.lblPlayer.Text; }
            set { this.lblPlayer.Text = value; }
        }
    }
}
