namespace SpaceAttempt3
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            buttonToEngine = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonToEngine
            // 
            buttonToEngine.BackColor = Color.Black;
            buttonToEngine.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonToEngine.ForeColor = Color.Green;
            buttonToEngine.Location = new Point(713, 905);
            buttonToEngine.Name = "buttonToEngine";
            buttonToEngine.Size = new Size(432, 139);
            buttonToEngine.TabIndex = 0;
            buttonToEngine.Text = "To the engine compartement";
            buttonToEngine.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(510, 68);
            label1.TabIndex = 1;
            label1.Text = "The antenna has been destroyed. \r\nYou are not able to repair it by yourself.";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonToEngine);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonToEngine;
        private Label label1;
    }
}