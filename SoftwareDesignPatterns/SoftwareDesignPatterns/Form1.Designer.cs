
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
            this.Btn_BallColor = new System.Windows.Forms.Button();
            this.Btn_Present = new System.Windows.Forms.Button();
            this.Btn_RibbonColor = new System.Windows.Forms.Button();
            this.Btn_BoxColor = new System.Windows.Forms.Button();
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
            this.Lbl_Next.Location = new System.Drawing.Point(297, 13);
            this.Lbl_Next.Name = "Lbl_Next";
            this.Lbl_Next.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Next.TabIndex = 3;
            this.Lbl_Next.Text = "Coming next:";
            // 
            // Btn_BallColor
            // 
            this.Btn_BallColor.BackColor = System.Drawing.Color.Blue;
            this.Btn_BallColor.Location = new System.Drawing.Point(12, 68);
            this.Btn_BallColor.Name = "Btn_BallColor";
            this.Btn_BallColor.Size = new System.Drawing.Size(80, 23);
            this.Btn_BallColor.TabIndex = 4;
            this.Btn_BallColor.UseVisualStyleBackColor = false;
            // 
            // Btn_Present
            // 
            this.Btn_Present.Location = new System.Drawing.Point(184, 12);
            this.Btn_Present.Name = "Btn_Present";
            this.Btn_Present.Size = new System.Drawing.Size(80, 50);
            this.Btn_Present.TabIndex = 5;
            this.Btn_Present.Text = "PRESENT";
            this.Btn_Present.UseVisualStyleBackColor = true;
            // 
            // Btn_RibbonColor
            // 
            this.Btn_RibbonColor.BackColor = System.Drawing.Color.Yellow;
            this.Btn_RibbonColor.Location = new System.Drawing.Point(184, 97);
            this.Btn_RibbonColor.Name = "Btn_RibbonColor";
            this.Btn_RibbonColor.Size = new System.Drawing.Size(80, 23);
            this.Btn_RibbonColor.TabIndex = 6;
            this.Btn_RibbonColor.UseVisualStyleBackColor = false;
            // 
            // Btn_BoxColor
            // 
            this.Btn_BoxColor.BackColor = System.Drawing.Color.Red;
            this.Btn_BoxColor.Location = new System.Drawing.Point(184, 68);
            this.Btn_BoxColor.Name = "Btn_BoxColor";
            this.Btn_BoxColor.Size = new System.Drawing.Size(80, 23);
            this.Btn_BoxColor.TabIndex = 7;
            this.Btn_BoxColor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.Btn_BoxColor);
            this.Controls.Add(this.Btn_RibbonColor);
            this.Controls.Add(this.Btn_Present);
            this.Controls.Add(this.Btn_BallColor);
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
        private System.Windows.Forms.Button Btn_BallColor;
        private System.Windows.Forms.Button Btn_Present;
        private System.Windows.Forms.Button Btn_RibbonColor;
        private System.Windows.Forms.Button Btn_BoxColor;
    }
}

