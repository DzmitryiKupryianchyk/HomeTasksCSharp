namespace SpaceAttempt3
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            buttonLook = new Button();
            buttonGetOut = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLook
            // 
            buttonLook.BackColor = SystemColors.ActiveCaptionText;
            buttonLook.Font = new Font("Tahoma", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLook.ForeColor = Color.FromArgb(0, 192, 0);
            buttonLook.Location = new Point(12, 905);
            buttonLook.Name = "buttonLook";
            buttonLook.Size = new Size(432, 139);
            buttonLook.TabIndex = 0;
            buttonLook.Text = "Look closer";
            buttonLook.UseVisualStyleBackColor = false;
            // 
            // buttonGetOut
            // 
            buttonGetOut.BackColor = SystemColors.ActiveCaptionText;
            buttonGetOut.Font = new Font("Tahoma", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGetOut.ForeColor = Color.FromArgb(0, 192, 0);
            buttonGetOut.Location = new Point(1414, 905);
            buttonGetOut.Name = "buttonGetOut";
            buttonGetOut.Size = new Size(432, 139);
            buttonGetOut.TabIndex = 1;
            buttonGetOut.Text = "Get out of here.";
            buttonGetOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(110, 42);
            label1.Name = "label1";
            label1.Size = new Size(1626, 38);
            label1.TabIndex = 2;
            label1.Text = "Xenomorph eggs are a specific feature of their breeding system. The eggs hatch into vectors that lay the embryo inside their prey.";
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonGetOut);
            Controls.Add(buttonLook);
            Name = "Form19";
            Text = "Form19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLook;
        private Button buttonGetOut;
        private Label label1;
    }
}