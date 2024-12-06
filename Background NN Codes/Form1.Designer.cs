namespace Background_NN_Codes
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
            this.button1 = new System.Windows.Forms.Button();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.InputC = new System.Windows.Forms.TextBox();
            this.InputD = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create BPNN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(49, 173);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 20);
            this.InputA.TabIndex = 1;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(170, 173);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 20);
            this.InputB.TabIndex = 2;
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(292, 173);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(100, 20);
            this.InputC.TabIndex = 3;
            // 
            // InputD
            // 
            this.InputD.Location = new System.Drawing.Point(415, 173);
            this.InputD.Name = "InputD";
            this.InputD.Size = new System.Drawing.Size(100, 20);
            this.InputD.TabIndex = 4;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(569, 173);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(176, 20);
            this.Output.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Train the Neural Network";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InputD);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.TextBox InputD;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

