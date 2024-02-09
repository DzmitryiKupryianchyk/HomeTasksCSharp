namespace SpaceAttempt3
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            buttonGoToControll = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonGoToControll
            // 
            buttonGoToControll.BackColor = SystemColors.ActiveCaptionText;
            buttonGoToControll.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGoToControll.ForeColor = Color.Green;
            buttonGoToControll.Location = new Point(695, 905);
            buttonGoToControll.Name = "buttonGoToControll";
            buttonGoToControll.Size = new Size(432, 139);
            buttonGoToControll.TabIndex = 0;
            buttonGoToControll.Text = "Go to controll panel and Start the self-destruct system";
            buttonGoToControll.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(1719, 68);
            label1.TabIndex = 1;
            label1.Text = "This species uses any living organisms as carriers to raise offspring. This parasitic method of reproduction allows them to adopt the DNA \r\nof the host and evolve rapidly.";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonGoToControll);
            Name = "Form14";
            Text = "Form14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGoToControll;
        private Label label1;
    }
}