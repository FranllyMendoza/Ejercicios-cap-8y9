
namespace Ejercicios_cap_8y9
{
    partial class Ejercicio9_4
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
            this.SiguienteButton = new System.Windows.Forms.Button();
            this.EnumeraciongroupBox1 = new System.Windows.Forms.GroupBox();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.EnumeraciongroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SiguienteButton
            // 
            this.SiguienteButton.Location = new System.Drawing.Point(99, 177);
            this.SiguienteButton.Margin = new System.Windows.Forms.Padding(4);
            this.SiguienteButton.Name = "SiguienteButton";
            this.SiguienteButton.Size = new System.Drawing.Size(119, 36);
            this.SiguienteButton.TabIndex = 4;
            this.SiguienteButton.Text = "Siguiente";
            this.SiguienteButton.UseVisualStyleBackColor = true;
            this.SiguienteButton.Click += new System.EventHandler(this.SiguienteButton_Click);
            // 
            // EnumeraciongroupBox1
            // 
            this.EnumeraciongroupBox1.Controls.Add(this.EnumLabel);
            this.EnumeraciongroupBox1.Location = new System.Drawing.Point(13, 13);
            this.EnumeraciongroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.EnumeraciongroupBox1.Name = "EnumeraciongroupBox1";
            this.EnumeraciongroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.EnumeraciongroupBox1.Size = new System.Drawing.Size(289, 156);
            this.EnumeraciongroupBox1.TabIndex = 3;
            this.EnumeraciongroupBox1.TabStop = false;
            this.EnumeraciongroupBox1.Text = "La Enumeracion";
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnumLabel.Location = new System.Drawing.Point(49, 60);
            this.EnumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(179, 38);
            this.EnumLabel.TabIndex = 0;
            this.EnumLabel.Text = "enumeracion";
            // 
            // Ejercicio9_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 228);
            this.Controls.Add(this.SiguienteButton);
            this.Controls.Add(this.EnumeraciongroupBox1);
            this.Name = "Ejercicio9_4";
            this.Text = "Ejercicio9_4";
            this.EnumeraciongroupBox1.ResumeLayout(false);
            this.EnumeraciongroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SiguienteButton;
        private System.Windows.Forms.GroupBox EnumeraciongroupBox1;
        private System.Windows.Forms.Label EnumLabel;
    }
}