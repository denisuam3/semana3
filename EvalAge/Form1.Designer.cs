namespace EvalAge
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
            label1 = new Label();
            LblAdware = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            Name = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // LblAdware
            // 
            LblAdware.BorderStyle = BorderStyle.Fixed3D;
            LblAdware.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAdware.ForeColor = SystemColors.MenuHighlight;
            LblAdware.Location = new Point(143, 187);
            LblAdware.Name = "LblAdware";
            LblAdware.Size = new Size(409, 149);
            LblAdware.TabIndex = 1;
            LblAdware.TextAlign = ContentAlignment.MiddleCenter;
            LblAdware.Click += LblAdware_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 83);
            label3.Name = "label3";
            label3.Size = new Size(252, 38);
            label3.TabIndex = 2;
            label3.Text = "Introduce tu Edad";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 3;
            // 
            // Name
            // 
            Name.Location = new Point(556, 93);
            Name.Name = "Name";
            Name.Size = new Size(94, 29);
            Name.TabIndex = 4;
            Name.Text = "Evaluar";
            Name.UseVisualStyleBackColor = true;
            Name.Click += Name_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Name);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(LblAdware);
            Controls.Add(label1);
            Name = "Form1";
            Opacity = 0.92D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblAdware;
        private Label label3;
        private TextBox textBox1;
        private Button Name;
    }
}
