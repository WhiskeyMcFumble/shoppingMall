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
            formPanel = new FlowLayoutPanel();
            schmitt_label = new Button();
            panel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.Location = new Point(79, 169);
            formPanel.Margin = new Padding(3, 2, 3, 2);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(757, 380);
            formPanel.TabIndex = 2;
            formPanel.Paint += formPanel_Paint;
            // 
            // schmitt_label
            // 
            schmitt_label.Location = new Point(66, 34);
            schmitt_label.Margin = new Padding(3, 2, 3, 2);
            schmitt_label.Name = "schmitt_label";
            schmitt_label.Size = new Size(82, 22);
            schmitt_label.TabIndex = 0;
            schmitt_label.Text = "Schmitt";
            schmitt_label.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            panel.Location = new Point(79, 39);
            panel.Name = "panel";
            panel.Size = new Size(757, 95);
            panel.TabIndex = 3;
            panel.Paint += flowLayoutPanel2_Paint;
            // 
            // StoreOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 580);
            Controls.Add(panel);
            Controls.Add(formPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StoreOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreOverview";
            Load += StoreOverview_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel formPanel;
        private Button schmitt_label;
        private FlowLayoutPanel panel;
    }
}