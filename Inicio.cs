﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADI.Clases.Controladores;
using SADI.Clases.Modelos;
using SADI.Vistas.Usuarios;
using SADI.Clases;

using DatosBD;


namespace SADI
{
    public partial class Inicio : Form
    {
        UsuariosController cUser = new UsuariosController();
        UsuariosModel mUser = new UsuariosModel();
    
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            mUser.Id = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuarios AddUsr = new AgregarUsuarios();
            AddUsr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarUsuariocs upUsr = new modificarUsuariocs();
            upUsr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cUser.PruebaTablaTemp())
            {
                cboRafita.DataSource = cUser.Tabla;
                cboRafita.ValueMember = "id";
                cboRafita.DisplayMember = "descri";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           string u = Utilerias.UserDomain;
            MessageBox.Show("nombre del equipo : " + Utilerias.ComputerName + "\n\n" + 
                 "dirección IP: " + Utilerias.IpAddress + "\n\n" + 
                 "nombre del Dominio : " + Utilerias.NombreDominio + "\n\n" + 
                 "usuario de Dominio : " + Utilerias.UserDomain);
        }
    }
}
