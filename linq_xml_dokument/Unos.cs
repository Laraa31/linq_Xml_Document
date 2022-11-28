using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_xml_dokument
{
    public partial class Unos : Form
    {
        List<Osoba> osobe=new List<Osoba>();
        public Unos()
        {
            InitializeComponent();
        }

        private void btnUnosPodataka_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(txtIme.ToString(), txtPrezime.ToString(), Convert.ToInt32(txtGodina));

            osobe.Add(osoba);

            DialogResult upit =MessageBox.Show("Želite li upisati još osoba", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (upit == DialogResult.Yes)
            {
                txtIme.Clear();
                txtPrezime.Clear();
                txtGodina.Clear();
            }
            else
            {
                var OsobeXml = new XDocument();
                OsobeXml.Add(new XElement("Osobe"));
                foreach(Osoba os in osobe)
                {
                    var Osoba = new XElement("Osoba",
                        new XElement("Ime", osoba.Ime), 
                        new XElement("Prezime", osoba.Prezime),
                        new XElement("GodRod", osoba.Godina));
                    OsobeXml.Root.Add(Osoba);
                }
                this.Close();
            }
        }
    }
}
