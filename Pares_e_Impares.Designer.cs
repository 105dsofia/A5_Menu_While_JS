
namespace A5_Menu_While_JS
{
    partial class Pares_e_Impares
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btntImpares = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(23, 104);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(135, 44);
            this.btnPares.TabIndex = 1;
            this.btnPares.Text = "Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btntImpares
            // 
            this.btntImpares.Location = new System.Drawing.Point(23, 154);
            this.btntImpares.Name = "btntImpares";
            this.btntImpares.Size = new System.Drawing.Size(135, 44);
            this.btntImpares.TabIndex = 2;
            this.btntImpares.Text = "Impares";
            this.btntImpares.UseVisualStyleBackColor = true;
            this.btntImpares.Click += new System.EventHandler(this.btntImpares_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(145, -5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 196);
            this.listBox1.TabIndex = 3;
            // 
            // Pares_e_Impares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 299);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btntImpares);
            this.Controls.Add(this.btnPares);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Pares_e_Impares";
            this.Text = "Pares_e_Impares";
            this.Load += new System.EventHandler(this.Pares_e_Impares_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btntImpares;
        private System.Windows.Forms.ListBox listBox1;
    }
}