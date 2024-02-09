namespace SpaceAttempt3
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            buttonRadio = new Button();
            buttonIntCommunication = new Button();
            buttonProbe = new Button();
            buttonScan = new Button();
            buttonDestruction = new Button();
            label1 = new Label();
            buttonRunToShuttle = new Button();
            SuspendLayout();
            // 
            // buttonRadio
            // 
            buttonRadio.BackColor = Color.FromArgb(128, 64, 0);
            buttonRadio.Cursor = Cursors.Hand;
            buttonRadio.FlatStyle = FlatStyle.Popup;
            buttonRadio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRadio.ForeColor = Color.FromArgb(255, 255, 128);
            buttonRadio.Location = new Point(546, 650);
            buttonRadio.Name = "buttonRadio";
            buttonRadio.Size = new Size(231, 34);
            buttonRadio.TabIndex = 0;
            buttonRadio.Text = "Radio on";
            buttonRadio.UseVisualStyleBackColor = false;
            // 
            // buttonIntCommunication
            // 
            buttonIntCommunication.BackColor = Color.FromArgb(128, 64, 0);
            buttonIntCommunication.Cursor = Cursors.Hand;
            buttonIntCommunication.FlatStyle = FlatStyle.Popup;
            buttonIntCommunication.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIntCommunication.ForeColor = Color.FromArgb(255, 255, 128);
            buttonIntCommunication.Location = new Point(546, 690);
            buttonIntCommunication.Name = "buttonIntCommunication";
            buttonIntCommunication.Size = new Size(231, 34);
            buttonIntCommunication.TabIndex = 1;
            buttonIntCommunication.Text = "Int. communication";
            buttonIntCommunication.UseVisualStyleBackColor = false;
            // 
            // buttonProbe
            // 
            buttonProbe.BackColor = Color.FromArgb(128, 64, 0);
            buttonProbe.Cursor = Cursors.Hand;
            buttonProbe.FlatStyle = FlatStyle.Popup;
            buttonProbe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProbe.ForeColor = Color.FromArgb(255, 255, 128);
            buttonProbe.Location = new Point(546, 730);
            buttonProbe.Name = "buttonProbe";
            buttonProbe.Size = new Size(231, 34);
            buttonProbe.TabIndex = 2;
            buttonProbe.Text = "Emergency alarm probe";
            buttonProbe.UseVisualStyleBackColor = false;
            // 
            // buttonScan
            // 
            buttonScan.BackColor = Color.FromArgb(128, 64, 0);
            buttonScan.Cursor = Cursors.Hand;
            buttonScan.FlatStyle = FlatStyle.Popup;
            buttonScan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonScan.ForeColor = Color.FromArgb(255, 255, 128);
            buttonScan.Location = new Point(783, 650);
            buttonScan.Name = "buttonScan";
            buttonScan.Size = new Size(231, 34);
            buttonScan.TabIndex = 3;
            buttonScan.Text = "Scan the ship";
            buttonScan.UseVisualStyleBackColor = false;
            // 
            // buttonDestruction
            // 
            buttonDestruction.BackColor = Color.FromArgb(128, 64, 0);
            buttonDestruction.Cursor = Cursors.Hand;
            buttonDestruction.FlatStyle = FlatStyle.Popup;
            buttonDestruction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDestruction.ForeColor = Color.FromArgb(255, 255, 128);
            buttonDestruction.Location = new Point(1249, 645);
            buttonDestruction.Name = "buttonDestruction";
            buttonDestruction.Size = new Size(121, 111);
            buttonDestruction.TabIndex = 4;
            buttonDestruction.Text = "Self-destruct system";
            buttonDestruction.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(510, 856);
            label1.Name = "label1";
            label1.Size = new Size(894, 34);
            label1.TabIndex = 5;
            label1.Text = "Launch the self-destruct system and run to the rescue shuttle.";
            // 
            // buttonRunToShuttle
            // 
            buttonRunToShuttle.BackColor = Color.FromArgb(128, 64, 0);
            buttonRunToShuttle.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRunToShuttle.ForeColor = Color.Yellow;
            buttonRunToShuttle.Location = new Point(711, 905);
            buttonRunToShuttle.Name = "buttonRunToShuttle";
            buttonRunToShuttle.Size = new Size(432, 139);
            buttonRunToShuttle.TabIndex = 6;
            buttonRunToShuttle.Text = "Run to shuttle";
            buttonRunToShuttle.UseVisualStyleBackColor = false;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1858, 1056);
            Controls.Add(buttonRunToShuttle);
            Controls.Add(label1);
            Controls.Add(buttonDestruction);
            Controls.Add(buttonScan);
            Controls.Add(buttonProbe);
            Controls.Add(buttonIntCommunication);
            Controls.Add(buttonRadio);
            Name = "Form15";
            Text = "Form15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRadio;
        private Button buttonIntCommunication;
        private Button buttonProbe;
        private Button buttonScan;
        private Button buttonDestruction;
        private Label label1;
        private Button buttonRunToShuttle;
    }
}