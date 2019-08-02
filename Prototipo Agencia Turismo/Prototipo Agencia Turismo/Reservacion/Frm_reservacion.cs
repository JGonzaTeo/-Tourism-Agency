﻿/* 
 -----------------------------------------------------
            AUTOR: Ivan Mogollón
  -----------------------------------------------------
*/

using Prototipo_Agencia_Turismo.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo
{
    public partial class Frm_reservacion : Form
    {
        IPHostEntry host;
        string localIP = "?";
        string usuario = "";
        DateTime fechai = DateTime.Now;
        //Reservacion
        String idCotizacion;
        String idReservacion;
        String tipoPago;
        //Asig Transp
        String idTrasnporte;
        String idEmpleado;
        String fechaSalida;
        String fechaEntrada;

        public Frm_reservacion(String nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }

        private void Frm_reservacion_Load(object sender, EventArgs e)
        {
            
        }

        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_facturadetalle WHERE Pk_idFactura= "+Lbl_idCotizacion+";";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_detalleFactura.Refresh();
                    Dgv_detalleFactura.Rows.Add(mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Btn_busquedaCotizacion_Click(object sender, EventArgs e)
        {
                 Frm_consultaCotizacion conCotizacion = new Frm_consultaCotizacion();
                 conCotizacion.ShowDialog();

                if (conCotizacion.DialogResult == DialogResult.OK)
                {
                    Lbl_idCotizacion.Text = conCotizacion.Dgv_consultaCotizacion.Rows[conCotizacion.Dgv_consultaCotizacion.CurrentRow.Index].
                    Cells[0].Value.ToString();
                    Lbl_nombCliente.Text = conCotizacion.Dgv_consultaCotizacion.Rows[conCotizacion.Dgv_consultaCotizacion.CurrentRow.Index].
                    Cells[1].Value.ToString();
                    
            }
            Dgv_detalleFactura.Rows.Clear();
            Dgv_detalleFactura.Refresh();
            MostrarConsulta();   
        }

        private void Btn_consultarMetodoPago_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoPago conPago = new Frm_consultaTipoPago();
            conPago.ShowDialog();

            if (conPago.DialogResult == DialogResult.OK)
            {
                Lbl_metodo.Text = conPago.Dgv_consultaPago.Rows[conPago.Dgv_consultaPago.CurrentRow.Index].
                    Cells[0].Value.ToString();              
            }
        }

        private void Btn_consultarVehiculo_Click(object sender, EventArgs e)
        {
            Consulta.Frm_consultaTransporte conTransporte = new Consulta.Frm_consultaTransporte();
            conTransporte.ShowDialog();

            if (conTransporte.DialogResult == DialogResult.OK)
            {
                Lbl_vehiculo.Text =
                    conTransporte.Dgv_consultaTransporte.Rows[conTransporte.Dgv_consultaTransporte.CurrentRow.Index].
                    Cells[0].Value.ToString();

            }
        }

        private void Btn_consultarPiloto_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado con_Emp = new Frm_consultaEmpleado();
            con_Emp.ShowDialog();

            if (con_Emp.DialogResult == DialogResult.OK)
            {
                Lbl_piloto.Text = con_Emp.Dgv_consultaEmpleados.Rows[con_Emp.Dgv_consultaEmpleados.CurrentRow.Index].
                    Cells[0].Value.ToString();
            }
        }
        
        private void Limpiar()
        {
            Lbl_idReservacion.Text = "";
            Lbl_idCotizacion.Text = "";
            Lbl_nombCliente.Text = "";
            Lbl_metodo.Text = "";
            Lbl_vehiculo.Text = "";
            Lbl_piloto.Text = "";
            Dtp_FecaEntrada.Value = Dtp_FecaEntrada.Value.Date;
            Dtp_FecaSalida.Value = Dtp_FecaSalida.Value.Date;
            Dgv_detalleFactura.Rows.Clear();
            Dgv_detalleFactura.Refresh();
        }
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Btn_reservar_Click(object sender, EventArgs e)
        {
            //Reservacion
            idCotizacion = Lbl_idCotizacion.Text;
            tipoPago = Lbl_metodo.Text;
            //Asig Transp
            idTrasnporte = Lbl_vehiculo.Text;
            idEmpleado = Lbl_piloto.Text;
            fechaSalida = Dtp_FecaSalida.Text;
            fechaEntrada = Dtp_FecaEntrada.Text;
            
            try
            {

                OdbcCommand comm2 = new OdbcCommand("{call Sp_InsertarReservacion(?,?)}", Conexion.nuevaConexion());
                comm2.CommandType = CommandType.StoredProcedure;
                comm2.Parameters.Add("idCotizacion", OdbcType.Text).Value = idCotizacion;
                comm2.Parameters.Add("idPago", OdbcType.Text).Value = tipoPago;
                comm2.ExecuteNonQuery(); MessageBox.Show("Reservacion creada exitosamente");

                string consultaMostrar = "select * from tbl_reservacion order by PK_idReservacion desc limit 1;";
                OdbcCommand comm3 = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm3.ExecuteReader();
                while (mostrarDatos.Read())
                {
                    idReservacion = mostrarDatos.GetString(0);
                }
                /*
                int x = 0;

                Int32.TryParse(idReservacion,out x);
                if (x == 0)
                  */
                if (idReservacion == "NULL")
                    Lbl_reservacion.Text = "0";
                else
                    Lbl_reservacion.Text = idReservacion;

                OdbcCommand comm = new OdbcCommand("{call Sp_InsertarAsigacionTransporte(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("idTransporte", OdbcType.Text).Value = idTrasnporte;
                comm.Parameters.Add("idReservacion", OdbcType.Text).Value = idReservacion;
                comm.Parameters.Add("idEmpleado", OdbcType.Text).Value = idEmpleado;
                comm.Parameters.Add("salida", OdbcType.Text).Value = fechaSalida;
                comm.Parameters.Add("entrada", OdbcType.Text).Value = fechaEntrada;
                comm.ExecuteNonQuery(); MessageBox.Show("Reservacion transporte");

                
                OdbcCommand comm1 = new OdbcCommand("{call SP_InsertarBitacora(?,?,?,?,?)}", Conexion.nuevaConexion());
                comm1.CommandType = CommandType.StoredProcedure;
                comm1.Parameters.Add("ope", OdbcType.Text).Value = "CREACION DE RESERVACION/ASIGNACION TRANSPORTE";
                comm1.Parameters.Add("usr", OdbcType.Text).Value = usuario;
                comm1.Parameters.Add("fecha", OdbcType.Text).Value = fechai.ToString("yyyy/MM/dd HH:mm:ss");
                comm1.Parameters.Add("proc", OdbcType.Text).Value = "Empleado";
                comm1.Parameters.Add("dirIp", OdbcType.Text).Value = localIP;
                comm1.ExecuteNonQuery();
                
                Limpiar();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show("Error al intentar reservar.");
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
