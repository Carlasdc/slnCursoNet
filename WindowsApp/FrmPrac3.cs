using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.EntidadesPrac3;

namespace WindowsApp
{
    public partial class FrmPrac3 : Form
    {
        public FrmPrac3()
        {
            InitializeComponent();
        }

        private Autor autor;
        private Autor autor2;
        private void btnCrearObj_Click(object sender, EventArgs e)
        {
            autor = new Autor();
            autor.Nombre = "Jorge Luis";
            autor.Apellido = "Borges";
            autor.FechaNacimiento = new DateTime(1899,08,26);
            autor.Ciudad = "Buenos Aires";
            autor.Domicilio = "Maipu 994";
            autor.Pais = "Argentna";

            MessageBox.Show("El autor "+ autor.Nombre + " "+ autor.Apellido + " , nacio el dia "+ autor.FechaNacimiento + " en "+ autor.Ciudad + " , " + autor.Pais);

            autor2 = new Autor();
            autor2.Nombre = "Agatha";
            autor2.Apellido = "Christie";
            autor2.FechaNacimiento = new DateTime(1890, 09, 15);
            autor2.Ciudad = "Devon";
            autor2.Domicilio = "Torquay";
            autor2.Pais = "Reino Unido";

            MessageBox.Show("El autor " + autor2.Nombre + " " + autor2.Apellido + " , nacio el dia " + autor2.FechaNacimiento + " en " + autor2.Ciudad + " , " + autor2.Pais);

        }
    }
}
