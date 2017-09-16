using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NotHotDogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picImagen_Click(object sender, EventArgs e)
        {
            fileImagen.ShowDialog();

            var ruta = fileImagen.FileName;

            if (string.IsNullOrWhiteSpace(ruta)) return;

            picImagen.Image = new Bitmap(ruta);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picResultado.Image = global::NotHotDogApp.Properties.Resources.Resultado;

            AnalizarImagen(ruta);

        }

        private async void AnalizarImagen(string ruta)
        {
            //Una de las dos Llaves obtenidas desde la pagina de Azure
            string llave = "70b9d7586a78433aaf2637288beee79e";

            //La url ofrecida por el  servicio de Azure.
            string urlServicio = "https://westcentralus.api.cognitive.microsoft.com/vision/v1.0/analyze";


            HttpClient cliente = new HttpClient();

            // Encabezado de la solicitud.
            cliente.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", llave);

            // Parametros que se envian como parte de la URL.
            string requestParameters = string.Format("visualFeatures=Description&subscription-key={0}", llave);

            // Url completa de la solicitud
            string uriCompleta = urlServicio + "?" + requestParameters;

            HttpResponseMessage response;

            // Se convierte la  imagen a un conjunto de bits para ser enviado como  cuerpo de la solicitud
            FileStream fileStream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] bitImagen = binaryReader.ReadBytes((int)fileStream.Length);

            using (ByteArrayContent content = new ByteArrayContent(bitImagen))
            {
                //Se especifica el tipo de contenido de la solicitud, en este caso datos binarios.
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                // Se ejecuta el  llamado al API
                response = await cliente.PostAsync(uriCompleta, content);

                // Se obtiene la respuesta.
                string contentString = await response.Content.ReadAsStringAsync();


                dynamic dynJson = JsonConvert.DeserializeObject(contentString);
                foreach (var item in dynJson)
                {
                    string valor = ((Newtonsoft.Json.Linq.JContainer)item).First.ToString();

                    if (valor.ToUpper().Contains("HOTDOG") || valor.ToUpper().Contains("HOT DOG"))
                    {
                        this.picResultado.Image = global::NotHotDogApp.Properties.Resources.YesHDResult;
                        return;
                    }

                }

                this.picResultado.Image = global::NotHotDogApp.Properties.Resources.NotHDResult;
            }
        }
    }
}
