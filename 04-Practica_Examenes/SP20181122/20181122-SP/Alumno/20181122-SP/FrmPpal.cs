using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;


namespace _20181122_SP
{
  public partial class FrmPpal : Form
  {
    Queue<Patente> cola;
    List<Thread> hilos;


    public FrmPpal()
    {
      InitializeComponent();

      this.cola = new Queue<Patente>();
      this.hilos = new Thread();
    }

    private void FrmPpal_Load(object sender, EventArgs e)
    {
      
    }

    private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void btnXml_Click(object sender, EventArgs e)
    {

    }

    private void btnTxt_Click(object sender, EventArgs e)
    {

    }

    private void btnSql_Click(object sender, EventArgs e)
    {

    }

    private void FinalizarSimulacion()
    {
      foreach(Thread hilo in this.hilos)
      {
        if(hilo.IsAlive)
        {
          hilo.Abort();
        }
      }
    }

    public void ProximaPatente()
    {

    }

    
  }
}
