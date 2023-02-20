
namespace ProyectoLFA
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
            this.BTNUpload = new System.Windows.Forms.Button();
            this.RTBGrammar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTNUpload
            // 
            this.BTNUpload.Location = new System.Drawing.Point(12, 55);
            this.BTNUpload.Name = "BTNUpload";
            this.BTNUpload.Size = new System.Drawing.Size(109, 23);
            this.BTNUpload.TabIndex = 0;
            this.BTNUpload.Text = "Cargar Gramática";
            this.BTNUpload.UseVisualStyleBackColor = true;
            // 
            // RTBGrammar
            // 
            this.RTBGrammar.Location = new System.Drawing.Point(12, 84);
            this.RTBGrammar.Name = "RTBGrammar";
            this.RTBGrammar.Size = new System.Drawing.Size(370, 241);
            this.RTBGrammar.TabIndex = 1;
            this.RTBGrammar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.RTBGrammar);
            this.Controls.Add(this.BTNUpload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNUpload;
        private System.Windows.Forms.RichTextBox RTBGrammar;
    }
}

