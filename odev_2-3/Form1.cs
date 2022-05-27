
using System.Text.RegularExpressions;

namespace odev_2_3
{
    public partial class Form1 : Form
    {
        object content = "";
        public Form1()
        {
            InitializeComponent();


        }
        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            content = fileContent;

            txtMetinYukle.Text = filePath;
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
        string[] Kelimeler;
        string[] Cumleler;
        object say = "";
        private void btnStackeOku_Click(object sender, EventArgs e)
        {
            LinkedListStack lstack = new LinkedListStack();
            lstack.Push(content);

            Metin metin = new Metin();

            string Cumle;
            List<string> tekil1 = new List<string>();
            Cumle = content.ToString().ToLower();
            Cumle = Cumle.ToLower();
            Cumleler = Cumle.Split('\n');

            for (int i = 0; i < Cumleler.Length; i++)
            {
                if (tekil1.Contains(Cumleler[i]) == false)
                {
                    tekil1.Add(Cumleler[i]);
                }
            }
            metin.CumleSayisi = Cumleler.Length;



            List<string> tekil = new List<string>();
            Cumle = Cumle.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "").Replace("'", "").Replace("\n", " ").Replace(".", " ");
            Kelimeler = Cumle.Split(' ');

            for (int i = 0; i < Kelimeler.Length; i++)
            {
                if (tekil.Contains(Kelimeler[i]) == false)
                {
                    tekil.Add(Kelimeler[i]);
                }
            }
            metin.KelimeSayisi = Kelimeler.Length;

            metin.OrtKelimeSayisi = Kelimeler.Length / Cumleler.Length;

            txtStackeOku.Text = " Cümle sayýsý: " + metin.CumleSayisi + "\r" +
                "\n Kelime Sayýsý: " + metin.KelimeSayisi + "\r" +
                "\n Ortalama Kelime Sayýsý: " + metin.OrtKelimeSayisi;

        }


        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            Heap heap = new Heap(Kelimeler.Length);
            for (int i = 0; i < Kelimeler.Length; i++)
            {
                heap.Insert(Kelimeler[i]);
            }
        }

        private void btnKelimeGetir_Click(object sender, EventArgs e)
        {

            EnSikKullanilaanKelime();

            HeapSort sort = new HeapSort();
            sort.sort(Kelimeler);


        }
        public void EnSikKullanilaanKelime()
        {
            lblKelimeGetir.Items.Clear();
            string cumle;
            string[] kelimeler;
            List<string> tekil = new List<string>();
            cumle = content.ToString().ToLower();
            cumle = cumle.ToLower();
            cumle = cumle.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "").Replace("'", "").Replace("\n", " ").Replace(".", " ");
            kelimeler = cumle.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (tekil.Contains(kelimeler[i]) == false)
                {
                    tekil.Add(kelimeler[i]);
                }
            }

            int max = 0;
            string tut = "";
            int a = 0;
            foreach (string k in tekil)
            {
                int sayac = 0;
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    if (kelimeler[i] == k)
                    {
                        sayac++;
                    }
                    if (sayac >= max)
                    {
                        max = sayac;
                        tut = k;
                    }
                }
                lblKelimeGetir.Items.Add("\n" + k + "--> " + sayac + " adet\r");
            }
            lblKelimeGetir.Items.Add("En çok Geçen Kelime: " + tut + "--> " + max + " adet");

        }
        private void btnHashTabloOlustur_Click(object sender, EventArgs e)
        {
            HashMap hashMap = new HashMap();
            hashMap.Add(Kelimeler.Length, Kelimeler);

        }
    }
}