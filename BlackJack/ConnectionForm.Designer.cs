﻿namespace BlackJack
{
    partial class ConnectionForm
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
			this.lblConnection = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblConnection
			// 
			this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblConnection.AutoSize = true;
			this.lblConnection.BackColor = System.Drawing.Color.Transparent;
			this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnection.ForeColor = System.Drawing.Color.Yellow;
			this.lblConnection.Location = new System.Drawing.Point(288, 143);
			this.lblConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblConnection.Name = "lblConnection";
			this.lblConnection.Size = new System.Drawing.Size(334, 55);
			this.lblConnection.TabIndex = 1;
			this.lblConnection.Text = "Connection ...";
			this.lblConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = global::BlackJack.RessImages.rideau;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(911, 465);
			this.Controls.Add(this.lblConnection);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ConnectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Connection";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnection;
    }
}