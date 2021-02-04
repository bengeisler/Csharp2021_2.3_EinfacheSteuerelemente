using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EinfacheSteuerelemente
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAusgabe_Click(object sender, EventArgs e)
		{
			lblAusgabe.Text =
				"Sie haben '"
				+ txtEingabe.Text
				+ "' eingegeben.";
		}

		private void btnRechnen_Click(object sender, EventArgs e)
		{
			double wert;
			wert = Convert.ToDouble(txtEingabe.Text); // string in double konvertieren
			wert *= 2; // Identisch mit : wert = wert * 2
			lblAusgabe.Text = "Ergebnis: " + wert;

		}

		private void nUpDwnEingabe_ValueChanged(object sender, EventArgs e)
		{
			lblAusgabe.Text =
				"Eingegebene Zahl: "
				+ nUpDwnEingabe.Value;
		}
	}
}
