
namespace Conversor_de_monedas
{
    partial class Form1
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
            this.Moneda = new System.Windows.Forms.Label();
            this.MonedaAC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YenCon = new System.Windows.Forms.TextBox();
            this.EuroCon = new System.Windows.Forms.TextBox();
            this.DolarCanCon = new System.Windows.Forms.TextBox();
            this.PesoCon = new System.Windows.Forms.TextBox();
            this.DolarCon = new System.Windows.Forms.TextBox();
            this.Yen = new System.Windows.Forms.Label();
            this.Euro = new System.Windows.Forms.Label();
            this.DolarCan = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.Dolar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Moneda
            // 
            this.Moneda.AutoSize = true;
            this.Moneda.Location = new System.Drawing.Point(12, 19);
            this.Moneda.Name = "Moneda";
            this.Moneda.Size = new System.Drawing.Size(46, 13);
            this.Moneda.TabIndex = 0;
            this.Moneda.Text = "Moneda";
            // 
            // MonedaAC
            // 
            this.MonedaAC.FormattingEnabled = true;
            this.MonedaAC.Items.AddRange(new object[] {
            "USD - Dolar estadounidense",
            "MXN - Peso mexicano",
            "CAD - Dolar canadiense",
            "EUR - Euro",
            "JPY - Yen japones"});
            this.MonedaAC.Location = new System.Drawing.Point(15, 36);
            this.MonedaAC.Name = "MonedaAC";
            this.MonedaAC.Size = new System.Drawing.Size(141, 21);
            this.MonedaAC.TabIndex = 1;
            this.MonedaAC.SelectedIndexChanged += new System.EventHandler(this.MonedaAC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto";
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(229, 36);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(147, 20);
            this.Monto.TabIndex = 3;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(229, 78);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(100, 27);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YenCon);
            this.groupBox1.Controls.Add(this.EuroCon);
            this.groupBox1.Controls.Add(this.DolarCanCon);
            this.groupBox1.Controls.Add(this.PesoCon);
            this.groupBox1.Controls.Add(this.DolarCon);
            this.groupBox1.Controls.Add(this.Yen);
            this.groupBox1.Controls.Add(this.Euro);
            this.groupBox1.Controls.Add(this.DolarCan);
            this.groupBox1.Controls.Add(this.Peso);
            this.groupBox1.Controls.Add(this.Dolar);
            this.groupBox1.Location = new System.Drawing.Point(15, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversiones";
            // 
            // YenCon
            // 
            this.YenCon.Location = new System.Drawing.Point(208, 139);
            this.YenCon.Name = "YenCon";
            this.YenCon.Size = new System.Drawing.Size(147, 20);
            this.YenCon.TabIndex = 9;
            // 
            // EuroCon
            // 
            this.EuroCon.Location = new System.Drawing.Point(208, 108);
            this.EuroCon.Name = "EuroCon";
            this.EuroCon.Size = new System.Drawing.Size(147, 20);
            this.EuroCon.TabIndex = 8;
            // 
            // DolarCanCon
            // 
            this.DolarCanCon.Location = new System.Drawing.Point(208, 78);
            this.DolarCanCon.Name = "DolarCanCon";
            this.DolarCanCon.Size = new System.Drawing.Size(147, 20);
            this.DolarCanCon.TabIndex = 7;
            // 
            // PesoCon
            // 
            this.PesoCon.Location = new System.Drawing.Point(208, 47);
            this.PesoCon.Name = "PesoCon";
            this.PesoCon.Size = new System.Drawing.Size(147, 20);
            this.PesoCon.TabIndex = 6;
            // 
            // DolarCon
            // 
            this.DolarCon.Location = new System.Drawing.Point(208, 18);
            this.DolarCon.Name = "DolarCon";
            this.DolarCon.Size = new System.Drawing.Size(147, 20);
            this.DolarCon.TabIndex = 5;
            // 
            // Yen
            // 
            this.Yen.AutoSize = true;
            this.Yen.Location = new System.Drawing.Point(8, 147);
            this.Yen.Name = "Yen";
            this.Yen.Size = new System.Drawing.Size(94, 13);
            this.Yen.TabIndex = 4;
            this.Yen.Text = "JPY - Yen japones";
            // 
            // Euro
            // 
            this.Euro.AutoSize = true;
            this.Euro.Location = new System.Drawing.Point(8, 116);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(61, 13);
            this.Euro.TabIndex = 3;
            this.Euro.Text = "EUR - Euro";
            // 
            // DolarCan
            // 
            this.DolarCan.AutoSize = true;
            this.DolarCan.Location = new System.Drawing.Point(8, 86);
            this.DolarCan.Name = "DolarCan";
            this.DolarCan.Size = new System.Drawing.Size(121, 13);
            this.DolarCan.TabIndex = 2;
            this.DolarCan.Text = "CAD - Dolar canadiense";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Location = new System.Drawing.Point(8, 54);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(64, 13);
            this.Peso.TabIndex = 1;
            this.Peso.Text = "MXN - Peso";
            // 
            // Dolar
            // 
            this.Dolar.AutoSize = true;
            this.Dolar.Location = new System.Drawing.Point(8, 25);
            this.Dolar.Name = "Dolar";
            this.Dolar.Size = new System.Drawing.Size(64, 13);
            this.Dolar.TabIndex = 0;
            this.Dolar.Text = "USD - Dolar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonedaAC);
            this.Controls.Add(this.Moneda);
            this.Name = "Form1";
            this.Text = "Conversor de monedas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Moneda;
        private System.Windows.Forms.ComboBox MonedaAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox YenCon;
        private System.Windows.Forms.TextBox EuroCon;
        private System.Windows.Forms.TextBox DolarCanCon;
        private System.Windows.Forms.TextBox PesoCon;
        private System.Windows.Forms.TextBox DolarCon;
        private System.Windows.Forms.Label Yen;
        private System.Windows.Forms.Label Euro;
        private System.Windows.Forms.Label DolarCan;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label Dolar;
    }
}

