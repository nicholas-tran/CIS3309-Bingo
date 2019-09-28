namespace Tran_CIS3309_BingoProject
{
    partial class FrmBingo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBingo));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtNumbersCalled = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.lblYourBingoCard = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWelcome.Location = new System.Drawing.Point(228, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(261, 19);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Game of BINGO";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(181, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name at the right:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(190, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 30);
            this.txtName.TabIndex = 2;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Enabled = false;
            this.lblReady.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(381, 38);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(139, 13);
            this.lblReady.TabIndex = 3;
            this.lblReady.Text = "Are you ready to play?";
            this.lblReady.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.Green;
            this.btnGo.Location = new System.Drawing.Point(523, 33);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(108, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Yes! Let\'s GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(637, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No! Exit!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Enabled = false;
            this.lblRules.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(9, 74);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(577, 39);
            this.lblRules.TabIndex = 6;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            this.lblRules.Visible = false;
            // 
            // txtNumbersCalled
            // 
            this.txtNumbersCalled.Enabled = false;
            this.txtNumbersCalled.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbersCalled.Location = new System.Drawing.Point(592, 64);
            this.txtNumbersCalled.Name = "txtNumbersCalled";
            this.txtNumbersCalled.Size = new System.Drawing.Size(100, 30);
            this.txtNumbersCalled.TabIndex = 6;
            this.txtNumbersCalled.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Enabled = false;
            this.btnDontHave.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDontHave.Location = new System.Drawing.Point(592, 100);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(100, 23);
            this.btnDontHave.TabIndex = 7;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // lblYourBingoCard
            // 
            this.lblYourBingoCard.AutoSize = true;
            this.lblYourBingoCard.Enabled = false;
            this.lblYourBingoCard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBingoCard.Location = new System.Drawing.Point(273, 120);
            this.lblYourBingoCard.Name = "lblYourBingoCard";
            this.lblYourBingoCard.Size = new System.Drawing.Size(144, 19);
            this.lblYourBingoCard.TabIndex = 9;
            this.lblYourBingoCard.Text = "Your Bingo Card";
            this.lblYourBingoCard.Visible = false;
            // 
            // pnlCard
            // 
            this.pnlCard.Enabled = false;
            this.pnlCard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCard.Location = new System.Drawing.Point(12, 142);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(700, 530);
            this.pnlCard.TabIndex = 10;
            this.pnlCard.Visible = false;
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(296, 33);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Submit Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // FrmBingo
            // 
            this.AcceptButton = this.btnDontHave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(722, 685);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblYourBingoCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtNumbersCalled);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FrmBingo";
            this.Text = "BINGO Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TextBox txtNumbersCalled;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Label lblYourBingoCard;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnName;
    }
}

