namespace Alexandria.Components
{
    partial class Tile
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.BackColor = System.Drawing.Color.Transparent;
            this.lblTile.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(28, 20);
            this.lblTile.Margin = new System.Windows.Forms.Padding(0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(23, 28);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "0";
            // 
            // Tile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblTile);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tile";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTile;
    }
}
