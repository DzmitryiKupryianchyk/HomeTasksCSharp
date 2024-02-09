namespace SpaceAttempt3
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            buttonMove = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonMove
            // 
            buttonMove.BackColor = SystemColors.ActiveCaptionText;
            buttonMove.Font = new Font("Tahoma", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMove.ForeColor = Color.Green;
            buttonMove.Location = new Point(728, 892);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(432, 139);
            buttonMove.TabIndex = 0;
            buttonMove.Text = "Move on";
            buttonMove.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1658, 34);
            label1.TabIndex = 1;
            label1.Text = "The cargo was sent to earth for the purpose of scientific research. But, apparently, because of the accident, he managed to get out.";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonMove);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMove;
        private Label label1;
    }
}