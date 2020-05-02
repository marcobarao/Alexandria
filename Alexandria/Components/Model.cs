using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Alexandria.Components
{
    public partial class Model : UserControl
    {
        public Model()
        {
            InitializeComponent();
        }

        public void PaintTiles(Color color, int line, int quantity)
        {
            Thread paintThread = new Thread(() =>
            {
                int tileIndex = this.Summation(0, line - 1) + 1;
                int lastIndex = tileIndex + quantity;

                for (int iterator = tileIndex; iterator < lastIndex; iterator++)
                {
                    Control tile = this.pnlModel.Controls[iterator];
                    tile.BackColor = color;
                }
            })
            { IsBackground = true};

            paintThread.Start();
        }

        public void Clear()
        {
            Thread paintThread = new Thread(() =>
                {
                    foreach (Control pnlModelControl in this.pnlModel.Controls)
                    {
                        pnlModelControl.BackColor = Color.FromArgb(83, 83, 83);
                    }
                })
                { IsBackground = true };

            paintThread.Start();
        }

        private int Summation(int start, int end)
        {
            int iterator, result = -1;
            for (iterator = start; iterator <= end; iterator++)
            {
                result += iterator;
            }

            return result;
        }
    }
}
