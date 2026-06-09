namespace RPS_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HowManyRound = new System.Windows.Forms.NumericUpDown();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btstartgame = new System.Windows.Forms.Button();
            this.textBoxPlayerWins = new System.Windows.Forms.TextBox();
            this.ShowGame = new System.Windows.Forms.Panel();
            this.textBoxDrawTime = new System.Windows.Forms.TextBox();
            this.textBoxPcWins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlayerChoice = new System.Windows.Forms.Panel();
            this.PcChoice = new System.Windows.Forms.Panel();
            this.tbhowWonGame = new System.Windows.Forms.TextBox();
            this.btPaper = new System.Windows.Forms.Button();
            this.btRock = new System.Windows.Forms.Button();
            this.btScissor = new System.Windows.Forms.Button();
            this.panelMenue = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HowManyRound)).BeginInit();
            this.ShowGame.SuspendLayout();
            this.panelMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(801, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Game \r\nRock  Paper Scissor";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many rounds do you want to play?";
            // 
            // HowManyRound
            // 
            this.HowManyRound.BackColor = System.Drawing.SystemColors.InfoText;
            this.HowManyRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowManyRound.ForeColor = System.Drawing.SystemColors.Window;
            this.HowManyRound.Location = new System.Drawing.Point(86, 43);
            this.HowManyRound.Name = "HowManyRound";
            this.HowManyRound.Size = new System.Drawing.Size(141, 22);
            this.HowManyRound.TabIndex = 5;
            this.HowManyRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::RPS_Game.Properties.Resources.vector_illustration_workplace_related_icons_260nw_2173462911;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Location = new System.Drawing.Point(729, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(72, 51);
            this.panel11.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::RPS_Game.Properties.Resources.vector_illustration_workplace_related_icons_260nw_2173462911;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(72, 51);
            this.panel9.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::RPS_Game.Properties.Resources.computer_administrator_icon_vector_12664585;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(86, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(40, 41);
            this.panel8.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RPS_Game.Properties.Resources.gaming_pc_icon_style_free_vector;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(186, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 41);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RPS_Game.Properties.Resources.istockphoto_1463565200_170667a;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(136, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 41);
            this.panel2.TabIndex = 2;
            // 
            // btstartgame
            // 
            this.btstartgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btstartgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btstartgame.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btstartgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btstartgame.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstartgame.Location = new System.Drawing.Point(120, 166);
            this.btstartgame.Name = "btstartgame";
            this.btstartgame.Size = new System.Drawing.Size(75, 40);
            this.btstartgame.TabIndex = 0;
            this.btstartgame.Text = "Start ";
            this.btstartgame.UseVisualStyleBackColor = false;
            this.btstartgame.Click += new System.EventHandler(this.btstartgame_Click);
            // 
            // textBoxPlayerWins
            // 
            this.textBoxPlayerWins.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxPlayerWins.Location = new System.Drawing.Point(21, 25);
            this.textBoxPlayerWins.Multiline = true;
            this.textBoxPlayerWins.Name = "textBoxPlayerWins";
            this.textBoxPlayerWins.Size = new System.Drawing.Size(44, 41);
            this.textBoxPlayerWins.TabIndex = 14;
            this.textBoxPlayerWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowGame
            // 
            this.ShowGame.Controls.Add(this.btScissor);
            this.ShowGame.Controls.Add(this.btRock);
            this.ShowGame.Controls.Add(this.btPaper);
            this.ShowGame.Controls.Add(this.PcChoice);
            this.ShowGame.Controls.Add(this.PlayerChoice);
            this.ShowGame.Controls.Add(this.label7);
            this.ShowGame.Controls.Add(this.label6);
            this.ShowGame.Controls.Add(this.panel12);
            this.ShowGame.Controls.Add(this.panel13);
            this.ShowGame.Controls.Add(this.panel14);
            this.ShowGame.Controls.Add(this.label5);
            this.ShowGame.Controls.Add(this.label4);
            this.ShowGame.Controls.Add(this.label3);
            this.ShowGame.Controls.Add(this.label2);
            this.ShowGame.Controls.Add(this.textBoxPcWins);
            this.ShowGame.Controls.Add(this.textBoxDrawTime);
            this.ShowGame.Controls.Add(this.textBoxPlayerWins);
            this.ShowGame.Location = new System.Drawing.Point(358, 126);
            this.ShowGame.Name = "ShowGame";
            this.ShowGame.Size = new System.Drawing.Size(430, 365);
            this.ShowGame.TabIndex = 15;
            this.ShowGame.Visible = false;
            // 
            // textBoxDrawTime
            // 
            this.textBoxDrawTime.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDrawTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrawTime.ForeColor = System.Drawing.Color.Olive;
            this.textBoxDrawTime.Location = new System.Drawing.Point(161, 25);
            this.textBoxDrawTime.Multiline = true;
            this.textBoxDrawTime.Name = "textBoxDrawTime";
            this.textBoxDrawTime.Size = new System.Drawing.Size(44, 41);
            this.textBoxDrawTime.TabIndex = 15;
            this.textBoxDrawTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPcWins
            // 
            this.textBoxPcWins.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPcWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPcWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxPcWins.Location = new System.Drawing.Point(301, 25);
            this.textBoxPcWins.Multiline = true;
            this.textBoxPcWins.Name = "textBoxPcWins";
            this.textBoxPcWins.Size = new System.Drawing.Size(44, 41);
            this.textBoxPcWins.TabIndex = 16;
            this.textBoxPcWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Player Wins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(161, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Draw Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(301, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pc Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Good luck and have fun playing against the PC 😊";
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::RPS_Game.Properties.Resources.scissors;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Cursor = System.Windows.Forms.Cursors.No;
            this.panel12.Location = new System.Drawing.Point(282, 286);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(40, 41);
            this.panel12.TabIndex = 22;
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::RPS_Game.Properties.Resources.Rock_Imoge;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel13.Cursor = System.Windows.Forms.Cursors.No;
            this.panel13.Location = new System.Drawing.Point(328, 286);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(40, 41);
            this.panel13.TabIndex = 23;
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = global::RPS_Game.Properties.Resources.handPaper;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Cursor = System.Windows.Forms.Cursors.No;
            this.panel14.Location = new System.Drawing.Point(236, 286);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(40, 41);
            this.panel14.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Player";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(268, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Computer";
            // 
            // PlayerChoice
            // 
            this.PlayerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerChoice.Location = new System.Drawing.Point(58, 160);
            this.PlayerChoice.Name = "PlayerChoice";
            this.PlayerChoice.Size = new System.Drawing.Size(72, 51);
            this.PlayerChoice.TabIndex = 16;
            // 
            // PcChoice
            // 
            this.PcChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcChoice.Location = new System.Drawing.Point(250, 160);
            this.PcChoice.Name = "PcChoice";
            this.PcChoice.Size = new System.Drawing.Size(72, 51);
            this.PcChoice.TabIndex = 26;
            // 
            // tbhowWonGame
            // 
            this.tbhowWonGame.BackColor = System.Drawing.Color.White;
            this.tbhowWonGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhowWonGame.Location = new System.Drawing.Point(23, 66);
            this.tbhowWonGame.Multiline = true;
            this.tbhowWonGame.Name = "tbhowWonGame";
            this.tbhowWonGame.Size = new System.Drawing.Size(765, 41);
            this.tbhowWonGame.TabIndex = 16;
            this.tbhowWonGame.Text = " ";
            this.tbhowWonGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbhowWonGame.Visible = false;
            // 
            // btPaper
            // 
            this.btPaper.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btPaper.BackgroundImage = global::RPS_Game.Properties.Resources.handPaper;
            this.btPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaper.Location = new System.Drawing.Point(21, 286);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(40, 41);
            this.btPaper.TabIndex = 27;
            this.btPaper.UseVisualStyleBackColor = false;
            this.btPaper.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRock
            // 
            this.btRock.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btRock.BackgroundImage = global::RPS_Game.Properties.Resources.Rock_Imoge;
            this.btRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRock.Location = new System.Drawing.Point(113, 286);
            this.btRock.Name = "btRock";
            this.btRock.Size = new System.Drawing.Size(40, 41);
            this.btRock.TabIndex = 28;
            this.btRock.UseVisualStyleBackColor = false;
            this.btRock.Click += new System.EventHandler(this.btRock_Click);
            // 
            // btScissor
            // 
            this.btScissor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btScissor.BackgroundImage = global::RPS_Game.Properties.Resources.scissors;
            this.btScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btScissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScissor.Location = new System.Drawing.Point(67, 286);
            this.btScissor.Name = "btScissor";
            this.btScissor.Size = new System.Drawing.Size(40, 41);
            this.btScissor.TabIndex = 29;
            this.btScissor.UseVisualStyleBackColor = false;
            this.btScissor.Click += new System.EventHandler(this.btScissor_Click);
            // 
            // panelMenue
            // 
            this.panelMenue.Controls.Add(this.panel2);
            this.panelMenue.Controls.Add(this.panel3);
            this.panelMenue.Controls.Add(this.btstartgame);
            this.panelMenue.Controls.Add(this.label1);
            this.panelMenue.Controls.Add(this.HowManyRound);
            this.panelMenue.Controls.Add(this.panel8);
            this.panelMenue.Location = new System.Drawing.Point(23, 126);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(329, 298);
            this.panelMenue.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.panelMenue);
            this.Controls.Add(this.ShowGame);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.tbhowWonGame);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HowManyRound)).EndInit();
            this.ShowGame.ResumeLayout(false);
            this.ShowGame.PerformLayout();
            this.panelMenue.ResumeLayout(false);
            this.panelMenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HowManyRound;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btstartgame;
        private System.Windows.Forms.TextBox textBoxPlayerWins;
        private System.Windows.Forms.Panel ShowGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPcWins;
        private System.Windows.Forms.TextBox textBoxDrawTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel PcChoice;
        private System.Windows.Forms.Panel PlayerChoice;
        private System.Windows.Forms.TextBox tbhowWonGame;
        private System.Windows.Forms.Button btScissor;
        private System.Windows.Forms.Button btRock;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.Panel panelMenue;
    }
}

