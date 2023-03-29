
namespace ProyectoLFA
{
    partial class TransitionsView
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
            this.RTXtext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FollowTable = new System.Windows.Forms.DataGridView();
            this.TreeTable = new System.Windows.Forms.DataGridView();
            this.TransitionsTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FollowTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransitionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RTXtext
            // 
            this.RTXtext.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTXtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RTXtext.Location = new System.Drawing.Point(12, 44);
            this.RTXtext.Name = "RTXtext";
            this.RTXtext.Size = new System.Drawing.Size(328, 95);
            this.RTXtext.TabIndex = 0;
            this.RTXtext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOKENS";
            // 
            // FollowTable
            // 
            this.FollowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FollowTable.Location = new System.Drawing.Point(18, 183);
            this.FollowTable.Name = "FollowTable";
            this.FollowTable.Size = new System.Drawing.Size(322, 219);
            this.FollowTable.TabIndex = 2;
            // 
            // TreeTable
            // 
            this.TreeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TreeTable.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.TreeTable.Location = new System.Drawing.Point(371, 69);
            this.TreeTable.Name = "TreeTable";
            this.TreeTable.Size = new System.Drawing.Size(383, 114);
            this.TreeTable.TabIndex = 3;
            // 
            // TransitionsTable
            // 
            this.TransitionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransitionsTable.Location = new System.Drawing.Point(371, 266);
            this.TransitionsTable.Name = "TransitionsTable";
            this.TransitionsTable.Size = new System.Drawing.Size(383, 136);
            this.TransitionsTable.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(368, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabla de transiciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(368, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabla de First, Last y Nullable\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tabla de Follow";
            // 
            // TransitionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransitionsTable);
            this.Controls.Add(this.TreeTable);
            this.Controls.Add(this.FollowTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTXtext);
            this.Name = "TransitionsView";
            this.Text = "TransitionsView";
            this.Load += new System.EventHandler(this.TransitionsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FollowTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransitionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTXtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FollowTable;
        private System.Windows.Forms.DataGridView TreeTable;
        private System.Windows.Forms.DataGridView TransitionsTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}