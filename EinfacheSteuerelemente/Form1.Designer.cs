
namespace EinfacheSteuerelemente
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtEingabe = new System.Windows.Forms.TextBox();
			this.btnAusgabe = new System.Windows.Forms.Button();
			this.btnRechnen = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.nUpDwnEingabe = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nUpDwnEingabe)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEingabe
			// 
			this.txtEingabe.Location = new System.Drawing.Point(12, 12);
			this.txtEingabe.Name = "txtEingabe";
			this.txtEingabe.Size = new System.Drawing.Size(172, 20);
			this.txtEingabe.TabIndex = 0;
			// 
			// btnAusgabe
			// 
			this.btnAusgabe.Location = new System.Drawing.Point(213, 12);
			this.btnAusgabe.Name = "btnAusgabe";
			this.btnAusgabe.Size = new System.Drawing.Size(75, 23);
			this.btnAusgabe.TabIndex = 1;
			this.btnAusgabe.Text = "Ausgabe";
			this.btnAusgabe.UseVisualStyleBackColor = true;
			this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
			// 
			// btnRechnen
			// 
			this.btnRechnen.Location = new System.Drawing.Point(213, 42);
			this.btnRechnen.Name = "btnRechnen";
			this.btnRechnen.Size = new System.Drawing.Size(75, 23);
			this.btnRechnen.TabIndex = 2;
			this.btnRechnen.Text = "Rechnen";
			this.btnRechnen.UseVisualStyleBackColor = true;
			this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(12, 88);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 3;
			this.lblAusgabe.Text = "label1";
			// 
			// nUpDwnEingabe
			// 
			this.nUpDwnEingabe.DecimalPlaces = 1;
			this.nUpDwnEingabe.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nUpDwnEingabe.Location = new System.Drawing.Point(12, 44);
			this.nUpDwnEingabe.Name = "nUpDwnEingabe";
			this.nUpDwnEingabe.Size = new System.Drawing.Size(120, 20);
			this.nUpDwnEingabe.TabIndex = 4;
			this.nUpDwnEingabe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nUpDwnEingabe.ValueChanged += new System.EventHandler(this.nUpDwnEingabe_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 146);
			this.Controls.Add(this.nUpDwnEingabe);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnRechnen);
			this.Controls.Add(this.btnAusgabe);
			this.Controls.Add(this.txtEingabe);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nUpDwnEingabe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEingabe;
		private System.Windows.Forms.Button btnAusgabe;
		private System.Windows.Forms.Button btnRechnen;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.NumericUpDown nUpDwnEingabe;
	}
}

