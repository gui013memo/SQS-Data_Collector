namespace DR_Collector
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private async void btn_Get_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            //var response  = await httpClient.GetAsync()

        }
    }
}