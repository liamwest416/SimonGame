namespace SimonGame
{
    partial class RunGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Location = new System.Drawing.Point(58, 162);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(157, 127);
            this.yellowButton.TabIndex = 0;
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(58, 35);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(157, 121);
            this.greenButton.TabIndex = 1;
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(221, 35);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(148, 121);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Location = new System.Drawing.Point(221, 162);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(148, 127);
            this.blueButton.TabIndex = 3;
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // RunGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimonGame.Properties.Resources.Simon_Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Name = "RunGame";
            this.Size = new System.Drawing.Size(426, 334);
            this.Load += new System.EventHandler(this.RunGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
    }
}
