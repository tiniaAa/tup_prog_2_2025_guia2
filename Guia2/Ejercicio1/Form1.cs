using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }








        public void ActualizarLista()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < servicio.VerCantidadPersonas(); i++)
            {
                Persona agregar = servicio.VerPersoa(i);
                listBox1.Items.Add(agregar.Describir());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 datos = new Form2();
            if (datos.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(datos.tbDNI.Text);
                string nombre = datos.tbNombre.Text;
                Persona persona = new Persona(dni, nombre);
                bool agregar = servicio.AgregarPerson(persona);
                if (agregar == true)
                {
                    MessageBox.Show("Persona agregado ");

                }
                else
                {
                    MessageBox.Show("Error al agregar persona ");
                }


            }
            ActualizarLista();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int ver = listBox1.SelectedIndex;
            Form2 form2 = new Form2();
            Persona persona = servicio.VerPersoa(ver);
            form2.tbDNI.Enabled = false;
            form2.tbNombre.Enabled = false;
            if (persona != null)
            {
                form2.tbDNI.Text = persona.DNI.ToString();
                form2.tbNombre.Text = persona.NOMBRE;
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Persona no encontrada ");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int mod = listBox1.SelectedIndex;
            Form2 datos = new Form2();
            datos.tbDNI.Enabled = false;
            datos.tbNombre.Enabled = true;
            Persona pers = servicio.VerPersoa(mod);
            if (pers!=null)
            {
                datos.tbDNI.Text=Convert.ToString(pers.DNI);
                datos.tbNombre.Text=pers.NOMBRE;

                if (datos.ShowDialog()==DialogResult.OK)
                {
                    string nombre = datos.tbNombre.Text;
                    pers.NOMBRE = nombre;   
                }
            }

            ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            Persona eliminar = servicio.VerPersoa(n);
            if (eliminar != null)
            {
                servicio.EliminarPersona(eliminar);
                listBox1.Items.Remove(listBox1.SelectedIndex);
                MessageBox.Show("Persona eliminada correctamente ");
            }
            else
            {
                MessageBox.Show("No se a podido eliminar la persona o hubo un error ");
            }
            ActualizarLista();
        }
    }
}
