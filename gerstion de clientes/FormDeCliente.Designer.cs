namespace gerstion_de_clientes
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            panel1 = new Panel();
            label1 = new Label();
            lblIdcliente = new Label();
            txtIdCliente = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            dgvClientes = new DataGridView();
            colIdCliente = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(189, 20);
            label1.Name = "label1";
            label1.Size = new Size(516, 32);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE GESTION DE CLIENTES";
            // 
            // lblIdcliente
            // 
            lblIdcliente.AutoSize = true;
            lblIdcliente.Location = new Point(32, 35);
            lblIdcliente.Name = "lblIdcliente";
            lblIdcliente.Size = new Size(68, 15);
            lblIdcliente.TabIndex = 1;
            lblIdcliente.Text = "ID Cliente :";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(106, 32);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(210, 23);
            txtIdCliente.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(106, 127);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 130);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido :";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(379, 35);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(61, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "telefono :";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(468, 27);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(468, 78);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(260, 23);
            txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(379, 86);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(51, 15);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo :";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ButtonFace;
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(66, 281);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(111, 32);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "📄 Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(205, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 33);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(341, 281);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 32);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "✏️Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(468, 127);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(260, 23);
            txtDireccion.TabIndex = 14;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(379, 135);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(66, 15);
            lblDireccion.TabIndex = 15;
            lblDireccion.Text = "Direccion :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIdcliente);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(lblCorreo);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 173);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(480, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 33);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "🗑️Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(621, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 33);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "❌Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colIdCliente, colNombre, colApellido, colTelefono, colCorreo, colDireccion });
            dgvClientes.Location = new Point(6, 20);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(829, 140);
            dgvClientes.TabIndex = 19;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // colIdCliente
            // 
            colIdCliente.DataPropertyName = "IdCliente";
            colIdCliente.HeaderText = "ID Cliente";
            colIdCliente.Name = "colIdCliente";
            colIdCliente.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.DataPropertyName = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.HeaderText = "Telefono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.DataPropertyName = "Correo";
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.DataPropertyName = "Direccion";
            colDireccion.HeaderText = "Direccion";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvClientes);
            groupBox2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(841, 166);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 511);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox1);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblIdcliente;
        private TextBox txtIdCliente;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnActualizar;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridView dgvClientes;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn colIdCliente;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colDireccion;
        private PictureBox pictureBox1;
    }
}
