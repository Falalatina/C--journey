namespace TrackerUI
{
    partial class createPrizeForm
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
            prizeLabel = new Label();
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            priceAmountlabel = new Label();
            priceAmountValue = new TextBox();
            prizePercentagelabel = new Label();
            prizePercentageValue = new TextBox();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // prizeLabel
            // 
            prizeLabel.AutoSize = true;
            prizeLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeLabel.ForeColor = SystemColors.HotTrack;
            prizeLabel.Location = new Point(188, 52);
            prizeLabel.Name = "prizeLabel";
            prizeLabel.Size = new Size(198, 47);
            prizeLabel.TabIndex = 14;
            prizeLabel.Text = "Create Prize";
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.HotTrack;
            placeNumberLabel.Location = new Point(188, 124);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(190, 41);
            placeNumberLabel.TabIndex = 17;
            placeNumberLabel.Text = "Place number";
            placeNumberLabel.Click += placeNumberLabel_Click;
            // 
            // placeNumberValue
            // 
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.ForeColor = SystemColors.HotTrack;
            placeNumberValue.Location = new Point(431, 130);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(283, 35);
            placeNumberValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.HotTrack;
            placeNameLabel.Location = new Point(188, 181);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(162, 41);
            placeNameLabel.TabIndex = 19;
            placeNameLabel.Text = "Place name";
            // 
            // placeNameValue
            // 
            placeNameValue.BorderStyle = BorderStyle.FixedSingle;
            placeNameValue.ForeColor = SystemColors.HotTrack;
            placeNameValue.Location = new Point(431, 187);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(283, 35);
            placeNameValue.TabIndex = 18;
            // 
            // priceAmountlabel
            // 
            priceAmountlabel.AutoSize = true;
            priceAmountlabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            priceAmountlabel.ForeColor = SystemColors.HotTrack;
            priceAmountlabel.Location = new Point(188, 238);
            priceAmountlabel.Name = "priceAmountlabel";
            priceAmountlabel.Size = new Size(184, 41);
            priceAmountlabel.TabIndex = 21;
            priceAmountlabel.Text = "Price amount";
            // 
            // priceAmountValue
            // 
            priceAmountValue.BorderStyle = BorderStyle.FixedSingle;
            priceAmountValue.ForeColor = SystemColors.HotTrack;
            priceAmountValue.Location = new Point(431, 244);
            priceAmountValue.Name = "priceAmountValue";
            priceAmountValue.Size = new Size(283, 35);
            priceAmountValue.TabIndex = 20;
            // 
            // prizePercentagelabel
            // 
            prizePercentagelabel.AutoSize = true;
            prizePercentagelabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentagelabel.ForeColor = SystemColors.HotTrack;
            prizePercentagelabel.Location = new Point(188, 370);
            prizePercentagelabel.Name = "prizePercentagelabel";
            prizePercentagelabel.Size = new Size(228, 41);
            prizePercentagelabel.TabIndex = 23;
            prizePercentagelabel.Text = "Prize percentage";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.ForeColor = SystemColors.HotTrack;
            prizePercentageValue.Location = new Point(431, 376);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(283, 35);
            prizePercentageValue.TabIndex = 22;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = SystemColors.HotTrack;
            orLabel.Location = new Point(393, 302);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(66, 41);
            orLabel.TabIndex = 24;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = Color.Transparent;
            createPrizeButton.FlatAppearance.BorderColor = Color.Blue;
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            createPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.ForeColor = SystemColors.HotTrack;
            createPrizeButton.Location = new Point(312, 491);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(251, 75);
            createPrizeButton.TabIndex = 28;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 626);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentagelabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(priceAmountlabel);
            Controls.Add(priceAmountValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(prizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(5, 6, 5, 6);
            Name = "createPrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label prizeLabel;
        private Label placeNumberLabel;
        private TextBox placeNumberValue;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label priceAmountlabel;
        private TextBox priceAmountValue;
        private Label prizePercentagelabel;
        private TextBox prizePercentageValue;
        private Label orLabel;
        private Button createPrizeButton;
    }
}