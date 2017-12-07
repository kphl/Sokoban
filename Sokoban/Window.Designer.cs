namespace Sokoban
{
    partial class Window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.resetButton = new System.Windows.Forms.PictureBox();
            this.gamePicture = new System.Windows.Forms.PictureBox();
            this.undoButton = new System.Windows.Forms.PictureBox();
            this.stepCounter = new System.Windows.Forms.Label();
            this.navigationBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.sokobanLabel = new System.Windows.Forms.Label();
            this.undoLabel = new System.Windows.Forms.Label();
            this.resetLabel = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.nextLevelLabel = new System.Windows.Forms.Label();
            this.winMessage = new System.Windows.Forms.Label();
            this.replayMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Image = global::Sokoban.Properties.Resources.reset;
            this.resetButton.Location = new System.Drawing.Point(430, 10);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(40, 40);
            this.resetButton.TabIndex = 5;
            this.resetButton.TabStop = false;
            this.resetButton.Tag = "Reset";
            this.resetButton.Click += new System.EventHandler(this.ResetLevel);
            // 
            // gamePicture
            // 
            this.gamePicture.BackColor = System.Drawing.Color.Wheat;
            this.gamePicture.Location = new System.Drawing.Point(49, 86);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(448, 448);
            this.gamePicture.TabIndex = 0;
            this.gamePicture.TabStop = false;
            // 
            // undoButton
            // 
            this.undoButton.AccessibleDescription = "";
            this.undoButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.undoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoButton.Image = global::Sokoban.Properties.Resources.undo;
            this.undoButton.Location = new System.Drawing.Point(482, 8);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(40, 40);
            this.undoButton.TabIndex = 6;
            this.undoButton.TabStop = false;
            this.undoButton.Tag = "";
            this.undoButton.Click += new System.EventHandler(this.Undo);
            // 
            // stepCounter
            // 
            this.stepCounter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stepCounter.BackColor = System.Drawing.Color.MediumAquamarine;
            this.stepCounter.Font = new System.Drawing.Font("Trebuchet MS", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepCounter.ForeColor = System.Drawing.Color.White;
            this.stepCounter.Location = new System.Drawing.Point(305, 8);
            this.stepCounter.Name = "stepCounter";
            this.stepCounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stepCounter.Size = new System.Drawing.Size(100, 40);
            this.stepCounter.TabIndex = 8;
            this.stepCounter.Text = "0";
            this.stepCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // navigationBackground
            // 
            this.navigationBackground.BackColor = System.Drawing.Color.MediumAquamarine;
            this.navigationBackground.Location = new System.Drawing.Point(-1, -2);
            this.navigationBackground.Name = "navigationBackground";
            this.navigationBackground.Size = new System.Drawing.Size(534, 78);
            this.navigationBackground.TabIndex = 9;
            this.navigationBackground.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(540, 5);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.levelLabel.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(97, 19);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(149, 46);
            this.levelLabel.TabIndex = 11;
            this.levelLabel.Text = "LEVEL 1";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.logo.Image = global::Sokoban.Properties.Resources.playerFace;
            this.logo.Location = new System.Drawing.Point(15, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(68, 48);
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // sokobanLabel
            // 
            this.sokobanLabel.AutoSize = true;
            this.sokobanLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.sokobanLabel.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.sokobanLabel.ForeColor = System.Drawing.Color.White;
            this.sokobanLabel.Location = new System.Drawing.Point(102, 8);
            this.sokobanLabel.Name = "sokobanLabel";
            this.sokobanLabel.Size = new System.Drawing.Size(64, 20);
            this.sokobanLabel.TabIndex = 13;
            this.sokobanLabel.Text = "Sokoban";
            // 
            // undoLabel
            // 
            this.undoLabel.AutoSize = true;
            this.undoLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.undoLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.undoLabel.ForeColor = System.Drawing.Color.White;
            this.undoLabel.Location = new System.Drawing.Point(485, 50);
            this.undoLabel.Name = "undoLabel";
            this.undoLabel.Size = new System.Drawing.Size(37, 16);
            this.undoLabel.TabIndex = 14;
            this.undoLabel.Text = "UNDO";
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.resetLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.resetLabel.ForeColor = System.Drawing.Color.White;
            this.resetLabel.Location = new System.Drawing.Point(433, 50);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(37, 16);
            this.resetLabel.TabIndex = 15;
            this.resetLabel.Text = "RESET";
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.stepsLabel.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.stepsLabel.ForeColor = System.Drawing.Color.White;
            this.stepsLabel.Location = new System.Drawing.Point(364, 50);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(36, 16);
            this.stepsLabel.TabIndex = 16;
            this.stepsLabel.Text = "STEPS";
            // 
            // nextLevelLabel
            // 
            this.nextLevelLabel.AutoSize = true;
            this.nextLevelLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.nextLevelLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLevelLabel.ForeColor = System.Drawing.Color.White;
            this.nextLevelLabel.Location = new System.Drawing.Point(140, 277);
            this.nextLevelLabel.Name = "nextLevelLabel";
            this.nextLevelLabel.Size = new System.Drawing.Size(265, 27);
            this.nextLevelLabel.TabIndex = 17;
            this.nextLevelLabel.Text = "PRESS ENTER TO CONTINUE";
            this.nextLevelLabel.Visible = false;
            // 
            // winMessage
            // 
            this.winMessage.AutoSize = true;
            this.winMessage.BackColor = System.Drawing.Color.MediumAquamarine;
            this.winMessage.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winMessage.ForeColor = System.Drawing.Color.White;
            this.winMessage.Location = new System.Drawing.Point(202, 277);
            this.winMessage.Name = "winMessage";
            this.winMessage.Size = new System.Drawing.Size(144, 40);
            this.winMessage.TabIndex = 18;
            this.winMessage.Text = "YOU WIN";
            this.winMessage.Visible = false;
            this.winMessage.Click += new System.EventHandler(this.RestartGame);
            // 
            // replayMessage
            // 
            this.replayMessage.BackColor = System.Drawing.Color.MediumAquamarine;
            this.replayMessage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayMessage.ForeColor = System.Drawing.Color.White;
            this.replayMessage.Location = new System.Drawing.Point(202, 317);
            this.replayMessage.Name = "replayMessage";
            this.replayMessage.Size = new System.Drawing.Size(144, 28);
            this.replayMessage.TabIndex = 19;
            this.replayMessage.Text = "(click to replay)";
            this.replayMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.replayMessage.Visible = false;
            this.replayMessage.Click += new System.EventHandler(this.RestartGame);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(530, 544);
            this.Controls.Add(this.replayMessage);
            this.Controls.Add(this.winMessage);
            this.Controls.Add(this.nextLevelLabel);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.undoLabel);
            this.Controls.Add(this.sokobanLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.stepCounter);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.gamePicture);
            this.Controls.Add(this.navigationBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Window";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.resetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gamePicture;
        private System.Windows.Forms.PictureBox resetButton;
        private System.Windows.Forms.PictureBox undoButton;
        private System.Windows.Forms.Label stepCounter;
        private System.Windows.Forms.PictureBox navigationBackground;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label sokobanLabel;
        private System.Windows.Forms.Label undoLabel;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Label nextLevelLabel;
        private System.Windows.Forms.Label winMessage;
        private System.Windows.Forms.Label replayMessage;
    }
}

