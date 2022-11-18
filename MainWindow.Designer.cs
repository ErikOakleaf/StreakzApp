namespace StreakzApp_WindowsForm_prototype
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.streakzLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.habitsListBox = new System.Windows.Forms.ListBox();
            this.completeHabitButton = new System.Windows.Forms.Button();
            this.createHabitButton = new System.Windows.Forms.Button();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.editHabitButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // streakzLabel
            // 
            this.streakzLabel.AutoSize = true;
            this.streakzLabel.Location = new System.Drawing.Point(12, 9);
            this.streakzLabel.Name = "streakzLabel";
            this.streakzLabel.Size = new System.Drawing.Size(175, 62);
            this.streakzLabel.TabIndex = 0;
            this.streakzLabel.Text = "Streakz";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(12, 94);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(290, 62);
            this.dateTimeLabel.TabIndex = 1;
            this.dateTimeLabel.Text = "<DateTime>";
            // 
            // habitsListBox
            // 
            this.habitsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitsListBox.FormattingEnabled = true;
            this.habitsListBox.ItemHeight = 28;
            this.habitsListBox.Location = new System.Drawing.Point(466, 94);
            this.habitsListBox.Name = "habitsListBox";
            this.habitsListBox.Size = new System.Drawing.Size(199, 312);
            this.habitsListBox.TabIndex = 2;
            this.habitsListBox.SelectedIndexChanged += new System.EventHandler(this.habitsListBox_SelectedIndexChanged);
            // 
            // completeHabitButton
            // 
            this.completeHabitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.completeHabitButton.Location = new System.Drawing.Point(697, 229);
            this.completeHabitButton.Name = "completeHabitButton";
            this.completeHabitButton.Size = new System.Drawing.Size(94, 29);
            this.completeHabitButton.TabIndex = 3;
            this.completeHabitButton.Text = "Complete";
            this.completeHabitButton.UseVisualStyleBackColor = true;
            this.completeHabitButton.Click += new System.EventHandler(this.completeHabitButton_Click);
            // 
            // createHabitButton
            // 
            this.createHabitButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createHabitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createHabitButton.Location = new System.Drawing.Point(466, 42);
            this.createHabitButton.Name = "createHabitButton";
            this.createHabitButton.Size = new System.Drawing.Size(199, 29);
            this.createHabitButton.TabIndex = 4;
            this.createHabitButton.Text = "Create Habit";
            this.createHabitButton.UseVisualStyleBackColor = true;
            this.createHabitButton.Click += new System.EventHandler(this.createHabitButton_Click);
            // 
            // dateTimer
            // 
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // editHabitButton
            // 
            this.editHabitButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editHabitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editHabitButton.Location = new System.Drawing.Point(466, 424);
            this.editHabitButton.Name = "editHabitButton";
            this.editHabitButton.Size = new System.Drawing.Size(199, 29);
            this.editHabitButton.TabIndex = 5;
            this.editHabitButton.Text = "Edit Habit";
            this.editHabitButton.UseVisualStyleBackColor = true;
            this.editHabitButton.Click += new System.EventHandler(this.editHabitButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(28, 197);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(274, 256);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.Text = "<Description>";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 62F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 475);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.editHabitButton);
            this.Controls.Add(this.createHabitButton);
            this.Controls.Add(this.completeHabitButton);
            this.Controls.Add(this.habitsListBox);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.streakzLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "MainWindow";
            this.Text = "Streakz";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label streakzLabel;
        private Label dateTimeLabel;
        private ListBox habitsListBox;
        private Button completeHabitButton;
        private Button createHabitButton;
        private System.Windows.Forms.Timer dateTimer;
        private Button editHabitButton;
        private RichTextBox descriptionTextBox;
    }
}