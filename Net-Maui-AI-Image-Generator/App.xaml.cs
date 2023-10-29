using Net_Maui_AI_Image_Generator.Views;

namespace Net_Maui_AI_Image_Generator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImageGeneratorView();
        }
    }
}