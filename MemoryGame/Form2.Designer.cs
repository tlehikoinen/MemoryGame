
namespace MemoryGame {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.exitButton = new System.Windows.Forms.Button();
            this.memoryGameGrid = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.winnerPanelMP = new System.Windows.Forms.Panel();
            this.player2StatsLabel = new System.Windows.Forms.Label();
            this.player1StatsLabel = new System.Windows.Forms.Label();
            this.winnerTextBox = new System.Windows.Forms.TextBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2StatsTextbox = new System.Windows.Forms.TextBox();
            this.player1StatsTextbox = new System.Windows.Forms.TextBox();
            this.winnerPanelTextBox = new System.Windows.Forms.TextBox();
            this.winnerPanelSP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.winnerPanelMP.SuspendLayout();
            this.winnerPanelSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(673, 72);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // memoryGameGrid
            // 
            this.memoryGameGrid.ColumnCount = 2;
            this.memoryGameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83333F));
            this.memoryGameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16667F));
            this.memoryGameGrid.Location = new System.Drawing.Point(28, 12);
            this.memoryGameGrid.Name = "memoryGameGrid";
            this.memoryGameGrid.RowCount = 2;
            this.memoryGameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.16667F));
            this.memoryGameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.83333F));
            this.memoryGameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.memoryGameGrid.Size = new System.Drawing.Size(600, 600);
            this.memoryGameGrid.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(673, 218);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPlayerLabel.Location = new System.Drawing.Point(306, 621);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(74, 32);
            this.currentPlayerLabel.TabIndex = 12;
            this.currentPlayerLabel.Text = "label1";
            // 
            // winnerPanelMP
            // 
            this.winnerPanelMP.Controls.Add(this.player2StatsLabel);
            this.winnerPanelMP.Controls.Add(this.player1StatsLabel);
            this.winnerPanelMP.Controls.Add(this.winnerTextBox);
            this.winnerPanelMP.Controls.Add(this.winnerLabel);
            this.winnerPanelMP.Controls.Add(this.label1);
            this.winnerPanelMP.Controls.Add(this.player2StatsTextbox);
            this.winnerPanelMP.Controls.Add(this.player1StatsTextbox);
            this.winnerPanelMP.Location = new System.Drawing.Point(12, 12);
            this.winnerPanelMP.Name = "winnerPanelMP";
            this.winnerPanelMP.Size = new System.Drawing.Size(635, 600);
            this.winnerPanelMP.TabIndex = 13;
            this.winnerPanelMP.Visible = false;
            // 
            // player2StatsLabel
            // 
            this.player2StatsLabel.AutoSize = true;
            this.player2StatsLabel.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2StatsLabel.Location = new System.Drawing.Point(457, 165);
            this.player2StatsLabel.Name = "player2StatsLabel";
            this.player2StatsLabel.Size = new System.Drawing.Size(0, 20);
            this.player2StatsLabel.TabIndex = 7;
            // 
            // player1StatsLabel
            // 
            this.player1StatsLabel.AutoSize = true;
            this.player1StatsLabel.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1StatsLabel.Location = new System.Drawing.Point(133, 165);
            this.player1StatsLabel.Name = "player1StatsLabel";
            this.player1StatsLabel.Size = new System.Drawing.Size(0, 20);
            this.player1StatsLabel.TabIndex = 6;
            // 
            // winnerTextBox
            // 
            this.winnerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winnerTextBox.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerTextBox.Location = new System.Drawing.Point(268, 339);
            this.winnerTextBox.Name = "winnerTextBox";
            this.winnerTextBox.ReadOnly = true;
            this.winnerTextBox.Size = new System.Drawing.Size(100, 24);
            this.winnerTextBox.TabIndex = 5;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerLabel.Location = new System.Drawing.Point(254, 289);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(131, 47);
            this.winnerLabel.TabIndex = 4;
            this.winnerLabel.Text = "Winner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Over";
            // 
            // player2StatsTextbox
            // 
            this.player2StatsTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.player2StatsTextbox.Location = new System.Drawing.Point(371, 188);
            this.player2StatsTextbox.Multiline = true;
            this.player2StatsTextbox.Name = "player2StatsTextbox";
            this.player2StatsTextbox.ReadOnly = true;
            this.player2StatsTextbox.Size = new System.Drawing.Size(214, 75);
            this.player2StatsTextbox.TabIndex = 1;
            // 
            // player1StatsTextbox
            // 
            this.player1StatsTextbox.Location = new System.Drawing.Point(49, 188);
            this.player1StatsTextbox.Multiline = true;
            this.player1StatsTextbox.Name = "player1StatsTextbox";
            this.player1StatsTextbox.Size = new System.Drawing.Size(214, 75);
            this.player1StatsTextbox.TabIndex = 0;
            // 
            // winnerPanelTextBox
            // 
            this.winnerPanelTextBox.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerPanelTextBox.Location = new System.Drawing.Point(190, 231);
            this.winnerPanelTextBox.Multiline = true;
            this.winnerPanelTextBox.Name = "winnerPanelTextBox";
            this.winnerPanelTextBox.ReadOnly = true;
            this.winnerPanelTextBox.Size = new System.Drawing.Size(239, 58);
            this.winnerPanelTextBox.TabIndex = 0;
            // 
            // winnerPanelSP
            // 
            this.winnerPanelSP.Controls.Add(this.label2);
            this.winnerPanelSP.Controls.Add(this.winnerPanelTextBox);
            this.winnerPanelSP.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerPanelSP.Location = new System.Drawing.Point(28, 9);
            this.winnerPanelSP.Name = "winnerPanelSP";
            this.winnerPanelSP.Size = new System.Drawing.Size(600, 583);
            this.winnerPanelSP.TabIndex = 14;
            this.winnerPanelSP.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Congrats!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 662);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.winnerPanelMP);
            this.Controls.Add(this.memoryGameGrid);
            this.Controls.Add(this.winnerPanelSP);
            this.Name = "Form2";
            this.Text = "Form2";
            this.winnerPanelMP.ResumeLayout(false);
            this.winnerPanelMP.PerformLayout();
            this.winnerPanelSP.ResumeLayout(false);
            this.winnerPanelSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel memoryGameGrid;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Panel winnerPanelMP;
        private System.Windows.Forms.TextBox winnerTextBox;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2StatsTextbox;
        private System.Windows.Forms.TextBox player1StatsTextbox;
        private System.Windows.Forms.Panel winnerPanelSP;
        private System.Windows.Forms.TextBox winnerPanelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2StatsLabel;
        private System.Windows.Forms.Label player1StatsLabel;
    }
}