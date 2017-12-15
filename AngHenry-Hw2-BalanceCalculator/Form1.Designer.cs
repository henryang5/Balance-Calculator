namespace AngHenry_Hw2_BalanceCalculator
{
    partial class balanceCalculatorForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.showBalanceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.beginningBalanceLabel = new System.Windows.Forms.Label();
            this.depositsLabel = new System.Windows.Forms.Label();
            this.withdrawsLabel = new System.Windows.Forms.Label();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.checkBeginningBalanceTextBox = new System.Windows.Forms.TextBox();
            this.checkingDepositTextBox = new System.Windows.Forms.TextBox();
            this.checkingWithdrawTextBox = new System.Windows.Forms.TextBox();
            this.savingBeginningBalanceTextBox = new System.Windows.Forms.TextBox();
            this.savingDepositTextBox = new System.Windows.Forms.TextBox();
            this.savingWithdrawTextBox = new System.Windows.Forms.TextBox();
            this.accountTitleLabel = new System.Windows.Forms.Label();
            this.accountManagerLabel = new System.Windows.Forms.Label();
            this.checkingEndbalanceLabel = new System.Windows.Forms.Label();
            this.savingEndbalanceLabel = new System.Windows.Forms.Label();
            this.accountSummaryLabel = new System.Windows.Forms.Label();
            this.activityMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(268, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(116, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tiny Bank\r\n\"We\'re Small but Safe\"";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showBalanceButton
            // 
            this.showBalanceButton.AccessibleName = "";
            this.showBalanceButton.Location = new System.Drawing.Point(456, 412);
            this.showBalanceButton.Name = "showBalanceButton";
            this.showBalanceButton.Size = new System.Drawing.Size(103, 50);
            this.showBalanceButton.TabIndex = 9;
            this.showBalanceButton.Text = "Show Balance";
            this.showBalanceButton.UseVisualStyleBackColor = true;
            this.showBalanceButton.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // resetButton
            // 
            this.resetButton.AccessibleDescription = "";
            this.resetButton.AccessibleName = "";
            this.resetButton.Location = new System.Drawing.Point(164, 494);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 38);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(304, 494);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 38);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(127, 128);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(328, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(56, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name: ";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(56, 176);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(65, 13);
            this.activityLabel.TabIndex = 6;
            this.activityLabel.Text = "Activity For: ";
            // 
            // checkingLabel
            // 
            this.checkingLabel.AutoSize = true;
            this.checkingLabel.Location = new System.Drawing.Point(56, 263);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(55, 13);
            this.checkingLabel.TabIndex = 8;
            this.checkingLabel.Text = "Checking:";
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Location = new System.Drawing.Point(56, 313);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(51, 13);
            this.savingsLabel.TabIndex = 9;
            this.savingsLabel.Text = "Savings: ";
            // 
            // beginningBalanceLabel
            // 
            this.beginningBalanceLabel.AutoSize = true;
            this.beginningBalanceLabel.Location = new System.Drawing.Point(132, 232);
            this.beginningBalanceLabel.Name = "beginningBalanceLabel";
            this.beginningBalanceLabel.Size = new System.Drawing.Size(96, 13);
            this.beginningBalanceLabel.TabIndex = 10;
            this.beginningBalanceLabel.Text = "Beginning Balance";
            // 
            // depositsLabel
            // 
            this.depositsLabel.AutoSize = true;
            this.depositsLabel.Location = new System.Drawing.Point(281, 232);
            this.depositsLabel.Name = "depositsLabel";
            this.depositsLabel.Size = new System.Drawing.Size(48, 13);
            this.depositsLabel.TabIndex = 11;
            this.depositsLabel.Text = "Deposits";
            // 
            // withdrawsLabel
            // 
            this.withdrawsLabel.AutoSize = true;
            this.withdrawsLabel.Location = new System.Drawing.Point(398, 232);
            this.withdrawsLabel.Name = "withdrawsLabel";
            this.withdrawsLabel.Size = new System.Drawing.Size(57, 13);
            this.withdrawsLabel.TabIndex = 12;
            this.withdrawsLabel.Text = "Withdraws";
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.AutoSize = true;
            this.endingBalanceLabel.Location = new System.Drawing.Point(504, 232);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(82, 13);
            this.endingBalanceLabel.TabIndex = 13;
            this.endingBalanceLabel.Text = "Ending Balance";
            // 
            // checkBeginningBalanceTextBox
            // 
            this.checkBeginningBalanceTextBox.Location = new System.Drawing.Point(127, 260);
            this.checkBeginningBalanceTextBox.Name = "checkBeginningBalanceTextBox";
            this.checkBeginningBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.checkBeginningBalanceTextBox.TabIndex = 3;
            this.checkBeginningBalanceTextBox.Text = "0.00";
            // 
            // checkingDepositTextBox
            // 
            this.checkingDepositTextBox.Location = new System.Drawing.Point(252, 260);
            this.checkingDepositTextBox.Name = "checkingDepositTextBox";
            this.checkingDepositTextBox.Size = new System.Drawing.Size(100, 20);
            this.checkingDepositTextBox.TabIndex = 4;
            this.checkingDepositTextBox.Text = "0.00";
            // 
            // checkingWithdrawTextBox
            // 
            this.checkingWithdrawTextBox.Location = new System.Drawing.Point(373, 260);
            this.checkingWithdrawTextBox.Name = "checkingWithdrawTextBox";
            this.checkingWithdrawTextBox.Size = new System.Drawing.Size(100, 20);
            this.checkingWithdrawTextBox.TabIndex = 5;
            this.checkingWithdrawTextBox.Text = "0.00";
            // 
            // savingBeginningBalanceTextBox
            // 
            this.savingBeginningBalanceTextBox.Location = new System.Drawing.Point(127, 310);
            this.savingBeginningBalanceTextBox.Name = "savingBeginningBalanceTextBox";
            this.savingBeginningBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingBeginningBalanceTextBox.TabIndex = 6;
            this.savingBeginningBalanceTextBox.Text = "0.00";
            // 
            // savingDepositTextBox
            // 
            this.savingDepositTextBox.Location = new System.Drawing.Point(252, 313);
            this.savingDepositTextBox.Name = "savingDepositTextBox";
            this.savingDepositTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingDepositTextBox.TabIndex = 7;
            this.savingDepositTextBox.Text = "0.00";
            // 
            // savingWithdrawTextBox
            // 
            this.savingWithdrawTextBox.Location = new System.Drawing.Point(373, 313);
            this.savingWithdrawTextBox.Name = "savingWithdrawTextBox";
            this.savingWithdrawTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingWithdrawTextBox.TabIndex = 8;
            this.savingWithdrawTextBox.Text = "0.00";
            // 
            // accountTitleLabel
            // 
            this.accountTitleLabel.AutoSize = true;
            this.accountTitleLabel.Location = new System.Drawing.Point(236, 368);
            this.accountTitleLabel.Name = "accountTitleLabel";
            this.accountTitleLabel.Size = new System.Drawing.Size(93, 13);
            this.accountTitleLabel.TabIndex = 22;
            this.accountTitleLabel.Text = "Account Summary";
            this.accountTitleLabel.UseMnemonic = false;
            // 
            // accountManagerLabel
            // 
            this.accountManagerLabel.AutoSize = true;
            this.accountManagerLabel.Location = new System.Drawing.Point(262, 78);
            this.accountManagerLabel.Name = "accountManagerLabel";
            this.accountManagerLabel.Size = new System.Drawing.Size(139, 13);
            this.accountManagerLabel.TabIndex = 24;
            this.accountManagerLabel.Text = "Personal Account Manager ";
            // 
            // checkingEndbalanceLabel
            // 
            this.checkingEndbalanceLabel.Location = new System.Drawing.Point(490, 263);
            this.checkingEndbalanceLabel.Name = "checkingEndbalanceLabel";
            this.checkingEndbalanceLabel.Size = new System.Drawing.Size(100, 20);
            this.checkingEndbalanceLabel.TabIndex = 25;
            // 
            // savingEndbalanceLabel
            // 
            this.savingEndbalanceLabel.Location = new System.Drawing.Point(490, 313);
            this.savingEndbalanceLabel.Name = "savingEndbalanceLabel";
            this.savingEndbalanceLabel.Size = new System.Drawing.Size(100, 20);
            this.savingEndbalanceLabel.TabIndex = 26;
            // 
            // accountSummaryLabel
            // 
            this.accountSummaryLabel.Location = new System.Drawing.Point(193, 393);
            this.accountSummaryLabel.Name = "accountSummaryLabel";
            this.accountSummaryLabel.Size = new System.Drawing.Size(240, 69);
            this.accountSummaryLabel.TabIndex = 27;
            // 
            // activityMaskedTextBox
            // 
            this.activityMaskedTextBox.Location = new System.Drawing.Point(127, 169);
            this.activityMaskedTextBox.Mask = "AAAAAAAAA,0000";
            this.activityMaskedTextBox.Name = "activityMaskedTextBox";
            this.activityMaskedTextBox.Size = new System.Drawing.Size(101, 20);
            this.activityMaskedTextBox.TabIndex = 2;
            // 
            // balanceCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 574);
            this.Controls.Add(this.activityMaskedTextBox);
            this.Controls.Add(this.accountSummaryLabel);
            this.Controls.Add(this.savingEndbalanceLabel);
            this.Controls.Add(this.checkingEndbalanceLabel);
            this.Controls.Add(this.accountManagerLabel);
            this.Controls.Add(this.accountTitleLabel);
            this.Controls.Add(this.savingWithdrawTextBox);
            this.Controls.Add(this.savingDepositTextBox);
            this.Controls.Add(this.savingBeginningBalanceTextBox);
            this.Controls.Add(this.checkingWithdrawTextBox);
            this.Controls.Add(this.checkingDepositTextBox);
            this.Controls.Add(this.checkBeginningBalanceTextBox);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.withdrawsLabel);
            this.Controls.Add(this.depositsLabel);
            this.Controls.Add(this.beginningBalanceLabel);
            this.Controls.Add(this.savingsLabel);
            this.Controls.Add(this.checkingLabel);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.showBalanceButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "balanceCalculatorForm";
            this.Text = "Hw 2 - Balance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button showBalanceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label beginningBalanceLabel;
        private System.Windows.Forms.Label depositsLabel;
        private System.Windows.Forms.Label withdrawsLabel;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.TextBox checkBeginningBalanceTextBox;
        private System.Windows.Forms.TextBox checkingDepositTextBox;
        private System.Windows.Forms.TextBox checkingWithdrawTextBox;
        private System.Windows.Forms.TextBox savingBeginningBalanceTextBox;
        private System.Windows.Forms.TextBox savingDepositTextBox;
        private System.Windows.Forms.TextBox savingWithdrawTextBox;
        private System.Windows.Forms.Label accountTitleLabel;
        private System.Windows.Forms.Label accountManagerLabel;
        private System.Windows.Forms.Label checkingEndbalanceLabel;
        private System.Windows.Forms.Label accountSummaryLabel;
        private System.Windows.Forms.Label savingEndbalanceLabel;
        private System.Windows.Forms.MaskedTextBox activityMaskedTextBox;
    }
}

