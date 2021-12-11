
namespace SoftwareDesignPatterns
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.Btn_Ball = new System.Windows.Forms.Button();
            this.Btn_Car = new System.Windows.Forms.Button();
            this.Lbl_Next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 240);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // Btn_Ball
            // 
            this.Btn_Ball.Location = new System.Drawing.Point(12, 12);
            this.Btn_Ball.Name = "Btn_Ball";
            this.Btn_Ball.Size = new System.Drawing.Size(80, 50);
            this.Btn_Ball.TabIndex = 1;
            this.Btn_Ball.Text = "BALL";
            this.Btn_Ball.UseVisualStyleBackColor = true;
            // 
            // Btn_Car
            // 
            this.Btn_Car.Location = new System.Drawing.Point(98, 12);
            this.Btn_Car.Name = "Btn_Car";
            this.Btn_Car.Size = new System.Drawing.Size(80, 50);
            this.Btn_Car.TabIndex = 2;
            this.Btn_Car.Text = "CAR";
            this.Btn_Car.UseVisualStyleBackColor = true;
            // 
            // Lbl_Next
            // 
            this.Lbl_Next.AutoSize = true;
            this.Lbl_Next.Location = new System.Drawing.Point(215, 12);
            this.Lbl_Next.Name = "Lbl_Next";
            this.Lbl_Next.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Next.TabIndex = 3;
            this.Lbl_Next.Text = "Coming next:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.Lbl_Next);
            this.Controls.Add(this.Btn_Car);
            this.Controls.Add(this.Btn_Ball);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button Btn_Ball;
        private System.Windows.Forms.Button Btn_Car;
        private System.Windows.Forms.Label Lbl_Next;
    }
}

