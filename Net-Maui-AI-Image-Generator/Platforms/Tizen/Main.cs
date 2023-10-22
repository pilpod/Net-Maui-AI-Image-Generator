using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Net_Maui_AI_Image_Generator
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}