
namespace Michael_Jeon_301_Dodge
{
    partial class FrmDodge
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
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.Location = new System.Drawing.Point(24, 30);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(500, 400);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(547, 407);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(547, 373);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 15);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lives";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(547, 313);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(13, 15);
            this.LblLives.TabIndex = 3;
            this.LblLives.Text = "5";
            this.LblLives.Click += new System.EventHandler(this.LblLives_Click);
            // 
            // TmrShip
            // 
            this.TmrShip.Enabled = true;
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // FrmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "FrmDodge";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Timer TmrFFFF;
        private System.Windows.Forms.Timer TmrShip;
    }
}

