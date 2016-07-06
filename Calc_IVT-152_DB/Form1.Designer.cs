namespace Calc_IVT_152_DB
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonLg = new System.Windows.Forms.Button();
            this.buttonFact = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonExponent = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonCot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(151, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(232, 38);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 4;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(313, 38);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(75, 23);
            this.buttonMult.TabIndex = 5;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(394, 38);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 6;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // buttonSin
            // 
            this.buttonSin.Location = new System.Drawing.Point(151, 67);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(75, 23);
            this.buttonSin.TabIndex = 8;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // buttonCos
            // 
            this.buttonCos.Location = new System.Drawing.Point(232, 67);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(75, 23);
            this.buttonCos.TabIndex = 9;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // buttonLn
            // 
            this.buttonLn.Location = new System.Drawing.Point(313, 67);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(75, 23);
            this.buttonLn.TabIndex = 10;
            this.buttonLn.Text = "Ln";
            this.buttonLn.UseVisualStyleBackColor = true;
            this.buttonLn.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // buttonLg
            // 
            this.buttonLg.Location = new System.Drawing.Point(394, 67);
            this.buttonLg.Name = "buttonLg";
            this.buttonLg.Size = new System.Drawing.Size(75, 23);
            this.buttonLg.TabIndex = 11;
            this.buttonLg.Text = "Lg";
            this.buttonLg.UseVisualStyleBackColor = true;
            this.buttonLg.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // buttonFact
            // 
            this.buttonFact.Location = new System.Drawing.Point(151, 96);
            this.buttonFact.Name = "buttonFact";
            this.buttonFact.Size = new System.Drawing.Size(75, 23);
            this.buttonFact.TabIndex = 12;
            this.buttonFact.Text = "n!";
            this.buttonFact.UseVisualStyleBackColor = true;
            this.buttonFact.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Location = new System.Drawing.Point(232, 96);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(75, 23);
            this.buttonRoot.TabIndex = 13;
            this.buttonRoot.Text = "Root";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonExponent
            // 
            this.buttonExponent.Location = new System.Drawing.Point(313, 96);
            this.buttonExponent.Name = "buttonExponent";
            this.buttonExponent.Size = new System.Drawing.Size(75, 23);
            this.buttonExponent.TabIndex = 14;
            this.buttonExponent.Text = "Exponent";
            this.buttonExponent.UseVisualStyleBackColor = true;
            this.buttonExponent.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(394, 96);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 15;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(151, 125);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(75, 23);
            this.buttonPercent.TabIndex = 16;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.button_ClickTwoArg);
            // 
            // buttonTan
            // 
            this.buttonTan.Location = new System.Drawing.Point(232, 125);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(75, 23);
            this.buttonTan.TabIndex = 17;
            this.buttonTan.Text = "Tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // buttonCot
            // 
            this.buttonCot.Location = new System.Drawing.Point(313, 125);
            this.buttonCot.Name = "buttonCot";
            this.buttonCot.Size = new System.Drawing.Size(75, 23);
            this.buttonCot.TabIndex = 18;
            this.buttonCot.Text = "Cot";
            this.buttonCot.UseVisualStyleBackColor = true;
            this.buttonCot.Click += new System.EventHandler(this.button_ClickOneArg);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 342);
            this.Controls.Add(this.buttonCot);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonExponent);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonFact);
            this.Controls.Add(this.buttonLg);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "СУПЕР ПРЕКРАСНЫЙ КАЛЬКУЛЯТОР over 9k";
            this.Click += new System.EventHandler(this.button_ClickTwoArg);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonLg;
        private System.Windows.Forms.Button buttonFact;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonExponent;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonCot;
    }
}

