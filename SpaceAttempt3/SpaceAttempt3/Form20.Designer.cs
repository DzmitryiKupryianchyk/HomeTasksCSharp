namespace SpaceAttempt3
{
    partial class Form20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            buttonFail = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonFail
            // 
            buttonFail.BackColor = SystemColors.ActiveCaptionText;
            buttonFail.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFail.ForeColor = Color.Red;
            buttonFail.Location = new Point(715, 905);
            buttonFail.Name = "buttonFail";
            buttonFail.RightToLeft = RightToLeft.No;
            buttonFail.Size = new Size(432, 139);
            buttonFail.TabIndex = 0;
            buttonFail.Text = "You failed";
            buttonFail.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(476, 34);
            label1.TabIndex = 1;
            label1.Text = "Unfortunately, he was quite hungry:(";
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonFail);
            Name = "Form20";
            Text = "Form20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFail;
        private Label label1;
    }
}