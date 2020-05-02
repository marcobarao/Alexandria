namespace Alexandria.Screens
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.Floor = new Alexandria.Components.Floor();
            this.Model = new Alexandria.Components.Model();
            this.Wall = new Alexandria.Components.Wall();
            this.Header = new Alexandria.Components.Header();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(518, 384);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Floor.Location = new System.Drawing.Point(10, 387);
            this.Floor.Margin = new System.Windows.Forms.Padding(0);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(637, 51);
            this.Floor.TabIndex = 2;
            // 
            // Model
            // 
            this.Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Model.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Model.Location = new System.Drawing.Point(9, 71);
            this.Model.Margin = new System.Windows.Forms.Padding(0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(300, 300);
            this.Model.TabIndex = 2;
            // 
            // Wall
            // 
            this.Wall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Wall.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.Wall.Location = new System.Drawing.Point(346, 71);
            this.Wall.Margin = new System.Windows.Forms.Padding(0);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(300, 300);
            this.Wall.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.MaximumSize = new System.Drawing.Size(2640, 40);
            this.Header.MinimumSize = new System.Drawing.Size(454, 40);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(673, 40);
            this.Header.TabIndex = 0;
            // 
            // Board
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(672, 459);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Wall);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Board";
            this.Text = "Alexandria - Tabuleiro";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Header Header;
        private Components.Wall Wall;
        private Components.Model Model;
        private Components.Floor Floor;
        private System.Windows.Forms.Button btnStart;
    }
}