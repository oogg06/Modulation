namespace Modulacion
{
    partial class Form1
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
            this.tabModulaciones = new System.Windows.Forms.TabControl();
            this.tabAM = new System.Windows.Forms.TabPage();
            this.panelCurvaAM = new System.Windows.Forms.Panel();
            this.comboNumNivelesAM = new System.Windows.Forms.ComboBox();
            this.lblNivelesAM = new System.Windows.Forms.Label();
            this.tabFM = new System.Windows.Forms.TabPage();
            this.comboNumNivelesFM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPM = new System.Windows.Forms.TabPage();
            this.comboNumNivelesPM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMixto = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroBinario = new System.Windows.Forms.TextBox();
            this.panelCurvaFM = new System.Windows.Forms.Panel();
            this.panelCurvaPM = new System.Windows.Forms.Panel();
            this.panelCurvaMixto = new System.Windows.Forms.Panel();
            this.tabModulaciones.SuspendLayout();
            this.tabAM.SuspendLayout();
            this.tabFM.SuspendLayout();
            this.tabPM.SuspendLayout();
            this.tabMixto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabModulaciones
            // 
            this.tabModulaciones.Controls.Add(this.tabAM);
            this.tabModulaciones.Controls.Add(this.tabFM);
            this.tabModulaciones.Controls.Add(this.tabPM);
            this.tabModulaciones.Controls.Add(this.tabMixto);
            this.tabModulaciones.Location = new System.Drawing.Point(36, 62);
            this.tabModulaciones.Name = "tabModulaciones";
            this.tabModulaciones.SelectedIndex = 0;
            this.tabModulaciones.Size = new System.Drawing.Size(936, 563);
            this.tabModulaciones.TabIndex = 0;
            // 
            // tabAM
            // 
            this.tabAM.Controls.Add(this.panelCurvaAM);
            this.tabAM.Controls.Add(this.comboNumNivelesAM);
            this.tabAM.Controls.Add(this.lblNivelesAM);
            this.tabAM.Location = new System.Drawing.Point(4, 22);
            this.tabAM.Name = "tabAM";
            this.tabAM.Padding = new System.Windows.Forms.Padding(3);
            this.tabAM.Size = new System.Drawing.Size(928, 537);
            this.tabAM.TabIndex = 0;
            this.tabAM.Text = "Modulación AM";
            this.tabAM.UseVisualStyleBackColor = true;
            // 
            // panelCurvaAM
            // 
            this.panelCurvaAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurvaAM.Location = new System.Drawing.Point(4, 45);
            this.panelCurvaAM.Name = "panelCurvaAM";
            this.panelCurvaAM.Size = new System.Drawing.Size(918, 486);
            this.panelCurvaAM.TabIndex = 6;
            // 
            // comboNumNivelesAM
            // 
            this.comboNumNivelesAM.FormattingEnabled = true;
            this.comboNumNivelesAM.Items.AddRange(new object[] {
            "1 nivel",
            "2 niveles",
            "3 niveles",
            "4 niveles"});
            this.comboNumNivelesAM.Location = new System.Drawing.Point(161, 9);
            this.comboNumNivelesAM.Name = "comboNumNivelesAM";
            this.comboNumNivelesAM.Size = new System.Drawing.Size(121, 21);
            this.comboNumNivelesAM.TabIndex = 5;
            // 
            // lblNivelesAM
            // 
            this.lblNivelesAM.AutoSize = true;
            this.lblNivelesAM.Location = new System.Drawing.Point(3, 12);
            this.lblNivelesAM.Name = "lblNivelesAM";
            this.lblNivelesAM.Size = new System.Drawing.Size(152, 13);
            this.lblNivelesAM.TabIndex = 4;
            this.lblNivelesAM.Text = "Introduce el numero de niveles";
            // 
            // tabFM
            // 
            this.tabFM.Controls.Add(this.panelCurvaFM);
            this.tabFM.Controls.Add(this.comboNumNivelesFM);
            this.tabFM.Controls.Add(this.label2);
            this.tabFM.Location = new System.Drawing.Point(4, 22);
            this.tabFM.Name = "tabFM";
            this.tabFM.Padding = new System.Windows.Forms.Padding(3);
            this.tabFM.Size = new System.Drawing.Size(928, 537);
            this.tabFM.TabIndex = 1;
            this.tabFM.Text = "Modulación FM";
            this.tabFM.UseVisualStyleBackColor = true;
            // 
            // comboNumNivelesFM
            // 
            this.comboNumNivelesFM.FormattingEnabled = true;
            this.comboNumNivelesFM.Items.AddRange(new object[] {
            "1 nivel",
            "2 niveles",
            "3 niveles",
            "4 niveles"});
            this.comboNumNivelesFM.Location = new System.Drawing.Point(161, 9);
            this.comboNumNivelesFM.Name = "comboNumNivelesFM";
            this.comboNumNivelesFM.Size = new System.Drawing.Size(121, 21);
            this.comboNumNivelesFM.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduce el numero de niveles";
            // 
            // tabPM
            // 
            this.tabPM.Controls.Add(this.panelCurvaPM);
            this.tabPM.Controls.Add(this.comboNumNivelesPM);
            this.tabPM.Controls.Add(this.label3);
            this.tabPM.Location = new System.Drawing.Point(4, 22);
            this.tabPM.Name = "tabPM";
            this.tabPM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPM.Size = new System.Drawing.Size(928, 537);
            this.tabPM.TabIndex = 2;
            this.tabPM.Text = "Modulación PSK";
            this.tabPM.UseVisualStyleBackColor = true;
            // 
            // comboNumNivelesPM
            // 
            this.comboNumNivelesPM.FormattingEnabled = true;
            this.comboNumNivelesPM.Items.AddRange(new object[] {
            "1 nivel",
            "2 niveles",
            "3 niveles",
            "4 niveles"});
            this.comboNumNivelesPM.Location = new System.Drawing.Point(161, 9);
            this.comboNumNivelesPM.Name = "comboNumNivelesPM";
            this.comboNumNivelesPM.Size = new System.Drawing.Size(121, 21);
            this.comboNumNivelesPM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Introduce el numero de niveles";
            // 
            // tabMixto
            // 
            this.tabMixto.Controls.Add(this.panelCurvaMixto);
            this.tabMixto.Location = new System.Drawing.Point(4, 22);
            this.tabMixto.Name = "tabMixto";
            this.tabMixto.Padding = new System.Windows.Forms.Padding(3);
            this.tabMixto.Size = new System.Drawing.Size(928, 537);
            this.tabMixto.TabIndex = 3;
            this.tabMixto.Text = "Mezcla";
            this.tabMixto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce una secuencia binaria";
            // 
            // txtNumeroBinario
            // 
            this.txtNumeroBinario.Location = new System.Drawing.Point(205, 12);
            this.txtNumeroBinario.Name = "txtNumeroBinario";
            this.txtNumeroBinario.Size = new System.Drawing.Size(183, 20);
            this.txtNumeroBinario.TabIndex = 2;
            this.txtNumeroBinario.TextChanged += new System.EventHandler(this.txtNumeroBinario_TextChanged);
            this.txtNumeroBinario.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroBinario_Validating);
            // 
            // panelCurvaFM
            // 
            this.panelCurvaFM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurvaFM.Location = new System.Drawing.Point(7, 38);
            this.panelCurvaFM.Name = "panelCurvaFM";
            this.panelCurvaFM.Size = new System.Drawing.Size(915, 493);
            this.panelCurvaFM.TabIndex = 6;
            // 
            // panelCurvaPM
            // 
            this.panelCurvaPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurvaPM.Location = new System.Drawing.Point(9, 36);
            this.panelCurvaPM.Name = "panelCurvaPM";
            this.panelCurvaPM.Size = new System.Drawing.Size(913, 498);
            this.panelCurvaPM.TabIndex = 6;
            // 
            // panelCurvaMixto
            // 
            this.panelCurvaMixto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurvaMixto.Location = new System.Drawing.Point(6, 37);
            this.panelCurvaMixto.Name = "panelCurvaMixto";
            this.panelCurvaMixto.Size = new System.Drawing.Size(916, 494);
            this.panelCurvaMixto.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 637);
            this.Controls.Add(this.txtNumeroBinario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabModulaciones);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador AM/FM/PM";
            this.tabModulaciones.ResumeLayout(false);
            this.tabAM.ResumeLayout(false);
            this.tabAM.PerformLayout();
            this.tabFM.ResumeLayout(false);
            this.tabFM.PerformLayout();
            this.tabPM.ResumeLayout(false);
            this.tabPM.PerformLayout();
            this.tabMixto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabModulaciones;
        private System.Windows.Forms.TabPage tabAM;
        private System.Windows.Forms.TabPage tabFM;
        private System.Windows.Forms.TabPage tabPM;
        private System.Windows.Forms.TabPage tabMixto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroBinario;
        private System.Windows.Forms.Panel panelCurvaAM;
        private System.Windows.Forms.ComboBox comboNumNivelesAM;
        private System.Windows.Forms.Label lblNivelesAM;
        private System.Windows.Forms.ComboBox comboNumNivelesFM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNumNivelesPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCurvaFM;
        private System.Windows.Forms.Panel panelCurvaPM;
        private System.Windows.Forms.Panel panelCurvaMixto;

    }
}