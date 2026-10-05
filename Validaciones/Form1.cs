using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón Salir
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Botón Limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            txtIdEmpleado.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();

            dtpFechaNacimiento.Value = DateTime.Now;
        }

        // Botón Agregar empleado
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar edad
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime hoy = DateTime.Now;

            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > hoy.AddYears(-edad).Date)
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show("El empleado debe tener al menos 18 años.");
                return;
            }

            // Validar ID
            if (!int.TryParse(txtIdEmpleado.Text, out _))
            {
                MessageBox.Show("El ID del empleado debe contener solamente números.");
                return;
            }

            // Validar nombre
            if (!txtNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El nombre debe contener solamente letras.");
                return;
            }

            // Validar apellidos
            if (!txtApellidos.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Los apellidos deben contener solamente letras.");
                return;
            }

            // Validar correo
            if (!txtCorreo.Text.Contains("@") ||
                !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un email válido.");
                return;
            }

            // Validar salario
            if (!decimal.TryParse(txtSalario.Text, out _))
            {
                MessageBox.Show("El salario debe contener solamente números.");
                return;
            }

            dgvEmpleados.Rows.Add(
                txtIdEmpleado.Text,
                txtNombre.Text,
                txtApellidos.Text,
                txtCorreo.Text,
                dtpFechaNacimiento.Value.ToShortDateString(),
                txtSalario.Text
            );

            MessageBox.Show("Empleado agregado correctamente.");
        }+

    }
}