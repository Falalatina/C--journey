namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tournamentNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            tournamentName = new Label();
            unplayedOnly = new CheckBox();
            roundDropDown = new ComboBox();
            matchupListBox = new ListBox();
            versusLabel = new Label();
            teamOneName = new Label();
            teamTwoName = new Label();
            scoreButton = new Button();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.HotTrack;
            tournamentNameLabel.Location = new Point(83, 64);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(203, 47);
            tournamentNameLabel.TabIndex = 0;
            tournamentNameLabel.Text = "Tournament:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(83, 141);
            label1.Name = "label1";
            label1.Size = new Size(108, 41);
            label1.TabIndex = 1;
            label1.Text = "Round:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(83, 359);
            label2.Name = "label2";
            label2.Size = new Size(94, 41);
            label2.TabIndex = 2;
            label2.Text = "Score:";
            label2.Click += label2_Click_2;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = SystemColors.HotTrack;
            tournamentName.Location = new Point(621, 64);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(142, 47);
            tournamentName.TabIndex = 3;
            tournamentName.Text = "<none>";
            tournamentName.Click += label3_Click;
            // 
            // unplayedOnly
            // 
            unplayedOnly.AutoSize = true;
            unplayedOnly.FlatStyle = FlatStyle.Flat;
            unplayedOnly.ForeColor = SystemColors.HotTrack;
            unplayedOnly.Location = new Point(591, 190);
            unplayedOnly.Name = "unplayedOnly";
            unplayedOnly.Size = new Size(172, 34);
            unplayedOnly.TabIndex = 4;
            unplayedOnly.Text = "Unplayed Only";
            unplayedOnly.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(336, 146);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(427, 38);
            roundDropDown.TabIndex = 5;
            // 
            // matchupListBox
            // 
            matchupListBox.ForeColor = SystemColors.HotTrack;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(83, 253);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(680, 94);
            matchupListBox.TabIndex = 6;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.ForeColor = SystemColors.HotTrack;
            versusLabel.Location = new Point(306, 387);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(57, 30);
            versusLabel.TabIndex = 7;
            versusLabel.Text = "-VS-";
            versusLabel.Click += label3_Click_1;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = SystemColors.HotTrack;
            teamOneName.Location = new Point(80, 417);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(250, 41);
            teamOneName.TabIndex = 8;
            teamOneName.Text = "<teamOneName>";
            teamOneName.Click += teanOneName_Click;
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = SystemColors.HotTrack;
            teamTwoName.Location = new Point(336, 417);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(245, 41);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<teamTwoName>";
            // 
            // scoreButton
            // 
            scoreButton.BackColor = Color.Transparent;
            scoreButton.FlatAppearance.BorderColor = Color.Blue;
            scoreButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            scoreButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.HotTrack;
            scoreButton.Location = new Point(591, 414);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(172, 44);
            scoreButton.TabIndex = 10;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = false;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreValue.ForeColor = SystemColors.HotTrack;
            teamOneScoreValue.Location = new Point(83, 484);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(235, 36);
            teamOneScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreValue.ForeColor = SystemColors.HotTrack;
            teamTwoScoreValue.Location = new Point(351, 484);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(217, 36);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 578);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamOneScoreValue);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneName);
            Controls.Add(versusLabel);
            Controls.Add(matchupListBox);
            Controls.Add(roundDropDown);
            Controls.Add(unplayedOnly);
            Controls.Add(tournamentName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viever";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentNameLabel;
        private Label label1;
        private Label label2;
        private Label tournamentName;
        private CheckBox unplayedOnly;
        private ComboBox roundDropDown;
        private ListBox matchupListBox;
        private Label versusLabel;
        private Label teamOneName;
        private Label teamTwoName;
        private Button scoreButton;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
    }
}