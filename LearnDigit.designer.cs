namespace LearnMath
{
    partial class LearnDigit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnDigit));
            this.Start_game = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.NextStage = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Start_game
            // 
            this.Start_game.BackColor = System.Drawing.Color.MistyRose;
            this.Start_game.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_game.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_game.Location = new System.Drawing.Point(12, 12);
            this.Start_game.Name = "Start_game";
            this.Start_game.Size = new System.Drawing.Size(159, 37);
            this.Start_game.TabIndex = 3;
            this.Start_game.Text = "התחל משחק";
            this.Start_game.UseVisualStyleBackColor = false;
            this.Start_game.Click += new System.EventHandler(this.Start_game_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.BackColor = System.Drawing.Color.MistyRose;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Exit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(22, 493);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 37);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "חזרה";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftPanel.BackColor = System.Drawing.Color.Silver;
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.Location = new System.Drawing.Point(228, 83);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftPanel.MaximumSize = new System.Drawing.Size(375, 406);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(375, 406);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(375, 406);
            this.LeftPanel.TabIndex = 4;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightPanel.BackColor = System.Drawing.Color.Gray;
            this.RightPanel.Location = new System.Drawing.Point(624, 83);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(375, 406);
            this.RightPanel.TabIndex = 5;
            // 
            // NextStage
            // 
            this.NextStage.Interval = 2000;
            this.NextStage.Tick += new System.EventHandler(this.NextStage_Tick);
            // 
            // LearnDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1150, 541);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Start_game);
            this.Controls.Add(this.Exit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LearnDigit";
            this.Text = "LearnDigit";
            this.Load += new System.EventHandler(this.LearnDigit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_game;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Timer NextStage;

    }
}