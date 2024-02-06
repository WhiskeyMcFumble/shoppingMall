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
            panel.Location = new Point(35, 43);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(687, 109);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // panelWorkers
            // 
            panelWorkers.Location = new Point(46, 202);
            panelWorkers.Name = "panelWorkers";
            panelWorkers.Size = new Size(829, 294);
            panelWorkers.TabIndex = 1;
            panelWorkers.Paint += flowLayoutPanel1_Paint;
            // 
            // add
            // 
            add.Location = new Point(785, 58);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 2;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // WorkersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(add);
            Controls.Add(panelWorkers);
            Controls.Add(panel);
            Margin = new Padding(3, 4, 3, 4);
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