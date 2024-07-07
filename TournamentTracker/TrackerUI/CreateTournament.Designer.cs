namespace TrackerUI
{
    partial class CreateTournament
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
            tournamentNameLabel = new Label();
            tournamentNameLabelCreate = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayersButton = new Button();
            deleteSelectedPriceButton = new Button();
            teamsLabel = new Label();
            prizelistBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.HotTrack;
            tournamentNameLabel.Location = new Point(83, 37);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(301, 47);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "Create Tournament";
            tournamentNameLabel.Click += tournamentNameLabel_Click;
            // 
            // tournamentNameLabelCreate
            // 
            tournamentNameLabelCreate.AutoSize = true;
            tournamentNameLabelCreate.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabelCreate.ForeColor = SystemColors.HotTrack;
            tournamentNameLabelCreate.Location = new Point(89, 113);
            tournamentNameLabelCreate.Name = "tournamentNameLabelCreate";
            tournamentNameLabelCreate.Size = new Size(253, 41);
            tournamentNameLabelCreate.TabIndex = 3;
            tournamentNameLabelCreate.Text = "Tournament name:";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.ForeColor = SystemColors.HotTrack;
            tournamentNameValue.Location = new Point(89, 157);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(253, 36);
            tournamentNameValue.TabIndex = 12;
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.ForeColor = SystemColors.HotTrack;
            entryFeeValue.Location = new Point(89, 255);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(253, 36);
            entryFeeValue.TabIndex = 14;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = SystemColors.HotTrack;
            entryFeeLabel.Location = new Point(89, 211);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(137, 41);
            entryFeeLabel.TabIndex = 13;
            entryFeeLabel.Text = "Entry fee:";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(89, 353);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(253, 38);
            selectTeamDropDown.TabIndex = 16;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.HotTrack;
            selectTeamLabel.Location = new Point(89, 312);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(170, 41);
            selectTeamLabel.TabIndex = 15;
            selectTeamLabel.Text = "Select team:";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(265, 320);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(119, 30);
            createNewTeamLink.TabIndex = 17;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = Color.Transparent;
            addTeamButton.FlatAppearance.BorderColor = Color.Blue;
            addTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            addTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.ForeColor = SystemColors.HotTrack;
            addTeamButton.Location = new Point(123, 419);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(184, 38);
            addTeamButton.TabIndex = 18;
            addTeamButton.Text = "Add team";
            addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = Color.Transparent;
            createPrizeButton.FlatAppearance.BorderColor = Color.Blue;
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            createPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.ForeColor = SystemColors.HotTrack;
            createPrizeButton.Location = new Point(123, 479);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(184, 38);
            createPrizeButton.TabIndex = 19;
            createPrizeButton.Text = "Create prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            createPrizeButton.Click += createPrizeButton_Click_1;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.ForeColor = SystemColors.HotTrack;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(465, 87);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(319, 154);
            tournamentPlayersListBox.TabIndex = 20;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = SystemColors.HotTrack;
            tournamentPlayersLabel.Location = new Point(465, 43);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(211, 41);
            tournamentPlayersLabel.TabIndex = 21;
            tournamentPlayersLabel.Text = "Teams / players";
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.BackColor = Color.Transparent;
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Blue;
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            deleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayersButton.ForeColor = SystemColors.HotTrack;
            deleteSelectedPlayersButton.Location = new Point(612, 250);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new Size(172, 44);
            deleteSelectedPlayersButton.TabIndex = 22;
            deleteSelectedPlayersButton.Text = "Delete selected";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPriceButton
            // 
            deleteSelectedPriceButton.BackColor = Color.Transparent;
            deleteSelectedPriceButton.FlatAppearance.BorderColor = Color.Blue;
            deleteSelectedPriceButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            deleteSelectedPriceButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            deleteSelectedPriceButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPriceButton.ForeColor = SystemColors.HotTrack;
            deleteSelectedPriceButton.Location = new Point(612, 506);
            deleteSelectedPriceButton.Name = "deleteSelectedPriceButton";
            deleteSelectedPriceButton.Size = new Size(172, 44);
            deleteSelectedPriceButton.TabIndex = 25;
            deleteSelectedPriceButton.Text = "Delete selected";
            deleteSelectedPriceButton.UseVisualStyleBackColor = false;
            // 
            // teamsLabel
            // 
            teamsLabel.AutoSize = true;
            teamsLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            teamsLabel.ForeColor = SystemColors.HotTrack;
            teamsLabel.Location = new Point(465, 299);
            teamsLabel.Name = "teamsLabel";
            teamsLabel.Size = new Size(211, 41);
            teamsLabel.TabIndex = 24;
            teamsLabel.Text = "Teams / players";
            // 
            // prizelistBox
            // 
            prizelistBox.ForeColor = SystemColors.HotTrack;
            prizelistBox.FormattingEnabled = true;
            prizelistBox.ItemHeight = 30;
            prizelistBox.Location = new Point(465, 343);
            prizelistBox.Name = "prizelistBox";
            prizelistBox.Size = new Size(319, 154);
            prizelistBox.TabIndex = 23;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = Color.Transparent;
            createTournamentButton.FlatAppearance.BorderColor = Color.Blue;
            createTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            createTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.ForeColor = SystemColors.HotTrack;
            createTournamentButton.Location = new Point(293, 539);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(251, 75);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournament
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 626);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPriceButton);
            Controls.Add(teamsLabel);
            Controls.Add(prizelistBox);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabelCreate);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournament";
            Text = "CreateTournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentNameLabel;
        private Label tournamentNameLabelCreate;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayersButton;
        private Button deleteSelectedPriceButton;
        private Label teamsLabel;
        private ListBox prizelistBox;
        private Button createTournamentButton;
    }
}