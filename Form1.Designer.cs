namespace CS311_Project2_BTA
{
    partial class frmCraps
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
            lblRoll1 = new Label();
            lblRoll2 = new Label();
            lblBalance = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblWinLosePoint = new Label();
            txtBank = new TextBox();
            txtDie1 = new TextBox();
            txtDie2 = new TextBox();
            txtStatus = new TextBox();
            lblDollarSign = new Label();
            SuspendLayout();
            // 
            // lblRoll1
            // 
            lblRoll1.AutoSize = true;
            lblRoll1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoll1.Location = new Point(51, 118);
            lblRoll1.Name = "lblRoll1";
            lblRoll1.Size = new Size(0, 30);
            lblRoll1.TabIndex = 0;
            // 
            // lblRoll2
            // 
            lblRoll2.AutoSize = true;
            lblRoll2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoll2.Location = new Point(141, 116);
            lblRoll2.Name = "lblRoll2";
            lblRoll2.Size = new Size(0, 32);
            lblRoll2.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.Location = new Point(230, 118);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(84, 30);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "$100.00";
            // 
            // txtBet
            // 
            txtBet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBet.Location = new Point(42, 12);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "enter your bet";
            txtBet.Size = new Size(116, 29);
            txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.Location = new Point(42, 171);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(135, 81);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblWinLosePoint
            // 
            lblWinLosePoint.AutoSize = true;
            lblWinLosePoint.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWinLosePoint.Location = new Point(240, 215);
            lblWinLosePoint.Name = "lblWinLosePoint";
            lblWinLosePoint.Size = new Size(0, 47);
            lblWinLosePoint.TabIndex = 5;
            // 
            // txtBank
            // 
            txtBank.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtBank.Location = new Point(230, 76);
            txtBank.Name = "txtBank";
            txtBank.Size = new Size(100, 39);
            txtBank.TabIndex = 6;
            txtBank.Text = "Bank";
            // 
            // txtDie1
            // 
            txtDie1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtDie1.Location = new Point(42, 76);
            txtDie1.Name = "txtDie1";
            txtDie1.Size = new Size(65, 39);
            txtDie1.TabIndex = 7;
            txtDie1.Text = "Die 1";
            // 
            // txtDie2
            // 
            txtDie2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtDie2.Location = new Point(128, 76);
            txtDie2.Name = "txtDie2";
            txtDie2.Size = new Size(71, 39);
            txtDie2.TabIndex = 8;
            txtDie2.Text = "Die 2";
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtStatus.Location = new Point(230, 173);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 39);
            txtStatus.TabIndex = 9;
            txtStatus.Text = "Status:";
            // 
            // lblDollarSign
            // 
            lblDollarSign.AutoSize = true;
            lblDollarSign.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDollarSign.Location = new Point(19, 18);
            lblDollarSign.Name = "lblDollarSign";
            lblDollarSign.Size = new Size(15, 17);
            lblDollarSign.TabIndex = 10;
            lblDollarSign.Text = "$";
            // 
            // frmCraps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 296);
            Controls.Add(lblDollarSign);
            Controls.Add(txtStatus);
            Controls.Add(txtDie2);
            Controls.Add(txtDie1);
            Controls.Add(txtBank);
            Controls.Add(lblWinLosePoint);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBalance);
            Controls.Add(lblRoll2);
            Controls.Add(lblRoll1);
            Name = "frmCraps";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoll1;
        private Label lblRoll2;
        private Label lblBalance;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblWinLosePoint;
        private TextBox txtBank;
        private TextBox txtDie1;
        private TextBox txtDie2;
        private TextBox txtStatus;
        private Label lblDollarSign;
    }
}