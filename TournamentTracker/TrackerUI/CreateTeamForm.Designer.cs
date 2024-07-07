namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabelCreate = new Label();
            teamNameLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            LastNameValue = new TextBox();
            emailLabel = new Label();
            emailValue = new TextBox();
            cellphoneLabel = new Label();
            cellphoneValue = new TextBox();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedTeamMembersButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.ForeColor = SystemColors.HotTrack;
            teamNameValue.Location = new Point(21, 120);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(512, 35);
            teamNameValue.TabIndex = 15;
            // 
            // teamNameLabelCreate
            // 
            teamNameLabelCreate.AutoSize = true;
            teamNameLabelCreate.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabelCreate.ForeColor = SystemColors.HotTrack;
            teamNameLabelCreate.Location = new Point(21, 76);
            teamNameLabelCreate.Name = "teamNameLabelCreate";
            teamNameLabelCreate.Size = new Size(169, 41);
            teamNameLabelCreate.TabIndex = 14;
            teamNameLabelCreate.Text = "Team name:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.HotTrack;
            teamNameLabel.Location = new Point(21, 13);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(202, 47);
            teamNameLabel.TabIndex = 13;
            teamNameLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.BackColor = Color.Transparent;
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Blue;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.ForeColor = SystemColors.HotTrack;
            addTeamMemberButton.Location = new Point(161, 272);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(232, 49);
            addTeamMemberButton.TabIndex = 21;
            addTeamMemberButton.Text = "Add team member";
            addTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(21, 228);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(512, 38);
            selectTeamMemberDropDown.TabIndex = 20;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = SystemColors.HotTrack;
            selectTeamMemberLabel.Location = new Point(21, 187);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(287, 41);
            selectTeamMemberLabel.TabIndex = 19;
            selectTeamMemberLabel.Text = "Select team member:";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(LastNameLabel);
            addNewMemberGroupBox.Controls.Add(LastNameValue);
            addNewMemberGroupBox.Controls.Add(FirstNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupBox.ForeColor = SystemColors.HotTrack;
            addNewMemberGroupBox.Location = new Point(21, 340);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(551, 274);
            addNewMemberGroupBox.TabIndex = 22;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add team member";
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.ForeColor = SystemColors.HotTrack;
            firstNameValue.Location = new Point(229, 50);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(283, 43);
            firstNameValue.TabIndex = 14;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = SystemColors.HotTrack;
            FirstNameLabel.Location = new Point(42, 44);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(148, 41);
            FirstNameLabel.TabIndex = 15;
            FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = SystemColors.HotTrack;
            LastNameLabel.Location = new Point(42, 85);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(155, 41);
            LastNameLabel.TabIndex = 17;
            LastNameLabel.Text = "Last  name";
            // 
            // LastNameValue
            // 
            LastNameValue.BorderStyle = BorderStyle.FixedSingle;
            LastNameValue.ForeColor = SystemColors.HotTrack;
            LastNameValue.Location = new Point(229, 91);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(283, 43);
            LastNameValue.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.HotTrack;
            emailLabel.Location = new Point(42, 126);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(85, 41);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.ForeColor = SystemColors.HotTrack;
            emailValue.Location = new Point(229, 132);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(283, 43);
            emailValue.TabIndex = 18;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = SystemColors.HotTrack;
            cellphoneLabel.Location = new Point(42, 167);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(145, 41);
            cellphoneLabel.TabIndex = 21;
            cellphoneLabel.Text = "Cellphone";
            cellphoneLabel.Click += label3_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.BorderStyle = BorderStyle.FixedSingle;
            cellphoneValue.ForeColor = SystemColors.HotTrack;
            cellphoneValue.Location = new Point(229, 173);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(283, 43);
            cellphoneValue.TabIndex = 20;
            // 
            // createMemberButton
            // 
            createMemberButton.BackColor = Color.Transparent;
            createMemberButton.FlatAppearance.BorderColor = Color.Blue;
            createMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            createMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createMemberButton.ForeColor = SystemColors.HotTrack;
            createMemberButton.Location = new Point(229, 224);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(283, 44);
            createMemberButton.TabIndex = 22;
            createMemberButton.Text = "Create member";
            createMemberButton.UseVisualStyleBackColor = false;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.ForeColor = SystemColors.HotTrack;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(587, 13);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(274, 394);
            teamMembersListBox.TabIndex = 23;
            // 
            // deleteSelectedTeamMembersButton
            // 
            deleteSelectedTeamMembersButton.BackColor = Color.Transparent;
            deleteSelectedTeamMembersButton.FlatAppearance.BorderColor = Color.Blue;
            deleteSelectedTeamMembersButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            deleteSelectedTeamMembersButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            deleteSelectedTeamMembersButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamMembersButton.ForeColor = SystemColors.HotTrack;
            deleteSelectedTeamMembersButton.Location = new Point(689, 425);
            deleteSelectedTeamMembersButton.Name = "deleteSelectedTeamMembersButton";
            deleteSelectedTeamMembersButton.Size = new Size(172, 44);
            deleteSelectedTeamMembersButton.TabIndex = 24;
            deleteSelectedTeamMembersButton.Text = "Delete selected";
            deleteSelectedTeamMembersButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = Color.Transparent;
            createTeamButton.FlatAppearance.BorderColor = Color.Blue;
            createTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            createTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.ForeColor = SystemColors.HotTrack;
            createTeamButton.Location = new Point(610, 539);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(251, 75);
            createTeamButton.TabIndex = 27;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 626);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedTeamMembersButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabelCreate);
            Controls.Add(teamNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabelCreate;
        private Label teamNameLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label FirstNameLabel;
        private Label cellphoneLabel;
        private TextBox cellphoneValue;
        private Label emailLabel;
        private TextBox emailValue;
        private Label LastNameLabel;
        private TextBox LastNameValue;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedTeamMembersButton;
        private Button createTeamButton;
    }
}