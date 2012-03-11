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
    public partial class Form1 : Form
    {
        string comboAM = "comboNumNivelesAM";
        string comboFM = "comboNumNivelesFM";
        string comboPM = "comboNumNivelesPM";
        ComboBox cmbAM, cmbFM, cmbPM;

        string nombrepanelAM="panelCurvaAM";
        string nombrepanelFM = "panelCurvaFM";
        string nombrepanelPM = "panelCurvaPM";
        string nombrepanelMixto = "panelCurvaMixto";
        Panel panelAM, panelFM, panelPM, panelMixto;
        
        public Form1()
        {
            InitializeComponent();
            cmbAM = getComboAM();
            cmbFM = getComboFM();
            cmbPM = getComboPM();
            panelAM = getPanel(tabAM, nombrepanelAM);
            panelFM = getPanel(tabFM, nombrepanelFM);
            panelPM = getPanel(tabAM, nombrepanelPM);
            panelMixto = getPanel(tabAM, nombrepanelMixto);
        }
        private Panel getPanel(TabPage pagina, string nombre)
        {
            Control[] combos = pagina.Controls.Find(nombre, false);
            Panel elPanel= (Panel)combos[0];
            return elPanel;
        }
        private ComboBox getCombo(TabPage pagina, string nombre)
        {
            Control[] combos = pagina.Controls.Find(nombre, false);
            ComboBox combo = (ComboBox)combos[0];
            return combo;
        }
        private ComboBox getComboAM()
        {
            return this.getCombo(tabAM, comboAM);
        }
        private ComboBox getComboFM()
        {
            return this.getCombo(tabFM, comboFM);
        }
        private ComboBox getComboPM()
        {
            return this.getCombo(tabPM, comboPM);
        }

        

        private void txtNumeroBinario_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void dibujar(string cadBinaria)
        {

        }

        private void txtNumeroBinario_Validating(object sender, CancelEventArgs e)
        {
            TabPage pestana ;
            Panel panelDibujo;
            switch (tabModulaciones.SelectedIndex)
            {
                case 0:
                    {
                        pestana = tabAM;
                        panelDibujo=panelAM;
                        break;
                    }
                case 1:
                    {
                        pestana = tabFM;
                        panelDibujo=panelFM;
                        break;
                    }
                case 2:
                    {
                        pestana = tabPM;
                        panelDibujo=panelPM;
                        break;
                    }
                case 3:
                    {
                        pestana = tabMixto;
                        panelDibujo=panelMixto;
                        break;
                    }
                
            } //Fin del switch
            Graphics dc=panelDibujo
  
        }
    }
}
