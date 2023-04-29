using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        public static Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sSQL = "SELECT * FROM MenuDataTable";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string dPicture = row["ticketPicture"].ToString();
                    string dName = row["ticketName"].ToString();
                    string dDescription = row["ticketDescription"].ToString();
                    string dQuantity = row["ticketQuantity"].ToString();
                    UserControl1[] listItems = new UserControl1[1];
                    for (int i = 0; i < listItems.Length; i++)
                    {
                        listItems[i] = new UserControl1();
                        var request = WebRequest.Create(dPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            listItems[i].Picture = Bitmap.FromStream(stream);
                            listItems[i].Picture = ResizeImage(listItems[i].Picture, 204, 126);
                        }
                        listItems[i].Title = dName;
                        listItems[i].Description = dDescription;
                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }
    }
}
