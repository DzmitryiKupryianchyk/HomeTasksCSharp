namespace SpaceAttempt3
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            buttonRun = new Button();
            buttonFight = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.Navy;
            buttonRun.Font = new Font("Tahoma", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRun.ForeColor = Color.Green;
            buttonRun.Location = new Point(23, 905);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(432, 139);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "Run away";
            buttonRun.UseVisualStyleBackColor = false;
            // 
            // buttonFight
            // 
            buttonFight.BackColor = Color.Navy;
            buttonFight.Font = new Font("Tahoma", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFight.ForeColor = Color.Green;
            buttonFight.Location = new Point(12, 12);
            buttonFight.Name = "buttonFight";
            buttonFight.Size = new Size(432, 139);
            buttonFight.TabIndex = 1;
            buttonFight.Text = "Fight him";
            buttonFight.UseMnemonic = false;
            buttonFight.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(12, 179);
            label1.Name = "label1";
            label1.Size = new Size(770, 136);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonFight);
            Controls.Add(buttonRun);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun;
        private Button buttonFight;
        private Label label1;
    }
}