namespace shoppingMall
{
    partial class Add
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
            name_label = new Label();
            category_label = new Label();
            capital_label = new Label();
            rating_label = new Label();
            name = new TextBox();
            category = new TextBox();
            capital = new TextBox();
            rating = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(50, 110);
            name_label.Name = "name_label";
            name_label.Size = new Size(49, 20);
            name_label.TabIndex = 0;
            name_label.Text = "Name";
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.Location = new Point(50, 173);
            category_label.Name = "category_label";
            category_label.Size = new Size(74, 20);
            category_label.TabIndex = 1;
            category_label.Text = "Kategorie";
            // 
            // capital_label
            // 
            capital_label.AutoSize = true;
            capital_label.Location = new Point(50, 234);
            capital_label.Name = "capital_label";
            capital_label.Size = new Size(56, 20);
            capital_label.TabIndex = 2;
            capital_label.Text = "Kapital";
            // 
            // rating_label
            // 
            rating_label.AutoSize = true;
            rating_label.Location = new Point(50, 296);
            rating_label.Name = "rating_label";
            rating_label.Size = new Size(52, 20);
            rating_label.TabIndex = 3;
            rating_label.Text = "Rating";
            // 
            // name
            // 
            name.Location = new Point(235, 110);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 4;
            // 
            // category
            // 
            category.Location = new Point(235, 173);
            category.Name = "category";
            category.Size = new Size(125, 27);
            category.TabIndex = 5;
            // 
            // capital
            // 
            capital.Location = new Point(235, 234);
            capital.Name = "capital";
            capital.Size = new Size(125, 27);
            capital.TabIndex = 6;
            // 
            // rating
            // 
            rating.Location = new Point(235, 289);
            rating.Name = "rating";
            rating.Size = new Size(125, 27);
            rating.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(540, 173);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Hinzufügen";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(rating);
            Controls.Add(capital);
            Controls.Add(category);
            Controls.Add(name);
            Controls.Add(rating_label);
            Controls.Add(capital_label);
            Controls.Add(category_label);
            Controls.Add(name_label);
            Name = "Add";
            Text = "Add";
            Load += Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private Label category_label;
        private Label capital_label;
        private Label rating_label;
        private TextBox name;
        private TextBox category;
        private TextBox capital;
        private TextBox rating;
        private Button addButton;
    }
}