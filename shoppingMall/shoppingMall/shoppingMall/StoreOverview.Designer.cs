namespace shoppingMall
{
    partial class StoreOverview
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
            panel = new FlowLayoutPanel();
            formPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(578, 69);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 22);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // panel
            // 
            panel.Location = new Point(88, 69);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(484, 94);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // formPanel
            // 
            formPanel.Location = new Point(88, 224);
            formPanel.Margin = new Padding(3, 2, 3, 2);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(610, 399);
            formPanel.TabIndex = 2;
            formPanel.Paint += formPanel_Paint_1;
            // 
            // StoreOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(946, 580);
            Controls.Add(formPanel);
            Controls.Add(panel);
            Controls.Add(addButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StoreOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreOverview";
            Load += StoreOverview_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private FlowLayoutPanel panel;
        private FlowLayoutPanel formPanel;
    }
}