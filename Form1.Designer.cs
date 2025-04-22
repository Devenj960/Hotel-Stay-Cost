namespace Program_2
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
            this.numGuestsLabel = new System.Windows.Forms.Label();
            this.numNightsLabel = new System.Windows.Forms.Label();
            this.numStarsLabel = new System.Windows.Forms.Label();
            this.hotelCostLabel = new System.Windows.Forms.Label();
            this.hotelCostOutput = new System.Windows.Forms.Label();
            this.numGuestsTextbox = new System.Windows.Forms.TextBox();
            this.numNightsTextbox = new System.Windows.Forms.TextBox();
            this.numStarsTextbox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numGuestsLabel
            // 
            this.numGuestsLabel.AutoSize = true;
            this.numGuestsLabel.Location = new System.Drawing.Point(117, 90);
            this.numGuestsLabel.Name = "numGuestsLabel";
            this.numGuestsLabel.Size = new System.Drawing.Size(143, 19);
            this.numGuestsLabel.TabIndex = 0;
            this.numGuestsLabel.Text = "Number of Guests:";
            // 
            // numNightsLabel
            // 
            this.numNightsLabel.AutoSize = true;
            this.numNightsLabel.Location = new System.Drawing.Point(117, 128);
            this.numNightsLabel.Name = "numNightsLabel";
            this.numNightsLabel.Size = new System.Drawing.Size(141, 19);
            this.numNightsLabel.TabIndex = 1;
            this.numNightsLabel.Text = "Number of Nights:";
            // 
            // numStarsLabel
            // 
            this.numStarsLabel.AutoSize = true;
            this.numStarsLabel.Location = new System.Drawing.Point(117, 167);
            this.numStarsLabel.Name = "numStarsLabel";
            this.numStarsLabel.Size = new System.Drawing.Size(92, 19);
            this.numStarsLabel.TabIndex = 2;
            this.numStarsLabel.Text = "Hotel Stars:";
            // 
            // hotelCostLabel
            // 
            this.hotelCostLabel.AutoSize = true;
            this.hotelCostLabel.Location = new System.Drawing.Point(117, 281);
            this.hotelCostLabel.Name = "hotelCostLabel";
            this.hotelCostLabel.Size = new System.Drawing.Size(88, 19);
            this.hotelCostLabel.TabIndex = 3;
            this.hotelCostLabel.Text = "Hotel Cost:";
            // 
            // hotelCostOutput
            // 
            this.hotelCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCostOutput.Location = new System.Drawing.Point(323, 273);
            this.hotelCostOutput.Name = "hotelCostOutput";
            this.hotelCostOutput.Size = new System.Drawing.Size(100, 27);
            this.hotelCostOutput.TabIndex = 4;
            // 
            // numGuestsTextbox
            // 
            this.numGuestsTextbox.Location = new System.Drawing.Point(323, 90);
            this.numGuestsTextbox.Name = "numGuestsTextbox";
            this.numGuestsTextbox.Size = new System.Drawing.Size(100, 27);
            this.numGuestsTextbox.TabIndex = 5;
            // 
            // numNightsTextbox
            // 
            this.numNightsTextbox.Location = new System.Drawing.Point(323, 128);
            this.numNightsTextbox.Name = "numNightsTextbox";
            this.numNightsTextbox.Size = new System.Drawing.Size(100, 27);
            this.numNightsTextbox.TabIndex = 6;
            // 
            // numStarsTextbox
            // 
            this.numStarsTextbox.Location = new System.Drawing.Point(323, 167);
            this.numStarsTextbox.Name = "numStarsTextbox";
            this.numStarsTextbox.Size = new System.Drawing.Size(100, 27);
            this.numStarsTextbox.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(207, 220);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(97, 34);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.numStarsTextbox);
            this.Controls.Add(this.numNightsTextbox);
            this.Controls.Add(this.numGuestsTextbox);
            this.Controls.Add(this.hotelCostOutput);
            this.Controls.Add(this.hotelCostLabel);
            this.Controls.Add(this.numStarsLabel);
            this.Controls.Add(this.numNightsLabel);
            this.Controls.Add(this.numGuestsLabel);
            this.Name = "Form1";
            this.Text = "Program 2 - Hotel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numGuestsLabel;
        private System.Windows.Forms.Label numNightsLabel;
        private System.Windows.Forms.Label numStarsLabel;
        private System.Windows.Forms.Label hotelCostLabel;
        private System.Windows.Forms.Label hotelCostOutput;
        private System.Windows.Forms.TextBox numGuestsTextbox;
        private System.Windows.Forms.TextBox numNightsTextbox;
        private System.Windows.Forms.TextBox numStarsTextbox;
        private System.Windows.Forms.Button calcButton;
    }
}

