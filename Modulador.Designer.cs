namespace Modulacion
{
    partial class Modulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumBinario = new System.Windows.Forms.TextBox();
            this.grupoAM = new System.Windows.Forms.GroupBox();
            this.comboNivelesAM = new System.Windows.Forms.ComboBox();
            this.grupoFM = new System.Windows.Forms.GroupBox();
            this.comboNivelesFM = new System.Windows.Forms.ComboBox();
            this.grupoPM = new System.Windows.Forms.GroupBox();
            this.comboNivelesPM = new System.Windows.Forms.ComboBox();
            this.panelCurva = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAjustada = new System.Windows.Forms.Label();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grupoAM.SuspendLayout();
            this.grupoFM.SuspendLayout();
            this.grupoPM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNumBinario
            // 
            resources.ApplyResources(this.txtNumBinario, "txtNumBinario");
            this.txtNumBinario.Name = "txtNumBinario";
            this.txtNumBinario.TextChanged += new System.EventHandler(this.txtNumBinario_TextChanged);
            this.txtNumBinario.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumBinario_Validating);
            // 
            // grupoAM
            // 
            this.grupoAM.Controls.Add(this.comboNivelesAM);
            resources.ApplyResources(this.grupoAM, "grupoAM");
            this.grupoAM.Name = "grupoAM";
            this.grupoAM.TabStop = false;
            // 
            // comboNivelesAM
            // 
            this.comboNivelesAM.FormattingEnabled = true;
            this.comboNivelesAM.Items.AddRange(new object[] {
            resources.GetString("comboNivelesAM.Items"),
            resources.GetString("comboNivelesAM.Items1"),
            resources.GetString("comboNivelesAM.Items2"),
            resources.GetString("comboNivelesAM.Items3")});
            resources.ApplyResources(this.comboNivelesAM, "comboNivelesAM");
            this.comboNivelesAM.Name = "comboNivelesAM";
            this.comboNivelesAM.SelectedIndexChanged += new System.EventHandler(this.comboNivelesAM_SelectedIndexChanged);
            // 
            // grupoFM
            // 
            this.grupoFM.Controls.Add(this.comboNivelesFM);
            resources.ApplyResources(this.grupoFM, "grupoFM");
            this.grupoFM.Name = "grupoFM";
            this.grupoFM.TabStop = false;
            // 
            // comboNivelesFM
            // 
            this.comboNivelesFM.FormattingEnabled = true;
            this.comboNivelesFM.Items.AddRange(new object[] {
            resources.GetString("comboNivelesFM.Items"),
            resources.GetString("comboNivelesFM.Items1"),
            resources.GetString("comboNivelesFM.Items2"),
            resources.GetString("comboNivelesFM.Items3")});
            resources.ApplyResources(this.comboNivelesFM, "comboNivelesFM");
            this.comboNivelesFM.Name = "comboNivelesFM";
            this.comboNivelesFM.SelectedIndexChanged += new System.EventHandler(this.comboNivelesFM_SelectedIndexChanged);
            // 
            // grupoPM
            // 
            this.grupoPM.Controls.Add(this.comboNivelesPM);
            resources.ApplyResources(this.grupoPM, "grupoPM");
            this.grupoPM.Name = "grupoPM";
            this.grupoPM.TabStop = false;
            // 
            // comboNivelesPM
            // 
            this.comboNivelesPM.FormattingEnabled = true;
            this.comboNivelesPM.Items.AddRange(new object[] {
            resources.GetString("comboNivelesPM.Items"),
            resources.GetString("comboNivelesPM.Items1"),
            resources.GetString("comboNivelesPM.Items2"),
            resources.GetString("comboNivelesPM.Items3")});
            resources.ApplyResources(this.comboNivelesPM, "comboNivelesPM");
            this.comboNivelesPM.Name = "comboNivelesPM";
            this.comboNivelesPM.SelectedIndexChanged += new System.EventHandler(this.comboNivelesPM_SelectedIndexChanged);
            // 
            // panelCurva
            // 
            resources.ApplyResources(this.panelCurva, "panelCurva");
            this.panelCurva.BackColor = System.Drawing.Color.White;
            this.panelCurva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurva.Name = "panelCurva";
            this.panelCurva.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCurva_Paint);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblAjustada
            // 
            resources.ApplyResources(this.lblAjustada, "lblAjustada");
            this.lblAjustada.Name = "lblAjustada";
            // 
            // txtDebug
            // 
            resources.ApplyResources(this.txtDebug, "txtDebug");
            this.txtDebug.Name = "txtDebug";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Modulador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.lblAjustada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCurva);
            this.Controls.Add(this.grupoPM);
            this.Controls.Add(this.grupoFM);
            this.Controls.Add(this.grupoAM);
            this.Controls.Add(this.txtNumBinario);
            this.Controls.Add(this.label1);
            this.Name = "Modulador";
            this.Load += new System.EventHandler(this.Modulador_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Modulador_Paint);
            this.grupoAM.ResumeLayout(false);
            this.grupoFM.ResumeLayout(false);
            this.grupoPM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumBinario;
        private System.Windows.Forms.GroupBox grupoAM;
        private System.Windows.Forms.ComboBox comboNivelesAM;
        private System.Windows.Forms.GroupBox grupoFM;
        private System.Windows.Forms.ComboBox comboNivelesFM;
        private System.Windows.Forms.GroupBox grupoPM;
        private System.Windows.Forms.ComboBox comboNivelesPM;
        private System.Windows.Forms.Panel panelCurva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAjustada;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label label3;

    }
}