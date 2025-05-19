using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // PARA VALIDAR EL CORREO
using capaLogica;
using capaEntidad;

namespace capaPresentacion
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
            inicializarFormulario();
        }

        // DICCIONARIO DE PROVINCIAS Y CIUDADDES
        Dictionary<string, List<string>> provinciasCiudades = new Dictionary<string, List<string>>
        {
            { "Azuay", new List<string> { "Cuenca", "Gualaceo", "Nabón", "Paute", "Pucará", "Santa Isabel", "Sígsig", "Camilo Ponce Enríquez", "Girón", "Guachapala", "Oña", "San Fernando", "Sevilla de Oro", "Chordeleg", "El Pan" } },
            { "Bolívar", new List<string> { "Guaranda", "Chillanes", "Chimbo", "Echeandía", "Las Naves", "San Miguel", "Caluma" } },
            { "Cañar", new List<string> { "Azogues", "Biblián", "Cañar", "Déleg", "El Tambo", "La Troncal", "Suscal" } },
            { "Carchi", new List<string> { "Tulcán", "Bolívar", "Espejo", "Mira", "Montúfar", "San Pedro de Huaca" } },
            { "Chimborazo", new List<string> { "Riobamba", "Alausí", "Chambo", "Chunchi", "Colta", "Cumandá", "Guamote", "Guano", "Pallatanga", "Penipe" } },
            { "Cotopaxi", new List<string> { "Latacunga", "La Maná", "Pangua", "Pujilí", "Salcedo", "Saquisilí", "Sigchos" } },
            { "El Oro", new List<string> { "Machala", "Arenillas", "Atahualpa", "Balsas", "Chilla", "El Guabo", "Huaquillas", "Las Lajas", "Marcabelí", "Pasaje", "Piñas", "Portovelo", "Santa Rosa", "Zaruma" } },
            { "Esmeraldas", new List<string> { "Esmeraldas", "Atacames", "Eloy Alfaro", "Muisne", "Quinindé", "Rioverde", "San Lorenzo" } },
            { "Galápagos", new List<string> { "Isabela", "San Cristóbal", "Santa Cruz" } },
            { "Guayas", new List<string> { "Guayaquil", "Alfredo Baquerizo Moreno (Jujan)", "Balao", "Balzar", "Colimes", "Daule", "Durán", "El Empalme", "El Triunfo", "General Antonio Elizalde (Bucay)", "General Villamil (Playas)", "Isidro Ayora", "Lomas de Sargentillo", "Marcelino Maridueña", "Milagro", "Naranjal", "Naranjito", "Nobol", "Palestina", "Pedro Carbo", "Salitre", "Samborondón", "Santa Lucía", "Simón Bolívar", "Yaguachi" } },
            { "Imbabura", new List<string> { "Ibarra", "Antonio Ante", "Cotacachi", "Otavalo", "Pimampiro", "San Miguel de Urcuquí" } },
            { "Loja", new List<string> { "Loja", "Calvas", "Catamayo", "Celica", "Chaguarpamba", "Espíndola", "Gonzanamá", "Macará", "Olmedo", "Paltas", "Pindal", "Puyango", "Quilanga", "Saraguro", "Sozoranga", "Zapotillo" } },
            { "Los Ríos", new List<string> { "Babahoyo", "Baba", "Buena Fe", "Mocache", "Montalvo", "Palenque", "Puebloviejo", "Quevedo", "Quinsaloma", "Urdaneta", "Valencia", "Ventanas", "Vinces" } },
            { "Manabí", new List<string> { "Portoviejo", "24 de Mayo", "Bolívar", "Chone", "El Carmen", "Flavio Alfaro", "Jama", "Jaramijó", "Jipijapa", "Junín", "Manta", "Montecristi", "Olmedo", "Paján", "Pedernales", "Pichincha", "Puerto López", "Rocafuerte", "San Vicente", "Santa Ana", "Sucre", "Tosagua" } },
            { "Morona Santiago", new List<string> { "Macas", "Gualaquiza", "Huamboya", "Limón Indanza", "Logroño", "Morona", "Pablo Sexto", "Palora", "San Juan Bosco", "Santiago", "Sucúa", "Taisha", "Tiwintza" } },
            { "Napo", new List<string> { "Tena", "Archidona", "Carlos Julio Arosemena Tola", "El Chaco", "Quijos" } },
            { "Orellana", new List<string> { "Francisco de Orellana", "Aguarico", "La Joya de los Sachas", "Loreto" } },
            { "Pastaza", new List<string> { "Puyo", "Arajuno", "Mera", "Santa Clara" } },
            { "Pichincha", new List<string> { "Quito", "Cayambe", "Mejía", "Pedro Moncayo", "Pedro Vicente Maldonado", "Puerto Quito", "Rumiñahui", "San Miguel de los Bancos" } },
            { "Santa Elena", new List<string> { "Santa Elena", "La Libertad", "Salinas" } },
            { "Santo Domingo de los Tsáchilas", new List<string> { "Santo Domingo", "La Concordia" } },
            { "Sucumbíos", new List<string> { "Nueva Loja", "Cascales", "Cuyabeno", "Gonzalo Pizarro", "Putumayo", "Shushufindi", "Sucumbíos" } },
            { "Tungurahua", new List<string> { "Ambato", "Baños de Agua Santa", "Cevallos", "Mocha", "Patate", "Quero", "San Pedro de Pelileo", "Santiago de Píllaro", "Tisaleo" } },
            { "Zamora Chinchipe", new List<string> { "Zamora", "Centinela del Cóndor", "Chinchipe", "El Pangui", "Nangaritza", "Palanda", "Paquisha", "Yacuambi", "Yantzaza" } }
        };
        public void inicializarFormulario()
        {
            this.ActiveControl = null;
            pctrLogotipo.Image = Image.FromFile("Recursos/Imagenes/logotipo.jpg");
        }

        classPuente puente = new classPuente();
        Cliente cliente = new Cliente();
        private const string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // patron que debe tener para ser correo valido: a@a.a

        private void btnCrearUsuarioCliente_Click_1(object sender, EventArgs e)
        {            
            if (puente.validarCedulaa(txtCedulaCliente.Texts.ToString()))
            {
                if(!puente.existeUsuario(txtNombreUsuarioCliente.Texts))
                {
                    if (Regex.IsMatch(txtEmailCliente.Texts, patronCorreo))
                    {
                        if (!string.IsNullOrWhiteSpace(txtNombreCliente.Texts) && !string.IsNullOrWhiteSpace(txtApellidoCliente.Texts) && !string.IsNullOrWhiteSpace(txtEmailCliente.Texts) && !string.IsNullOrWhiteSpace(txtDireccionCliente.Texts) && cmbxCuidad.SelectedIndex != -1 && cmbxGeneroCliente.SelectedIndex != -1 && cmbxProvincia.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtNombreUsuarioCliente.Texts) && !string.IsNullOrWhiteSpace(txtContraseniaUsuarioCliente.Texts))
                        {
                            Cliente clienteNuevo = new Cliente
                            {
                                cedulaCliente = txtCedulaCliente.Texts,
                                nombreCliente = txtNombreCliente.Texts,
                                apellidoCliente = txtApellidoCliente.Texts,
                                generoCliente = cmbxGeneroCliente.Texts[0],
                                direccionCliente = txtDireccionCliente.Texts,
                                ciudadCliente = cmbxCuidad.Texts,
                                provinciaCliente = cmbxProvincia.Texts,
                                correoCliente = txtEmailCliente.Texts,
                                userCliente = txtNombreUsuarioCliente.Texts,
                                passCliente = txtContraseniaUsuarioCliente.Texts
                                // como no tiene pasaporte no se pone nada 
                            };
                            if (puente.ingresarrCliente(clienteNuevo))
                            {
                                MessageBox.Show("Cliente agregado");
                                this.Close();
                            }
                            else
                            {
                                if (puente.existeCliente(txtCedulaCliente.Texts))
                                {
                                    MessageBox.Show("Cliente NO agregado, esa cedula ya existe");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe llenar todos los campos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un correo valido");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe alguien con ese Usuario");
                }
            }
            else
            {
                txtCedulaCliente.Texts = "";
                MessageBox.Show("NOO ES UNA CEDULA LEGAL");
            }
        }






        private void btnAtras_MouseEnter(object sender, EventArgs e)
        {
            btnAtras.Font = new Font(btnAtras.Font, FontStyle.Underline);

        }

        private void btnAtras_MouseLeave(object sender, EventArgs e)
        {
            btnAtras.Font = new Font(btnAtras.Font, FontStyle.Regular);
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            btnAtras.ForeColor = Color.Firebrick;
            btnAtras.IconColor = Color.Firebrick;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroCliente_Load(object sender, EventArgs e)
        {
            cmbxProvincia.DataSource = new BindingSource(provinciasCiudades.Keys.ToList(), null);
        }

        

        private void cmbxProvincia_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string provinciaSeleccionada = cmbxProvincia.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(provinciaSeleccionada) && provinciasCiudades.ContainsKey(provinciaSeleccionada))
            {
                cmbxCuidad.Items.Clear();
                cmbxCuidad.Items.AddRange(provinciasCiudades[provinciaSeleccionada].ToArray());
            }
        }
    }
}
