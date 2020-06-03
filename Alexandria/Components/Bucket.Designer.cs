namespace Alexandria.Components
{
    partial class Bucket
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
            this.flpTiles = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBucketName = new System.Windows.Forms.Label();
            this.tile5 = new Alexandria.Components.Tile();
            this.tile4 = new Alexandria.Components.Tile();
            this.tile3 = new Alexandria.Components.Tile();
            this.tile2 = new Alexandria.Components.Tile();
            this.tile1 = new Alexandria.Components.Tile();
            this.flpTiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTiles
            // 
            this.flpTiles.Controls.Add(this.tile5);
            this.flpTiles.Controls.Add(this.tile4);
            this.flpTiles.Controls.Add(this.tile3);
            this.flpTiles.Controls.Add(this.tile2);
            this.flpTiles.Controls.Add(this.tile1);
            this.flpTiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTiles.Location = new System.Drawing.Point(0, 28);
            this.flpTiles.Margin = new System.Windows.Forms.Padding(0);
            this.flpTiles.Name = "flpTiles";
            this.flpTiles.Size = new System.Drawing.Size(300, 60);
            this.flpTiles.TabIndex = 0;
            // 
            // lblBucketName
            // 
            this.lblBucketName.AutoSize = true;
            this.lblBucketName.BackColor = System.Drawing.Color.Transparent;
            this.lblBucketName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucketName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblBucketName.Location = new System.Drawing.Point(0, 0);
            this.lblBucketName.Name = "lblBucketName";
            this.lblBucketName.Size = new System.Drawing.Size(74, 28);
            this.lblBucketName.TabIndex = 1;
            this.lblBucketName.Text = "Bucket";
            // 
            // tile5
            // 
            this.tile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tile5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tile5.Location = new System.Drawing.Point(5, 5);
            this.tile5.Margin = new System.Windows.Forms.Padding(5);
            this.tile5.Name = "tile5";
            this.tile5.Penalty = 0;
            this.tile5.Size = new System.Drawing.Size(50, 50);
            this.tile5.TabIndex = 9;
            // 
            // tile4
            // 
            this.tile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.tile4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tile4.Location = new System.Drawing.Point(65, 5);
            this.tile4.Margin = new System.Windows.Forms.Padding(5);
            this.tile4.Name = "tile4";
            this.tile4.Penalty = 0;
            this.tile4.Size = new System.Drawing.Size(50, 50);
            this.tile4.TabIndex = 8;
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(215)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.tile3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tile3.Location = new System.Drawing.Point(125, 5);
            this.tile3.Margin = new System.Windows.Forms.Padding(5);
            this.tile3.Name = "tile3";
            this.tile3.Penalty = 0;
            this.tile3.Size = new System.Drawing.Size(50, 50);
            this.tile3.TabIndex = 7;
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(244)))), ((int)(((byte)(157)))), ((int)(((byte)(55)))));
            this.tile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tile2.Location = new System.Drawing.Point(185, 5);
            this.tile2.Margin = new System.Windows.Forms.Padding(5);
            this.tile2.Name = "tile2";
            this.tile2.Penalty = 0;
            this.tile2.Size = new System.Drawing.Size(50, 50);
            this.tile2.TabIndex = 6;
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.tile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tile1.Location = new System.Drawing.Point(245, 5);
            this.tile1.Margin = new System.Windows.Forms.Padding(5);
            this.tile1.Name = "tile1";
            this.tile1.Penalty = 0;
            this.tile1.Size = new System.Drawing.Size(50, 50);
            this.tile1.TabIndex = 5;
            // 
            // Bucket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.lblBucketName);
            this.Controls.Add(this.flpTiles);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 8, 4);
            this.Name = "Bucket";
            this.Size = new System.Drawing.Size(300, 88);
            this.flpTiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTiles;
        private Tile tile5;
        private Tile tile4;
        private Tile tile3;
        private Tile tile2;
        private Tile tile1;
        private System.Windows.Forms.Label lblBucketName;
    }
}
