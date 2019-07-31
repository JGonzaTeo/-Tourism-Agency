﻿namespace Prototipo_Agencia_Turismo
{
    partial class Frm_reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reservacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Lbl_nomCliente = new System.Windows.Forms.Label();
            this.Lbl_idCotizacion = new System.Windows.Forms.Label();
            this.Lbl_idCliente = new System.Windows.Forms.Label();
            this.Lbl_reservacion = new System.Windows.Forms.Label();
            this.Lbl_idReservacion = new System.Windows.Forms.Label();
            this.Lbl_metodo = new System.Windows.Forms.Label();
            this.Lbl_metodoPago = new System.Windows.Forms.Label();
            this.Lbl_fechaSalida = new System.Windows.Forms.Label();
            this.Lbl_piloto = new System.Windows.Forms.Label();
            this.Lbl_idPiloto = new System.Windows.Forms.Label();
            this.Lbl_vehiculo = new System.Windows.Forms.Label();
            this.Lbl_idVehiculo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_detalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_consultarPiloto = new System.Windows.Forms.Button();
            this.Btn_consultarVehiculo = new System.Windows.Forms.Button();
            this.Btn_consultarMetodoPago = new System.Windows.Forms.Button();
            this.Btn_busquedaCotizacion = new System.Windows.Forms.Button();
            this.Btn_reservar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 1;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(24, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(102, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "RESERVACION";
            // 
            // Dgv_detalleFactura
            // 
            this.Dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleFactura.Location = new System.Drawing.Point(28, 278);
            this.Dgv_detalleFactura.Name = "Dgv_detalleFactura";
            this.Dgv_detalleFactura.RowTemplate.Height = 24;
            this.Dgv_detalleFactura.Size = new System.Drawing.Size(904, 272);
            this.Dgv_detalleFactura.TabIndex = 24;
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.Location = new System.Drawing.Point(196, 111);
            this.Lbl_empleado.Name = "Lbl_empleado";
            this.Lbl_empleado.Size = new System.Drawing.Size(93, 20);
            this.Lbl_empleado.TabIndex = 23;
            this.Lbl_empleado.Text = "nomCliente";
            // 
            // Lbl_nomCliente
            // 
            this.Lbl_nomCliente.AutoSize = true;
            this.Lbl_nomCliente.Location = new System.Drawing.Point(8, 111);
            this.Lbl_nomCliente.Name = "Lbl_nomCliente";
            this.Lbl_nomCliente.Size = new System.Drawing.Size(153, 20);
            this.Lbl_nomCliente.TabIndex = 22;
            this.Lbl_nomCliente.Text = "Nombre del cliente:";
            // 
            // Lbl_idCotizacion
            // 
            this.Lbl_idCotizacion.AutoSize = true;
            this.Lbl_idCotizacion.Location = new System.Drawing.Point(196, 62);
            this.Lbl_idCotizacion.Name = "Lbl_idCotizacion";
            this.Lbl_idCotizacion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_idCotizacion.TabIndex = 21;
            this.Lbl_idCotizacion.Text = "idCotizacion";
            // 
            // Lbl_idCliente
            // 
            this.Lbl_idCliente.AutoSize = true;
            this.Lbl_idCliente.Location = new System.Drawing.Point(8, 62);
            this.Lbl_idCliente.Name = "Lbl_idCliente";
            this.Lbl_idCliente.Size = new System.Drawing.Size(133, 20);
            this.Lbl_idCliente.TabIndex = 20;
            this.Lbl_idCliente.Text = "ID de cotizacion:";
            // 
            // Lbl_reservacion
            // 
            this.Lbl_reservacion.AutoSize = true;
            this.Lbl_reservacion.Location = new System.Drawing.Point(196, 16);
            this.Lbl_reservacion.Name = "Lbl_reservacion";
            this.Lbl_reservacion.Size = new System.Drawing.Size(114, 20);
            this.Lbl_reservacion.TabIndex = 19;
            this.Lbl_reservacion.Text = "idReservacion";
            // 
            // Lbl_idReservacion
            // 
            this.Lbl_idReservacion.AutoSize = true;
            this.Lbl_idReservacion.Location = new System.Drawing.Point(8, 16);
            this.Lbl_idReservacion.Name = "Lbl_idReservacion";
            this.Lbl_idReservacion.Size = new System.Drawing.Size(141, 20);
            this.Lbl_idReservacion.TabIndex = 18;
            this.Lbl_idReservacion.Text = "ID de reservacion";
            // 
            // Lbl_metodo
            // 
            this.Lbl_metodo.AutoSize = true;
            this.Lbl_metodo.Location = new System.Drawing.Point(196, 155);
            this.Lbl_metodo.Name = "Lbl_metodo";
            this.Lbl_metodo.Size = new System.Drawing.Size(89, 20);
            this.Lbl_metodo.TabIndex = 34;
            this.Lbl_metodo.Text = "idTipoPago";
            // 
            // Lbl_metodoPago
            // 
            this.Lbl_metodoPago.AutoSize = true;
            this.Lbl_metodoPago.Location = new System.Drawing.Point(8, 155);
            this.Lbl_metodoPago.Name = "Lbl_metodoPago";
            this.Lbl_metodoPago.Size = new System.Drawing.Size(141, 20);
            this.Lbl_metodoPago.TabIndex = 33;
            this.Lbl_metodoPago.Text = "Metodo de pago:";
            // 
            // Lbl_fechaSalida
            // 
            this.Lbl_fechaSalida.AutoSize = true;
            this.Lbl_fechaSalida.Location = new System.Drawing.Point(8, 111);
            this.Lbl_fechaSalida.Name = "Lbl_fechaSalida";
            this.Lbl_fechaSalida.Size = new System.Drawing.Size(129, 20);
            this.Lbl_fechaSalida.TabIndex = 40;
            this.Lbl_fechaSalida.Text = "Fecha de salida:";
            // 
            // Lbl_piloto
            // 
            this.Lbl_piloto.AutoSize = true;
            this.Lbl_piloto.Location = new System.Drawing.Point(196, 67);
            this.Lbl_piloto.Name = "Lbl_piloto";
            this.Lbl_piloto.Size = new System.Drawing.Size(62, 20);
            this.Lbl_piloto.TabIndex = 39;
            this.Lbl_piloto.Text = "idPiloto";
            // 
            // Lbl_idPiloto
            // 
            this.Lbl_idPiloto.AutoSize = true;
            this.Lbl_idPiloto.Location = new System.Drawing.Point(8, 67);
            this.Lbl_idPiloto.Name = "Lbl_idPiloto";
            this.Lbl_idPiloto.Size = new System.Drawing.Size(98, 20);
            this.Lbl_idPiloto.TabIndex = 38;
            this.Lbl_idPiloto.Text = "ID de piloto:";
            // 
            // Lbl_vehiculo
            // 
            this.Lbl_vehiculo.AutoSize = true;
            this.Lbl_vehiculo.Location = new System.Drawing.Point(196, 16);
            this.Lbl_vehiculo.Name = "Lbl_vehiculo";
            this.Lbl_vehiculo.Size = new System.Drawing.Size(87, 20);
            this.Lbl_vehiculo.TabIndex = 37;
            this.Lbl_vehiculo.Text = "idVehiculo";
            // 
            // Lbl_idVehiculo
            // 
            this.Lbl_idVehiculo.AutoSize = true;
            this.Lbl_idVehiculo.Location = new System.Drawing.Point(8, 16);
            this.Lbl_idVehiculo.Name = "Lbl_idVehiculo";
            this.Lbl_idVehiculo.Size = new System.Drawing.Size(121, 20);
            this.Lbl_idVehiculo.TabIndex = 36;
            this.Lbl_idVehiculo.Text = "ID de vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fecha de entrada:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(196, 111);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(101, 20);
            this.Lbl_fecha.TabIndex = 48;
            this.Lbl_fecha.Text = "yyyy/mm/dd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "yyyy/mm/dd";
            // 
            // Lbl_detalle
            // 
            this.Lbl_detalle.AutoSize = true;
            this.Lbl_detalle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_detalle.Location = new System.Drawing.Point(25, 248);
            this.Lbl_detalle.Name = "Lbl_detalle";
            this.Lbl_detalle.Size = new System.Drawing.Size(158, 17);
            this.Lbl_detalle.TabIndex = 13;
            this.Lbl_detalle.Text = "DETALLE RESERVACION";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_consultarMetodoPago);
            this.panel1.Controls.Add(this.Btn_busquedaCotizacion);
            this.panel1.Controls.Add(this.Lbl_idReservacion);
            this.panel1.Controls.Add(this.Lbl_reservacion);
            this.panel1.Controls.Add(this.Lbl_metodo);
            this.panel1.Controls.Add(this.Lbl_idCliente);
            this.panel1.Controls.Add(this.Lbl_metodoPago);
            this.panel1.Controls.Add(this.Lbl_idCotizacion);
            this.panel1.Controls.Add(this.Lbl_empleado);
            this.panel1.Controls.Add(this.Lbl_nomCliente);
            this.panel1.Location = new System.Drawing.Point(43, 46);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(401, 188);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_consultarPiloto);
            this.panel2.Controls.Add(this.Btn_consultarVehiculo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Lbl_idVehiculo);
            this.panel2.Controls.Add(this.Lbl_fecha);
            this.panel2.Controls.Add(this.Lbl_vehiculo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Lbl_idPiloto);
            this.panel2.Controls.Add(this.Lbl_piloto);
            this.panel2.Controls.Add(this.Lbl_fechaSalida);
            this.panel2.Location = new System.Drawing.Point(519, 46);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(401, 188);
            this.panel2.TabIndex = 52;
            // 
            // Btn_consultarPiloto
            // 
            this.Btn_consultarPiloto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultarPiloto.FlatAppearance.BorderSize = 3;
            this.Btn_consultarPiloto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultarPiloto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultarPiloto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultarPiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultarPiloto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultarPiloto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultarPiloto.Image")));
            this.Btn_consultarPiloto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultarPiloto.Location = new System.Drawing.Point(334, 51);
            this.Btn_consultarPiloto.Name = "Btn_consultarPiloto";
            this.Btn_consultarPiloto.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultarPiloto.TabIndex = 60;
            this.Btn_consultarPiloto.Text = "Consultar";
            this.Btn_consultarPiloto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultarPiloto.UseVisualStyleBackColor = false;
            // 
            // Btn_consultarVehiculo
            // 
            this.Btn_consultarVehiculo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultarVehiculo.FlatAppearance.BorderSize = 3;
            this.Btn_consultarVehiculo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultarVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultarVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultarVehiculo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultarVehiculo.Image")));
            this.Btn_consultarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultarVehiculo.Location = new System.Drawing.Point(334, 3);
            this.Btn_consultarVehiculo.Name = "Btn_consultarVehiculo";
            this.Btn_consultarVehiculo.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultarVehiculo.TabIndex = 59;
            this.Btn_consultarVehiculo.Text = "Consultar";
            this.Btn_consultarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultarVehiculo.UseVisualStyleBackColor = false;
            // 
            // Btn_consultarMetodoPago
            // 
            this.Btn_consultarMetodoPago.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultarMetodoPago.FlatAppearance.BorderSize = 3;
            this.Btn_consultarMetodoPago.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultarMetodoPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultarMetodoPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultarMetodoPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultarMetodoPago.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultarMetodoPago.Image")));
            this.Btn_consultarMetodoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultarMetodoPago.Location = new System.Drawing.Point(334, 139);
            this.Btn_consultarMetodoPago.Name = "Btn_consultarMetodoPago";
            this.Btn_consultarMetodoPago.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultarMetodoPago.TabIndex = 60;
            this.Btn_consultarMetodoPago.Text = "Consultar";
            this.Btn_consultarMetodoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultarMetodoPago.UseVisualStyleBackColor = false;
            // 
            // Btn_busquedaCotizacion
            // 
            this.Btn_busquedaCotizacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_busquedaCotizacion.FlatAppearance.BorderSize = 3;
            this.Btn_busquedaCotizacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_busquedaCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_busquedaCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_busquedaCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_busquedaCotizacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_busquedaCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_busquedaCotizacion.Image")));
            this.Btn_busquedaCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_busquedaCotizacion.Location = new System.Drawing.Point(334, 47);
            this.Btn_busquedaCotizacion.Name = "Btn_busquedaCotizacion";
            this.Btn_busquedaCotizacion.Size = new System.Drawing.Size(40, 40);
            this.Btn_busquedaCotizacion.TabIndex = 59;
            this.Btn_busquedaCotizacion.Text = "Consultar";
            this.Btn_busquedaCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_busquedaCotizacion.UseVisualStyleBackColor = false;
            // 
            // Btn_reservar
            // 
            this.Btn_reservar.FlatAppearance.BorderSize = 3;
            this.Btn_reservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_reservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reservar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reservar.Image = global::Prototipo_Agencia_Turismo.Properties.Resources.icons8_guardar_40;
            this.Btn_reservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reservar.Location = new System.Drawing.Point(970, 420);
            this.Btn_reservar.Name = "Btn_reservar";
            this.Btn_reservar.Size = new System.Drawing.Size(175, 43);
            this.Btn_reservar.TabIndex = 32;
            this.Btn_reservar.Text = "Reservar";
            this.Btn_reservar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.FlatAppearance.BorderSize = 3;
            this.Btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = global::Prototipo_Agencia_Turismo.Properties.Resources.icons8_borrar_40;
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminar.Location = new System.Drawing.Point(970, 350);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(175, 43);
            this.Btn_eliminar.TabIndex = 31;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, -5);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 48);
            this.Btn_minimizar.TabIndex = 12;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1100, -5);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 48);
            this.Btn_cerrar.TabIndex = 11;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // Frm_reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_detalle);
            this.Controls.Add(this.Btn_reservar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Dgv_detalleFactura);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_reservacion";
            this.Text = "Frm_reservacion";
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_reservar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView Dgv_detalleFactura;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.Label Lbl_nomCliente;
        private System.Windows.Forms.Label Lbl_idCotizacion;
        private System.Windows.Forms.Label Lbl_idCliente;
        private System.Windows.Forms.Label Lbl_reservacion;
        private System.Windows.Forms.Label Lbl_idReservacion;
        private System.Windows.Forms.Label Lbl_metodo;
        private System.Windows.Forms.Label Lbl_metodoPago;
        private System.Windows.Forms.Label Lbl_fechaSalida;
        private System.Windows.Forms.Label Lbl_piloto;
        private System.Windows.Forms.Label Lbl_idPiloto;
        private System.Windows.Forms.Label Lbl_vehiculo;
        private System.Windows.Forms.Label Lbl_idVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_detalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_consultarMetodoPago;
        private System.Windows.Forms.Button Btn_busquedaCotizacion;
        private System.Windows.Forms.Button Btn_consultarPiloto;
        private System.Windows.Forms.Button Btn_consultarVehiculo;
    }
}