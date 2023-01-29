namespace HolaMundo2
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
            this.boton = new System.Windows.Forms.Button();
            this.Texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(371, 71);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "Pulsar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.Location = new System.Drawing.Point(353, 242);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(112, 15);
            this.Texto.TabIndex = 1;
            this.Texto.Text = "Mensaje provisional";
            this.Texto.Click += new System.EventHandler(this.Texto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.boton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button boton;
        private Label Texto;
    }
}