namespace StreakzApp_WindowsForm_prototype
{
    partial class EditHabitForm
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
            this.editHabitButton = new System.Windows.Forms.Button();
            this.timeCreatedLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.maxStreakLabel = new System.Windows.Forms.Label();
            this.removeHabitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editHabitButton
            // 
            this.editHabitButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editHabitButton.Location = new System.Drawing.Point(27, 410);
            this.editHabitButton.Name = "editHabitButton";
            this.editHabitButton.Size = new System.Drawing.Size(94, 29);
            this.editHabitButton.TabIndex = 15;
            this.editHabitButton.Text = "Edit Habit";
            this.editHabitButton.UseVisualStyleBackColor = true;
            this.editHabitButton.Click += new System.EventHandler(this.editHabitButton_Click);
            // 
            // timeCreatedLabel
            // 
            this.timeCreatedLabel.AutoSize = true;
            this.timeCreatedLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeCreatedLabel.Location = new System.Drawing.Point(27, 24);
            this.timeCreatedLabel.Name = "timeCreatedLabel";
            this.timeCreatedLabel.Size = new System.Drawing.Size(172, 23);
            this.timeCreatedLabel.TabIndex = 14;
            this.timeCreatedLabel.Text = "<DateTime Created>";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(27, 241);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(307, 163);
            this.descriptionTextBox.TabIndex = 13;
            this.descriptionTextBox.Text = "";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(209, 118);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(125, 38);
            this.intervalTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(27, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 38);
            this.nameTextBox.TabIndex = 11;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(21, 207);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(131, 31);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(209, 84);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(90, 31);
            this.intervalLabel.TabIndex = 9;
            this.intervalLabel.Text = "Interval";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 31);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // maxStreakLabel
            // 
            this.maxStreakLabel.AutoSize = true;
            this.maxStreakLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxStreakLabel.Location = new System.Drawing.Point(27, 61);
            this.maxStreakLabel.Name = "maxStreakLabel";
            this.maxStreakLabel.Size = new System.Drawing.Size(116, 23);
            this.maxStreakLabel.TabIndex = 16;
            this.maxStreakLabel.Text = "<max streak>";
            // 
            // removeHabitButton
            // 
            this.removeHabitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeHabitButton.Location = new System.Drawing.Point(209, 410);
            this.removeHabitButton.Name = "removeHabitButton";
            this.removeHabitButton.Size = new System.Drawing.Size(94, 29);
            this.removeHabitButton.TabIndex = 17;
            this.removeHabitButton.Text = "Remove Habit";
            this.removeHabitButton.UseVisualStyleBackColor = true;
            this.removeHabitButton.Click += new System.EventHandler(this.removeHabitButton_Click);
            // 
            // EditHabitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 465);
            this.Controls.Add(this.removeHabitButton);
            this.Controls.Add(this.maxStreakLabel);
            this.Controls.Add(this.editHabitButton);
            this.Controls.Add(this.timeCreatedLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "EditHabitForm";
            this.Text = "EditHabitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editHabitButton;
        private Label timeCreatedLabel;
        private RichTextBox descriptionTextBox;
        private TextBox intervalTextBox;
        private TextBox nameTextBox;
        private Label descriptionLabel;
        private Label intervalLabel;
        private Label nameLabel;
        private Label maxStreakLabel;
        private Button removeHabitButton;
    }
}