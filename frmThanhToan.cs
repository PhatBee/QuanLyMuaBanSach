﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyMuaBanSach
{
    public partial class frmThanhToan : Form
    {
        DataTable _tbDichVu = new DataTable();
        DataTable dt = new DataTable();
        MyDB mydb = new MyDB();
        private int soTien;
        private string soHD;
        public frmThanhToan(int soTien, string soHD)
        {
            InitializeComponent();
            this.soTien = soTien;
            this.soHD = soHD;
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            try
            {
                var apiRequest = new ApiRequest();

                if (cbxNganHang.SelectedValue.ToString() == "970415")
                {
                    apiRequest.acqId = Convert.ToInt32(cbxNganHang.SelectedValue.ToString());
                    apiRequest.accountNo = long.Parse("108875270343");
                    apiRequest.accountName = "NGUYEN HOAI TAN";
                    apiRequest.amount = Convert.ToInt32(soTien);
                    apiRequest.format = "text";
                    apiRequest.template = cbxLoaiQR.Text;
                }
                else if (cbxNganHang.SelectedValue.ToString() == "970436")
                {
                    apiRequest.acqId = Convert.ToInt32(cbxNganHang.SelectedValue.ToString());
                    apiRequest.accountNo = long.Parse("1015708276");
                    apiRequest.accountName = "ONG VINH PHAT";
                    apiRequest.amount = Convert.ToInt32(soTien);
                    apiRequest.format = "text";
                    apiRequest.template = cbxLoaiQR.Text;
                }

                var jsonRequest = JsonConvert.SerializeObject(apiRequest);
                // use restsharp for request api.
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pictureBox1.Image = image;

                lblTenTaiKhoan.Text = apiRequest.accountName;
                lblSoTaiKhoan.Text = apiRequest.accountNo.ToString();
                lblNganHang.Text = cbxNganHang.Text;
                lblNoiDung.Text = "Thanh toán hóa đơn: " + soHD;

                lblSoTien.Text = Convert.ToInt32(soTien).ToString("#,##0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            try
            {

                using (WebClient client = new WebClient())
                {
                    var htmlData = client.DownloadData("https://raw.githubusercontent.com/PhatBee/QR/main/API.json");
                    var bankRawJson = Encoding.UTF8.GetString(htmlData);
                    var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                    cbxNganHang.DataSource = listBankData.data;   // list banks
                    cbxNganHang.DisplayMember = "shortName";
                    cbxNganHang.ValueMember = "bin";
                    cbxNganHang.SelectedValue = listBankData.data.FirstOrDefault().bin;
                    cbxLoaiQR.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có kết nối internet!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
