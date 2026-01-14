namespace BasicCalculator
{
    partial class Form1
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
            this.operand1Label = new Label();
            this.operand1Textbox = new TextBox();
            this.operand2Label = new Label();
            this.operand2Textbox = new TextBox();
            this.operatorLabel = new Label();
            this.operatorTextbox = new TextBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // operand1Label
            // 
            this.operand1Label.AutoSize = true;
            this.operand1Label.Location = new Point(118, 95);
            this.operand1Label.Name = "operand1Label";
            this.operand1Label.Size = new Size(65, 15);
            this.operand1Label.TabIndex = 0;
            this.operand1Label.Text = "Operand 1:";
            // 
            // operand1Textbox
            // 
            this.operand1Textbox.Location = new Point(217, 92);
            this.operand1Textbox.Name = "operand1Textbox";
            this.operand1Textbox.Size = new Size(100, 23);
            this.operand1Textbox.TabIndex = 1;
            // 
            // operand2Label
            // 
            this.operand2Label.AutoSize = true;
            this.operand2Label.Location = new Point(118, 166);
            this.operand2Label.Name = "operand2Label";
            this.operand2Label.Size = new Size(65, 15);
            this.operand2Label.TabIndex = 2;
            this.operand2Label.Text = "Operand 2:";
            // 
            // operand2Textbox
            // 
            this.operand2Textbox.Location = new Point(217, 163);
            this.operand2Textbox.Name = "operand2Textbox";
            this.operand2Textbox.Size = new Size(100, 23);
            this.operand2Textbox.TabIndex = 3;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Location = new Point(118, 236);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new Size(57, 15);
            this.operatorLabel.TabIndex = 4;
            this.operatorLabel.Text = "Operator:";
            // 
            // operatorTextbox
            // 
            this.operatorTextbox.Location = new Point(217, 233);
            this.operatorTextbox.Name = "operatorTextbox";
            this.operatorTextbox.Size = new Size(100, 23);
            this.operatorTextbox.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(118, 287);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(199, 49);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 445);
            Controls.Add(calculateButton);
            Controls.Add(this.operatorTextbox);
            Controls.Add(this.operatorLabel);
            Controls.Add(this.operand2Textbox);
            Controls.Add(this.operand2Label);
            Controls.Add(this.operand1Textbox);
            Controls.Add(this.operand1Label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label operand1Label;
        private TextBox operand1Textbox;
        private Label operand2Label;
        private TextBox operand2Textbox;
        private Label operatorLabel;
        private TextBox operatorTextbox;
        private Button calculateButton;
    }
}
