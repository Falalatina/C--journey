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
            btn1 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.FlatAppearance.BorderColor = Color.Red;
            btn1.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = Color.Red;
            btn1.Location = new Point(124, 117);
            btn1.Name = "btn1";
            btn1.Size = new Size(488, 307);
            btn1.TabIndex = 0;
            btn1.Text = "Click me!!";
            btn1.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(735, 554);
            Controls.Add(btn1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournament";
            Text = "CreateTournament";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
    }
}