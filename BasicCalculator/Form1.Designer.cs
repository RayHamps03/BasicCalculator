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
            operand1Label = new Label();
            operand1Textbox = new TextBox();
            operand2Label = new Label();
            operand2Textbox = new TextBox();
            operatorLabel = new Label();
            operatorTextbox = new TextBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // operand1Label
            // 
            operand1Label.AutoSize = true;
            operand1Label.Location = new Point(118, 95);
            operand1Label.Name = "operand1Label";
            operand1Label.Size = new Size(65, 15);
            operand1Label.TabIndex = 0;
            operand1Label.Text = "Operand 1:";
            // 
            // operand1Textbox
            // 
            operand1Textbox.Location = new Point(217, 92);
            operand1Textbox.Name = "operand1Textbox";
            operand1Textbox.Size = new Size(100, 23);
            operand1Textbox.TabIndex = 1;
            // 
            // operand2Label
            // 
            operand2Label.AutoSize = true;
            operand2Label.Location = new Point(118, 166);
            operand2Label.Name = "operand2Label";
            operand2Label.Size = new Size(65, 15);
            operand2Label.TabIndex = 2;
            operand2Label.Text = "Operand 2:";
            // 
            // operand2Textbox
            // 
            operand2Textbox.Location = new Point(217, 163);
            operand2Textbox.Name = "operand2Textbox";
            operand2Textbox.Size = new Size(100, 23);
            operand2Textbox.TabIndex = 3;
            // 
            // operatorLabel
            // 
            operatorLabel.AutoSize = true;
            operatorLabel.Location = new Point(118, 236);
            operatorLabel.Name = "operatorLabel";
            operatorLabel.Size = new Size(57, 15);
            operatorLabel.TabIndex = 4;
            operatorLabel.Text = "Operator:";
            // 
            // operatorTextbox
            // 
            operatorTextbox.Location = new Point(217, 233);
            operatorTextbox.Name = "operatorTextbox";
            operatorTextbox.Size = new Size(100, 23);
            operatorTextbox.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(118, 287);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(199, 49);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 445);
            Controls.Add(calculateButton);
            Controls.Add(operatorTextbox);
            Controls.Add(operatorLabel);
            Controls.Add(operand2Textbox);
            Controls.Add(operand2Label);
            Controls.Add(operand1Textbox);
            Controls.Add(operand1Label);
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
