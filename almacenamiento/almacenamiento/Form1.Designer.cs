namespace almacenamiento
{
    partial class Form1
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
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cbode = new System.Windows.Forms.ComboBox();
            this.cboa = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnconversion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "Almacenamiento",
            "Monedas"});
            this.cbotipo.Location = new System.Drawing.Point(207, 39);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 21);
            this.cbotipo.TabIndex = 0;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbode
            // 
            this.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbode.FormattingEnabled = true;
            this.cbode.Location = new System.Drawing.Point(57, 84);
            this.cbode.Name = "cbode";
            this.cbode.Size = new System.Drawing.Size(121, 21);
            this.cbode.TabIndex = 1;
            this.cbode.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboa
            // 
            this.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboa.FormattingEnabled = true;
            this.cboa.Location = new System.Drawing.Point(280, 84);
            this.cboa.Name = "cboa";
            this.cboa.Size = new System.Drawing.Size(121, 21);
            this.cboa.TabIndex = 2;
            this.cboa.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(189, 135);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 3;
            this.txtcantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnconversion
            // 
            this.btnconversion.Location = new System.Drawing.Point(189, 178);
            this.btnconversion.Name = "btnconversion";
            this.btnconversion.Size = new System.Drawing.Size(93, 46);
            this.btnconversion.TabIndex = 4;
            this.btnconversion.Text = "Conversion";
            this.btnconversion.UseVisualStyleBackColor = true;
            this.btnconversion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "A :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad: ";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(309, 138);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(73, 13);
            this.lblrespuesta.TabIndex = 9;
            this.lblrespuesta.Text = "Procesando...";
            this.lblrespuesta.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 353);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconversion);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cboa);
            this.Controls.Add(this.cbode);
            this.Controls.Add(this.cbotipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cbode;
        private System.Windows.Forms.ComboBox cboa;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnconversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblrespuesta;
    }
}

