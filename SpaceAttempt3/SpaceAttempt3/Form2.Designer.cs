namespace SpaceAttempt3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            AffirmativeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AffirmativeButton
            // 
            AffirmativeButton.BackColor = Color.Black;
            AffirmativeButton.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AffirmativeButton.ForeColor = SystemColors.ActiveCaption;
            AffirmativeButton.Location = new Point(748, 918);
            AffirmativeButton.Name = "AffirmativeButton";
            AffirmativeButton.Size = new Size(417, 182);
            AffirmativeButton.TabIndex = 0;
            AffirmativeButton.Text = "Affirmative";
            AffirmativeButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1752, 102);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.UseMnemonic = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1880, 1112);
            Controls.Add(label1);
            Controls.Add(AffirmativeButton);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(0, 192, 0);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AffirmativeButton;
        private Label label1;
    }
}