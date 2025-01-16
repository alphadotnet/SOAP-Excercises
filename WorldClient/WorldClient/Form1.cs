using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorldServiceReference;

namespace WorldClient
{
    public partial class Form1 : Form
    {
        private WorldServiceSoapClient _client;
        public Form1()
        {
            InitializeComponent();
            _client = new WorldServiceSoapClient(WorldServiceSoapClient.EndpointConfiguration.WorldServiceSoap);
        }

        private void btnGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức bất đồng bộ và chờ kết quả trả về với .Result
                var res = _client.GetAllCountriesAsync().Result;

                // Truy cập vào thuộc tính Body của GetAllCountriesResponse
                var countries = res.Body.GetAllCountriesResult;  // Truy cập vào GetAllCountriesResult trong Body

                // Thiết lập DataGridView để hiển thị các quốc gia
                dataGridViewCountries.Rows.Clear();  // Xóa các dòng cũ trong DataGridView

                // Duyệt qua danh sách quốc gia và thêm vào DataGridView
                foreach (var country in countries)
                {
                    // Thêm một dòng mới vào DataGridView
                    dataGridViewCountries.Rows.Add(country.Code, country.Name);
                }

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập các cột cho DataGridView1
            dataGridViewCountries.Columns.Clear();
            dataGridViewCountries.Columns.Add("Code", "Country Code");  // Cột cho Mã quốc gia
            dataGridViewCountries.Columns.Add("Name", "Country Name");  // Cột cho Tên quốc gia

            // Thiết lập các cột cho DataGridView2
            dataGridViewCity.Columns.Clear();
            dataGridViewCity.Columns.Add("ID", "ID");
            dataGridViewCity.Columns.Add("Name", "Name");
            dataGridViewCity.Columns.Add("CountryCode", "Country Code");
            dataGridViewCity.Columns.Add("District", "District");
        }

        private void btnGetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã quốc gia từ TextBox
                string countryCode = txtCountryCode.Text;

                // Gọi phương thức GetCountryByCodeAsync để lấy quốc gia theo mã
                var res = _client.GetCountryByCodeAsync(countryCode).Result;

                // Kiểm tra nếu không có quốc gia nào tìm thấy
                if (res == null || res.Body == null || res.Body.GetCountryByCodeResult == null)
                {
                    MessageBox.Show($"No country found with code {countryCode}");
                    return;
                }

                // Lấy quốc gia từ GetCountryByCodeResult
                var country = res.Body.GetCountryByCodeResult;

                // Kiểm tra nếu quốc gia có thông tin
                if (country != null)
                {
                    // Thiết lập DataGridView để hiển thị thông tin quốc gia
                    dataGridViewCountries.Rows.Clear();  // Xóa các dòng cũ trong DataGridView

                    // Thêm thông tin quốc gia vào DataGridView
                    dataGridViewCountries.Rows.Add(country.Code, country.Name);
                }
                else
                {
                    MessageBox.Show($"No country found for the code {countryCode}");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên thành phố từ TextBox
                string cityName = txtCityName.Text;

                // Gọi phương thức GetCityByNameAsync để lấy thành phố theo tên
                var res = _client.GetCityByNameAsync(cityName).Result;

                // Kiểm tra nếu không có thành phố nào tìm thấy
                if (res == null || res.Body == null || res.Body.GetCityByNameResult == null)
                {
                    MessageBox.Show($"No city found with name {cityName}");
                    return;
                }

                // Lấy thành phố từ GetCityByNameResult
                var city = res.Body.GetCityByNameResult;

                // Kiểm tra nếu thành phố có thông tin
                if (city != null)
                {
                    // Thiết lập DataGridView để hiển thị thông tin thành phố
                    dataGridViewCity.Rows.Clear();  // Xóa các dòng cũ trong DataGridView

                    // Thêm thông tin thành phố vào DataGridView
                    dataGridViewCity.Rows.Add(city.ID, city.Name, city.CountryCode, city.District);
                }
                else
                {
                    MessageBox.Show($"No city found for the name {cityName}");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetCitiesByCountryCode_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã quốc gia từ TextBox
                string countryCode = txtCountryCodeCities.Text;

                // Gọi phương thức GetCitiesByCountryCodeAsync để lấy danh sách thành phố theo mã quốc gia
                var res = _client.GetCitiesByCountryCodeAsync(countryCode).Result;

                // Kiểm tra nếu không có thành phố nào tìm thấy
                if (res?.Body?.GetCitiesByCountryCodeResult == null || !res.Body.GetCitiesByCountryCodeResult.Any())
                {
                    MessageBox.Show($"No cities found for country code {countryCode}");
                    return;
                }

                // Lấy danh sách thành phố từ GetCitiesByCountryCodeResult
                var cities = res.Body.GetCitiesByCountryCodeResult;

                // Kiểm tra nếu danh sách thành phố có thông tin
                if (cities != null && cities.Any())
                {
                    // Thiết lập DataGridView để hiển thị thông tin thành phố
                    dataGridViewCity.Rows.Clear();  // Xóa các dòng cũ trong DataGridView

                    // Thêm thông tin thành phố vào DataGridView
                    foreach (var city in cities)
                    {
                        dataGridViewCity.Rows.Add(city.ID, city.Name, city.CountryCode, city.District);
                    }
                }
                else
                {
                    MessageBox.Show($"No cities found for the country code {countryCode}");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
