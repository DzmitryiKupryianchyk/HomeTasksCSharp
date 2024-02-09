namespace SpaceAttempt3
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            buttonRun1 = new Button();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // buttonRun1
            // 
            buttonRun1.BackColor = SystemColors.ActiveCaptionText;
            buttonRun1.Font = new Font("Tahoma", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRun1.ForeColor = Color.FromArgb(0, 192, 0);
            buttonRun1.Location = new Point(12, 12);
            buttonRun1.Name = "buttonRun1";
            buttonRun1.Size = new Size(432, 139);
            buttonRun1.TabIndex = 0;
            buttonRun1.Text = "Run!";
            buttonRun1.UseVisualStyleBackColor = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaptionText;
            buttonHelp.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHelp.ForeColor = Color.FromArgb(0, 192, 0);
            buttonHelp.Location = new Point(1414, 905);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(432, 139);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Help out";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRun1);
            Name = "Form23";
            Text = "Form23";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRun1;
        private Button buttonHelp;
    }
}