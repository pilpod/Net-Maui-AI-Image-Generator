using AndroidX.Navigation;
using Net_Maui_AI_Image_Generator.Models;
using System.Collections.ObjectModel;

namespace Net_Maui_AI_Image_Generator.Views;

public partial class DashboardView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

	public DashboardView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

    private void BtnCreateNewImage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenerationOptionsView());
    }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>() 
		{ 
			new Profile
			{
				Name = "Héctor",
				ProfileImage = "profile1_500.jpg",
				NoPhotos = 12
			},
            new Profile
            {
                Name = "Maddy",
                ProfileImage = "profile2_500.jpg",
                NoPhotos = 5
            },
            new Profile
            {
                Name = "John",
                ProfileImage = "profile3_500.jpg",
                NoPhotos = 3
            },
        };

        GeneratedImages = new ObservableCollection<GeneratedImage>()
        {
            new GeneratedImage
            {
                ImagePath = "dashboard1.jpg",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, trees, blue sky"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard2_1000.jpg",
                MainKeyword = "Mountains",
                Keywords = new List<string>
                {
                    "Landscape, photorealistic, dawn, mountain"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard3_1000.jpg",
                MainKeyword = "Robot",
                Keywords = new List<string>
                {
                    "AI, robotic, human, light, metal"
                }
            }
        };
    }
}