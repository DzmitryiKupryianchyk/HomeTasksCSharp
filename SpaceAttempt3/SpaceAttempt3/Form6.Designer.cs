namespace SpaceAttempt3
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            buttonRadio = new Button();
            buttonInternalCommunication = new Button();
            buttonAlarmProbe = new Button();
            buttonCheckEngine = new Button();
            buttonCheckAntenna = new Button();
            label1 = new Label();
            buttonScan = new Button();
            SuspendLayout();
            // 
            // buttonRadio
            // 
            buttonRadio.BackColor = Color.FromArgb(128, 64, 0);
            buttonRadio.Cursor = Cursors.Hand;
            buttonRadio.FlatStyle = FlatStyle.Popup;
            buttonRadio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRadio.ForeColor = Color.FromArgb(255, 255, 128);
            buttonRadio.Location = new Point(548, 652);
            buttonRadio.Name = "buttonRadio";
            buttonRadio.Size = new Size(231, 34);
            buttonRadio.TabIndex = 0;
            buttonRadio.Text = "Radio On";
            buttonRadio.UseVisualStyleBackColor = false;
            // 
            // buttonInternalCommunication
            // 
            buttonInternalCommunication.BackColor = Color.FromArgb(128, 64, 0);
            buttonInternalCommunication.Cursor = Cursors.Hand;
            buttonInternalCommunication.FlatStyle = FlatStyle.Popup;
            buttonInternalCommunication.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInternalCommunication.ForeColor = Color.FromArgb(255, 255, 128);
            buttonInternalCommunication.Location = new Point(548, 691);
            buttonInternalCommunication.Name = "buttonInternalCommunication";
            buttonInternalCommunication.Size = new Size(231, 35);
            buttonInternalCommunication.TabIndex = 1;
            buttonInternalCommunication.Text = "Int. communication ";
            buttonInternalCommunication.UseVisualStyleBackColor = false;
            // 
            // buttonAlarmProbe
            // 
            buttonAlarmProbe.BackColor = Color.FromArgb(128, 64, 0);
            buttonAlarmProbe.Cursor = Cursors.Hand;
            buttonAlarmProbe.FlatStyle = FlatStyle.Popup;
            buttonAlarmProbe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlarmProbe.ForeColor = Color.FromArgb(255, 255, 128);
            buttonAlarmProbe.Location = new Point(548, 730);
            buttonAlarmProbe.Name = "buttonAlarmProbe";
            buttonAlarmProbe.Size = new Size(231, 33);
            buttonAlarmProbe.TabIndex = 2;
            buttonAlarmProbe.Text = "emergency alarm probe";
            buttonAlarmProbe.UseVisualStyleBackColor = false;
            // 
            // buttonCheckEngine
            // 
            buttonCheckEngine.BackColor = Color.FromArgb(128, 64, 0);
            buttonCheckEngine.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCheckEngine.ForeColor = Color.Yellow;
            buttonCheckEngine.Location = new Point(12, 905);
            buttonCheckEngine.Name = "buttonCheckEngine";
            buttonCheckEngine.Size = new Size(432, 139);
            buttonCheckEngine.TabIndex = 3;
            buttonCheckEngine.Text = "CheckUp the engine compartment";
            buttonCheckEngine.UseVisualStyleBackColor = false;
            // 
            // buttonCheckAntenna
            // 
            buttonCheckAntenna.BackColor = Color.FromArgb(128, 64, 0);
            buttonCheckAntenna.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCheckAntenna.ForeColor = Color.Yellow;
            buttonCheckAntenna.Location = new Point(1414, 905);
            buttonCheckAntenna.Name = "buttonCheckAntenna";
            buttonCheckAntenna.Size = new Size(432, 139);
            buttonCheckAntenna.TabIndex = 4;
            buttonCheckAntenna.Text = "Check up the main antenna";
            buttonCheckAntenna.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(69, 790);
            label1.Name = "label1";
            label1.Size = new Size(1704, 102);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonScan
            // 
            buttonScan.BackColor = Color.FromArgb(128, 64, 0);
            buttonScan.FlatStyle = FlatStyle.Popup;
            buttonScan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonScan.ForeColor = Color.FromArgb(255, 255, 128);
            buttonScan.Location = new Point(785, 652);
            buttonScan.Name = "buttonScan";
            buttonScan.Size = new Size(231, 33);
            buttonScan.TabIndex = 6;
            buttonScan.Text = "Scan the ship";
            buttonScan.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1858, 1056);
            Controls.Add(buttonScan);
            Controls.Add(label1);
            Controls.Add(buttonCheckAntenna);
            Controls.Add(buttonCheckEngine);
            Controls.Add(buttonAlarmProbe);
            Controls.Add(buttonInternalCommunication);
            Controls.Add(buttonRadio);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRadio;
        private Button buttonInternalCommunication;
        private Button buttonAlarmProbe;
        private Button buttonCheckEngine;
        private Button buttonCheckAntenna;
        private Label label1;
        private Button buttonScan;
    }
}