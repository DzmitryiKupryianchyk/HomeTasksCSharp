namespace SpaceAttempt3
{
    partial class Form25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            buttonBad = new Button();
            SuspendLayout();
            // 
            // buttonBad
            // 
            buttonBad.BackColor = SystemColors.ActiveCaptionText;
            buttonBad.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBad.ForeColor = Color.Green;
            buttonBad.Location = new Point(711, 905);
            buttonBad.Name = "buttonBad";
            buttonBad.Size = new Size(432, 139);
            buttonBad.TabIndex = 0;
            buttonBad.Text = "It's bad";
            buttonBad.UseVisualStyleBackColor = false;
            // 
            // Form25
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(buttonBad);
            Name = "Form25";
            Text = "Form25";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBad;
    }
}