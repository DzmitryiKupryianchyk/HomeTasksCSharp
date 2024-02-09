namespace SpaceAttempt3
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            buttonFinish = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonFinish
            // 
            buttonFinish.BackColor = SystemColors.ActiveCaptionText;
            buttonFinish.Font = new Font("Tahoma", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFinish.ForeColor = Color.Red;
            buttonFinish.Location = new Point(705, 905);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(432, 139);
            buttonFinish.TabIndex = 0;
            buttonFinish.Text = "Finish the game.";
            buttonFinish.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(320, 9);
            label1.Name = "label1";
            label1.Size = new Size(1271, 87);
            label1.TabIndex = 1;
            label1.Text = "And I warned you that you had to run.";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonFinish);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFinish;
        private Label label1;
    }
}