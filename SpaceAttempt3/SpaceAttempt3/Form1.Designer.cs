namespace SpaceAttempt3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAccept = new Button();
            buttonDecline = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAccept
            // 
            buttonAccept.BackgroundImage = (Image)resources.GetObject("buttonAccept.BackgroundImage");
            buttonAccept.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAccept.Location = new Point(12, 905);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(432, 139);
            buttonAccept.TabIndex = 0;
            buttonAccept.Text = "Accept";
            buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonDecline
            // 
            buttonDecline.BackgroundImage = (Image)resources.GetObject("buttonDecline.BackgroundImage");
            buttonDecline.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDecline.Location = new Point(1414, 905);
            buttonDecline.Name = "buttonDecline";
            buttonDecline.Size = new Size(432, 139);
            buttonDecline.TabIndex = 1;
            buttonDecline.Text = "Decline";
            buttonDecline.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(716, 26);
            label1.Name = "label1";
            label1.Size = new Size(426, 96);
            label1.TabIndex = 2;
            label1.Text = "Start Game?";
            label1.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonDecline);
            Controls.Add(buttonAccept);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAccept;
        private Button buttonDecline;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
    }
}
