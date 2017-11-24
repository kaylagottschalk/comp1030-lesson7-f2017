namespace week7
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
            this.btnLoop1 = new System.Windows.Forms.Button();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.btnWhileLoop = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoop1
            // 
            this.btnLoop1.Location = new System.Drawing.Point(96, 21);
            this.btnLoop1.Name = "btnLoop1";
            this.btnLoop1.Size = new System.Drawing.Size(75, 23);
            this.btnLoop1.TabIndex = 0;
            this.btnLoop1.Text = "For loop";
            this.btnLoop1.UseVisualStyleBackColor = true;
            this.btnLoop1.Click += new System.EventHandler(this.btnLoop1_Click);
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(182, 64);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(143, 13);
            this.lblMessage1.TabIndex = 1;
            this.lblMessage1.Text = "Click the button to run a loop";
            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new System.Drawing.Point(341, 21);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new System.Drawing.Size(75, 23);
            this.btnWhileLoop.TabIndex = 2;
            this.btnWhileLoop.Text = "While loop";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new System.EventHandler(this.btnWhileLoop_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(51, 147);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(51, 173);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(287, 162);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(157, 13);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "Click the button to add numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 315);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.btnLoop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoop1;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Button btnWhileLoop;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSum;
    }
}

