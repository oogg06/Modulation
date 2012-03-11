using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Modulacion
{
    public partial class Modulador : Form
    {
        CreadorCurvas curvador;
        Graphics dc;
        Color []colores = { Color.Red, Color.Green};
        int posSiguienteColor = 0;
        public Modulador()
        {
            curvador = new CreadorCurvas(); 
            InitializeComponent();
            
            comboNivelesAM.SelectedIndex = 2;
            comboNivelesFM.SelectedIndex = 0;
            comboNivelesPM.SelectedIndex = 1;
            txtNumBinario.Text = "10100110101"; 
            
                        
            evaluar();
        }

        private Color siguienteColor()
        {
            posSiguienteColor++;
            posSiguienteColor = posSiguienteColor % colores.Length;
            return colores[posSiguienteColor];
        }
        /// <summary>
        /// Genera un vector con todas las amplitudes posibles
        /// </summary>
        /// <returns></returns>
        private int[] getAmplitudes()
        {
            int numNiveles = getNumAmplitudes();
            int[] vectorAmplitudes = new int[numNiveles];
            int amplitudInicial = ((panelCurva.Height-40)/2) / numNiveles;
            for (int pos = 0; pos < numNiveles; pos++)
            {
                vectorAmplitudes[pos] = (pos + 1) * amplitudInicial;
            }
            return vectorAmplitudes;

        }
        private int[] getFrecuencias()
        {
            int numFrecuencias = getNumFrecuencias();
            int[] vectorFrecuencias = new int[numFrecuencias];
            for (int pos = 0; pos < numFrecuencias; pos++)
            {
                vectorFrecuencias[pos] = pos + 1;
            }
            return vectorFrecuencias;
        }
        private float[] getFases()
        {
            int numFases = getNumFases();
            float[] vectorFases = new float[numFases];
            float delta = (float)Math.PI * 2 / numFases;
            for (int pos = 0; pos < numFases; pos++)
            {
                vectorFases[pos] = pos * delta;
            }
            return vectorFases;
        }
        private void txtNumBinario_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private int getNumAmplitudes()
        {
            if (comboNivelesAM.SelectedIndex == -1)
                comboNivelesAM.SelectedIndex = 0;
            int numAmplitudes = (int)Math.Pow(2, comboNivelesAM.SelectedIndex);
            return numAmplitudes;
        }

        private string extraerBits(string cadBinaria, int posInicial, int numNiveles, out int bitsExtraidos)
        {
            int bitsParaExtraer= (int)Math.Log(numNiveles, 2.0);
            if (bitsParaExtraer == 0)
            {
                bitsExtraidos = 0;
                return "0";
            }
            string paraDevolver=cadBinaria.Substring(posInicial, bitsParaExtraer);
            bitsExtraidos = bitsParaExtraer;
            return paraDevolver;
        }
        
        private string puntear(string cadena, int numNiveles)
        {
            int salto = (int)Math.Log(numNiveles, 2);
            int pos = salto;
            string cadenaDevuelta=cadena;
            string separador = ".";
            int posFinal = cadena.Length + (cadena.Length / salto);
            while (pos < posFinal)
            {
                cadenaDevuelta=cadenaDevuelta.Insert(pos, separador);
                pos = pos + 1;
                pos=pos+salto;
            }
            return cadenaDevuelta;
        }
        private bool todoCorrecto()
        {
            string cadenaBits = txtNumBinario.Text;
            
            char bitExaminado;
            int pos;
            for (pos = 0; pos < cadenaBits.Length; pos++)
            {
                bitExaminado = cadenaBits[pos];
                if ((bitExaminado!='0') && (bitExaminado!='1'))
                {
                    return false;
                }
            }
            return true;
        }
        private bool nadaActivado()
        {
            int posAM = comboNivelesAM.SelectedIndex;
            int posFM = comboNivelesFM.SelectedIndex;
            int posPM = comboNivelesPM.SelectedIndex;
            if ((posAM==0) && (posFM==0) && (posPM==0))
            {
                return true;
            }
            return false;
        }
        private void evaluar()
        {
            if (nadaActivado())
            {
                MessageBox.Show("No puede desactivar todo. Activando AM de 2 niveles", "Error");
                comboNivelesAM.SelectedIndex = 1;
                return;
            }
            if (txtNumBinario.Text.Length > 512)
            {
                MessageBox.Show("El número de bits se ha limitado a 512.", "Error");
                return;
            }
            if (!todoCorrecto())
            {
                MessageBox.Show("Por favor, introduzca solo bits 0 o 1. Gracias", "Error");
                return;
            }
            int numAmplitudes = getNumAmplitudes();
            int numFrecuencias = getNumFrecuencias();
            int numFases = getNumFases();
            int numEstadosModulacion = numAmplitudes * numFases * numFrecuencias; 
            int[] vectorAmplitudes = getAmplitudes();
            int[] vectorFrecuencias = getFrecuencias();
            float[] vectorFases = getFases();

            

            
            this.Text = "Modulador de "+numEstadosModulacion.ToString()+" niveles";
            string cadenaParaAjustar = txtNumBinario.Text;
            string cadAjustada = curvador.ajustaCadenaBinaria(numEstadosModulacion, cadenaParaAjustar);
            string cadPunteada = puntear(cadAjustada, numEstadosModulacion);
            lblAjustada.Text = cadPunteada;

            //Ahora extraemos los bits de la cadena ajustada para ver qué amplitud, que  hercios y qué
            //fase tenemos que utilizar
            int pos = 0;
            string bitsAmplitud, bitsFrecuencia, bitsFase;
            int bitsExtraidos;
            int xOrigen = 0;
            int ultimoX;
            int longitudOnda = 80; //Ancho en pixeles de las ondas
            Pen lapiz = new Pen(siguienteColor());
            lapiz.Width = 2.5f;
            dc = panelCurva.CreateGraphics();
            dc.Clear(Color.White);
            int mitadAltura = panelCurva.Height / 2;
            dc.TranslateTransform(0, (float)mitadAltura);
            txtDebug.Clear();
            Pen lapizNegro = new Pen(Color.Black);
            Brush brochaNegra=Brushes.Black;
            Font fuente = new Font("Arial", 11.0f);
            
            string bitsSacados;
            while (pos < cadAjustada.Length) 
            {
                bitsSacados = "";
                bitsAmplitud=extraerBits(cadAjustada,  pos, numAmplitudes, out bitsExtraidos);
                pos += bitsExtraidos;
                if (bitsExtraidos != 0)
                {
                    bitsSacados += bitsAmplitud;
                }
                bitsFrecuencia = extraerBits(cadAjustada, pos, numFrecuencias, out bitsExtraidos);
                pos += bitsExtraidos;
                if (bitsExtraidos != 0)
                {
                    bitsSacados += bitsFrecuencia;
                }
                bitsFase = extraerBits(cadAjustada,  pos, numFases, out bitsExtraidos);
                pos += bitsExtraidos;
                if (bitsExtraidos != 0)
                {
                    bitsSacados += bitsFase;
                }
                
                int amplitudCurva= vectorAmplitudes[convertirEnBinario(bitsAmplitud)];
                int frecuenciaCurva = vectorFrecuencias[convertirEnBinario(bitsFrecuencia)];
                float faseCurva=vectorFases[convertirEnBinario(bitsFase)];

                
                
                
                PointF[] puntosCurva = curvador.crearCurva(amplitudCurva, faseCurva, frecuenciaCurva,xOrigen, longitudOnda, out ultimoX);
                xOrigen = ultimoX;
                //dc.DrawLine(lapizNegro, new Point(xOrigen, 20), new Point(xOrigen, mitadAltura));
                //dc.DrawLine(lapizNegro, new Point(xOrigen, -20), new Point(xOrigen, -mitadAltura));
                dc.DrawCurve(lapiz, puntosCurva);
                
                int xCadena=ultimoX-(int)(longitudOnda/2);
                dc.DrawString(bitsSacados, fuente, brochaNegra, new PointF(xCadena, -amplitudCurva));
                lapiz = new Pen(siguienteColor());
                lapiz.Width = 2.5f;
                //txtDebug.AppendText("Curva:\r\n");
                //explicarCurva(puntosCurva);
            }
            
        }
        private void explicarCurva(PointF[] vectorPuntos)
        {
            
            for (int pos = 0; pos < vectorPuntos.Length; pos++)
            {
                PointF puntoActual = vectorPuntos[pos];
                txtDebug.AppendText("( " + puntoActual.X.ToString());
                txtDebug.AppendText(" , " + puntoActual.Y.ToString());
                txtDebug.AppendText(" )\r\n");
            }
            txtDebug.AppendText("\r\n");
            return;
        }
        private int getNumFases()
        {
            if (comboNivelesPM.SelectedIndex == -1)
            {
                comboNivelesPM.SelectedIndex = 0;
            }
            int numFases = (int)Math.Pow(2, comboNivelesPM.SelectedIndex);
            return numFases;
        }

        private int getNumFrecuencias()
        {
            if (comboNivelesFM.SelectedIndex==-1){
                comboNivelesFM.SelectedIndex=0;
            }
            int numFrecuencias = (int)Math.Pow(2, comboNivelesFM.SelectedIndex);
            return numFrecuencias;
        }

        private void comboNivelesAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluar();
        }

        private void comboNivelesFM_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluar();
        }

        private void comboNivelesPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            evaluar();
        }

        private int convertirEnBinario(string cadBinaria)
        {
            return Convert.ToInt32(cadBinaria, 2);
        }

        private void Modulador_Load(object sender, EventArgs e)
        {
        }

      

        private void txtNumBinario_TextChanged(object sender, EventArgs e)
        {
            if (txtNumBinario.Text!="") evaluar();
        }

        private void panelCurva_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Modulador_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
