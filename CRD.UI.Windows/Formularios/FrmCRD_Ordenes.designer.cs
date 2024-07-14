namespace CRD.UI.Windows.Formularios
{
    partial class FrmCRD_Ordenes
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoProveedorPrinciapal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPersonaReferenciada = new System.Windows.Forms.TextBox();
            this.txtCodigoSistema = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescuentoProveedor = new System.Windows.Forms.TextBox();
            this.txtLiberado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescuentoCompania = new System.Windows.Forms.TextBox();
            this.txtNombreProveedorPrincipal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBienesFacturadosRecibidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaOrden = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImporteBruto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(45, 488);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(734, 133);
            this.dgvLista.TabIndex = 3;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBuscador);
            this.groupBox1.Controls.Add(this.txtBuscador);
            this.groupBox1.Controls.Add(this.labNombre);
            this.groupBox1.Location = new System.Drawing.Point(35, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(347, 52);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(86, 26);
            this.btnBuscador.TabIndex = 4;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscador.Location = new System.Drawing.Point(25, 52);
            this.txtBuscador.MaxLength = 50;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(303, 26);
            this.txtBuscador.TabIndex = 3;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // labNombre
            // 
            this.labNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(21, 29);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(211, 20);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Buscador Por Numero de Orden :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dgvLista);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(127, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 647);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCodigoProveedorPrinciapal);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPersonaReferenciada);
            this.groupBox2.Controls.Add(this.txtCodigoSistema);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDescuentoProveedor);
            this.groupBox2.Controls.Add(this.txtLiberado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDescuentoCompania);
            this.groupBox2.Controls.Add(this.txtNombreProveedorPrincipal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBienesFacturadosRecibidos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFechaOrden);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIva);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtImporteBruto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtCompania);
            this.groupBox2.Controls.Add(this.txtNumeroOrden);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(35, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 312);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Compañia:";
            // 
            // txtCodigoProveedorPrinciapal
            // 
            this.txtCodigoProveedorPrinciapal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoProveedorPrinciapal.Location = new System.Drawing.Point(282, 149);
            this.txtCodigoProveedorPrinciapal.Name = "txtCodigoProveedorPrinciapal";
            this.txtCodigoProveedorPrinciapal.Size = new System.Drawing.Size(189, 26);
            this.txtCodigoProveedorPrinciapal.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Descuento Proveedor:";
            // 
            // txtPersonaReferenciada
            // 
            this.txtPersonaReferenciada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonaReferenciada.Location = new System.Drawing.Point(25, 251);
            this.txtPersonaReferenciada.Name = "txtPersonaReferenciada";
            this.txtPersonaReferenciada.Size = new System.Drawing.Size(189, 26);
            this.txtPersonaReferenciada.TabIndex = 35;
            // 
            // txtCodigoSistema
            // 
            this.txtCodigoSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoSistema.Location = new System.Drawing.Point(282, 97);
            this.txtCodigoSistema.Name = "txtCodigoSistema";
            this.txtCodigoSistema.Size = new System.Drawing.Size(189, 26);
            this.txtCodigoSistema.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(535, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Liberado:";
            // 
            // txtDescuentoProveedor
            // 
            this.txtDescuentoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuentoProveedor.Location = new System.Drawing.Point(282, 253);
            this.txtDescuentoProveedor.Name = "txtDescuentoProveedor";
            this.txtDescuentoProveedor.Size = new System.Drawing.Size(189, 26);
            this.txtDescuentoProveedor.TabIndex = 33;
            // 
            // txtLiberado
            // 
            this.txtLiberado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiberado.Location = new System.Drawing.Point(539, 253);
            this.txtLiberado.Name = "txtLiberado";
            this.txtLiberado.Size = new System.Drawing.Size(189, 26);
            this.txtLiberado.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo Sistema:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Nombre Proveedor Principal:";
            // 
            // txtDescuentoCompania
            // 
            this.txtDescuentoCompania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuentoCompania.Location = new System.Drawing.Point(282, 201);
            this.txtDescuentoCompania.Name = "txtDescuentoCompania";
            this.txtDescuentoCompania.Size = new System.Drawing.Size(189, 26);
            this.txtDescuentoCompania.TabIndex = 21;
            // 
            // txtNombreProveedorPrincipal
            // 
            this.txtNombreProveedorPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProveedorPrincipal.Location = new System.Drawing.Point(25, 149);
            this.txtNombreProveedorPrincipal.Name = "txtNombreProveedorPrincipal";
            this.txtNombreProveedorPrincipal.Size = new System.Drawing.Size(189, 26);
            this.txtNombreProveedorPrincipal.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Descuento Compañia:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Bienes Facturados Recibidos:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Código Proveedor Principal:";
            // 
            // txtBienesFacturadosRecibidos
            // 
            this.txtBienesFacturadosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBienesFacturadosRecibidos.Location = new System.Drawing.Point(539, 201);
            this.txtBienesFacturadosRecibidos.Name = "txtBienesFacturadosRecibidos";
            this.txtBienesFacturadosRecibidos.Size = new System.Drawing.Size(189, 26);
            this.txtBienesFacturadosRecibidos.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Orden:";
            // 
            // txtFechaOrden
            // 
            this.txtFechaOrden.Location = new System.Drawing.Point(25, 97);
            this.txtFechaOrden.Name = "txtFechaOrden";
            this.txtFechaOrden.Size = new System.Drawing.Size(189, 26);
            this.txtFechaOrden.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "IVA:";
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.Location = new System.Drawing.Point(539, 97);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(189, 26);
            this.txtIva.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Importe Bruto:";
            // 
            // txtImporteBruto
            // 
            this.txtImporteBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteBruto.Location = new System.Drawing.Point(539, 149);
            this.txtImporteBruto.Name = "txtImporteBruto";
            this.txtImporteBruto.Size = new System.Drawing.Size(189, 26);
            this.txtImporteBruto.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Persona Referenciada:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(539, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(189, 26);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // txtCompania
            // 
            this.txtCompania.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompania.Location = new System.Drawing.Point(25, 201);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(189, 26);
            this.txtCompania.TabIndex = 15;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(25, 45);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(189, 26);
            this.txtNumeroOrden.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero Orden:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCRD_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCRD_Ordenes";
            this.Text = "FrmCRD_Ordenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoSistema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImporteBruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescuentoCompania;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPersonaReferenciada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescuentoProveedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLiberado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombreProveedorPrincipal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigoProveedorPrinciapal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBienesFacturadosRecibidos;
    }
}