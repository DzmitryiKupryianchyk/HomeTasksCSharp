namespace SpaceAttempt3
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            buttonAlarm = new Button();
            label1 = new Label();
            buttonSOS = new Button();
            buttonFindCrew = new Button();
            buttonCheckCargo = new Button();
            SuspendLayout();
            // 
            // buttonAlarm
            // 
            buttonAlarm.BackColor = Color.Red;
            buttonAlarm.Cursor = Cursors.Hand;
            buttonAlarm.FlatStyle = FlatStyle.Popup;
            buttonAlarm.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlarm.Location = new Point(443, 399);
            buttonAlarm.Name = "buttonAlarm";
            buttonAlarm.Size = new Size(123, 116);
            buttonAlarm.TabIndex = 0;
            buttonAlarm.Text = "Alarm";
            buttonAlarm.UseMnemonic = false;
            buttonAlarm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(207, 844);
            label1.Name = "label1";
            label1.Size = new Size(1514, 43);
            label1.TabIndex = 1;
            label1.Text = "I guess it's better to urn off the alarm. After that you should make a decision what to do next.";
            label1.UseMnemonic = false;
            // 
            // buttonSOS
            // 
            buttonSOS.BackColor = SystemColors.ActiveCaptionText;
            buttonSOS.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSOS.ForeColor = Color.FromArgb(0, 192, 0);
            buttonSOS.Location = new Point(27, 905);
            buttonSOS.Name = "buttonSOS";
            buttonSOS.Size = new Size(432, 139);
            buttonSOS.TabIndex = 2;
            buttonSOS.Text = "Send an SOS signal";
            buttonSOS.UseMnemonic = false;
            buttonSOS.UseVisualStyleBackColor = false;
            // 
            // buttonFindCrew
            // 
            buttonFindCrew.BackColor = SystemColors.ActiveCaptionText;
            buttonFindCrew.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFindCrew.ForeColor = Color.FromArgb(0, 192, 0);
            buttonFindCrew.Location = new Point(719, 905);
            buttonFindCrew.Name = "buttonFindCrew";
            buttonFindCrew.Size = new Size(432, 139);
            buttonFindCrew.TabIndex = 3;
            buttonFindCrew.Text = "Find the rest of crew members";
            buttonFindCrew.UseMnemonic = false;
            buttonFindCrew.UseVisualStyleBackColor = false;
            buttonFindCrew.Click += buttonFindCrew_Click_1;
            // 
            // buttonCheckCargo
            // 
            buttonCheckCargo.BackColor = SystemColors.ActiveCaptionText;
            buttonCheckCargo.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckCargo.ForeColor = Color.FromArgb(0, 192, 0);
            buttonCheckCargo.Location = new Point(1414, 905);
            buttonCheckCargo.Name = "buttonCheckCargo";
            buttonCheckCargo.Size = new Size(432, 139);
            buttonCheckCargo.TabIndex = 4;
            buttonCheckCargo.Text = "Check on the cargo";
            buttonCheckCargo.UseMnemonic = false;
            buttonCheckCargo.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1858, 1056);
            Controls.Add(buttonCheckCargo);
            Controls.Add(buttonFindCrew);
            Controls.Add(buttonSOS);
            Controls.Add(label1);
            Controls.Add(buttonAlarm);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAlarm;
        private Label label1;
        private Button buttonSOS;
        private Button buttonFindCrew;
        private Button buttonCheckCargo;
    }
}