namespace Cita_Medica
{
    partial class Citas
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaSet = new Cita_Medica.ClinicaSet();
            this.comboPaciente = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new Cita_Medica.ClinicaSetTableAdapters.MedicoTableAdapter();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Cita_Medica.ClinicaSetTableAdapters.UsuarioTableAdapter();
            this.pacienteTableAdapter = new Cita_Medica.ClinicaSetTableAdapters.PacienteTableAdapter();
            this.ultimos_PacientesToolStrip = new System.Windows.Forms.ToolStrip();
            this.ultimos_PacientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.ultimos_PacientesToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medico";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(360, 42);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 9, 14, 29, 59, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Paciente";
            // 
            // comboMedico
            // 
            this.comboMedico.DataSource = this.medicoBindingSource;
            this.comboMedico.DisplayMember = "Nombre";
            this.comboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedico.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMedico.FormattingEnabled = true;
            this.comboMedico.Location = new System.Drawing.Point(223, 62);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(360, 42);
            this.comboMedico.TabIndex = 14;
            this.comboMedico.ValueMember = "Id";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.clinicaSetBindingSource;
            // 
            // clinicaSetBindingSource
            // 
            this.clinicaSetBindingSource.DataSource = this.clinicaSet;
            this.clinicaSetBindingSource.Position = 0;
            // 
            // clinicaSet
            // 
            this.clinicaSet.DataSetName = "ClinicaSet";
            this.clinicaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboPaciente
            // 
            this.comboPaciente.DataSource = this.pacienteBindingSource;
            this.comboPaciente.DisplayMember = "Nombre";
            this.comboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaciente.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaciente.FormattingEnabled = true;
            this.comboPaciente.Location = new System.Drawing.Point(225, 139);
            this.comboPaciente.Name = "comboPaciente";
            this.comboPaciente.Size = new System.Drawing.Size(360, 42);
            this.comboPaciente.TabIndex = 14;
            this.comboPaciente.ValueMember = "Id";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.clinicaSet;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.clinicaSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // ultimos_PacientesToolStrip
            // 
            this.ultimos_PacientesToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultimos_PacientesToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ultimos_PacientesToolStrip.Font = new System.Drawing.Font("Myanmar Text", 14F);
            this.ultimos_PacientesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ultimos_PacientesToolStripButton});
            this.ultimos_PacientesToolStrip.Location = new System.Drawing.Point(588, 140);
            this.ultimos_PacientesToolStrip.Name = "ultimos_PacientesToolStrip";
            this.ultimos_PacientesToolStrip.Size = new System.Drawing.Size(180, 41);
            this.ultimos_PacientesToolStrip.TabIndex = 15;
            this.ultimos_PacientesToolStrip.Text = "Ultimos Pacientes";
            // 
            // ultimos_PacientesToolStripButton
            // 
            this.ultimos_PacientesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ultimos_PacientesToolStripButton.Name = "ultimos_PacientesToolStripButton";
            this.ultimos_PacientesToolStripButton.Size = new System.Drawing.Size(168, 38);
            this.ultimos_PacientesToolStripButton.Text = "Ultimos Pacientes";
            this.ultimos_PacientesToolStripButton.Click += new System.EventHandler(this.ultimos_PacientesToolStripButton_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultimos_PacientesToolStrip);
            this.Controls.Add(this.comboPaciente);
            this.Controls.Add(this.comboMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ultimos_PacientesToolStrip.ResumeLayout(false);
            this.ultimos_PacientesToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMedico;
        private System.Windows.Forms.ComboBox comboPaciente;
        private System.Windows.Forms.BindingSource clinicaSetBindingSource;
        private ClinicaSet clinicaSet;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ClinicaSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ClinicaSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.ToolStrip ultimos_PacientesToolStrip;
        private System.Windows.Forms.ToolStripButton ultimos_PacientesToolStripButton;
    }
}