namespace TPMOD2_GUI
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
            this.Submit = new System.Windows.Forms.Button();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.outputNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(63, 95);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(160, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(63, 55);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(160, 23);
            this.inputNama.TabIndex = 1;
            // 
            // outputNama
            // 
            this.outputNama.AutoSize = true;
            this.outputNama.Location = new System.Drawing.Point(93, 137);
            this.outputNama.Name = "outputNama";
            this.outputNama.Size = new System.Drawing.Size(0, 15);
            this.outputNama.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 204);
            this.Controls.Add(this.outputNama);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Submit;
        private TextBox inputNama;
        private Label outputNama;
    }
}