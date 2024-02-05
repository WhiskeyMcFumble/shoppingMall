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
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(31, 32);
            panel.Name = "panel";
            panel.Size = new Size(735, 82);
            panel.TabIndex = 0;
            // 
            // WorkersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Name = "WorkersPage";
            Text = "WorkersPage";
            Load += WorkersPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
    }
}