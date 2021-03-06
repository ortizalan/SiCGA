﻿namespace SADI.UserControls
{
    partial class SerieDocumental
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpoCrearSerieDoctal = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSeries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpoDetallesDoc = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboValorDoctal = new System.Windows.Forms.ComboBox();
            this.cboClasificaciones = new System.Windows.Forms.ComboBox();
            this.gpoCveSevi = new System.Windows.Forms.GroupBox();
            this.txtCveSevi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkTieneSevi = new System.Windows.Forms.CheckBox();
            this.gpoSerieDoctal = new System.Windows.Forms.GroupBox();
            this.lblSerieDoctal = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtOtraInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescExpe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreExp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.chkConsecutivo = new System.Windows.Forms.CheckBox();
            this.chkAddTema = new System.Windows.Forms.CheckBox();
            this.chkDigitalizado = new System.Windows.Forms.CheckBox();
            this.lblArchivoDig = new System.Windows.Forms.Label();
            this.cmdChangeFile = new System.Windows.Forms.Button();
            this.cmdAddFiles = new System.Windows.Forms.Button();
            this.gpoCrearSerieDoctal.SuspendLayout();
            this.gpoDetallesDoc.SuspendLayout();
            this.gpoCveSevi.SuspendLayout();
            this.gpoSerieDoctal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpoCrearSerieDoctal
            // 
            this.gpoCrearSerieDoctal.Controls.Add(this.label4);
            this.gpoCrearSerieDoctal.Controls.Add(this.dtpFecha);
            this.gpoCrearSerieDoctal.Controls.Add(this.cboTema);
            this.gpoCrearSerieDoctal.Controls.Add(this.label3);
            this.gpoCrearSerieDoctal.Controls.Add(this.cboSeries);
            this.gpoCrearSerieDoctal.Controls.Add(this.label2);
            this.gpoCrearSerieDoctal.Controls.Add(this.cboSeccion);
            this.gpoCrearSerieDoctal.Controls.Add(this.label1);
            this.gpoCrearSerieDoctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoCrearSerieDoctal.Location = new System.Drawing.Point(4, 6);
            this.gpoCrearSerieDoctal.Name = "gpoCrearSerieDoctal";
            this.gpoCrearSerieDoctal.Size = new System.Drawing.Size(544, 203);
            this.gpoCrearSerieDoctal.TabIndex = 1;
            this.gpoCrearSerieDoctal.TabStop = false;
            this.gpoCrearSerieDoctal.Text = "Crear Serie Documental";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Creación :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(360, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(119, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cboTema
            // 
            this.cboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(96, 155);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(442, 21);
            this.cboTema.TabIndex = 5;
            this.cboTema.SelectedValueChanged += new System.EventHandler(this.cboTema_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tema :";
            // 
            // cboSeries
            // 
            this.cboSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeries.FormattingEnabled = true;
            this.cboSeries.Location = new System.Drawing.Point(96, 117);
            this.cboSeries.Name = "cboSeries";
            this.cboSeries.Size = new System.Drawing.Size(442, 21);
            this.cboSeries.TabIndex = 3;
            this.cboSeries.SelectedValueChanged += new System.EventHandler(this.cboSeries_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serie :";
            // 
            // cboSeccion
            // 
            this.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(98, 77);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(440, 21);
            this.cboSeccion.TabIndex = 1;
            this.cboSeccion.SelectedValueChanged += new System.EventHandler(this.cboSeccion_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sección :";
            // 
            // gpoDetallesDoc
            // 
            this.gpoDetallesDoc.Controls.Add(this.label6);
            this.gpoDetallesDoc.Controls.Add(this.label5);
            this.gpoDetallesDoc.Controls.Add(this.cboValorDoctal);
            this.gpoDetallesDoc.Controls.Add(this.cboClasificaciones);
            this.gpoDetallesDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoDetallesDoc.Location = new System.Drawing.Point(554, 6);
            this.gpoDetallesDoc.Name = "gpoDetallesDoc";
            this.gpoDetallesDoc.Size = new System.Drawing.Size(325, 155);
            this.gpoDetallesDoc.TabIndex = 2;
            this.gpoDetallesDoc.TabStop = false;
            this.gpoDetallesDoc.Text = "Detalles Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "     Valor \r\nDocumental :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clasificación :";
            // 
            // cboValorDoctal
            // 
            this.cboValorDoctal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValorDoctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValorDoctal.FormattingEnabled = true;
            this.cboValorDoctal.Location = new System.Drawing.Point(112, 105);
            this.cboValorDoctal.Name = "cboValorDoctal";
            this.cboValorDoctal.Size = new System.Drawing.Size(193, 21);
            this.cboValorDoctal.TabIndex = 1;
            this.cboValorDoctal.SelectedValueChanged += new System.EventHandler(this.cboValorDoctal_SelectedValueChanged);
            // 
            // cboClasificaciones
            // 
            this.cboClasificaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasificaciones.FormattingEnabled = true;
            this.cboClasificaciones.Location = new System.Drawing.Point(112, 63);
            this.cboClasificaciones.Name = "cboClasificaciones";
            this.cboClasificaciones.Size = new System.Drawing.Size(193, 21);
            this.cboClasificaciones.TabIndex = 0;
            this.cboClasificaciones.SelectedValueChanged += new System.EventHandler(this.cboClasificaciones_SelectedValueChanged);
            // 
            // gpoCveSevi
            // 
            this.gpoCveSevi.Controls.Add(this.txtCveSevi);
            this.gpoCveSevi.Controls.Add(this.label9);
            this.gpoCveSevi.Controls.Add(this.chkTieneSevi);
            this.gpoCveSevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoCveSevi.Location = new System.Drawing.Point(554, 166);
            this.gpoCveSevi.Name = "gpoCveSevi";
            this.gpoCveSevi.Size = new System.Drawing.Size(325, 97);
            this.gpoCveSevi.TabIndex = 7;
            this.gpoCveSevi.TabStop = false;
            this.gpoCveSevi.Text = "Clave SEVI";
            // 
            // txtCveSevi
            // 
            this.txtCveSevi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCveSevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCveSevi.Location = new System.Drawing.Point(99, 65);
            this.txtCveSevi.Name = "txtCveSevi";
            this.txtCveSevi.Size = new System.Drawing.Size(213, 20);
            this.txtCveSevi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Clave SEVI :";
            // 
            // chkTieneSevi
            // 
            this.chkTieneSevi.AutoSize = true;
            this.chkTieneSevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTieneSevi.Location = new System.Drawing.Point(14, 35);
            this.chkTieneSevi.Name = "chkTieneSevi";
            this.chkTieneSevi.Size = new System.Drawing.Size(166, 17);
            this.chkTieneSevi.TabIndex = 0;
            this.chkTieneSevi.Text = "Cuenta con Clave SEVI?";
            this.chkTieneSevi.UseVisualStyleBackColor = true;
            this.chkTieneSevi.CheckedChanged += new System.EventHandler(this.chkTieneSevi_CheckedChanged);
            // 
            // gpoSerieDoctal
            // 
            this.gpoSerieDoctal.Controls.Add(this.lblSerieDoctal);
            this.gpoSerieDoctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoSerieDoctal.Location = new System.Drawing.Point(4, 215);
            this.gpoSerieDoctal.Name = "gpoSerieDoctal";
            this.gpoSerieDoctal.Size = new System.Drawing.Size(544, 64);
            this.gpoSerieDoctal.TabIndex = 11;
            this.gpoSerieDoctal.TabStop = false;
            this.gpoSerieDoctal.Text = "Serie Documental";
            // 
            // lblSerieDoctal
            // 
            this.lblSerieDoctal.AutoSize = true;
            this.lblSerieDoctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerieDoctal.ForeColor = System.Drawing.Color.Maroon;
            this.lblSerieDoctal.Location = new System.Drawing.Point(6, 28);
            this.lblSerieDoctal.Name = "lblSerieDoctal";
            this.lblSerieDoctal.Size = new System.Drawing.Size(19, 20);
            this.lblSerieDoctal.TabIndex = 4;
            this.lblSerieDoctal.Text = "::";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.Location = new System.Drawing.Point(8, 516);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkStatus.Size = new System.Drawing.Size(139, 19);
            this.chkStatus.TabIndex = 18;
            this.chkStatus.Text = "Expediente Activo";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtOtraInfo
            // 
            this.txtOtraInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtraInfo.Location = new System.Drawing.Point(498, 399);
            this.txtOtraInfo.Multiline = true;
            this.txtOtraInfo.Name = "txtOtraInfo";
            this.txtOtraInfo.Size = new System.Drawing.Size(381, 112);
            this.txtOtraInfo.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(495, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Información Adicional :";
            // 
            // txtDescExpe
            // 
            this.txtDescExpe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescExpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescExpe.Location = new System.Drawing.Point(8, 399);
            this.txtDescExpe.Multiline = true;
            this.txtDescExpe.Name = "txtDescExpe";
            this.txtDescExpe.Size = new System.Drawing.Size(475, 112);
            this.txtDescExpe.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descripción del Expediente :";
            // 
            // txtNombreExp
            // 
            this.txtNombreExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreExp.Location = new System.Drawing.Point(8, 308);
            this.txtNombreExp.Name = "txtNombreExp";
            this.txtNombreExp.Size = new System.Drawing.Size(410, 20);
            this.txtNombreExp.TabIndex = 13;
            this.txtNombreExp.Leave += new System.EventHandler(this.txtNombreExp_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre del Expediente :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtConsecutivo);
            this.groupBox1.Controls.Add(this.chkConsecutivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(554, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consecutivo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Número Consecutivo :";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(225, 45);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(87, 21);
            this.txtConsecutivo.TabIndex = 1;
            this.txtConsecutivo.TextChanged += new System.EventHandler(this.txtConsecutivo_TextChanged);
            this.txtConsecutivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsecutivo_KeyPress);
            // 
            // chkConsecutivo
            // 
            this.chkConsecutivo.AutoSize = true;
            this.chkConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsecutivo.Location = new System.Drawing.Point(14, 23);
            this.chkConsecutivo.Name = "chkConsecutivo";
            this.chkConsecutivo.Size = new System.Drawing.Size(153, 17);
            this.chkConsecutivo.TabIndex = 0;
            this.chkConsecutivo.Text = "Ingresar Consecutivo?";
            this.chkConsecutivo.UseVisualStyleBackColor = true;
            this.chkConsecutivo.CheckedChanged += new System.EventHandler(this.chkConsecutivo_CheckedChanged);
            // 
            // chkAddTema
            // 
            this.chkAddTema.AutoSize = true;
            this.chkAddTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddTema.Location = new System.Drawing.Point(424, 310);
            this.chkAddTema.Name = "chkAddTema";
            this.chkAddTema.Size = new System.Drawing.Size(105, 17);
            this.chkAddTema.TabIndex = 20;
            this.chkAddTema.Text = "Agregar Tema";
            this.chkAddTema.UseVisualStyleBackColor = true;
            this.chkAddTema.CheckedChanged += new System.EventHandler(this.chkAddTema_CheckedChanged);
            // 
            // chkDigitalizado
            // 
            this.chkDigitalizado.AutoSize = true;
            this.chkDigitalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDigitalizado.Location = new System.Drawing.Point(8, 346);
            this.chkDigitalizado.Name = "chkDigitalizado";
            this.chkDigitalizado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDigitalizado.Size = new System.Drawing.Size(193, 19);
            this.chkDigitalizado.TabIndex = 21;
            this.chkDigitalizado.Text = "Tiene Archivo Digitalizado";
            this.chkDigitalizado.UseVisualStyleBackColor = true;
            this.chkDigitalizado.CheckedChanged += new System.EventHandler(this.chkDigitalizado_CheckedChanged);
            // 
            // lblArchivoDig
            // 
            this.lblArchivoDig.AutoSize = true;
            this.lblArchivoDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoDig.Location = new System.Drawing.Point(207, 348);
            this.lblArchivoDig.Name = "lblArchivoDig";
            this.lblArchivoDig.Size = new System.Drawing.Size(15, 13);
            this.lblArchivoDig.TabIndex = 22;
            this.lblArchivoDig.Text = "::";
            // 
            // cmdChangeFile
            // 
            this.cmdChangeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChangeFile.Location = new System.Drawing.Point(471, 342);
            this.cmdChangeFile.Name = "cmdChangeFile";
            this.cmdChangeFile.Size = new System.Drawing.Size(125, 23);
            this.cmdChangeFile.TabIndex = 23;
            this.cmdChangeFile.Text = "Cambiar Archivo";
            this.cmdChangeFile.UseVisualStyleBackColor = true;
            // 
            // cmdAddFiles
            // 
            this.cmdAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddFiles.Location = new System.Drawing.Point(599, 342);
            this.cmdAddFiles.Name = "cmdAddFiles";
            this.cmdAddFiles.Size = new System.Drawing.Size(153, 23);
            this.cmdAddFiles.TabIndex = 24;
            this.cmdAddFiles.Text = "Agregar Otro Archivo";
            this.cmdAddFiles.UseVisualStyleBackColor = true;
            this.cmdAddFiles.Click += new System.EventHandler(this.cmdAddFiles_Click);
            // 
            // SerieDocumental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdAddFiles);
            this.Controls.Add(this.cmdChangeFile);
            this.Controls.Add(this.lblArchivoDig);
            this.Controls.Add(this.chkDigitalizado);
            this.Controls.Add(this.chkAddTema);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtOtraInfo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescExpe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreExp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gpoSerieDoctal);
            this.Controls.Add(this.gpoCveSevi);
            this.Controls.Add(this.gpoDetallesDoc);
            this.Controls.Add(this.gpoCrearSerieDoctal);
            this.Name = "SerieDocumental";
            this.Size = new System.Drawing.Size(890, 540);
            this.gpoCrearSerieDoctal.ResumeLayout(false);
            this.gpoCrearSerieDoctal.PerformLayout();
            this.gpoDetallesDoc.ResumeLayout(false);
            this.gpoDetallesDoc.PerformLayout();
            this.gpoCveSevi.ResumeLayout(false);
            this.gpoCveSevi.PerformLayout();
            this.gpoSerieDoctal.ResumeLayout(false);
            this.gpoSerieDoctal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoCrearSerieDoctal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpoDetallesDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboValorDoctal;
        private System.Windows.Forms.ComboBox cboClasificaciones;
        private System.Windows.Forms.GroupBox gpoCveSevi;
        private System.Windows.Forms.TextBox txtCveSevi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTieneSevi;
        private System.Windows.Forms.GroupBox gpoSerieDoctal;
        private System.Windows.Forms.CheckBox chkStatus;
        public System.Windows.Forms.TextBox txtOtraInfo = new System.Windows.Forms.TextBox(); //
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtDescExpe = new System.Windows.Forms.TextBox(); //
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.CheckBox chkConsecutivo;
        private System.Windows.Forms.Label lblSerieDoctal;
        private System.Windows.Forms.CheckBox chkAddTema;
        private System.Windows.Forms.CheckBox chkDigitalizado;
        private System.Windows.Forms.Label lblArchivoDig;
        private System.Windows.Forms.Button cmdChangeFile;
        private System.Windows.Forms.Button cmdAddFiles;
    }
}
