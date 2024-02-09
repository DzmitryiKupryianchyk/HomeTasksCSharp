namespace SpaceAttempt3
{
    partial class Form18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form18));
            buttonShit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonShit
            // 
            buttonShit.BackColor = SystemColors.ActiveCaptionText;
            buttonShit.Font = new Font("Tahoma", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShit.ForeColor = Color.FromArgb(0, 192, 0);
            buttonShit.Location = new Point(12, 905);
            buttonShit.Name = "buttonShit";
            buttonShit.Size = new Size(432, 139);
            buttonShit.TabIndex = 0;
            buttonShit.Text = "Run!!!";
            buttonShit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(1287, 152);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonShit);
            Name = "Form18";
            Text = "Form18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShit;
        private Label label1;
    }
}