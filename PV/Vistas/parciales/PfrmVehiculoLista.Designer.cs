﻿namespace PV.Vistas.parciales
{
    partial class PfrmVehiculoLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfrmVehiculoLista));
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.idVehiculoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusExistentes = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.editarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(12, 28);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(317, 24);
            this.txtNombre.TabIndex = 31;
            // 
            // grdExistentes
            // 
            this.grdExistentes.AllowUserToAddRows = false;
            this.grdExistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdExistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExistentes.BackgroundColor = System.Drawing.Color.White;
            this.grdExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdExistentes.ColumnHeadersHeight = 30;
            this.grdExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editarCol,
            this.eliminarCol,
            this.idVehiculoCol,
            this.tipoCol,
            this.marcaCol,
            this.lineaCol,
            this.modeloCol,
            this.placaCol,
            this.colorCol,
            this.fechaIngresoCol,
            this.estadoCol,
            this.precioCol,
            this.observacionesCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdExistentes.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(0, 87);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.ReadOnly = true;
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdExistentes.RowHeadersWidth = 20;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdExistentes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdExistentes.RowTemplate.Height = 30;
            this.grdExistentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExistentes.Size = new System.Drawing.Size(960, 353);
            this.grdExistentes.TabIndex = 36;
            this.grdExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExistentes_CellClick);
            // 
            // idVehiculoCol
            // 
            this.idVehiculoCol.DataPropertyName = "idVehiculo";
            this.idVehiculoCol.HeaderText = "Código";
            this.idVehiculoCol.MaxInputLength = 10;
            this.idVehiculoCol.Name = "idVehiculoCol";
            this.idVehiculoCol.ReadOnly = true;
            this.idVehiculoCol.Visible = false;
            // 
            // tipoCol
            // 
            this.tipoCol.DataPropertyName = "tipoVehiculo";
            this.tipoCol.HeaderText = "Tipo";
            this.tipoCol.MaxInputLength = 60;
            this.tipoCol.Name = "tipoCol";
            this.tipoCol.ReadOnly = true;
            // 
            // marcaCol
            // 
            this.marcaCol.DataPropertyName = "marca";
            this.marcaCol.HeaderText = "Marca";
            this.marcaCol.MaxInputLength = 60;
            this.marcaCol.Name = "marcaCol";
            this.marcaCol.ReadOnly = true;
            // 
            // lineaCol
            // 
            this.lineaCol.DataPropertyName = "linea";
            this.lineaCol.HeaderText = "Linea";
            this.lineaCol.MaxInputLength = 60;
            this.lineaCol.Name = "lineaCol";
            this.lineaCol.ReadOnly = true;
            // 
            // modeloCol
            // 
            this.modeloCol.DataPropertyName = "modelo";
            this.modeloCol.HeaderText = "Modelo";
            this.modeloCol.MaxInputLength = 60;
            this.modeloCol.Name = "modeloCol";
            this.modeloCol.ReadOnly = true;
            // 
            // placaCol
            // 
            this.placaCol.DataPropertyName = "placa";
            this.placaCol.HeaderText = "Placa";
            this.placaCol.MaxInputLength = 60;
            this.placaCol.Name = "placaCol";
            this.placaCol.ReadOnly = true;
            // 
            // colorCol
            // 
            this.colorCol.DataPropertyName = "color";
            this.colorCol.HeaderText = "Color";
            this.colorCol.MaxInputLength = 60;
            this.colorCol.Name = "colorCol";
            this.colorCol.ReadOnly = true;
            // 
            // fechaIngresoCol
            // 
            this.fechaIngresoCol.DataPropertyName = "fechaIngreso";
            this.fechaIngresoCol.HeaderText = "Fecha Ingreso";
            this.fechaIngresoCol.MaxInputLength = 60;
            this.fechaIngresoCol.Name = "fechaIngresoCol";
            this.fechaIngresoCol.ReadOnly = true;
            // 
            // estadoCol
            // 
            this.estadoCol.DataPropertyName = "estado";
            this.estadoCol.HeaderText = "Estado";
            this.estadoCol.MaxInputLength = 20;
            this.estadoCol.Name = "estadoCol";
            this.estadoCol.ReadOnly = true;
            // 
            // precioCol
            // 
            this.precioCol.DataPropertyName = "precioVenta";
            this.precioCol.HeaderText = "Precio Venta";
            this.precioCol.MaxInputLength = 20;
            this.precioCol.Name = "precioCol";
            this.precioCol.ReadOnly = true;
            // 
            // observacionesCol
            // 
            this.observacionesCol.DataPropertyName = "observaciones";
            this.observacionesCol.HeaderText = "Observaciones";
            this.observacionesCol.MaxInputLength = 1200;
            this.observacionesCol.MinimumWidth = 100;
            this.observacionesCol.Name = "observacionesCol";
            this.observacionesCol.ReadOnly = true;
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 443);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Size = new System.Drawing.Size(960, 22);
            this.statusExistentes.TabIndex = 37;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn1.FillWeight = 121.8274F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PV.Properties.Resources.Pencil_Tip_24px;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 53.33205F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PV.Properties.Resources.Delete_24px;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // editarCol
            // 
            this.editarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.editarCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.editarCol.FillWeight = 121.8274F;
            this.editarCol.HeaderText = "";
            this.editarCol.Image = global::PV.Properties.Resources.Pencil_Tip_24px;
            this.editarCol.MinimumWidth = 30;
            this.editarCol.Name = "editarCol";
            this.editarCol.ReadOnly = true;
            this.editarCol.Width = 30;
            // 
            // eliminarCol
            // 
            this.eliminarCol.FillWeight = 53.33205F;
            this.eliminarCol.HeaderText = "";
            this.eliminarCol.Image = global::PV.Properties.Resources.Delete_24px;
            this.eliminarCol.MinimumWidth = 30;
            this.eliminarCol.Name = "eliminarCol";
            this.eliminarCol.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::PV.Properties.Resources.Search_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(343, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::PV.Properties.Resources.Delete_Property_24px;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(534, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 24);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Image = global::PV.Properties.Resources.Add_Property_24px;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.Location = new System.Drawing.Point(433, 28);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(95, 24);
            this.btnGrabar.TabIndex = 33;
            this.btnGrabar.Text = "Nuevo";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // PfrmListaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 465);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtNombre);
            this.Name = "PfrmListaVehiculo";
            this.Text = "frmPListaVehiculos";
            this.Load += new System.EventHandler(this.PfrmListaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.DataGridViewImageColumn editarCol;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesCol;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;

    }
}