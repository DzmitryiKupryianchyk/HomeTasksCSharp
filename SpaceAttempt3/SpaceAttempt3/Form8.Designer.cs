namespace SpaceAttempt3
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            buttonOpen = new Button();
            buttonPrecaution = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.Black;
            buttonOpen.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOpen.ForeColor = Color.FromArgb(0, 192, 0);
            buttonOpen.Location = new Point(12, 905);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(432, 139);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Open the airlock and enter.";
            buttonOpen.UseVisualStyleBackColor = false;
            // 
            // buttonPrecaution
            // 
            buttonPrecaution.BackColor = Color.Black;
            buttonPrecaution.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrecaution.ForeColor = Color.FromArgb(0, 192, 0);
            buttonPrecaution.Location = new Point(1414, 905);
            buttonPrecaution.Name = "buttonPrecaution";
            buttonPrecaution.Size = new Size(432, 139);
            buttonPrecaution.TabIndex = 1;
            buttonPrecaution.Text = "Find another way.";
            buttonPrecaution.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(363, 854);
            label1.Name = "label1";
            label1.Size = new Size(1107, 34);
            label1.TabIndex = 2;
            label1.Text = "There is some strange roar behind the door. Maybe it's much safer to find another way.";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(label1);
            Controls.Add(buttonPrecaution);
            Controls.Add(buttonOpen);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private Button buttonPrecaution;
        private Label label1;
    }
}