using System.Xml;

namespace HavaDurumu
{
    public partial class form1 : Form
    {
        string havaDurumuLink = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(havaDurumuLink);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");

            foreach (XmlNode node in nodes)
            {
                string il = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string mak_sicaklik = node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = il;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = mak_sicaklik;
                dataGridView1.Rows.Add(row);
            }
        }
    }
}