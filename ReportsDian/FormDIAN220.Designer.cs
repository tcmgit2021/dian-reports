namespace DianReportsApp
{
    partial class FormDIAN220
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
            this.components = new System.ComponentModel.Container();
            this.tabControlCertificado220 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelResEnviados = new System.Windows.Forms.Label();
            this.labelResGenerados = new System.Windows.Forms.Label();
            this.richTextBoxResultados = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelEnviados = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.checkBoxGenerarTodos = new System.Windows.Forms.CheckBox();
            this.checkBoxCambiarRuta = new System.Windows.Forms.CheckBox();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxEnviarCorreo = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxCuerpo = new System.Windows.Forms.RichTextBox();
            this.textBoxAsunto = new System.Windows.Forms.TextBox();
            this.labelAsunto = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelCuerpo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRemitente = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.sp_consultarPersona_2023TableAdapter = new DianReportsApp.Adam2023DataSetTableAdapters.sp_consultarPersona_2023TableAdapter();
            this.sp_consultarPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adam2023DataSet = new DianReportsApp.Adam2023DataSet();
            this.tabControlCertificado220.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consultarPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adam2023DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCertificado220
            // 
            this.tabControlCertificado220.Controls.Add(this.tabPage1);
            this.tabControlCertificado220.Controls.Add(this.tabPage2);
            this.tabControlCertificado220.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCertificado220.Location = new System.Drawing.Point(0, 0);
            this.tabControlCertificado220.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlCertificado220.Name = "tabControlCertificado220";
            this.tabControlCertificado220.SelectedIndex = 0;
            this.tabControlCertificado220.Size = new System.Drawing.Size(392, 387);
            this.tabControlCertificado220.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelResEnviados);
            this.tabPage1.Controls.Add(this.labelResGenerados);
            this.tabPage1.Controls.Add(this.richTextBoxResultados);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.labelEnviados);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxRuta);
            this.tabPage1.Controls.Add(this.checkBoxGenerarTodos);
            this.tabPage1.Controls.Add(this.checkBoxCambiarRuta);
            this.tabPage1.Controls.Add(this.buttonGenerar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxCedula);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.checkBoxEnviarCorreo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(384, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Certificado 220";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelResEnviados
            // 
            this.labelResEnviados.AutoSize = true;
            this.labelResEnviados.Location = new System.Drawing.Point(92, 252);
            this.labelResEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResEnviados.Name = "labelResEnviados";
            this.labelResEnviados.Size = new System.Drawing.Size(10, 13);
            this.labelResEnviados.TabIndex = 24;
            this.labelResEnviados.Text = " ";
            // 
            // labelResGenerados
            // 
            this.labelResGenerados.AutoSize = true;
            this.labelResGenerados.Location = new System.Drawing.Point(92, 228);
            this.labelResGenerados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResGenerados.Name = "labelResGenerados";
            this.labelResGenerados.Size = new System.Drawing.Size(10, 13);
            this.labelResGenerados.TabIndex = 23;
            this.labelResGenerados.Text = " ";
            // 
            // richTextBoxResultados
            // 
            this.richTextBoxResultados.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxResultados.Location = new System.Drawing.Point(94, 277);
            this.richTextBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxResultados.Name = "richTextBoxResultados";
            this.richTextBoxResultados.ReadOnly = true;
            this.richTextBoxResultados.Size = new System.Drawing.Size(270, 71);
            this.richTextBoxResultados.TabIndex = 22;
            this.richTextBoxResultados.Text = "";
            this.richTextBoxResultados.TextChanged += new System.EventHandler(this.richTextBoxResultados_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Generados:";
            // 
            // labelEnviados
            // 
            this.labelEnviados.AutoSize = true;
            this.labelEnviados.Location = new System.Drawing.Point(74, 228);
            this.labelEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnviados.Name = "labelEnviados";
            this.labelEnviados.Size = new System.Drawing.Size(10, 13);
            this.labelEnviados.TabIndex = 20;
            this.labelEnviados.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 252);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Enviados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 275);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Resultados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(95, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Formulario 220 DIAN ";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(114, 132);
            this.textBoxRuta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.ReadOnly = true;
            this.textBoxRuta.Size = new System.Drawing.Size(202, 20);
            this.textBoxRuta.TabIndex = 13;
            this.textBoxRuta.Text = "C:/DIAN/Certificados_2022";
            // 
            // checkBoxGenerarTodos
            // 
            this.checkBoxGenerarTodos.AutoSize = true;
            this.checkBoxGenerarTodos.Location = new System.Drawing.Point(114, 98);
            this.checkBoxGenerarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGenerarTodos.Name = "checkBoxGenerarTodos";
            this.checkBoxGenerarTodos.Size = new System.Drawing.Size(93, 17);
            this.checkBoxGenerarTodos.TabIndex = 0;
            this.checkBoxGenerarTodos.Text = "Generar todos";
            this.checkBoxGenerarTodos.UseVisualStyleBackColor = true;
            this.checkBoxGenerarTodos.CheckedChanged += new System.EventHandler(this.checkBoxGenerarTodos_CheckedChanged);
            // 
            // checkBoxCambiarRuta
            // 
            this.checkBoxCambiarRuta.AutoSize = true;
            this.checkBoxCambiarRuta.Checked = true;
            this.checkBoxCambiarRuta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCambiarRuta.Location = new System.Drawing.Point(232, 154);
            this.checkBoxCambiarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCambiarRuta.Name = "checkBoxCambiarRuta";
            this.checkBoxCambiarRuta.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCambiarRuta.TabIndex = 18;
            this.checkBoxCambiarRuta.Text = "Cambiar ruta";
            this.checkBoxCambiarRuta.UseVisualStyleBackColor = true;
            this.checkBoxCambiarRuta.CheckedChanged += new System.EventHandler(this.checkBoxCambiarRuta_CheckedChanged);
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(168, 194);
            this.buttonGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(69, 24);
            this.buttonGenerar.TabIndex = 1;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cédula:";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(114, 75);
            this.textBoxCedula.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(202, 20);
            this.textBoxCedula.TabIndex = 3;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ruta:";
            // 
            // checkBoxEnviarCorreo
            // 
            this.checkBoxEnviarCorreo.AutoSize = true;
            this.checkBoxEnviarCorreo.Location = new System.Drawing.Point(210, 98);
            this.checkBoxEnviarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnviarCorreo.Name = "checkBoxEnviarCorreo";
            this.checkBoxEnviarCorreo.Size = new System.Drawing.Size(107, 17);
            this.checkBoxEnviarCorreo.TabIndex = 4;
            this.checkBoxEnviarCorreo.Text = "Enviar por correo";
            this.checkBoxEnviarCorreo.UseVisualStyleBackColor = true;
            this.checkBoxEnviarCorreo.CheckedChanged += new System.EventHandler(this.checkBoxEnviarCorreo_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxCuerpo);
            this.tabPage2.Controls.Add(this.textBoxAsunto);
            this.tabPage2.Controls.Add(this.labelAsunto);
            this.tabPage2.Controls.Add(this.textBoxContrasena);
            this.tabPage2.Controls.Add(this.labelContrasena);
            this.tabPage2.Controls.Add(this.textBoxPuerto);
            this.tabPage2.Controls.Add(this.labelPuerto);
            this.tabPage2.Controls.Add(this.textBoxHost);
            this.tabPage2.Controls.Add(this.labelHost);
            this.tabPage2.Controls.Add(this.labelCuerpo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxRemitente);
            this.tabPage2.Controls.Add(this.labelCorreo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(384, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Correo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCuerpo
            // 
            this.richTextBoxCuerpo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBoxCuerpo.Location = new System.Drawing.Point(96, 236);
            this.richTextBoxCuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxCuerpo.Name = "richTextBoxCuerpo";
            this.richTextBoxCuerpo.ReadOnly = true;
            this.richTextBoxCuerpo.Size = new System.Drawing.Size(246, 103);
            this.richTextBoxCuerpo.TabIndex = 47;
            this.richTextBoxCuerpo.Text = "Buenos días<br/><br/>\nAdjuntamos certificado de ingresos y retenciones año 2022.<" +
    "br/><br/><br/>\nAtentamente,<br/><br/>\nÁrea de nómina<br/>\nSOE<br/><br/>";
            this.richTextBoxCuerpo.TextChanged += new System.EventHandler(this.richTextBoxCuerpo_TextChanged);
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Location = new System.Drawing.Point(96, 205);
            this.textBoxAsunto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(246, 20);
            this.textBoxAsunto.TabIndex = 49;
            this.textBoxAsunto.Text = "Certificado ingresos y retenciones año 2022";
            this.textBoxAsunto.TextChanged += new System.EventHandler(this.textBoxAsunto_TextChanged);
            // 
            // labelAsunto
            // 
            this.labelAsunto.AutoSize = true;
            this.labelAsunto.Location = new System.Drawing.Point(48, 207);
            this.labelAsunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsunto.Name = "labelAsunto";
            this.labelAsunto.Size = new System.Drawing.Size(43, 13);
            this.labelAsunto.TabIndex = 48;
            this.labelAsunto.Text = "Asunto:";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(96, 109);
            this.textBoxContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(246, 20);
            this.textBoxContrasena.TabIndex = 46;
            this.textBoxContrasena.Text = "Gecolsa2014";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(28, 108);
            this.labelContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(64, 13);
            this.labelContrasena.TabIndex = 45;
            this.labelContrasena.Text = "Contraseña:";
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(96, 141);
            this.textBoxPuerto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(246, 20);
            this.textBoxPuerto.TabIndex = 44;
            this.textBoxPuerto.Text = "587";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(48, 143);
            this.labelPuerto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(41, 13);
            this.labelPuerto.TabIndex = 43;
            this.labelPuerto.Text = "Puerto:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(96, 172);
            this.textBoxHost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(246, 20);
            this.textBoxHost.TabIndex = 42;
            this.textBoxHost.Text = "smtp.office365.com";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(59, 175);
            this.labelHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(32, 13);
            this.labelHost.TabIndex = 41;
            this.labelHost.Text = "Host:";
            // 
            // labelCuerpo
            // 
            this.labelCuerpo.AutoSize = true;
            this.labelCuerpo.Location = new System.Drawing.Point(48, 238);
            this.labelCuerpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCuerpo.Name = "labelCuerpo";
            this.labelCuerpo.Size = new System.Drawing.Size(44, 13);
            this.labelCuerpo.TabIndex = 40;
            this.labelCuerpo.Text = "Cuerpo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Configuración de correo";
            // 
            // textBoxRemitente
            // 
            this.textBoxRemitente.Location = new System.Drawing.Point(96, 78);
            this.textBoxRemitente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemitente.Name = "textBoxRemitente";
            this.textBoxRemitente.Size = new System.Drawing.Size(246, 20);
            this.textBoxRemitente.TabIndex = 38;
            this.textBoxRemitente.Text = "nomina1@gecolsa.com.co";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(50, 78);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 37;
            this.labelCorreo.Text = "Correo:";
            // 
            // sp_consultarPersona_2023TableAdapter
            // 
            this.sp_consultarPersona_2023TableAdapter.ClearBeforeFill = true;
            // 
            // sp_consultarPersonaBindingSource
            // 
            this.sp_consultarPersonaBindingSource.AllowNew = true;
            this.sp_consultarPersonaBindingSource.DataMember = "sp_consultarPersona_2023";
            this.sp_consultarPersonaBindingSource.DataSource = this.adam2023DataSet;
            this.sp_consultarPersonaBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // adam2023DataSet
            // 
            this.adam2023DataSet.DataSetName = "Adam2023DataSet";
            this.adam2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormDIAN220
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(392, 387);
            this.Controls.Add(this.tabControlCertificado220);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormDIAN220";
            this.Text = "FormDIAN220";
            this.Load += new System.EventHandler(this.FormDIAN220_Load);
            this.tabControlCertificado220.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consultarPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adam2023DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.TabControl tabControlCertificado220;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelResEnviados;
        private System.Windows.Forms.Label labelResGenerados;
        private System.Windows.Forms.RichTextBox richTextBoxResultados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelEnviados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRuta;
        public System.Windows.Forms.CheckBox checkBoxGenerarTodos;
        private System.Windows.Forms.CheckBox checkBoxCambiarRuta;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxEnviarCorreo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxCuerpo;
        private System.Windows.Forms.TextBox textBoxAsunto;
        private System.Windows.Forms.Label labelAsunto;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelCuerpo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRemitente;
        private System.Windows.Forms.Label labelCorreo;
        private Adam2023DataSet adam2023DataSet;
        private System.Windows.Forms.BindingSource sp_consultarPersonaBindingSource;
        private Adam2023DataSetTableAdapters.sp_consultarPersona_2023TableAdapter sp_consultarPersona_2023TableAdapter;        
    }
}