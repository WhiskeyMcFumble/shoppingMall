namespace shoppingMall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            v = new FlowLayoutPanel();
            label2 = new Label();
            capital_label = new Label();
            capital = new Label();
            store_number_label = new Label();
            store_number = new Label();
            person_label = new Label();
            person_number = new Label();
            event_label = new Label();
            rating_label = new Label();
            rating = new Label();
            edit_button = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            game_store_label = new Button();
            panel2 = new Panel();
            jupiter_label = new Button();
            panel3 = new Panel();
            mh_label = new Button();
            panel4 = new Panel();
            bwm_label = new Button();
            panel5 = new Panel();
            button1 = new Button();
            panel6 = new Panel();
            schmitt_label = new Button();
            panel7 = new Panel();
            button2 = new Button();
            panel8 = new Panel();
            button3 = new Button();
            v.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // v
            // 
            v.Controls.Add(label2);
            v.Controls.Add(capital_label);
            v.Controls.Add(capital);
            v.Controls.Add(store_number_label);
            v.Controls.Add(store_number);
            v.Controls.Add(person_label);
            v.Controls.Add(person_number);
            v.Controls.Add(event_label);
            v.Controls.Add(rating_label);
            v.Controls.Add(rating);
            v.Controls.Add(edit_button);
            v.Location = new Point(48, 40);
            v.Name = "v";
            v.Size = new Size(1050, 43);
            v.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // capital_label
            // 
            capital_label.AutoSize = true;
            capital_label.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            capital_label.ForeColor = SystemColors.ControlLightLight;
            capital_label.Location = new Point(9, 0);
            capital_label.Name = "capital_label";
            capital_label.Size = new Size(88, 30);
            capital_label.TabIndex = 0;
            capital_label.Text = "Kapital";
            capital_label.Click += capital_label_Click;
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.Cursor = Cursors.No;
            capital.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            capital.ForeColor = SystemColors.ControlLightLight;
            capital.Location = new Point(103, 0);
            capital.Name = "capital";
            capital.Size = new Size(105, 30);
            capital.TabIndex = 2;
            capital.Text = "10.000$";
            // 
            // store_number_label
            // 
            store_number_label.AutoSize = true;
            store_number_label.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            store_number_label.ForeColor = SystemColors.ControlLightLight;
            store_number_label.Location = new Point(214, 0);
            store_number_label.Name = "store_number_label";
            store_number_label.Size = new Size(191, 30);
            store_number_label.TabIndex = 3;
            store_number_label.Text = "Geschäftsanzahl";
            // 
            // store_number
            // 
            store_number.AutoSize = true;
            store_number.Cursor = Cursors.No;
            store_number.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            store_number.ForeColor = SystemColors.ControlLightLight;
            store_number.Location = new Point(411, 0);
            store_number.Name = "store_number";
            store_number.Size = new Size(27, 30);
            store_number.TabIndex = 4;
            store_number.Text = "8";
            // 
            // person_label
            // 
            person_label.AutoSize = true;
            person_label.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            person_label.ForeColor = SystemColors.ControlLightLight;
            person_label.Location = new Point(444, 0);
            person_label.Name = "person_label";
            person_label.Size = new Size(186, 30);
            person_label.TabIndex = 5;
            person_label.Text = "Personenanzahl";
            person_label.Click += person_label_Click;
            // 
            // person_number
            // 
            person_number.AutoSize = true;
            person_number.Cursor = Cursors.No;
            person_number.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            person_number.ForeColor = SystemColors.ControlLightLight;
            person_number.Location = new Point(636, 0);
            person_number.Name = "person_number";
            person_number.Size = new Size(55, 30);
            person_number.TabIndex = 6;
            person_number.Text = "120";
            // 
            // event_label
            // 
            event_label.AutoSize = true;
            event_label.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            event_label.ForeColor = SystemColors.ControlLightLight;
            event_label.Location = new Point(697, 0);
            event_label.Name = "event_label";
            event_label.Size = new Size(85, 30);
            event_label.TabIndex = 7;
            event_label.Text = "Events";
            // 
            // rating_label
            // 
            rating_label.AutoSize = true;
            rating_label.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rating_label.ForeColor = SystemColors.ControlLightLight;
            rating_label.Location = new Point(788, 0);
            rating_label.Name = "rating_label";
            rating_label.Size = new Size(84, 30);
            rating_label.TabIndex = 8;
            rating_label.Text = "Rating";
            // 
            // rating
            // 
            rating.AutoSize = true;
            rating.Cursor = Cursors.No;
            rating.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rating.ForeColor = SystemColors.ControlLightLight;
            rating.Location = new Point(878, 0);
            rating.Name = "rating";
            rating.Size = new Size(49, 30);
            rating.TabIndex = 9;
            rating.Text = "4,3";
            // 
            // edit_button
            // 
            edit_button.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            edit_button.Location = new Point(933, 3);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(94, 29);
            edit_button.TabIndex = 10;
            edit_button.Text = "edit";
            edit_button.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(156, 129);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(820, 507);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(game_store_label);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 3, 20, 30);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(100);
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // game_store_label
            // 
            game_store_label.Location = new Point(59, 45);
            game_store_label.Name = "game_store_label";
            game_store_label.Size = new Size(128, 29);
            game_store_label.TabIndex = 0;
            game_store_label.Text = "Game Store";
            game_store_label.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(jupiter_label);
            panel2.Cursor = Cursors.Cross;
            panel2.Location = new Point(276, 3);
            panel2.Margin = new Padding(3, 3, 20, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 1;
            // 
            // jupiter_label
            // 
            jupiter_label.Location = new Point(75, 45);
            jupiter_label.Name = "jupiter_label";
            jupiter_label.Size = new Size(94, 29);
            jupiter_label.TabIndex = 0;
            jupiter_label.Text = "Jupiter";
            jupiter_label.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(mh_label);
            panel3.Location = new Point(549, 3);
            panel3.Margin = new Padding(3, 3, 20, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 2;
            // 
            // mh_label
            // 
            mh_label.Location = new Point(77, 49);
            mh_label.Name = "mh_label";
            mh_label.Size = new Size(114, 29);
            mh_label.TabIndex = 0;
            mh_label.Text = "M && H";
            mh_label.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LavenderBlush;
            panel4.Controls.Add(bwm_label);
            panel4.Location = new Point(3, 161);
            panel4.Margin = new Padding(3, 3, 20, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 3;
            // 
            // bwm_label
            // 
            bwm_label.Location = new Point(50, 49);
            bwm_label.Name = "bwm_label";
            bwm_label.Size = new Size(143, 29);
            bwm_label.TabIndex = 0;
            bwm_label.Text = "Brille wenig Mann";
            bwm_label.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LavenderBlush;
            panel5.Controls.Add(button1);
            panel5.Location = new Point(276, 161);
            panel5.Margin = new Padding(3, 3, 20, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(77, 50);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "360 ° ";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LavenderBlush;
            panel6.Controls.Add(schmitt_label);
            panel6.Location = new Point(549, 161);
            panel6.Margin = new Padding(3, 3, 20, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 5;
            // 
            // schmitt_label
            // 
            schmitt_label.Location = new Point(75, 45);
            schmitt_label.Name = "schmitt_label";
            schmitt_label.Size = new Size(94, 29);
            schmitt_label.TabIndex = 0;
            schmitt_label.Text = "Schmitt";
            schmitt_label.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LavenderBlush;
            panel7.Controls.Add(button2);
            panel7.Location = new Point(3, 319);
            panel7.Margin = new Padding(3, 3, 20, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 125);
            panel7.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(59, 45);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 0;
            button2.Text = "Teemoint AG";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LavenderBlush;
            panel8.Controls.Add(button3);
            panel8.Location = new Point(276, 319);
            panel8.Margin = new Padding(3, 3, 20, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 125);
            panel8.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(73, 45);
            button3.Name = "button3";
            button3.Size = new Size(116, 29);
            button3.TabIndex = 0;
            button3.Text = "Cchlchter ";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1121, 648);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(v);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            v.ResumeLayout(false);
            v.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel v;
        private Label label2;
        private Label capital_label;
        private Label capital;
        private Label store_number_label;
        private Label store_number;
        private Label person_label;
        private Label person_number;
        private Label event_label;
        private Label rating_label;
        private Label rating;
        private Button edit_button;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button game_store_label;
        private Button jupiter_label;
        private Button mh_label;
        private Button bwm_label;
        private Button button1;
        private Panel panel6;
        private Button schmitt_label;
        private Panel panel7;
        private Button button2;
        private Panel panel8;
        private Button button3;
    }
}