﻿namespace shoppingMall
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
            flowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            store_button = new Button();
            panel2 = new Panel();
            workers_button = new Button();
            panel = new FlowLayoutPanel();
            flowPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.Controls.Add(panel1);
            flowPanel.Controls.Add(panel2);
            flowPanel.Location = new Point(154, 140);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(621, 253);
            flowPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(store_button);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 192);
            panel1.TabIndex = 0;
            // 
            // store_button
            // 
            store_button.Location = new Point(114, 85);
            store_button.Name = "store_button";
            store_button.Size = new Size(75, 23);
            store_button.TabIndex = 0;
            store_button.Text = "Geschäfte";
            store_button.UseVisualStyleBackColor = true;
            store_button.Click += store_button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(workers_button);
            panel2.Location = new Point(304, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 192);
            panel2.TabIndex = 1;
            // 
            // workers_button
            // 
            workers_button.Location = new Point(118, 86);
            workers_button.Name = "workers_button";
            workers_button.Size = new Size(75, 23);
            workers_button.TabIndex = 0;
            workers_button.Text = "Mitarbeiter";
            workers_button.UseVisualStyleBackColor = true;
            workers_button.Click += workers_button_Click_1;
            // 
            // panel
            // 
            panel.Location = new Point(30, 23);
            panel.Name = "panel";
            panel.Size = new Size(917, 100);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(990, 486);
            Controls.Add(panel);
            Controls.Add(flowPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            flowPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private Panel panel1;
        private Panel panel2;
        private Button store_button;
        private Button workers_button;
        private FlowLayoutPanel panel;
    }
}