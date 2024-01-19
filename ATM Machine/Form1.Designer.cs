namespace ATM_Machine
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPin = new Label();
            txtPin = new TextBox();
            btnEnter = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(72, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter Your PIN";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPin.Location = new Point(32, 104);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(35, 21);
            lblPin.TabIndex = 1;
            lblPin.Text = "PIN";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(80, 104);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(192, 23);
            txtPin.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(200, 136);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(120, 136);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 181);
            Controls.Add(btnClear);
            Controls.Add(btnEnter);
            Controls.Add(txtPin);
            Controls.Add(lblPin);
            Controls.Add(lblTitle);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM Machine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPin;
        private TextBox txtPin;
        private Button btnEnter;
        private Button btnClear;
    }
}