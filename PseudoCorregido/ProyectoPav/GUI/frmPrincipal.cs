﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ProyectoPav
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
           
        }

        public void cargarLista(ListBox lista, String tabla, string display, string value)
        {
            BDHelper oDatos = new BDHelper();
            lista.DataSource = oDatos.consulta_oldb("select * from Users");
            lista.DisplayMember = display;
            lista.ValueMember = value;
            lista.SelectedIndex = -1;
        }

        public void llenarCombo(ComboBox combo, String tabla, string display, string value)
        {
            BDHelper oDatos = new BDHelper();
            combo.DataSource = oDatos.consulta_oldb("select * from Users");
            combo.DisplayMember = display;
            combo.ValueMember = value;
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            new frmLogIn().ShowDialog();
        }
        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            frmUsuarios open = new frmUsuarios();
            open.ShowDialog();
        }

    }
}