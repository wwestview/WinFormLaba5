namespace WinFormsApp1
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
            buttonCircle = new Button();
            buttonSquare = new Button();
            buttonRhomb = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(25, 8);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(86, 32);
            this.buttonCircle.TabIndex = 0;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.ButtonCircle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(120, 8);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(86, 32);
            this.buttonSquare.TabIndex = 1;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonRhomb
            // 
            this.buttonRhomb.Location = new System.Drawing.Point(215, 8);
            this.buttonRhomb.Name = "buttonRhomb";
            this.buttonRhomb.Size = new System.Drawing.Size(86, 32);
            this.buttonRhomb.TabIndex = 2;
            this.buttonRhomb.Text = "Rhomb";
            this.buttonRhomb.UseVisualStyleBackColor = true;
            this.buttonRhomb.Click += new System.EventHandler(this.ButtonRhomb_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(310, 8);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 32);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.buttonCircle);
            Controls.Add(this.buttonSquare);
            Controls.Add(this.buttonRhomb);
            Controls.Add(this.buttonClear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCircle;
        private Button buttonSquare;
        private Button buttonRhomb;
        private Button buttonClear;
    }
}
