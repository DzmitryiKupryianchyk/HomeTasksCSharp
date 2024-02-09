namespace SpaceAttempt3
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            buttonFail1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonFail1
            // 
            buttonFail1.BackColor = SystemColors.ActiveCaptionText;
            buttonFail1.Font = new Font("Tahoma", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFail1.ForeColor = Color.Red;
            buttonFail1.Location = new Point(12, 905);
            buttonFail1.Name = "buttonFail1";
            buttonFail1.Size = new Size(432, 139);
            buttonFail1.TabIndex = 0;
            buttonFail1.Text = "Fail";
            buttonFail1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 34);
            label1.TabIndex = 1;
            label1.Text = "So cute. He kissed you :3";
            // 
            // Form21
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonFail1);
            Name = "Form21";
            Text = "Form21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFail1;
        private Label label1;
    }
}