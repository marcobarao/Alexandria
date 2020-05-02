namespace Alexandria.Components
{
    partial class Floor
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
            this.flpFloor = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpFloor
            // 
            this.flpFloor.Location = new System.Drawing.Point(0, 0);
            this.flpFloor.Name = "flpFloor";
            this.flpFloor.Size = new System.Drawing.Size(637, 60);
            this.flpFloor.TabIndex = 0;
            // 
            // Floor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.flpFloor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Floor";
            this.Size = new System.Drawing.Size(637, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFloor;
    }
}
