namespace DR_Collector
{
    public partial class Main_form : Form
    {

        string data = string.Empty;

        public Main_form()
        {
            InitializeComponent();
        }

        public async void btn_Get_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync("http://172.16.0.2:55402/api/sqs/results?dateFrom=2023-07-29T04:20:00&dateTo=2023-07-29T04:30:02&station=Station-11&uniqueId=11-99.Work%20Finish");

            string data = await response.Content.ReadAsStringAsync();

            data = data.Trim(); 
        }


    }
}