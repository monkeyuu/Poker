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
            this.grbet = new System.Windows.Forms.GroupBox();
            this.betmoney_txt = new System.Windows.Forms.TextBox();
            this.bet_btn = new System.Windows.Forms.Button();
            this.betmoney_lbl = new System.Windows.Forms.Label();
            this.Totalresult_lbl = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.grbet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(12, 12);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(485, 160);
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
            this.grpButton.Location = new System.Drawing.Point(12, 263);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(485, 80);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(252, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(223, 36);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(164, 28);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 36);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(94, 28);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(64, 36);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(21, 28);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(67, 36);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grbet
            // 
            this.grbet.Controls.Add(this.betmoney_txt);
            this.grbet.Controls.Add(this.bet_btn);
            this.grbet.Controls.Add(this.betmoney_lbl);
            this.grbet.Controls.Add(this.Totalresult_lbl);
            this.grbet.Controls.Add(this.Total_lbl);
            this.grbet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grbet.Location = new System.Drawing.Point(13, 179);
            this.grbet.Name = "grbet";
            this.grbet.Size = new System.Drawing.Size(484, 78);
            this.grbet.TabIndex = 2;
            this.grbet.TabStop = false;
            this.grbet.Text = "下注";
            this.grbet.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // betmoney_txt
            // 
            this.betmoney_txt.Location = new System.Drawing.Point(298, 33);
            this.betmoney_txt.Name = "betmoney_txt";
            this.betmoney_txt.Size = new System.Drawing.Size(100, 29);
            this.betmoney_txt.TabIndex = 4;
            // 
            // bet_btn
            // 
            this.bet_btn.Location = new System.Drawing.Point(413, 30);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(61, 34);
            this.bet_btn.TabIndex = 3;
            this.bet_btn.Text = "押注";
            this.bet_btn.UseVisualStyleBackColor = true;
            this.bet_btn.Click += new System.EventHandler(this.bet_btn_Click);
            // 
            // betmoney_lbl
            // 
            this.betmoney_lbl.AutoSize = true;
            this.betmoney_lbl.Location = new System.Drawing.Point(217, 38);
            this.betmoney_lbl.Name = "betmoney_lbl";
            this.betmoney_lbl.Size = new System.Drawing.Size(73, 20);
            this.betmoney_lbl.TabIndex = 2;
            this.betmoney_lbl.Text = "押注金額";
            // 
            // Totalresult_lbl
            // 
            this.Totalresult_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Totalresult_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Totalresult_lbl.Location = new System.Drawing.Point(89, 35);
            this.Totalresult_lbl.Name = "Totalresult_lbl";
            this.Totalresult_lbl.Size = new System.Drawing.Size(116, 27);
            this.Totalresult_lbl.TabIndex = 1;
            this.Totalresult_lbl.Text = "1000000";
            this.Totalresult_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Location = new System.Drawing.Point(25, 37);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(57, 20);
            this.Total_lbl.TabIndex = 0;
            this.Total_lbl.Text = "總資金";
            this.Total_lbl.Click += new System.EventHandler(this.Total_lbl_Click);
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 355);
            this.Controls.Add(this.grbet);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpButton.ResumeLayout(false);
            this.grbet.ResumeLayout(false);
            this.grbet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grbet;
        private System.Windows.Forms.TextBox betmoney_txt;
        private System.Windows.Forms.Button bet_btn;
        private System.Windows.Forms.Label betmoney_lbl;
        private System.Windows.Forms.Label Totalresult_lbl;
        private System.Windows.Forms.Label Total_lbl;
    }
}