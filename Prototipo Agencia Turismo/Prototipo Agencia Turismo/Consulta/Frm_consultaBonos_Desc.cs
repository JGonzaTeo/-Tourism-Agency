﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Agencia_Turismo.Consulta
{
    public partial class Frm_consultaBonos_Desc : Form
    {
        String nombre;
        public Frm_consultaBonos_Desc()
        {
            InitializeComponent();
        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void MostrarConsulta()
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_bonos_descuentos WHERE Estado='0';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, Conexion.nuevaConexion());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaBonoYDesc.Refresh();
                    Dgv_consultaBonoYDesc.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Frm_consultaBonos_Desc_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaBonoYDesc.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaBonoYDesc.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
             Dgv_consultaBonoYDesc.Rows.Clear();
               nombre = Txt_consultaGuiaturistico.Text;
                try
                {
                    OdbcCommand comm = new OdbcCommand("{call Sp_BuscarBonosYDesc(?)}", Conexion.nuevaConexion());
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("nom", OdbcType.Text).Value = nombre;
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaBonoYDesc.Refresh();
                        Dgv_consultaBonoYDesc.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                             mostrarDatos.GetString(3));
                    }
                }
                   
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
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
