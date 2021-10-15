
namespace CSC240_03_03_AdmissionsGUI_bpc
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
            this.Lable1 = new System.Windows.Forms.Label();
            this.Lable2 = new System.Windows.Forms.Label();
            this.UxGPATextBox1 = new System.Windows.Forms.TextBox();
            this.UxTestTextBox2 = new System.Windows.Forms.TextBox();
            this.UxCheckButton = new System.Windows.Forms.Button();
            this.UxResultTextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lable1.Location = new System.Drawing.Point(24, 262);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(199, 34);
            this.Lable1.TabIndex = 0;
            this.Lable1.Text = "Enter GPA Score:";
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Font = new System.Drawing.Font("Bernard MT Condensed", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lable2.Location = new System.Drawing.Point(25, 342);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(198, 34);
            this.Lable2.TabIndex = 1;
            this.Lable2.Text = "Enter Test Score:";
            // 
            // UxGPATextBox1
            // 
            this.UxGPATextBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGPATextBox1.Location = new System.Drawing.Point(256, 261);
            this.UxGPATextBox1.Name = "UxGPATextBox1";
            this.UxGPATextBox1.Size = new System.Drawing.Size(200, 36);
            this.UxGPATextBox1.TabIndex = 2;
            // 
            // UxTestTextBox2
            // 
            this.UxTestTextBox2.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxTestTextBox2.Location = new System.Drawing.Point(256, 341);
            this.UxTestTextBox2.Name = "UxTestTextBox2";
            this.UxTestTextBox2.Size = new System.Drawing.Size(200, 36);
            this.UxTestTextBox2.TabIndex = 3;
            // 
            // UxCheckButton
            // 
            this.UxCheckButton.BackColor = System.Drawing.Color.Linen;
            this.UxCheckButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxCheckButton.Location = new System.Drawing.Point(572, 262);
            this.UxCheckButton.Name = "UxCheckButton";
            this.UxCheckButton.Size = new System.Drawing.Size(176, 119);
            this.UxCheckButton.TabIndex = 4;
            this.UxCheckButton.Text = "Press to see results!";
            this.UxCheckButton.UseVisualStyleBackColor = false;
            // 
            // UxResultTextBox3
            // 
            this.UxResultTextBox3.Font = new System.Drawing.Font("Bernard MT Condensed", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxResultTextBox3.Location = new System.Drawing.Point(868, 305);
            this.UxResultTextBox3.Name = "UxResultTextBox3";
            this.UxResultTextBox3.Size = new System.Drawing.Size(200, 42);
            this.UxResultTextBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1286, 667);
            this.Controls.Add(this.UxResultTextBox3);
            this.Controls.Add(this.UxCheckButton);
            this.Controls.Add(this.UxTestTextBox2);
            this.Controls.Add(this.UxGPATextBox1);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.Lable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.TextBox UxGPATextBox1;
        private System.Windows.Forms.TextBox UxTestTextBox2;
        private System.Windows.Forms.Button UxCheckButton;
        private System.Windows.Forms.TextBox UxResultTextBox3;
    }
}

