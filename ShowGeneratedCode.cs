using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassengerCodeApp
{
    public partial class ShowGeneratedCode : Form
    {
        private string _imageUrl;
        private string _passengerCode;

        public ShowGeneratedCode(string imageURL, string passengerCode)
        {
            InitializeComponent();
            _imageUrl = imageURL;
            _passengerCode = passengerCode;
        }

        private void ShowGeneratedCode_Load(object sender, EventArgs e)
        {
            try
            {
                using WebClient webClient = new WebClient();
                var imageData = webClient.DownloadData(_imageUrl);
                var memoryStream = new MemoryStream(imageData);
                var image = Image.FromStream(memoryStream);

                pictureBox1.Image = image;
                labelTheCode.Text = _passengerCode;
            }
            catch
            {

            }

        }
    }
}
