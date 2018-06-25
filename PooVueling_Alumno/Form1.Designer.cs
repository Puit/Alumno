namespace PooVueling_Alumno
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
            this.txtbx_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.txtbx_Apellidos = new System.Windows.Forms.TextBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.txtbx_DNI = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txtbx_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbx_Nombre
            // 
            this.txtbx_Nombre.Location = new System.Drawing.Point(33, 34);
            this.txtbx_Nombre.Name = "txtbx_Nombre";
            this.txtbx_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbx_Nombre.TabIndex = 0;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(33, 13);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(151, 13);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_apellidos.TabIndex = 3;
            this.lbl_apellidos.Text = "Apellidos";
            // 
            // txtbx_Apellidos
            // 
            this.txtbx_Apellidos.Location = new System.Drawing.Point(151, 34);
            this.txtbx_Apellidos.Name = "txtbx_Apellidos";
            this.txtbx_Apellidos.Size = new System.Drawing.Size(100, 20);
            this.txtbx_Apellidos.TabIndex = 2;
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Location = new System.Drawing.Point(33, 64);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(26, 13);
            this.lbl_DNI.TabIndex = 5;
            this.lbl_DNI.Text = "DNI";
            // 
            // txtbx_DNI
            // 
            this.txtbx_DNI.Location = new System.Drawing.Point(33, 85);
            this.txtbx_DNI.Name = "txtbx_DNI";
            this.txtbx_DNI.Size = new System.Drawing.Size(100, 20);
            this.txtbx_DNI.TabIndex = 4;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(99, 135);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(151, 64);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(65, 13);
            this.lbl_Id.TabIndex = 8;
            this.lbl_Id.Text = "Identificador";
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Location = new System.Drawing.Point(151, 85);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.Size = new System.Drawing.Size(100, 20);
            this.txtbx_ID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 178);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txtbx_ID);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_DNI);
            this.Controls.Add(this.txtbx_DNI);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.txtbx_Apellidos);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txtbx_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.TextBox txtbx_Apellidos;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.TextBox txtbx_DNI;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txtbx_ID;
    }
}

