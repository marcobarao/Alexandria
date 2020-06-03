using System;
using System.Drawing;
using System.Windows.Forms;
using Alexandria.Components;

namespace Alexandria.Screens
{
    partial class Lobby
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.iMatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMatches = new System.Windows.Forms.Panel();
            this.lblCreateMatch = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.iPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefreshMatch = new System.Windows.Forms.Button();
            this.btnRefreshPlayers = new System.Windows.Forms.Button();
            this.header = new Alexandria.Components.Header();
            ((System.ComponentModel.ISupportInitialize)(this.iMatchBindingSource)).BeginInit();
            this.pnlMatches.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPlayerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(24, 64);
            this.lblMatches.Margin = new System.Windows.Forms.Padding(0);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(156, 28);
            this.lblMatches.TabIndex = 2;
            this.lblMatches.Text = "Partidas abertas";
            // 
            // lstMatches
            // 
            this.lstMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lstMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMatches.DataSource = this.iMatchBindingSource;
            this.lstMatches.DisplayMember = "name";
            this.lstMatches.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstMatches.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.ItemHeight = 20;
            this.lstMatches.Location = new System.Drawing.Point(0, 0);
            this.lstMatches.Margin = new System.Windows.Forms.Padding(0);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(343, 280);
            this.lstMatches.TabIndex = 1;
            this.lstMatches.ValueMember = "id";
            this.lstMatches.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // iMatchBindingSource
            // 
            this.iMatchBindingSource.DataSource = typeof(Alexandria.Logic.Match.IMatch);
            // 
            // pnlMatches
            // 
            this.pnlMatches.Controls.Add(this.lstMatches);
            this.pnlMatches.Location = new System.Drawing.Point(29, 104);
            this.pnlMatches.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMatches.Name = "pnlMatches";
            this.pnlMatches.Size = new System.Drawing.Size(306, 280);
            this.pnlMatches.TabIndex = 3;
            // 
            // lblCreateMatch
            // 
            this.lblCreateMatch.AutoSize = true;
            this.lblCreateMatch.Location = new System.Drawing.Point(355, 64);
            this.lblCreateMatch.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreateMatch.Name = "lblCreateMatch";
            this.lblCreateMatch.Size = new System.Drawing.Size(180, 28);
            this.lblCreateMatch.TabIndex = 4;
            this.lblCreateMatch.Text = "Ações com partida";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(356, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 23);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(360, 135);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 34);
            this.txtName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(360, 208);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(301, 34);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(356, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 23);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Senha";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(360, 266);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(146, 34);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoin.FlatAppearance.BorderSize = 0;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.Location = new System.Drawing.Point(514, 266);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(0);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(146, 34);
            this.btnJoin.TabIndex = 10;
            this.btnJoin.Text = "Entrar";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogadores na partida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstPlayers);
            this.panel1.Location = new System.Drawing.Point(689, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 280);
            this.panel1.TabIndex = 13;
            // 
            // lstPlayers
            // 
            this.lstPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lstPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlayers.DataSource = this.iPlayerBindingSource;
            this.lstPlayers.DisplayMember = "name";
            this.lstPlayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPlayers.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 20;
            this.lstPlayers.Location = new System.Drawing.Point(0, 0);
            this.lstPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(343, 280);
            this.lstPlayers.TabIndex = 1;
            this.lstPlayers.ValueMember = "id";
            this.lstPlayers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            // 
            // iPlayerBindingSource
            // 
            this.iPlayerBindingSource.DataSource = typeof(Alexandria.Logic.Player.IPlayer);
            // 
            // btnRefreshMatch
            // 
            this.btnRefreshMatch.FlatAppearance.BorderSize = 0;
            this.btnRefreshMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshMatch.Image = global::Alexandria.Properties.Resources.refresh_icon;
            this.btnRefreshMatch.Location = new System.Drawing.Point(311, 68);
            this.btnRefreshMatch.Name = "btnRefreshMatch";
            this.btnRefreshMatch.Size = new System.Drawing.Size(24, 24);
            this.btnRefreshMatch.TabIndex = 14;
            this.btnRefreshMatch.UseVisualStyleBackColor = true;
            this.btnRefreshMatch.Click += new System.EventHandler(this.btnRefreshMatch_Click);
            // 
            // btnRefreshPlayers
            // 
            this.btnRefreshPlayers.FlatAppearance.BorderSize = 0;
            this.btnRefreshPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPlayers.Image = global::Alexandria.Properties.Resources.refresh_icon;
            this.btnRefreshPlayers.Location = new System.Drawing.Point(971, 66);
            this.btnRefreshPlayers.Name = "btnRefreshPlayers";
            this.btnRefreshPlayers.Size = new System.Drawing.Size(24, 24);
            this.btnRefreshPlayers.TabIndex = 15;
            this.btnRefreshPlayers.UseVisualStyleBackColor = true;
            this.btnRefreshPlayers.Click += new System.EventHandler(this.btnRefreshPlayers_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.MaximumSize = new System.Drawing.Size(4991, 40);
            this.header.MinimumSize = new System.Drawing.Size(858, 40);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1022, 40);
            this.header.TabIndex = 0;
            // 
            // Lobby
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1022, 427);
            this.Controls.Add(this.btnRefreshPlayers);
            this.Controls.Add(this.btnRefreshMatch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCreateMatch);
            this.Controls.Add(this.pnlMatches);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alexandria - Lobby";
            this.Load += new System.EventHandler(this.frmLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iMatchBindingSource)).EndInit();
            this.pnlMatches.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iPlayerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Panel pnlMatches;
        private Label lblCreateMatch;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnCreate;
        private Button btnJoin;
        private Label label1;
        private Panel panel1;
        private ListBox lstPlayers;
        private Button btnRefreshPlayers;
        private ListBox lstMatches;
        private BindingSource iMatchBindingSource;
        private BindingSource iPlayerBindingSource;
        private Button btnRefreshMatch;
    }
}

