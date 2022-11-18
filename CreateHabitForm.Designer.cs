namespace StreakzApp_WindowsForm_prototype
{
    partial class CreateHabitForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.createHabitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(231, 67);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(90, 31);
            this.intervalLabel.TabIndex = 1;
            this.intervalLabel.Text = "Interval";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(43, 190);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(131, 31);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(49, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 38);
            this.nameTextBox.TabIndex = 3;
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(231, 101);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(125, 38);
            this.intervalTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(49, 224);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(307, 163);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Text = "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(104, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(194, 31);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Create New Habit";
            // 
            // createHabitButton
            // 
            this.createHabitButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createHabitButton.Location = new System.Drawing.Point(147, 397);
            this.createHabitButton.Name = "createHabitButton";
            this.createHabitButton.Size = new System.Drawing.Size(94, 29);
            this.createHabitButton.TabIndex = 7;
            this.createHabitButton.Text = "Create Habit";
            this.createHabitButton.UseVisualStyleBackColor = true;
            this.createHabitButton.Click += new System.EventHandler(this.createHabitButton_Click);
            // 
            // CreateHabitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 438);
            this.Controls.Add(this.createHabitButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateHabitForm";
            this.Text = "CreateHabitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label intervalLabel;
        private Label descriptionLabel;
        private TextBox nameTextBox;
        private TextBox intervalTextBox;
        private RichTextBox descriptionTextBox;
        private Label titleLabel;
        private Button createHabitButton;
    }
}