namespace Eksamensprojekt
{
    partial class Explorer
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
            path_bar = new TextBox();
            back_button = new Button();
            confirm_button = new Button();
            file_endings_view = new ListBox();
            file_ending_info = new Label();
            add_file_ending_box = new TextBox();
            add_file_ending_button = new Button();
            file_view = new ListBox();
            SuspendLayout();
            // 
            // path_bar
            // 
            path_bar.Location = new Point(12, 328);
            path_bar.Name = "path_bar";
            path_bar.ReadOnly = true;
            path_bar.Size = new Size(497, 20);
            path_bar.TabIndex = 1;
            // 
            // back_button
            // 
            back_button.Location = new Point(515, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 3;
            back_button.Text = "Tilbage";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // confirm_button
            // 
            confirm_button.Location = new Point(515, 328);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(121, 21);
            confirm_button.TabIndex = 5;
            confirm_button.Text = "Vælg";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_Click;
            // 
            // file_endings_view
            // 
            file_endings_view.FormattingEnabled = true;
            file_endings_view.Items.AddRange(new object[] { "csv", "txt" });
            file_endings_view.Location = new Point(515, 266);
            file_endings_view.Name = "file_endings_view";
            file_endings_view.Size = new Size(120, 56);
            file_endings_view.TabIndex = 6;
            // 
            // file_ending_info
            // 
            file_ending_info.AutoSize = true;
            file_ending_info.Location = new Point(515, 217);
            file_ending_info.Name = "file_ending_info";
            file_ending_info.Size = new Size(40, 13);
            file_ending_info.TabIndex = 7;
            file_ending_info.Text = "Filtyper";
            // 
            // add_file_ending_box
            // 
            add_file_ending_box.Location = new Point(515, 240);
            add_file_ending_box.Name = "add_file_ending_box";
            add_file_ending_box.Size = new Size(120, 20);
            add_file_ending_box.TabIndex = 8;
            // 
            // add_file_ending_button
            // 
            add_file_ending_button.Location = new Point(581, 213);
            add_file_ending_button.Name = "add_file_ending_button";
            add_file_ending_button.Size = new Size(54, 21);
            add_file_ending_button.TabIndex = 9;
            add_file_ending_button.Text = "Tilføj";
            add_file_ending_button.UseVisualStyleBackColor = true;
            add_file_ending_button.Click += add_file_ending_button_Click;
            // 
            // file_view
            // 
            file_view.FormattingEnabled = true;
            file_view.Location = new Point(12, 13);
            file_view.Name = "file_view";
            file_view.Size = new Size(497, 303);
            file_view.TabIndex = 10;
            file_view.MouseClick += file_view_MouseClick;
            file_view.MouseDoubleClick += file_view_MouseDoubleClick;
            // 
            // Explorer
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 362);
            Controls.Add(file_view);
            Controls.Add(add_file_ending_button);
            Controls.Add(add_file_ending_box);
            Controls.Add(file_ending_info);
            Controls.Add(file_endings_view);
            Controls.Add(confirm_button);
            Controls.Add(back_button);
            Controls.Add(path_bar);
            MaximumSize = new Size(655, 390);
            MinimumSize = new Size(655, 390);
            Name = "Explorer";
            Text = "Explorer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox path_bar;
        private Button back_button;
        private Button confirm_button;
        private ListBox file_endings_view;
        private Label file_ending_info;
        private TextBox add_file_ending_box;
        private Button add_file_ending_button;
        private ListBox file_view;
    }
}