namespace SpaceAttempt3
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            buttonMoveOn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonMoveOn
            // 
            buttonMoveOn.BackColor = Color.Navy;
            buttonMoveOn.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMoveOn.ForeColor = Color.FromArgb(0, 192, 0);
            buttonMoveOn.Location = new Point(641, 905);
            buttonMoveOn.Name = "buttonMoveOn";
            buttonMoveOn.Size = new Size(432, 139);
            buttonMoveOn.TabIndex = 1;
            buttonMoveOn.Text = "Move on";
            buttonMoveOn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(622, 852);
            label1.Name = "label1";
            label1.Size = new Size(495, 39);
            label1.TabIndex = 2;
            label1.Text = "It's suspiciously quiet on the ship.";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonMoveOn);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonMoveOn;
        private Label label1;
    }
}