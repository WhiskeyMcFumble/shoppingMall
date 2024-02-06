namespace shoppingMall
{
    partial class AddWorker
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
            addButton = new Button();
            rating = new TextBox();
            field = new TextBox();
            age = new TextBox();
            name = new TextBox();
            rating_label = new Label();
            workfield_label = new Label();
            age_label = new Label();
            name_label = new Label();
            workhours = new TextBox();
            weekhours_label = new Label();
            position = new TextBox();
            position_label = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(563, 180);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 17;
            addButton.Text = "Hinzufügen";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // rating
            // 
            rating.Location = new Point(256, 303);
            rating.Name = "rating";
            rating.Size = new Size(125, 27);
            rating.TabIndex = 16;
            // 
            // field
            // 
            field.Location = new Point(256, 192);
            field.Name = "field";
            field.Size = new Size(125, 27);
            field.TabIndex = 15;
            // 
            // age
            // 
            age.Location = new Point(256, 131);
            age.Name = "age";
            age.Size = new Size(125, 27);
            age.TabIndex = 14;
            // 
            // name
            // 
            name.Location = new Point(256, 68);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 13;
            // 
            // rating_label
            // 
            rating_label.AutoSize = true;
            rating_label.Location = new Point(71, 310);
            rating_label.Name = "rating_label";
            rating_label.Size = new Size(52, 20);
            rating_label.TabIndex = 12;
            rating_label.Text = "Rating";
            // 
            // workfield_label
            // 
            workfield_label.AutoSize = true;
            workfield_label.Location = new Point(71, 192);
            workfield_label.Name = "workfield_label";
            workfield_label.Size = new Size(105, 20);
            workfield_label.TabIndex = 11;
            workfield_label.Text = "Arbeitsbereich";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(71, 131);
            age_label.Name = "age_label";
            age_label.Size = new Size(41, 20);
            age_label.TabIndex = 10;
            age_label.Text = "Alter";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(71, 68);
            name_label.Name = "name_label";
            name_label.Size = new Size(49, 20);
            name_label.TabIndex = 9;
            name_label.Text = "Name";
            // 
            // workhours
            // 
            workhours.Location = new Point(256, 361);
            workhours.Name = "workhours";
            workhours.Size = new Size(125, 27);
            workhours.TabIndex = 19;
            // 
            // weekhours_label
            // 
            weekhours_label.AutoSize = true;
            weekhours_label.Location = new Point(71, 368);
            weekhours_label.Name = "weekhours_label";
            weekhours_label.Size = new Size(108, 20);
            weekhours_label.TabIndex = 18;
            weekhours_label.Text = "Arbeitsstunden";
            // 
            // position
            // 
            position.Location = new Point(256, 249);
            position.Name = "position";
            position.Size = new Size(125, 27);
            position.TabIndex = 21;
            // 
            // position_label
            // 
            position_label.AutoSize = true;
            position_label.Location = new Point(71, 249);
            position_label.Name = "position_label";
            position_label.Size = new Size(61, 20);
            position_label.TabIndex = 20;
            position_label.Text = "Position";
            // 
            // AddWorker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(position);
            Controls.Add(position_label);
            Controls.Add(workhours);
            Controls.Add(weekhours_label);
            Controls.Add(addButton);
            Controls.Add(rating);
            Controls.Add(field);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(rating_label);
            Controls.Add(workfield_label);
            Controls.Add(age_label);
            Controls.Add(name_label);
            Name = "AddWorker";
            Text = "AddWorker";
            Load += AddWorker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private TextBox rating;
        private TextBox field;
        private TextBox age;
        private TextBox name;
        private Label rating_label;
        private Label workfield_label;
        private Label age_label;
        private Label name_label;
        private TextBox workhours;
        private Label weekhours_label;
        private TextBox position;
        private Label position_label;
    }
}