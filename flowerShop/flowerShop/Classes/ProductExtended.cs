using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ZXing;

namespace flowerShop.Classes
{
    public class ProductExtended
    {
        public ProductExtended(Model.Product product)
        {
            this.Product = product;
        }
        public Model.Product Product { get; set; }

        //строка с заглушкой или фото+папка
        public string ProductPhotoPath
        {
            get
            {
                string temp = Environment.CurrentDirectory + "/Images/" + Product.ProductPhoto;
                if (!File.Exists(temp))
                {
                    temp = "/Resources/picture.png";

                }
                return temp;
            }

        }

        //цена со скидкой
        private double productCostWithDiscount;
        public double ProductCostWithDiscount
        {
            get
            {
                double temp = 0.0;
                double discount = (double)Product.ProductCost * (double)Product.ProductDiscount / 100;
                temp = (double)Product.ProductCost - discount;
                return temp;
            }
            set
            {
                productCostWithDiscount = value;
            }
        }

        public ImageSource ProductQRCode { 
            get {
                    // Создание объекта BarcodeWriter
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    // Установка кодировки на UTF-8
                    var encodingOptions = new ZXing.Common.EncodingOptions
                    {
                        Width = 100,
                        Height = 100,
                        Margin = 0
                    };

                    encodingOptions.Hints.Add(ZXing.EncodeHintType.CHARACTER_SET, "UTF-8");
                    barcodeWriter.Options = encodingOptions;
                    var bitmap = barcodeWriter.Write(Product.ProductArticle);

                return BitmapToImageSource(bitmap);
            }
        }

        private ImageSource BitmapToImageSource(System.Drawing.Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                memory.Position = 0;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }
}
