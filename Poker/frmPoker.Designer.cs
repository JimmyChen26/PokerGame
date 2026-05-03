namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.lblMoneyText = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblBetText = new System.Windows.Forms.Label();
            this.txtBetMoney = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblRechargeText = new System.Windows.Forms.Label();
            this.lblallin = new System.Windows.Forms.Label();
            this.txtRechargeMoney = new System.Windows.Forms.TextBox();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.btnAllIn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblOddsHint = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.grpBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(50, 100);
            this.grpPoker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPoker.Size = new System.Drawing.Size(728, 240);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(50, 570);
            this.grpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpButton.Name = "grpButton";
            this.grpButton.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpButton.Size = new System.Drawing.Size(728, 120);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(378, 42);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(334, 54);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(246, 42);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(123, 54);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(141, 42);
            this.btnChangeCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(96, 54);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(32, 42);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(100, 54);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpBet
            // 
            this.grpBet.Controls.Add(this.btnAllIn);
            this.grpBet.Controls.Add(this.btnRecharge);
            this.grpBet.Controls.Add(this.txtRechargeMoney);
            this.grpBet.Controls.Add(this.lblallin);
            this.grpBet.Controls.Add(this.lblRechargeText);
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.txtBetMoney);
            this.grpBet.Controls.Add(this.lblBetText);
            this.grpBet.Controls.Add(this.txtMoney);
            this.grpBet.Controls.Add(this.lblMoneyText);
            this.grpBet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBet.Location = new System.Drawing.Point(50, 358);
            this.grpBet.Name = "grpBet";
            this.grpBet.Size = new System.Drawing.Size(728, 205);
            this.grpBet.TabIndex = 2;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // lblMoneyText
            // 
            this.lblMoneyText.AutoSize = true;
            this.lblMoneyText.Location = new System.Drawing.Point(6, 77);
            this.lblMoneyText.Name = "lblMoneyText";
            this.lblMoneyText.Size = new System.Drawing.Size(85, 30);
            this.lblMoneyText.TabIndex = 0;
            this.lblMoneyText.Text = "總資金";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(112, 68);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(158, 39);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.Text = "1000000";
            // 
            // lblBetText
            // 
            this.lblBetText.AutoSize = true;
            this.lblBetText.Location = new System.Drawing.Point(296, 77);
            this.lblBetText.Name = "lblBetText";
            this.lblBetText.Size = new System.Drawing.Size(109, 30);
            this.lblBetText.TabIndex = 2;
            this.lblBetText.Text = "押注金額";
            // 
            // txtBetMoney
            // 
            this.txtBetMoney.Location = new System.Drawing.Point(411, 68);
            this.txtBetMoney.Name = "txtBetMoney";
            this.txtBetMoney.Size = new System.Drawing.Size(145, 39);
            this.txtBetMoney.TabIndex = 3;
            this.txtBetMoney.Text = "500";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(574, 73);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(115, 38);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblRechargeText
            // 
            this.lblRechargeText.AutoSize = true;
            this.lblRechargeText.Location = new System.Drawing.Point(6, 146);
            this.lblRechargeText.Name = "lblRechargeText";
            this.lblRechargeText.Size = new System.Drawing.Size(109, 30);
            this.lblRechargeText.TabIndex = 5;
            this.lblRechargeText.Text = "儲值金額";
            // 
            // lblallin
            // 
            this.lblallin.AutoSize = true;
            this.lblallin.Location = new System.Drawing.Point(486, 159);
            this.lblallin.Name = "lblallin";
            this.lblallin.Size = new System.Drawing.Size(70, 30);
            this.lblallin.TabIndex = 6;
            this.lblallin.Text = "All In";
            // 
            // txtRechargeMoney
            // 
            this.txtRechargeMoney.Location = new System.Drawing.Point(121, 143);
            this.txtRechargeMoney.Name = "txtRechargeMoney";
            this.txtRechargeMoney.Size = new System.Drawing.Size(121, 39);
            this.txtRechargeMoney.TabIndex = 7;
            this.txtRechargeMoney.Text = "1000000";
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(265, 146);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(104, 56);
            this.btnRecharge.TabIndex = 8;
            this.btnRecharge.Text = "儲值";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // btnAllIn
            // 
            this.btnAllIn.Location = new System.Drawing.Point(574, 133);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(115, 66);
            this.btnAllIn.TabIndex = 9;
            this.btnAllIn.Text = "梭哈";
            this.btnAllIn.UseVisualStyleBackColor = true;
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(57, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 18);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(47, 707);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(50, 18);
            this.lblSlogan.TabIndex = 4;
            this.lblSlogan.Text = "label2";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(47, 759);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(50, 18);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "label3";
            // 
            // lblOddsHint
            // 
            this.lblOddsHint.AutoSize = true;
            this.lblOddsHint.Location = new System.Drawing.Point(50, 797);
            this.lblOddsHint.Name = "lblOddsHint";
            this.lblOddsHint.Size = new System.Drawing.Size(50, 18);
            this.lblOddsHint.TabIndex = 6;
            this.lblOddsHint.Text = "label1";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 890);
            this.Controls.Add(this.lblOddsHint);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpButton.ResumeLayout(false);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.Label lblBetText;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoneyText;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBetMoney;
        private System.Windows.Forms.Button btnAllIn;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.TextBox txtRechargeMoney;
        private System.Windows.Forms.Label lblallin;
        private System.Windows.Forms.Label lblRechargeText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblOddsHint;
    }
}