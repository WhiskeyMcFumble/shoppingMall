namespace shoppingMall
{
    partial class DetailScreen
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
            detail_name = new Label();
            size_label = new Label();
            category_label = new Label();
            capital_store_label = new Label();
            rating_store_label = new Label();
            size = new Label();
            category = new Label();
            capital = new Label();
            rating = new Label();
            SuspendLayout();
            // 
            // detail_name
            // 
            detail_name.AutoSize = true;
            detail_name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            detail_name.Location = new Point(78, 62);
            detail_name.Name = "detail_name";
            detail_name.Size = new Size(82, 35);
            detail_name.TabIndex = 0;
            detail_name.Text = "Name";
            detail_name.Click += name_store_Click;
            // 
            // size_label
            // 
            size_label.AutoSize = true;
            size_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            size_label.Location = new Point(78, 144);
            size_label.Name = "size_label";
            size_label.Size = new Size(73, 30);
            size_label.TabIndex = 1;
            size_label.Text = "Größe";
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            category_label.Location = new Point(78, 199);
            category_label.Name = "category_label";
            category_label.Size = new Size(107, 30);
            category_label.TabIndex = 2;
            category_label.Text = "Kategorie";
            // 
            // capital_store_label
            // 
            capital_store_label.AutoSize = true;
            capital_store_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            capital_store_label.Location = new Point(78, 265);
            capital_store_label.Name = "capital_store_label";
            capital_store_label.Size = new Size(78, 30);
            capital_store_label.TabIndex = 4;
            capital_store_label.Text = "Kapital";
            // 
            // rating_store_label
            // 
            rating_store_label.AutoSize = true;
            rating_store_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            rating_store_label.Location = new Point(78, 323);
            rating_store_label.Name = "rating_store_label";
            rating_store_label.Size = new Size(74, 30);
            rating_store_label.TabIndex = 5;
            rating_store_label.Text = "Rating";
            // 
            // size
            // 
            size.AutoSize = true;
            size.Location = new Point(275, 152);
            size.Name = "size";
            size.Size = new Size(50, 20);
            size.TabIndex = 6;
            size.Text = "label1";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(275, 207);
            category.Name = "category";
            category.Size = new Size(50, 20);
            category.TabIndex = 7;
            category.Text = "label1";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.Location = new Point(275, 265);
            capital.Name = "capital";
            capital.Size = new Size(50, 20);
            capital.TabIndex = 9;
            capital.Text = "label1";
            // 
            // rating
            // 
            rating.AutoSize = true;
            rating.Location = new Point(275, 331);
            rating.Name = "rating";
            rating.Size = new Size(50, 20);
            rating.TabIndex = 10;
            rating.Text = "label1";
            // 
            // DetailScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1193, 762);
            Controls.Add(rating);
            Controls.Add(capital);
            Controls.Add(category);
            Controls.Add(size);
            Controls.Add(rating_store_label);
            Controls.Add(capital_store_label);
            Controls.Add(category_label);
            Controls.Add(size_label);
            Controls.Add(detail_name);
            Name = "DetailScreen";
            Text = "DetailScreen";
            Load += DetailScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        private Label detail_name;
        private Label size_label;
        private Label category_label;
        private Label capital_store_label;
        private Label rating_store_label;
        private Label size;
        private Label category;
        private Label capital;
        private Label rating;
    }
}