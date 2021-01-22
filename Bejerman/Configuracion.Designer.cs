namespace Bejerman
{
    partial class Configuracion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.DGVConfig = new System.Windows.Forms.DataGridView();
            this.BrnGuardar = new System.Windows.Forms.Button();
            this.TxtOrigen = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.Carpetaguardar = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.PuntodeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntodeVentaElec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AperturaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVConfig
            // 
            this.DGVConfig.AllowUserToAddRows = false;
            this.DGVConfig.AllowUserToDeleteRows = false;
            this.DGVConfig.AllowUserToResizeColumns = false;
            this.DGVConfig.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            this.DGVConfig.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVConfig.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGVConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVConfig.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVConfig.ColumnHeadersHeight = 25;
            this.DGVConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PuntodeVenta,
            this.PuntodeVentaElec,
            this.CodigoZona,
            this.AperturaContable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVConfig.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGVConfig.EnableHeadersVisualStyles = false;
            this.DGVConfig.GridColor = System.Drawing.SystemColors.Window;
            this.DGVConfig.Location = new System.Drawing.Point(12, 12);
            this.DGVConfig.MaximumSize = new System.Drawing.Size(782, 366);
            this.DGVConfig.MinimumSize = new System.Drawing.Size(782, 366);
            this.DGVConfig.MultiSelect = false;
            this.DGVConfig.Name = "DGVConfig";
            this.DGVConfig.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVConfig.RowHeadersVisible = false;
            this.DGVConfig.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVConfig.Size = new System.Drawing.Size(782, 366);
            this.DGVConfig.TabIndex = 0;
            // 
            // BrnGuardar
            // 
            this.BrnGuardar.Location = new System.Drawing.Point(719, 382);
            this.BrnGuardar.Name = "BrnGuardar";
            this.BrnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BrnGuardar.TabIndex = 1;
            this.BrnGuardar.Text = "Guardar";
            this.BrnGuardar.UseVisualStyleBackColor = true;
            this.BrnGuardar.Click += new System.EventHandler(this.BrnGuardar_Click);
            // 
            // TxtOrigen
            // 
            this.TxtOrigen.Location = new System.Drawing.Point(53, 385);
            this.TxtOrigen.Name = "TxtOrigen";
            this.TxtOrigen.Size = new System.Drawing.Size(395, 20);
            this.TxtOrigen.TabIndex = 2;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(638, 383);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSeleccionar.TabIndex = 4;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Archivo:";
            // 
            // PuntodeVenta
            // 
            this.PuntodeVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuntodeVenta.FillWeight = 20F;
            this.PuntodeVenta.HeaderText = "Punto de Venta Manual";
            this.PuntodeVenta.MaxInputLength = 4;
            this.PuntodeVenta.Name = "PuntodeVenta";
            this.PuntodeVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PuntodeVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PuntodeVentaElec
            // 
            this.PuntodeVentaElec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuntodeVentaElec.FillWeight = 20F;
            this.PuntodeVentaElec.HeaderText = "Punto de Venta Electrónico";
            this.PuntodeVentaElec.MaxInputLength = 4;
            this.PuntodeVentaElec.Name = "PuntodeVentaElec";
            this.PuntodeVentaElec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PuntodeVentaElec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CodigoZona
            // 
            this.CodigoZona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodigoZona.FillWeight = 20F;
            this.CodigoZona.HeaderText = "Código Zona";
            this.CodigoZona.MaxInputLength = 4;
            this.CodigoZona.Name = "CodigoZona";
            this.CodigoZona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoZona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AperturaContable
            // 
            this.AperturaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AperturaContable.FillWeight = 20F;
            this.AperturaContable.HeaderText = "Apertura Contable";
            this.AperturaContable.MaxInputLength = 4;
            this.AperturaContable.Name = "AperturaContable";
            this.AperturaContable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AperturaContable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(806, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.TxtOrigen);
            this.Controls.Add(this.BrnGuardar);
            this.Controls.Add(this.DGVConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 458);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración parámetros Bejerman";
            ((System.ComponentModel.ISupportInitialize)(this.DGVConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVConfig;
        private System.Windows.Forms.Button BrnGuardar;
        private System.Windows.Forms.TextBox TxtOrigen;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.FolderBrowserDialog Carpetaguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntodeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntodeVentaElec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn AperturaContable;
    }
}

