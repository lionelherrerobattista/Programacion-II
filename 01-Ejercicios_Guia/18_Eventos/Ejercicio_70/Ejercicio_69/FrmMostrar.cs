﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69
{
    public partial class FrmMostrar : Form
    {

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string nombre)
        {
            this.lblEtiqueta.Text = nombre;
        }

        public void ActualizarFoto(string ruta)
        {
            this.pictureBox1.ImageLocation = ruta;
        }

    }
}
