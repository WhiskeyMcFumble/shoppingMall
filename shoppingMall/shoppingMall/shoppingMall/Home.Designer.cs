namespace shoppingMall
{
    partial class Home
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            fontDialog1 = new FontDialog();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            stores_button = new Button();
            panel2 = new Panel();
            workers_button = new Button();
            panel3 = new Panel();
            events_button = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(27, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(813, 42);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Location = new Point(42, 184);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(759, 230);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(stores_button);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 3, 20, 30);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(100);
            panel1.Size = new Size(228, 196);
            panel1.TabIndex = 0;
            // 
            // stores_button
            // 
            stores_button.Location = new Point(47, 79);
            stores_button.Name = "stores_button";
            stores_button.Size = new Size(128, 29);
            stores_button.TabIndex = 0;
            stores_button.Text = "Geschäfte";
            stores_button.UseVisualStyleBackColor = true;
           
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(workers_button);
            panel2.Location = new Point(254, 3);
            panel2.Margin = new Padding(3, 3, 20, 30);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(100);
            panel2.Size = new Size(228, 196);
            panel2.TabIndex = 1;
            // 
            // workers_button
            // 
            workers_button.Location = new Point(49, 79);
            workers_button.Name = "workers_button";
            workers_button.Size = new Size(128, 29);
            workers_button.TabIndex = 0;
            workers_button.Text = "Mitarbeiter";
            workers_button.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(events_button);
            panel3.Location = new Point(505, 3);
            panel3.Margin = new Padding(3, 3, 20, 30);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(100);
            panel3.Size = new Size(228, 196);
            panel3.TabIndex = 2;
            // 
            // events_button
            // 
            events_button.Location = new Point(57, 79);
            events_button.Name = "events_button";
            events_button.Size = new Size(128, 29);
            events_button.TabIndex = 0;
            events_button.Text = "Events";
            events_button.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 583);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FontDialog fontDialog1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Button stores_button;
        private Panel panel2;
        private Button workers_button;
        private Panel panel3;
        private Button events_button;
    }
}