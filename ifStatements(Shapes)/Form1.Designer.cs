namespace ifStatements_Shapes_
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
            this.introLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeInput = new System.Windows.Forms.TextBox();
            this.colourInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(19, 51);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(584, 28);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Enter \"r\" for Red, \"g\" for Green, or \"b\" for Blue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter \"circle\" or \"square\"";
            // 
            // shapeInput
            // 
            this.shapeInput.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold);
            this.shapeInput.Location = new System.Drawing.Point(469, 169);
            this.shapeInput.Name = "shapeInput";
            this.shapeInput.Size = new System.Drawing.Size(278, 34);
            this.shapeInput.TabIndex = 2;
            this.shapeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colourInput
            // 
            this.colourInput.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold);
            this.colourInput.Location = new System.Drawing.Point(638, 48);
            this.colourInput.Name = "colourInput";
            this.colourInput.Size = new System.Drawing.Size(109, 34);
            this.colourInput.TabIndex = 3;
            this.colourInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(594, 240);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 62);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "BEGIN";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(817, 521);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.colourInput);
            this.Controls.Add(this.shapeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.introLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shapeInput;
        private System.Windows.Forms.TextBox colourInput;
        private System.Windows.Forms.Button startButton;
    }
}

