using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExcepcionesEjemplo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try


            {
                // Convertimos el texto ingresado en los cuadros a números enteros
                int numero1 = int.Parse(txtNumero1.Text);
                int numero2 = int.Parse(txtNumero2.Text);

                // Realizamos la división
                int resultado = numero1 / numero2;

                // Mostramos el resultado en la etiqueta correspondiente
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
                // Ocurre si el usuario escribe letras u otros símbolos no válidos
                MessageBox.Show("Por favor, introduce números válidos.", "Error de Formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DivideByZeroException)
            {
                // Ocurre si el divisor es cero
                MessageBox.Show("No es posible dividir entre cero.", "División por cero",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Cubre cualquier otro tipo de error inesperado
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Siempre se ejecuta, ocurra o no un error
                txtNumero1.Clear();
                txtNumero2.Clear();
                txtNumero1.Focus();
            }
        }
    }
}
