
namespace Program1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.widthInputTextBox = new System.Windows.Forms.TextBox();
            this.lengthInputTextBox = new System.Windows.Forms.TextBox();
            this.colorInputTextBox = new System.Windows.Forms.TextBox();
            this.paintInputTextBox = new System.Windows.Forms.TextBox();
            this.coatsInputTextBox = new System.Windows.Forms.TextBox();
            this.illuminateInputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.areaOutput = new System.Windows.Forms.Label();
            this.paintingCostsOutput = new System.Windows.Forms.Label();
            this.coatsOutput = new System.Windows.Forms.Label();
            this.laborCostsOutput = new System.Windows.Forms.Label();
            this.totalCostsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to My Mural Calculator!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the width (in ft):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the length (in ft):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of colors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price of paint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of coats (1 or 2):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Illuminate mural? (1=yes 0=no):";
            // 
            // widthInputTextBox
            // 
            this.widthInputTextBox.Location = new System.Drawing.Point(439, 76);
            this.widthInputTextBox.Name = "widthInputTextBox";
            this.widthInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthInputTextBox.TabIndex = 7;
            // 
            // lengthInputTextBox
            // 
            this.lengthInputTextBox.Location = new System.Drawing.Point(439, 113);
            this.lengthInputTextBox.Name = "lengthInputTextBox";
            this.lengthInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthInputTextBox.TabIndex = 8;
            // 
            // colorInputTextBox
            // 
            this.colorInputTextBox.Location = new System.Drawing.Point(439, 154);
            this.colorInputTextBox.Name = "colorInputTextBox";
            this.colorInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorInputTextBox.TabIndex = 9;
            // 
            // paintInputTextBox
            // 
            this.paintInputTextBox.Location = new System.Drawing.Point(439, 191);
            this.paintInputTextBox.Name = "paintInputTextBox";
            this.paintInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintInputTextBox.TabIndex = 10;
            // 
            // coatsInputTextBox
            // 
            this.coatsInputTextBox.Location = new System.Drawing.Point(439, 227);
            this.coatsInputTextBox.Name = "coatsInputTextBox";
            this.coatsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.coatsInputTextBox.TabIndex = 11;
            // 
            // illuminateInputTextBox
            // 
            this.illuminateInputTextBox.Location = new System.Drawing.Point(439, 268);
            this.illuminateInputTextBox.Name = "illuminateInputTextBox";
            this.illuminateInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.illuminateInputTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total area in sq ft:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Painting costs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Coats costs:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Labor costs:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total costs:";
            // 
            // areaOutput
            // 
            this.areaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaOutput.Location = new System.Drawing.Point(575, 344);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(100, 23);
            this.areaOutput.TabIndex = 19;
            // 
            // paintingCostsOutput
            // 
            this.paintingCostsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintingCostsOutput.Location = new System.Drawing.Point(575, 380);
            this.paintingCostsOutput.Name = "paintingCostsOutput";
            this.paintingCostsOutput.Size = new System.Drawing.Size(100, 23);
            this.paintingCostsOutput.TabIndex = 20;
            // 
            // coatsOutput
            // 
            this.coatsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coatsOutput.Location = new System.Drawing.Point(575, 412);
            this.coatsOutput.Name = "coatsOutput";
            this.coatsOutput.Size = new System.Drawing.Size(100, 23);
            this.coatsOutput.TabIndex = 21;
            // 
            // laborCostsOutput
            // 
            this.laborCostsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostsOutput.Location = new System.Drawing.Point(575, 446);
            this.laborCostsOutput.Name = "laborCostsOutput";
            this.laborCostsOutput.Size = new System.Drawing.Size(100, 23);
            this.laborCostsOutput.TabIndex = 22;
            // 
            // totalCostsOutput
            // 
            this.totalCostsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostsOutput.Location = new System.Drawing.Point(575, 480);
            this.totalCostsOutput.Name = "totalCostsOutput";
            this.totalCostsOutput.Size = new System.Drawing.Size(100, 23);
            this.totalCostsOutput.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 536);
            this.Controls.Add(this.totalCostsOutput);
            this.Controls.Add(this.laborCostsOutput);
            this.Controls.Add(this.coatsOutput);
            this.Controls.Add(this.paintingCostsOutput);
            this.Controls.Add(this.areaOutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.illuminateInputTextBox);
            this.Controls.Add(this.coatsInputTextBox);
            this.Controls.Add(this.paintInputTextBox);
            this.Controls.Add(this.colorInputTextBox);
            this.Controls.Add(this.lengthInputTextBox);
            this.Controls.Add(this.widthInputTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox widthInputTextBox;
        private System.Windows.Forms.TextBox lengthInputTextBox;
        private System.Windows.Forms.TextBox colorInputTextBox;
        private System.Windows.Forms.TextBox paintInputTextBox;
        private System.Windows.Forms.TextBox coatsInputTextBox;
        private System.Windows.Forms.TextBox illuminateInputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.Label paintingCostsOutput;
        private System.Windows.Forms.Label coatsOutput;
        private System.Windows.Forms.Label laborCostsOutput;
        private System.Windows.Forms.Label totalCostsOutput;
    }
}

