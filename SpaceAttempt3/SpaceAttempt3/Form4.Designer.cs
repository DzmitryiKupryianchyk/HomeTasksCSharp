﻿namespace SpaceAttempt3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            buttonGotIt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonGotIt
            // 
            buttonGotIt.BackColor = Color.FromArgb(0, 0, 64);
            buttonGotIt.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGotIt.ForeColor = Color.Green;
            buttonGotIt.Location = new Point(707, 905);
            buttonGotIt.Name = "buttonGotIt";
            buttonGotIt.Size = new Size(432, 139);
            buttonGotIt.TabIndex = 0;
            buttonGotIt.Text = "Got It";
            buttonGotIt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(1703, 102);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.UseMnemonic = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonGotIt);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGotIt;
        private Label label1;
    }
}