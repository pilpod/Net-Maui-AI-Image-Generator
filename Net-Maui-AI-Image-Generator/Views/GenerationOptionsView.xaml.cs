using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Net_Maui_AI_Image_Generator.Models;

namespace Net_Maui_AI_Image_Generator.Views;

public partial class GenerationOptionsView : ContentPage
{
    public List<string> Options { get; set; }
    public List<ArtStyle> Styles { get; set; }

    public GenerationOptionsView()
    {
        InitializeComponent();
        FillOptions();
        BindingContext = this;

        ModifyEntry();
    }

    private void FillOptions()
    {
        Options = new List<string>()
        {
            "World",
            "Winter",
            "Trees"
        };

        Styles = new List<ArtStyle>()
        {
            new ArtStyle() { Name = "Cartoon", ImageUrl = "cartoon_category.jpg"},
            new ArtStyle() { Name = "Anime", ImageUrl = "anime_category.jpg" },
            new ArtStyle() { Name = "Watercolor Art", ImageUrl = "watercolor_category.jpg" },
            new ArtStyle() { Name = "Realistic", ImageUrl = "realistic_category.jpg" }
        };

    }

    public void ModifyEntry()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
        });
    }
}