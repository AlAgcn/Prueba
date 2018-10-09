﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPav
{
    public partial class frmElegirPaciente : Form
    {
        BDHelper oDatos = new BDHelper();
        public frmElegirPaciente()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string str = "SELECT Nombre,Apellido, dni, Historia_Clinica FROM PACIENTES WHERE 1=1";
            if (!(txtNombre.Text == string.Empty))
                str += " AND Nomnbre='" + txtNombre.Text + "'";
            if (!(txtApellido.Text == string.Empty))
            {
                str += " AND Apellido='" + txtApellido.Text + "'";
            }
            if (!(txtDni.Text == string.Empty))
            {
                str += " AND dni=" + txtDni.Text + "";
            }
            if (!(txtHistoria.Text == string.Empty))
            {
                str += " AND n_historiaclinica=" + txtHistoria.Text + "";
            }
          dgvPacientes.Rows.Clear();
          DataTable aux = new DataTable();
          aux = oDatos.consultaTabla_parametros(str);
          llenarGrilla(dgvPacientes, aux);
        }

        private void llenarGrilla(DataGridView grilla, DataTable data)
        {
            for (int i=0; i<data.Rows.Count; i++)
            {
                grilla.Rows.Add(data.Rows[i]["Nombre"], 
                                data.Rows[i]["Apellido"], 
                                data.Rows[i]["dni"], 
                                data.Rows[i]["n_HistoriaClinica"]);
            }
        }

        private void cmdDetalle_Click(object sender, EventArgs e)
        {
            string str = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
            int histo = int.Parse(dgvPacientes.CurrentRow.Cells[3].Value.ToString());
            frmAtencion form = new frmAtencion(str, histo);
            form.ShowDialog();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
