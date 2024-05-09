using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoCorreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Métodos de eventos que le piqué por error
        private void txtBoxDestinatario1_TextChanged(object sender, EventArgs e)
        {

        }

        //Métodos de eventos que le piqué por error
        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Evento click del botón 1 que envía el correo al usuario 2
        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            string remitente = txtBoxRemitente1.Text;
            string destinatario = txtBoxDestinatario1.Text;
            string asunto = txtBoxAsunto1.Text;
            string mensaje = txtBoxMensaje1.Text;
            string[] palabrasSpam = { "Gratis", "Oferta", "Promoción" };
            string[] enlacesCortos = {"bit.ly","tiny.url","ow.ly","goo.gl","http"};

            if (string.IsNullOrEmpty(remitente) || string.IsNullOrEmpty(destinatario) || string.IsNullOrEmpty(asunto) || string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Por favor ingrese los datos completos.");
                txtBoxRemitente1.Clear();
                txtBoxDestinatario1.Clear();
                txtBoxAsunto1.Clear();
                txtBoxMensaje1.Clear();
            }
            else
            {
                if (comprobarSpam())
                {
                    if (comprobarEnlaceCortado())
                    {
                        MessageBox.Show("El mensaje contiene un enlace acortado o poco seguro, se recomienda evitar o revisar detenidamente su confiabilidad.");
                    }
                    listBoxSPAM2.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                    txtBoxRemitente1.Clear();
                    txtBoxDestinatario1.Clear();
                    txtBoxAsunto1.Clear();
                    txtBoxMensaje1.Clear();
                    listBoxEnviados1.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                } else
                {
                    if (comprobarEnlaceCortado())
                    {
                        MessageBox.Show("El mensaje contiene un enlace acortado o poco seguro, se recomienda evitar o revisar detenidamente su confiabilidad.");
                    }
                    listBoxEnviados1.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                    txtBoxRemitente1.Clear();
                    txtBoxDestinatario1.Clear();
                    txtBoxAsunto1.Clear();
                    txtBoxMensaje1.Clear();
                    listBoxRecibidos2.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                }
            }
            
            bool comprobarSpam()
            {
                foreach (string palabra in palabrasSpam)
                {
                    if (mensaje.ToLower().Contains(palabra.ToLower()))
                    {
                        return true;
                    }
                }
                return false;
            }

            bool comprobarEnlaceCortado()
            {
                foreach (string enlace in enlacesCortos)
                {
                    if (mensaje.ToLower().Contains(enlace.ToLower()))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //Evento click del botón 2 que envía el correo al usuario 1
        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            string remitente = txtBoxRemitente2.Text;
            string destinatario = txtBoxDestinatario2.Text;
            string asunto = txtBoxAsunto2.Text;
            string mensaje = txtBoxMensaje2.Text;
            string[] palabrasSpam = { "Gratis", "Oferta", "Promoción" };
            if (string.IsNullOrEmpty(remitente) || string.IsNullOrEmpty(destinatario) || string.IsNullOrEmpty(asunto) || string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Por favor ingrese los datos completos.");
                txtBoxRemitente2.Clear();
                txtBoxDestinatario2.Clear();
                txtBoxAsunto2.Clear();
                txtBoxMensaje2.Clear();
            }
            else
            {
                if (comprobarSpam())
                {
                    listBoxSPAM1.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                    txtBoxRemitente2.Clear();
                    txtBoxDestinatario2.Clear();
                    txtBoxAsunto2.Clear();
                    txtBoxMensaje2.Clear();
                }
                else
                {
                    listBoxEnviados2.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                    txtBoxRemitente2.Clear();
                    txtBoxDestinatario2.Clear();
                    txtBoxAsunto2.Clear();
                    txtBoxMensaje2.Clear();
                    listBoxRecibidos1.Items.Add(remitente + "," + destinatario + "," + asunto + "," + mensaje);
                }
            }

            bool comprobarSpam()
            {
                foreach (string palabra in palabrasSpam)
                {
                    if (mensaje.ToLower().Contains(palabra.ToLower()))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
