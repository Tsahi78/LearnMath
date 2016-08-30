namespace LearnMath
{
    partial class Counting
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
            this.Start_game = new System.Windows.Forms.Button();
            this.Return_Count_Button = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.new_game_time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Start_game
            // 
            this.Start_game.BackColor = System.Drawing.Color.MistyRose;
            this.Start_game.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_game.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_game.Location = new System.Drawing.Point(85, 15);
            this.Start_game.Margin = new System.Windows.Forms.Padding(4);
            this.Start_game.Name = "Start_game";
            this.Start_game.Size = new System.Drawing.Size(212, 46);
            this.Start_game.TabIndex = 5;
            this.Start_game.Text = "התחל משחק";
            this.Start_game.UseVisualStyleBackColor = false;
            this.Start_game.Click += new System.EventHandler(this.Start_game_Click);
            // 
            // Return_Count_Button
            // 
            this.Return_Count_Button.BackColor = System.Drawing.Color.MistyRose;
            this.Return_Count_Button.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Return_Count_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return_Count_Button.Location = new System.Drawing.Point(85, 447);
            this.Return_Count_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Return_Count_Button.Name = "Return_Count_Button";
            this.Return_Count_Button.Size = new System.Drawing.Size(139, 46);
            this.Return_Count_Button.TabIndex = 4;
            this.Return_Count_Button.Text = "חזרה";
            this.Return_Count_Button.UseVisualStyleBackColor = false;
            this.Return_Count_Button.Click += new System.EventHandler(this.Return_Count_Button_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LeftPanel.Location = new System.Drawing.Point(224, 85);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(332, 319);
            this.LeftPanel.TabIndex = 6;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.RightPanel.Location = new System.Drawing.Point(574, 85);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(464, 359);
            this.RightPanel.TabIndex = 7;
            this.RightPanel.Visible = false;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Aqua;
            this.num1.Location = new System.Drawing.Point(270, 434);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 59);
            this.num1.TabIndex = 8;
            this.num1.Tag = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Yellow;
            this.num2.Location = new System.Drawing.Point(350, 434);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 59);
            this.num2.TabIndex = 9;
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.num3.Location = new System.Drawing.Point(430, 434);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 59);
            this.num3.TabIndex = 10;
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // new_game_time
            // 
            this.new_game_time.Interval = 3000;
            this.new_game_time.Tick += new System.EventHandler(this.new_game_time_Tick);
            // 
            // Counting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1340, 587);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Start_game);
            this.Controls.Add(this.Return_Count_Button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Counting";
            this.Text = "Counting";
            this.Load += new System.EventHandler(this.Counting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_game;
        private System.Windows.Forms.Button Return_Count_Button;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Timer new_game_time;
    }
}