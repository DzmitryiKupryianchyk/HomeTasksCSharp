namespace SpaceAttempt3
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            buttonRun1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonRun1
            // 
            buttonRun1.BackColor = SystemColors.ActiveCaptionText;
            buttonRun1.Font = new Font("Tahoma", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRun1.ForeColor = Color.FromArgb(0, 192, 0);
            buttonRun1.Location = new Point(12, 905);
            buttonRun1.Name = "buttonRun1";
            buttonRun1.Size = new Size(432, 139);
            buttonRun1.TabIndex = 0;
            buttonRun1.Text = "RUN!";
            buttonRun1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(682, 34);
            label1.TabIndex = 1;
            label1.Text = "You would better not to move. Maybe he will pass by.";
            // 
            // Form22
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1709, 1056);
            Controls.Add(label1);
            Controls.Add(buttonRun1);
            ForeColor = Color.FromArgb(0, 192, 0);
            Name = "Form22";
            Text = "Form22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun1;
        private Label label1;
    }
}