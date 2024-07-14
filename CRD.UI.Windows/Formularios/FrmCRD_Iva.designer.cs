namespace CRD.UI.Windows.Formularios
{
    partial class FrmCRD_Iva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdIva = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnRazonSocial = new System.Windows.Forms.RadioButton();
            this.rbtnCodProveedor = new System.Windows.Forms.RadioButton();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEstablecerIva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.dgvLista);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(50, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 504);
            this.panel1.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtIdIva);
            this.groupBox4.Controls.Add(this.Eliminar);
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.btnLimpiar);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtValor);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox4.Location = new System.Drawing.Point(34, 167);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(564, 165);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Id Iva";
            // 
            // txtIdIva
            // 
            this.txtIdIva.Location = new System.Drawing.Point(26, 37);
            this.txtIdIva.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdIva.Name = "txtIdIva";
            this.txtIdIva.ReadOnly = true;
            this.txtIdIva.Size = new System.Drawing.Size(140, 26);
            this.txtIdIva.TabIndex = 34;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(447, 77);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(64, 35);
            this.Eliminar.TabIndex = 33;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(447, 32);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 34);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(274, 127);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 33);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Valor del Iva:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(28, 88);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(143, 26);
            this.txtValor.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnEstablecerIva);
            this.groupBox5.Controls.Add(this.rbtnRazonSocial);
            this.groupBox5.Controls.Add(this.rbtnCodProveedor);
            this.groupBox5.Controls.Add(this.btnBuscador);
            this.groupBox5.Controls.Add(this.txtBuscador);
            this.groupBox5.Controls.Add(this.labNombre);
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox5.Location = new System.Drawing.Point(34, 42);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(564, 130);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // rbtnRazonSocial
            // 
            this.rbtnRazonSocial.AutoSize = true;
            this.rbtnRazonSocial.Location = new System.Drawing.Point(170, 69);
            this.rbtnRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnRazonSocial.Name = "rbtnRazonSocial";
            this.rbtnRazonSocial.Size = new System.Drawing.Size(75, 24);
            this.rbtnRazonSocial.TabIndex = 6;
            this.rbtnRazonSocial.Text = "Nombre";
            this.rbtnRazonSocial.UseVisualStyleBackColor = true;
            // 
            // rbtnCodProveedor
            // 
            this.rbtnCodProveedor.AutoSize = true;
            this.rbtnCodProveedor.Checked = true;
            this.rbtnCodProveedor.Location = new System.Drawing.Point(19, 69);
            this.rbtnCodProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCodProveedor.Name = "rbtnCodProveedor";
            this.rbtnCodProveedor.Size = new System.Drawing.Size(129, 24);
            this.rbtnCodProveedor.TabIndex = 5;
            this.rbtnCodProveedor.TabStop = true;
            this.rbtnCodProveedor.Text = "Codigo Empresa";
            this.rbtnCodProveedor.UseVisualStyleBackColor = true;
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(328, 42);
            this.btnBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(64, 31);
            this.btnBuscador.TabIndex = 4;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscador.Location = new System.Drawing.Point(19, 42);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscador.MaxLength = 50;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(278, 26);
            this.txtBuscador.TabIndex = 3;
            // 
            // labNombre
            // 
            this.labNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(16, 24);
            this.labNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(70, 20);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Buscador:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(41, 354);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(541, 131);
            this.dgvLista.TabIndex = 3;
            this.dgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(551, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Gestión de Iva";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEstablecerIva
            // 
            this.btnEstablecerIva.Location = new System.Drawing.Point(328, 89);
            this.btnEstablecerIva.Name = "btnEstablecerIva";
            this.btnEstablecerIva.Size = new System.Drawing.Size(220, 31);
            this.btnEstablecerIva.TabIndex = 7;
            this.btnEstablecerIva.Text = "Establecer Como IVA Principal";
            this.btnEstablecerIva.UseVisualStyleBackColor = true;
            this.btnEstablecerIva.Click += new System.EventHandler(this.btnEstablecerIva_Click);
            // 
            // FrmCRD_Iva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 531);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCRD_Iva";
            this.Text = "FrmIva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdIva;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnRazonSocial;
        private System.Windows.Forms.RadioButton rbtnCodProveedor;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEstablecerIva;
    }
}