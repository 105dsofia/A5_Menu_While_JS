
namespace A5_Menu_While_JS
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOp1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOp1
            // 
            this.btnOp1.Location = new System.Drawing.Point(12, 65);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(169, 38);
            this.btnOp1.TabIndex = 0;
            this.btnOp1.Text = "Repetir Texto";
            this.btnOp1.UseVisualStyleBackColor = true;
            this.btnOp1.Click += new System.EventHandler(this.btnOp1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija una Opción";
            // 
            // btnOp2
            // 
            this.btnOp2.Location = new System.Drawing.Point(12, 109);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(169, 38);
            this.btnOp2.TabIndex = 0;
            this.btnOp2.Text = "Pares e Impares";
            this.btnOp2.UseVisualStyleBackColor = true;
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            // 
            // btnOp3
            // 
            this.btnOp3.Location = new System.Drawing.Point(12, 153);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(169, 38);
            this.btnOp3.TabIndex = 0;
            this.btnOp3.Text = "Sumatoria";
            this.btnOp3.UseVisualStyleBackColor = true;
            this.btnOp3.Click += new System.EventHandler(this.btnOp3_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Button btnOp3;
    }
}

