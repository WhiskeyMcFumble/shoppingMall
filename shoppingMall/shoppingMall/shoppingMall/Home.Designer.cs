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
            label1 = new Label();
            fontDialog1 = new FontDialog();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            stores_button = new Button();
            panel2 = new Panel();
            workers_button = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(24, 30);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(711, 32);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Location = new Point(151, 138);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(469, 172);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(stores_button);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 18, 22);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(88, 75, 88, 75);
            panel1.Size = new Size(200, 147);
            panel1.TabIndex = 0;
            // 
            // stores_button
            // 
            stores_button.Location = new Point(41, 59);
            stores_button.Margin = new Padding(3, 2, 3, 2);
            stores_button.Name = "stores_button";
            stores_button.Size = new Size(112, 22);
            stores_button.TabIndex = 0;
            stores_button.Text = "Geschäfte";
            stores_button.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(workers_button);
            panel2.Location = new Point(224, 2);
            panel2.Margin = new Padding(3, 2, 18, 22);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(88, 75, 88, 75);
            panel2.Size = new Size(200, 147);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // workers_button
            // 
            workers_button.Location = new Point(43, 59);
            workers_button.Margin = new Padding(3, 2, 3, 2);
            workers_button.Name = "workers_button";
            workers_button.Size = new Size(112, 22);
            workers_button.TabIndex = 0;
            workers_button.Text = "Mitarbeiter";
            workers_button.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 428);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
    }
}