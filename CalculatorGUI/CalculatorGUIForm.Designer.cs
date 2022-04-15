namespace CalculatorGUI
{
   partial class CalculatorGUIForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
               this.remainderButton = new System.Windows.Forms.Button();
               this.removeSpaceTextBox = new System.Windows.Forms.TextBox();
               this.removeSpaceButton = new System.Windows.Forms.Button();
               this.resultTextBox = new System.Windows.Forms.Label();
               this.reverseWordButton = new System.Windows.Forms.Button();
               this.reverseWordTextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.dividendTextBox = new System.Windows.Forms.TextBox();
               this.divisorTextBox = new System.Windows.Forms.TextBox();
               this.LogBase10Button = new System.Windows.Forms.Button();
               this.logBase10TextBox = new System.Windows.Forms.TextBox();
               this.logToChosenBaseButton = new System.Windows.Forms.Button();
               this.chosenBaseTextBox = new System.Windows.Forms.TextBox();
               this.baseLabel = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.chosenNumberTextBox = new System.Windows.Forms.TextBox();
               this.minAndMaxButton = new System.Windows.Forms.Button();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.minAndMaxTextBox1 = new System.Windows.Forms.TextBox();
               this.minAndMaxTextBox2 = new System.Windows.Forms.TextBox();
               this.numberToPowerButton = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.numToPowerBaseTextBox = new System.Windows.Forms.TextBox();
               this.numToPowerPowerTextBox = new System.Windows.Forms.TextBox();
               this.findRootsButton = new System.Windows.Forms.Button();
               this.label8 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label10 = new System.Windows.Forms.Label();
               this.coefficientATextBox = new System.Windows.Forms.TextBox();
               this.CoefficientBTextBox = new System.Windows.Forms.TextBox();
               this.constantTextBox = new System.Windows.Forms.TextBox();
               this.squareRootButton = new System.Windows.Forms.Button();
               this.label11 = new System.Windows.Forms.Label();
               this.squareRootTextBox = new System.Windows.Forms.TextBox();
               this.exitButton = new System.Windows.Forms.Button();
               this.label12 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // remainderButton
               // 
               this.remainderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.remainderButton.Location = new System.Drawing.Point(9, 116);
               this.remainderButton.Margin = new System.Windows.Forms.Padding(0);
               this.remainderButton.Name = "remainderButton";
               this.remainderButton.Size = new System.Drawing.Size(211, 56);
               this.remainderButton.TabIndex = 33;
               this.remainderButton.Text = "Quotient and Remainder";
               this.remainderButton.Click += new System.EventHandler(this.button13_Click);
               // 
               // removeSpaceTextBox
               // 
               this.removeSpaceTextBox.Location = new System.Drawing.Point(226, 21);
               this.removeSpaceTextBox.Multiline = true;
               this.removeSpaceTextBox.Name = "removeSpaceTextBox";
               this.removeSpaceTextBox.Size = new System.Drawing.Size(252, 26);
               this.removeSpaceTextBox.TabIndex = 17;
               // 
               // removeSpaceButton
               // 
               this.removeSpaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.removeSpaceButton.Location = new System.Drawing.Point(9, 17);
               this.removeSpaceButton.Margin = new System.Windows.Forms.Padding(0);
               this.removeSpaceButton.Name = "removeSpaceButton";
               this.removeSpaceButton.Size = new System.Drawing.Size(208, 40);
               this.removeSpaceButton.TabIndex = 21;
               this.removeSpaceButton.Text = "Remove Space";
               this.removeSpaceButton.Click += new System.EventHandler(this.removeSpaceButton_Click);
               // 
               // resultTextBox
               // 
               this.resultTextBox.AutoSize = true;
               this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
               this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.resultTextBox.Location = new System.Drawing.Point(14, 790);
               this.resultTextBox.Name = "resultTextBox";
               this.resultTextBox.Size = new System.Drawing.Size(2, 34);
               this.resultTextBox.TabIndex = 34;
               // 
               // reverseWordButton
               // 
               this.reverseWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.reverseWordButton.Location = new System.Drawing.Point(9, 63);
               this.reverseWordButton.Name = "reverseWordButton";
               this.reverseWordButton.Size = new System.Drawing.Size(211, 45);
               this.reverseWordButton.TabIndex = 35;
               this.reverseWordButton.Text = "Reverse Word";
               this.reverseWordButton.UseVisualStyleBackColor = true;
               this.reverseWordButton.Click += new System.EventHandler(this.reverseWordButton_Click);
               // 
               // reverseWordTextBox
               // 
               this.reverseWordTextBox.Location = new System.Drawing.Point(228, 69);
               this.reverseWordTextBox.Name = "reverseWordTextBox";
               this.reverseWordTextBox.Size = new System.Drawing.Size(252, 39);
               this.reverseWordTextBox.TabIndex = 36;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(228, 116);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(192, 32);
               this.label1.TabIndex = 37;
               this.label1.Text = "Enter Dividend:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(228, 143);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(171, 32);
               this.label2.TabIndex = 38;
               this.label2.Text = "Enter Divisor:";
               // 
               // dividendTextBox
               // 
               this.dividendTextBox.Location = new System.Drawing.Point(399, 116);
               this.dividendTextBox.Name = "dividendTextBox";
               this.dividendTextBox.Size = new System.Drawing.Size(73, 39);
               this.dividendTextBox.TabIndex = 39;
               // 
               // divisorTextBox
               // 
               this.divisorTextBox.Location = new System.Drawing.Point(399, 143);
               this.divisorTextBox.Name = "divisorTextBox";
               this.divisorTextBox.Size = new System.Drawing.Size(73, 39);
               this.divisorTextBox.TabIndex = 40;
               // 
               // LogBase10Button
               // 
               this.LogBase10Button.Location = new System.Drawing.Point(9, 184);
               this.LogBase10Button.Name = "LogBase10Button";
               this.LogBase10Button.Size = new System.Drawing.Size(207, 42);
               this.LogBase10Button.TabIndex = 41;
               this.LogBase10Button.Text = "Log Base 10";
               this.LogBase10Button.UseVisualStyleBackColor = true;
               this.LogBase10Button.Click += new System.EventHandler(this.LogBase10Button_Click);
               // 
               // logBase10TextBox
               // 
               this.logBase10TextBox.Location = new System.Drawing.Point(348, 188);
               this.logBase10TextBox.Name = "logBase10TextBox";
               this.logBase10TextBox.Size = new System.Drawing.Size(100, 39);
               this.logBase10TextBox.TabIndex = 42;
               // 
               // logToChosenBaseButton
               // 
               this.logToChosenBaseButton.Location = new System.Drawing.Point(9, 251);
               this.logToChosenBaseButton.Name = "logToChosenBaseButton";
               this.logToChosenBaseButton.Size = new System.Drawing.Size(204, 39);
               this.logToChosenBaseButton.TabIndex = 43;
               this.logToChosenBaseButton.Text = "Log to Chosen Base";
               this.logToChosenBaseButton.UseVisualStyleBackColor = true;
               this.logToChosenBaseButton.Click += new System.EventHandler(this.logToChosenBaseButton_Click);
               // 
               // chosenBaseTextBox
               // 
               this.chosenBaseTextBox.Location = new System.Drawing.Point(347, 267);
               this.chosenBaseTextBox.Name = "chosenBaseTextBox";
               this.chosenBaseTextBox.Size = new System.Drawing.Size(100, 39);
               this.chosenBaseTextBox.TabIndex = 44;
               // 
               // baseLabel
               // 
               this.baseLabel.AutoSize = true;
               this.baseLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.baseLabel.Location = new System.Drawing.Point(226, 267);
               this.baseLabel.Name = "baseLabel";
               this.baseLabel.Size = new System.Drawing.Size(74, 32);
               this.baseLabel.TabIndex = 45;
               this.baseLabel.Text = "Base:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(226, 240);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(117, 32);
               this.label3.TabIndex = 46;
               this.label3.Text = "Number:";
               // 
               // chosenNumberTextBox
               // 
               this.chosenNumberTextBox.Location = new System.Drawing.Point(347, 240);
               this.chosenNumberTextBox.Name = "chosenNumberTextBox";
               this.chosenNumberTextBox.Size = new System.Drawing.Size(101, 39);
               this.chosenNumberTextBox.TabIndex = 47;
               // 
               // minAndMaxButton
               // 
               this.minAndMaxButton.Location = new System.Drawing.Point(14, 354);
               this.minAndMaxButton.Name = "minAndMaxButton";
               this.minAndMaxButton.Size = new System.Drawing.Size(203, 80);
               this.minAndMaxButton.TabIndex = 48;
               this.minAndMaxButton.Text = "Find Min and Max";
               this.minAndMaxButton.UseVisualStyleBackColor = true;
               this.minAndMaxButton.Click += new System.EventHandler(this.minAndMaxButton_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(226, 363);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(137, 32);
               this.label4.TabIndex = 49;
               this.label4.Text = "Number 1:";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(228, 395);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(137, 32);
               this.label5.TabIndex = 50;
               this.label5.Text = "Number 2:";
               // 
               // minAndMaxTextBox1
               // 
               this.minAndMaxTextBox1.Location = new System.Drawing.Point(348, 363);
               this.minAndMaxTextBox1.Name = "minAndMaxTextBox1";
               this.minAndMaxTextBox1.Size = new System.Drawing.Size(100, 39);
               this.minAndMaxTextBox1.TabIndex = 51;
               // 
               // minAndMaxTextBox2
               // 
               this.minAndMaxTextBox2.Location = new System.Drawing.Point(348, 398);
               this.minAndMaxTextBox2.Name = "minAndMaxTextBox2";
               this.minAndMaxTextBox2.Size = new System.Drawing.Size(100, 39);
               this.minAndMaxTextBox2.TabIndex = 52;
               // 
               // numberToPowerButton
               // 
               this.numberToPowerButton.Location = new System.Drawing.Point(14, 450);
               this.numberToPowerButton.Name = "numberToPowerButton";
               this.numberToPowerButton.Size = new System.Drawing.Size(206, 74);
               this.numberToPowerButton.TabIndex = 53;
               this.numberToPowerButton.Text = "Find Number to Power";
               this.numberToPowerButton.UseVisualStyleBackColor = true;
               this.numberToPowerButton.Click += new System.EventHandler(this.numberToPowerButton_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(231, 457);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(74, 32);
               this.label6.TabIndex = 54;
               this.label6.Text = "Base:";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(231, 489);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(94, 32);
               this.label7.TabIndex = 55;
               this.label7.Text = "Power:";
               // 
               // numToPowerBaseTextBox
               // 
               this.numToPowerBaseTextBox.Location = new System.Drawing.Point(347, 454);
               this.numToPowerBaseTextBox.Name = "numToPowerBaseTextBox";
               this.numToPowerBaseTextBox.Size = new System.Drawing.Size(100, 39);
               this.numToPowerBaseTextBox.TabIndex = 56;
               // 
               // numToPowerPowerTextBox
               // 
               this.numToPowerPowerTextBox.Location = new System.Drawing.Point(347, 489);
               this.numToPowerPowerTextBox.Name = "numToPowerPowerTextBox";
               this.numToPowerPowerTextBox.Size = new System.Drawing.Size(100, 39);
               this.numToPowerPowerTextBox.TabIndex = 57;
               // 
               // findRootsButton
               // 
               this.findRootsButton.Location = new System.Drawing.Point(14, 542);
               this.findRootsButton.Name = "findRootsButton";
               this.findRootsButton.Size = new System.Drawing.Size(202, 42);
               this.findRootsButton.TabIndex = 58;
               this.findRootsButton.Text = "Find Roots";
               this.findRootsButton.UseVisualStyleBackColor = true;
               this.findRootsButton.Click += new System.EventHandler(this.findRootsButton_Click);
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.Location = new System.Drawing.Point(228, 542);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(170, 32);
               this.label8.TabIndex = 59;
               this.label8.Text = "Coefficient A:";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.Location = new System.Drawing.Point(231, 574);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(168, 32);
               this.label9.TabIndex = 60;
               this.label9.Text = "Coefficient B:";
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.Location = new System.Drawing.Point(231, 602);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(124, 32);
               this.label10.TabIndex = 61;
               this.label10.Text = "Constant:";
               // 
               // coefficientATextBox
               // 
               this.coefficientATextBox.Location = new System.Drawing.Point(348, 539);
               this.coefficientATextBox.Name = "coefficientATextBox";
               this.coefficientATextBox.Size = new System.Drawing.Size(100, 39);
               this.coefficientATextBox.TabIndex = 62;
               // 
               // CoefficientBTextBox
               // 
               this.CoefficientBTextBox.Location = new System.Drawing.Point(348, 567);
               this.CoefficientBTextBox.Name = "CoefficientBTextBox";
               this.CoefficientBTextBox.Size = new System.Drawing.Size(100, 39);
               this.CoefficientBTextBox.TabIndex = 63;
               // 
               // constantTextBox
               // 
               this.constantTextBox.Location = new System.Drawing.Point(348, 602);
               this.constantTextBox.Name = "constantTextBox";
               this.constantTextBox.Size = new System.Drawing.Size(100, 39);
               this.constantTextBox.TabIndex = 64;
               // 
               // squareRootButton
               // 
               this.squareRootButton.Location = new System.Drawing.Point(13, 650);
               this.squareRootButton.Name = "squareRootButton";
               this.squareRootButton.Size = new System.Drawing.Size(155, 39);
               this.squareRootButton.TabIndex = 65;
               this.squareRootButton.Text = "Square Root";
               this.squareRootButton.UseVisualStyleBackColor = true;
               this.squareRootButton.Click += new System.EventHandler(this.squareRootButton_Click);
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label11.Location = new System.Drawing.Point(233, 657);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(117, 32);
               this.label11.TabIndex = 66;
               this.label11.Text = "Number:";
               // 
               // squareRootTextBox
               // 
               this.squareRootTextBox.Location = new System.Drawing.Point(347, 657);
               this.squareRootTextBox.Name = "squareRootTextBox";
               this.squareRootTextBox.Size = new System.Drawing.Size(100, 39);
               this.squareRootTextBox.TabIndex = 67;
               // 
               // exitButton
               // 
               this.exitButton.Location = new System.Drawing.Point(359, 739);
               this.exitButton.Name = "exitButton";
               this.exitButton.Size = new System.Drawing.Size(75, 23);
               this.exitButton.TabIndex = 68;
               this.exitButton.Text = "Exit";
               this.exitButton.UseVisualStyleBackColor = true;
               this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label12.Location = new System.Drawing.Point(228, 188);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(117, 32);
               this.label12.TabIndex = 69;
               this.label12.Text = "Number:";
               // 
               // CalculatorGUIForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.Gainsboro;
               this.ClientSize = new System.Drawing.Size(510, 851);
               this.Controls.Add(this.label12);
               this.Controls.Add(this.exitButton);
               this.Controls.Add(this.squareRootTextBox);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.squareRootButton);
               this.Controls.Add(this.constantTextBox);
               this.Controls.Add(this.CoefficientBTextBox);
               this.Controls.Add(this.coefficientATextBox);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.findRootsButton);
               this.Controls.Add(this.numToPowerPowerTextBox);
               this.Controls.Add(this.numToPowerBaseTextBox);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.numberToPowerButton);
               this.Controls.Add(this.minAndMaxTextBox2);
               this.Controls.Add(this.minAndMaxTextBox1);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.minAndMaxButton);
               this.Controls.Add(this.chosenNumberTextBox);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.baseLabel);
               this.Controls.Add(this.chosenBaseTextBox);
               this.Controls.Add(this.logToChosenBaseButton);
               this.Controls.Add(this.logBase10TextBox);
               this.Controls.Add(this.LogBase10Button);
               this.Controls.Add(this.divisorTextBox);
               this.Controls.Add(this.dividendTextBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.reverseWordTextBox);
               this.Controls.Add(this.reverseWordButton);
               this.Controls.Add(this.resultTextBox);
               this.Controls.Add(this.remainderButton);
               this.Controls.Add(this.removeSpaceButton);
               this.Controls.Add(this.removeSpaceTextBox);
               this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Name = "CalculatorGUIForm";
               this.Text = "Calculator GUI";
               this.ResumeLayout(false);
               this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button remainderButton;
      private System.Windows.Forms.TextBox removeSpaceTextBox;
          private System.Windows.Forms.Button removeSpaceButton;
          private System.Windows.Forms.Label resultTextBox;
          private System.Windows.Forms.Button reverseWordButton;
          private System.Windows.Forms.TextBox reverseWordTextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox dividendTextBox;
          private System.Windows.Forms.TextBox divisorTextBox;
          private System.Windows.Forms.Button LogBase10Button;
          private System.Windows.Forms.TextBox logBase10TextBox;
          private System.Windows.Forms.Button logToChosenBaseButton;
          private System.Windows.Forms.TextBox chosenBaseTextBox;
          private System.Windows.Forms.Label baseLabel;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox chosenNumberTextBox;
          private System.Windows.Forms.Button minAndMaxButton;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox minAndMaxTextBox1;
          private System.Windows.Forms.TextBox minAndMaxTextBox2;
          private System.Windows.Forms.Button numberToPowerButton;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.TextBox numToPowerBaseTextBox;
          private System.Windows.Forms.TextBox numToPowerPowerTextBox;
          private System.Windows.Forms.Button findRootsButton;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label label10;
          private System.Windows.Forms.TextBox coefficientATextBox;
          private System.Windows.Forms.TextBox CoefficientBTextBox;
          private System.Windows.Forms.TextBox constantTextBox;
          private System.Windows.Forms.Button squareRootButton;
          private System.Windows.Forms.Label label11;
          private System.Windows.Forms.TextBox squareRootTextBox;
          private System.Windows.Forms.Button exitButton;
          private System.Windows.Forms.Label label12;
     }
}

