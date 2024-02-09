namespace SpaceAttempt3
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            buttonLaunch = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLaunch
            // 
            buttonLaunch.BackColor = SystemColors.ActiveCaptionText;
            buttonLaunch.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLaunch.ForeColor = Color.FromArgb(0, 192, 0);
            buttonLaunch.Location = new Point(733, 905);
            buttonLaunch.Name = "buttonLaunch";
            buttonLaunch.Size = new Size(432, 139);
            buttonLaunch.TabIndex = 0;
            buttonLaunch.Text = "Launch the shuttle";
            buttonLaunch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(524, 853);
            label1.Name = "label1";
            label1.Size = new Size(851, 34);
            label1.TabIndex = 1;
            label1.Text = "Launch the shuttle! The self-destruction system will work out soon!";
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonLaunch);
            Name = "Form16";
            Text = "Form16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLaunch;
        private Label label1;
    }
}