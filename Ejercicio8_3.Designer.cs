
namespace Ejercicios_cap_8y9
{
    partial class Ejercicio8_3
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.HoraLabel = new System.Windows.Forms.Label();
            this.tiempofecha_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.FechaLabel);
            this.groupBox1.Controls.Add(this.HoraLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(442, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la fecha y la hora ";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FechaLabel.Location = new System.Drawing.Point(165, 123);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(124, 44);
            this.FechaLabel.TabIndex = 4;
            this.FechaLabel.Text = "Fecha";
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraLabel.ForeColor = System.Drawing.Color.Black;
            this.HoraLabel.Location = new System.Drawing.Point(165, 63);
            this.HoraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(104, 44);
            this.HoraLabel.TabIndex = 3;
            this.HoraLabel.Text = "Hora";
            // 
            // tiempofecha_timer
            // 
            this.tiempofecha_timer.Tick += new System.EventHandler(this.tiempofecha_timer_Tick);
            // 
            // Ejercicio8_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio8_3";
            this.Text = "Ejercicio8_3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer tiempofecha_timer;
    }
}