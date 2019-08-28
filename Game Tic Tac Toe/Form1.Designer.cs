namespace Game_Tic_Tac_Toe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(6, 6);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(582, 455);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlInfor
            // 
            this.pnlInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfor.Location = new System.Drawing.Point(595, 210);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(200, 251);
            this.pnlInfor.TabIndex = 2;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbAvatar.BackgroundImage = global::Game_Tic_Tac_Toe.Properties.Resources.Tic_tac_toe;
            this.ptbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAvatar.ErrorImage = global::Game_Tic_Tac_Toe.Properties.Resources.Tic_tac_toe;
            this.ptbAvatar.InitialImage = global::Game_Tic_Tac_Toe.Properties.Resources.Tic_tac_toe;
            this.ptbAvatar.Location = new System.Drawing.Point(595, 6);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(200, 198);
            this.ptbAvatar.TabIndex = 3;
            this.ptbAvatar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.PictureBox ptbAvatar;
    }
}

