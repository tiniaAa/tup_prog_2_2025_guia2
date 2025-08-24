using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 agregar = new Form2();

            if (agregar.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(agregar.tbDNI.Text);
                string nombre = agregar.tbNombre.Text;

                bool agregado = servicio.AgregarPersona(dni, nombre);

                if (agregado == true)
                {
                    ActualizarLista();
                    MessageBox.Show("Persona agregada exitosamente");

                }
                else { MessageBox.Show("No se agrego la persona "); }

            }
            else
            { MessageBox.Show("Se cancelo la carga de una persona "); }


        }
        public void ActualizarLista()
        {
            listBox1.Items.Clear();


            for (int n = 0; n < servicio.VerCantidadPersona(); n++)
            {
                Persona agregar = servicio.VerPersona(n);
                listBox1.Items.Add(agregar.Describir());
            }


        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            int ver = listBox1.SelectedIndex;
            Form2 form2 = new Form2();
            Persona persona = servicio.VerPersona(ver);
            form2.tbDNI.Enabled = false;
            form2.tbNombre.Enabled = false;

            if (ver != null)
            {
                form2.tbDNI.Text = persona.Dni.ToString();
                form2.tbNombre.Text = persona.Nombre;
                form2.ShowDialog();

            }
            else { MessageBox.Show("Persona no encontrada "); }

            ActualizarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int mod = listBox1.SelectedIndex;
            Form2 form2 = new Form2();

            form2.tbDNI.Enabled = false;
            form2.tbNombre.Enabled = true;
            Persona persona = servicio.VerPersona(mod);
            if (persona != null)
            {
                form2.tbDNI.Text = Convert.ToString(persona.Dni);
                form2.tbNombre.Text = persona.Nombre;

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    string nombre = form2.tbNombre.Text;
                    persona.Nombre = nombre;
                }


            }
            else { MessageBox.Show("No se pudo agrgegar a la persona "); }

            ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int n =listBox1.SelectedIndex;
            Persona eliminar = servicio.VerPersona(n);

            if (eliminar != null)
            {
                servicio.EliminarPersona(eliminar);
                listBox1.Items.Remove(listBox1.SelectedIndex);
                MessageBox.Show("Persona eliminada correctamente ");
            }
            else { MessageBox.Show("No se pudo eliminar la persona "); }
            ActualizarLista();

        }
    }
}
