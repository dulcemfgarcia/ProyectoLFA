
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
            this.TResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNUpload
            // 
            this.BTNUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNUpload.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUpload.Location = new System.Drawing.Point(13, 27);
            this.BTNUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNUpload.Name = "BTNUpload";
            this.BTNUpload.Size = new System.Drawing.Size(158, 28);
            this.BTNUpload.TabIndex = 0;
            this.BTNUpload.Text = "Cargar Gramática";
            this.BTNUpload.UseVisualStyleBackColor = false;
            this.BTNUpload.Click += new System.EventHandler(this.BTNUpload_Click);
            // 
            // RTBGrammar
            // 
            this.RTBGrammar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RTBGrammar.Location = new System.Drawing.Point(16, 103);
            this.RTBGrammar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RTBGrammar.Name = "RTBGrammar";
            this.RTBGrammar.Size = new System.Drawing.Size(492, 296);
            this.RTBGrammar.TabIndex = 1;
            this.RTBGrammar.Text = "";
            // 
            // TResult
            // 
            this.TResult.Location = new System.Drawing.Point(181, 71);
            this.TResult.Name = "TResult";
            this.TResult.Size = new System.Drawing.Size(308, 22);
            this.TResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(525, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TResult);
            this.Controls.Add(this.RTBGrammar);
            this.Controls.Add(this.BTNUpload);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNUpload;
        private System.Windows.Forms.RichTextBox RTBGrammar;
        private System.Windows.Forms.TextBox TResult;
        private System.Windows.Forms.Label label1;
    }
}

