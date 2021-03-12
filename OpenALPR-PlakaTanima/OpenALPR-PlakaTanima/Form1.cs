using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using openalprnet;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace PlakaTanima
{
    public partial class Form1 : Form

    {
        SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=PlakaTanim; Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase; 
                                                                         
                                                                         
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public Rectangle boundingRectangle(List<Point> points)//resmi küçültüp büyütüyo //kenar bulmayı yapıyor.
        {
            var minX = points.Min(p => p.X); // Sol taraftaki giriş değişkenlerini sağ taraftaki lambda gövdesinden ayırmak için kullanılır.en küçüğü bulur.
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        private static Image cropImage(Image img, Rectangle cropArea) // görüntüyü kırpıyorum. //croparea kırpma alanı
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat); //resmi pixellerine ayırdı.çoğalttı.
        }

        public static Bitmap combineImages(List<Image> images) //tüm görüntüleri belleğe okuyor.
        {
            Bitmap finalImage = null;
            // plkayaı okurken parçalıyo ve parçaları birbirine ekliyo teker teker.bileşenlerine ayırıyor.""
            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }
                //birleştirilen görüntüyü  tutmak için bitmap oluştur.
                finalImage = new Bitmap(width, height);
                using (var g = Graphics.FromImage(finalImage))//görüntüden bir grafik nesnesi elde edelim

                {
                    g.Clear(Color.Black);
                    var offset = 0; //her görüntüden geçip son görüntüye çiz

                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally //belleği temizle
            {
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }

        private void processImageFile(string fileName)//resim seç butonuna tıklanınca seçilenn resmin yolu string filename olarak attım.
        {
            txtPlaka.Text = "";
            resetControls();// bütün resimler boşta.
            var region = radioButton2.Checked ? "us" : "eu";
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf"); //yol oluşturma asıl burada başlıyor.assembly burada uri örneği oluşturuyor.
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
            using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
            {
                if (!alpr.IsLoaded())
                {
                    txtPlaka.Text = "Error initializing OpenALPR";
                    return;
                }
                picOriginResim.ImageLocation = fileName;                                     // seçtiğim yoldaki resmi ana ekrana alıyorum
                picOriginResim.Load();                                                       //resmi yükleme yapıyor.

                var results = alpr.Recognize(fileName);                                     //tanımayı yapıyor.

                var images = new List<Image>(results.Plates.Count()); // plaka sayısını atıyor.
                var i = 1;
                foreach (var result in results.Plates)                                                  //Resim düzenlemesi yapıyor.//düzenlenen resmi de diğer picboxa atıcak.
                {
                    var rect = boundingRectangle(result.PlatePoints);                                   // resmi çerçeveleyecek.
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                    images.Add(cropped);            //Buralar bulduğu plaka sayısına göre döngüye giriyor.

                    txtPlaka.Text = EnBenzeyenPlakayiGetir(result.TopNPlates);
                }

                if (images.Any())
                {
                    picPlakaResmi.Image = combineImages(images);                               // oluşturulan resmi picplakaresmine attım.
                }
            }
        }

        private string EnBenzeyenPlakayiGetir(List<AlprPlateNet> plakalar) //Plakayı bulmaya çalışıyyor en çok neye benziyor karakterler diye.
        {
            foreach (var item in plakalar)
            {
                return item.Characters.PadRight(12);
            }
            return "";
        }

        private void resetControls()
        {
            picOriginResim.Image = null;
            picPlakaResmi.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetControls();
        }

      

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) //kontrol metodum. REsimler boş mu dolu mu onnu kontrol edecek.
            {
                processImageFile(openFileDialog.FileName); //resim seçtirdim .Proccessımagefile methoduna attım.
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DEMET\\SQLEXPRESS;Initial Catalog=PlakaTanima;Integrated Security=True");
            if (baglanti.State == ConnectionState.Closed) 
                baglanti.Open();
                string kayıt = "insert into dbo.plaka(Plakalar) values(@çekilen_plaka)";
                SqlCommand cmd = new SqlCommand(kayıt, baglanti);
                cmd.Parameters.AddWithValue("@çekilen_plaka", txtPlaka.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Plaka Kayıt İşlemi Gerçekleşti.");
        }

        private void KontrolClick_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DEMET\\SQLEXPRESS;Initial Catalog=PlakaTanima;Integrated Security=True");

            if (baglanti.State == ConnectionState.Closed) 
                 baglanti.Open();
                 SqlCommand cmd = new SqlCommand("select Plakalar from plaka",baglanti);
                    cmd.Parameters.AddWithValue("@Plakalar", txtPlaka.Text);
                    cmd.Connection = baglanti;
                 SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                txtPlaka.Text = sdr["Plakalar"].ToString();
                MessageBox.Show("geçebilir");
            }
            else
                MessageBox.Show("geçemez");


            
                 baglanti.Close();

        }
    }
}