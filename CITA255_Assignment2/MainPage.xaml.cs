namespace CITA255_Assignment2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            gamesList.ItemsSource = games;
            hoursList.ItemsSource = hours;
        }

        List<string> games = new List<string>
        {
            "Kingdom Hearts series", "Deltarune", "Tsukihime", "Witch on the Holy Night", "Shin Megami Tensei V", "Crisis Core -FINAL FANTASY VII- Reunion", "Hades", "Final Fantasy XVI", "Metaphor: ReFantazio"
        };

        List<double> hours = new List<double>
        {
            48, 2.3, 0, 1.5, 10, 0, 3, 13, 9
        };

        private void TestButtonClicked(object sender, EventArgs e)
        {
            double total = 0;
            foreach (double hours in hours)
            {
                total = total + hours;
                Console.WriteLine(total);
            }

            totalLabel.Text = total.ToString() + " hours";
        }
    }
}
