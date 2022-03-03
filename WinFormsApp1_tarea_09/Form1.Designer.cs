
namespace WinFormsApp1_tarea_09
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
            this.txtBx_pimer_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_segundo_numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_tercer_numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_tamaño = new System.Windows.Forms.TextBox();
            this.bttn_generar_serie = new System.Windows.Forms.Button();
            this.txtBx_salida_serie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBx_pimer_numero
            // 
            this.txtBx_pimer_numero.Location = new System.Drawing.Point(112, 33);
            this.txtBx_pimer_numero.Name = "txtBx_pimer_numero";
            this.txtBx_pimer_numero.Size = new System.Drawing.Size(125, 27);
            this.txtBx_pimer_numero.TabIndex = 0;
            this.txtBx_pimer_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_pimer_numero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1er numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "2do numero";
            // 
            // txtBx_segundo_numero
            // 
            this.txtBx_segundo_numero.Location = new System.Drawing.Point(112, 66);
            this.txtBx_segundo_numero.Name = "txtBx_segundo_numero";
            this.txtBx_segundo_numero.Size = new System.Drawing.Size(125, 27);
            this.txtBx_segundo_numero.TabIndex = 2;
            this.txtBx_segundo_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_segundo_numero_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "3er numero";
            // 
            // txtBx_tercer_numero
            // 
            this.txtBx_tercer_numero.Location = new System.Drawing.Point(112, 99);
            this.txtBx_tercer_numero.Name = "txtBx_tercer_numero";
            this.txtBx_tercer_numero.Size = new System.Drawing.Size(125, 27);
            this.txtBx_tercer_numero.TabIndex = 4;
            this.txtBx_tercer_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_tercer_numero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tamaño";
            // 
            // txtBx_tamaño
            // 
            this.txtBx_tamaño.Location = new System.Drawing.Point(112, 132);
            this.txtBx_tamaño.Name = "txtBx_tamaño";
            this.txtBx_tamaño.Size = new System.Drawing.Size(125, 27);
            this.txtBx_tamaño.TabIndex = 6;
            this.txtBx_tamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_tamaño_KeyPress);
            // 
            // bttn_generar_serie
            // 
            this.bttn_generar_serie.Location = new System.Drawing.Point(21, 165);
            this.bttn_generar_serie.Name = "bttn_generar_serie";
            this.bttn_generar_serie.Size = new System.Drawing.Size(216, 29);
            this.bttn_generar_serie.TabIndex = 8;
            this.bttn_generar_serie.Text = "Generar serie";
            this.bttn_generar_serie.UseVisualStyleBackColor = true;
            this.bttn_generar_serie.Click += new System.EventHandler(this.bttn_generar_serie_Click);
            // 
            // txtBx_salida_serie
            // 
            this.txtBx_salida_serie.Location = new System.Drawing.Point(289, 33);
            this.txtBx_salida_serie.Multiline = true;
            this.txtBx_salida_serie.Name = "txtBx_salida_serie";
            this.txtBx_salida_serie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_salida_serie.Size = new System.Drawing.Size(499, 161);
            this.txtBx_salida_serie.TabIndex = 9;
            this.txtBx_salida_serie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_salida_serie_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx_salida_serie);
            this.Controls.Add(this.bttn_generar_serie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBx_tamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_tercer_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_segundo_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_pimer_numero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_pimer_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_segundo_numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_tercer_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_tamaño;
        private System.Windows.Forms.Button bttn_generar_serie;
        private System.Windows.Forms.TextBox txtBx_salida_serie;
    }
}

