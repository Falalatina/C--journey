namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            selectExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = SystemColors.HotTrack;
            tournamentDashboardLabel.Location = new Point(262, 60);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(367, 47);
            tournamentDashboardLabel.TabIndex = 15;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // selectExistingTournamentDropDown
            // 
            selectExistingTournamentDropDown.FormattingEnabled = true;
            selectExistingTournamentDropDown.Location = new Point(218, 216);
            selectExistingTournamentDropDown.Name = "selectExistingTournamentDropDown";
            selectExistingTournamentDropDown.Size = new Size(454, 38);
            selectExistingTournamentDropDown.TabIndex = 18;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = SystemColors.HotTrack;
            loadExistingTournamentLabel.Location = new Point(276, 172);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(339, 41);
            loadExistingTournamentLabel.TabIndex = 17;
            loadExistingTournamentLabel.Text = "Load existing tournament";
            loadExistingTournamentLabel.Click += loadExistingTournamentLabel_Click;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.BackColor = Color.Transparent;
            loadTournamentButton.FlatAppearance.BorderColor = Color.Blue;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.ForeColor = SystemColors.HotTrack;
            loadTournamentButton.Location = new Point(329, 288);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(232, 49);
            loadTournamentButton.TabIndex = 22;
            loadTournamentButton.Text = "Load tournament";
            loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = Color.Transparent;
            createTournamentButton.FlatAppearance.BorderColor = Color.Blue;
            createTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            createTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.ForeColor = SystemColors.HotTrack;
            createTournamentButton.Location = new Point(320, 371);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(251, 75);
            createTournamentButton.TabIndex = 28;
            createTournamentButton.Text = "Create tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 626);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(selectExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private ComboBox selectExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}