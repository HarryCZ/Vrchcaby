namespace Vrchcaby.UI
{
    partial class GameMenuForm
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
            this.playerSetupPannel = new System.Windows.Forms.TableLayoutPanel();
            this.inputPlayer4 = new System.Windows.Forms.TextBox();
            this.labelPlayer4 = new System.Windows.Forms.Label();
            this.inputPlayer3 = new System.Windows.Forms.TextBox();
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.inputPlayer2 = new System.Windows.Forms.TextBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.inputPlayer1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerSetupPannel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerSetupPannel
            // 
            this.playerSetupPannel.BackColor = System.Drawing.Color.Transparent;
            this.playerSetupPannel.BackgroundImage = global::Vrchcaby.Properties.Resources.textureGreyOpa;
            this.playerSetupPannel.ColumnCount = 2;
            this.playerSetupPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerSetupPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerSetupPannel.Controls.Add(this.inputPlayer4, 1, 3);
            this.playerSetupPannel.Controls.Add(this.labelPlayer4, 0, 3);
            this.playerSetupPannel.Controls.Add(this.inputPlayer3, 1, 2);
            this.playerSetupPannel.Controls.Add(this.labelPlayer3, 0, 2);
            this.playerSetupPannel.Controls.Add(this.inputPlayer2, 1, 1);
            this.playerSetupPannel.Controls.Add(this.labelPlayer2, 0, 1);
            this.playerSetupPannel.Controls.Add(this.labelPlayer1, 0, 0);
            this.playerSetupPannel.Controls.Add(this.inputPlayer1, 1, 0);
            this.playerSetupPannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerSetupPannel.ForeColor = System.Drawing.Color.White;
            this.playerSetupPannel.Location = new System.Drawing.Point(192, 83);
            this.playerSetupPannel.Name = "playerSetupPannel";
            this.playerSetupPannel.Padding = new System.Windows.Forms.Padding(10);
            this.playerSetupPannel.RowCount = 4;
            this.playerSetupPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerSetupPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerSetupPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerSetupPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.playerSetupPannel.Size = new System.Drawing.Size(325, 208);
            this.playerSetupPannel.TabIndex = 0;
            // 
            // inputPlayer4
            // 
            this.inputPlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlayer4.Location = new System.Drawing.Point(165, 157);
            this.inputPlayer4.MaxLength = 8;
            this.inputPlayer4.Name = "inputPlayer4";
            this.inputPlayer4.Size = new System.Drawing.Size(147, 35);
            this.inputPlayer4.TabIndex = 7;
            // 
            // labelPlayer4
            // 
            this.labelPlayer4.AutoSize = true;
            this.labelPlayer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayer4.Location = new System.Drawing.Point(13, 151);
            this.labelPlayer4.Name = "labelPlayer4";
            this.labelPlayer4.Size = new System.Drawing.Size(146, 47);
            this.labelPlayer4.TabIndex = 6;
            this.labelPlayer4.Text = "Hráč 1";
            this.labelPlayer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPlayer3
            // 
            this.inputPlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlayer3.Location = new System.Drawing.Point(165, 110);
            this.inputPlayer3.MaxLength = 8;
            this.inputPlayer3.Name = "inputPlayer3";
            this.inputPlayer3.Size = new System.Drawing.Size(147, 35);
            this.inputPlayer3.TabIndex = 5;
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayer3.Location = new System.Drawing.Point(13, 104);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(146, 47);
            this.labelPlayer3.TabIndex = 4;
            this.labelPlayer3.Text = "Hráč 1";
            this.labelPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPlayer2
            // 
            this.inputPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlayer2.Location = new System.Drawing.Point(165, 63);
            this.inputPlayer2.MaxLength = 8;
            this.inputPlayer2.Name = "inputPlayer2";
            this.inputPlayer2.Size = new System.Drawing.Size(147, 35);
            this.inputPlayer2.TabIndex = 3;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayer2.Location = new System.Drawing.Point(13, 57);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(146, 47);
            this.labelPlayer2.TabIndex = 2;
            this.labelPlayer2.Text = "Hráč 1";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlayer1.Location = new System.Drawing.Point(13, 10);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(146, 47);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Hráč 1";
            this.labelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPlayer1
            // 
            this.inputPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlayer1.Location = new System.Drawing.Point(165, 16);
            this.inputPlayer1.MaxLength = 8;
            this.inputPlayer1.Name = "inputPlayer1";
            this.inputPlayer1.Size = new System.Drawing.Size(147, 35);
            this.inputPlayer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Vrchcaby.Properties.Resources.butt;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nová hra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Vrchcaby.Properties.Resources.butt;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Konec hry";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::Vrchcaby.Properties.Resources.textureGreyOpa;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(568, 281);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 128);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GameMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Vrchcaby.Properties.Resources.welcome;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.playerSetupPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nová hra";
            this.playerSetupPannel.ResumeLayout(false);
            this.playerSetupPannel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel playerSetupPannel;
        private System.Windows.Forms.TextBox inputPlayer4;
        private System.Windows.Forms.Label labelPlayer4;
        private System.Windows.Forms.TextBox inputPlayer3;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.TextBox inputPlayer2;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.TextBox inputPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}