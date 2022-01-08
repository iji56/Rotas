using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Rotas.Helper;
using Rotas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Poppins-Regular.ttf")]
[assembly: ExportFont("Poppins-Bold.ttf")]
namespace Rotas
{
    public partial class App : Application
    {
        public static UserRotas userRotas;
        public static ReferenceData referenceData;
        public App()
        {

        
            InitializeComponent();
            Sharpnado.Tabs.Initializer.Initialize(false, false);
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            readRotas();
            readReferenceData();
            MainPage = new NavigationPage(new MainPage());
        }


        public static void readRotas()
        {

            userRotas = new UserRotas();
            GetJsonData("UserRotas_MockData.json");

        }


        public static void readReferenceData()
        {
            referenceData = new ReferenceData();
            GetJsonData("ReferenceData.json");

        }
        private static void GetJsonData(string fileName)
        {
            string jsonFileName = fileName;

            var assembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"{assembly}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();


                if (fileName == "ReferenceData.json")
                {
                    referenceData = JsonConvert.DeserializeObject<ReferenceData>(jsonString);

                }
                else
                {
                    userRotas = JsonConvert.DeserializeObject<UserRotas>(jsonString);
                }

            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
