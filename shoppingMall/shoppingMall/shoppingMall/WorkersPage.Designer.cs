namespace shoppingMall
{
    partial class WorkersPage
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
            panel = new FlowLayoutPanel();
            panelWorkers = new FlowLayoutPanel();
            add = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(40, 55);
            panel.Name = "panel";
            panel.Size = new Size(504, 82);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // panelWorkers
            // 
            panelWorkers.Location = new Point(40, 197);
            panelWorkers.Margin = new Padding(3, 2, 3, 2);
            panelWorkers.Name = "panelWorkers";
            panelWorkers.Size = new Size(592, 220);
            panelWorkers.TabIndex = 1;
            panelWorkers.Paint += flowLayoutPanel1_Paint;
            // 
            // add
            // 
            add.Location = new Point(550, 55);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Size = new Size(82, 22);
            add.TabIndex = 2;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // WorkersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(add);
            Controls.Add(panelWorkers);
            Controls.Add(panel);
            Name = "WorkersPage";
            Text = "WorkersPage";
            Load += WorkersPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
        private FlowLayoutPanel panelWorkers;
        private Button add;
    }
}