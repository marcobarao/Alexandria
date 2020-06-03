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
    public partial class Score : UserControl
    {
        public Score()
        {
            InitializeComponent();
        }

        public int ScorePoints
        {
            get { return Convert.ToInt32(this.lblScore.Text); }
            set { this.lblScore.Text = value.ToString(); }
        }
    }
}
