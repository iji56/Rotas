using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotas.Models;
using Rotas.ViewModels;
using Xamarin.Forms;

namespace Rotas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext  = new MainPageViewModel(Navigation);
            Animate();
        }

        private async void Animate()
        {
           
           await SelectionBar.TranslateTo( btnPosts.X-5, 0, 0, null);
            SelectionBar.BackgroundColor = Color.FromHex("#232396");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }

        #region Top Tab Animation
        private void ContentType_Tapped(object sender, EventArgs e)
        {
            double childPos = ((StackLayout)sender).Children[0].X;
            double parentPos= ((StackLayout)sender).X;
            int index = Convert.ToInt32(((StackLayout)sender).ClassId);
            NagivateTabs(index, true, parentPos,childPos);
        }


        private async void NagivateTabs(int index, bool navigate, double parentPos, double childPos)
        {
            
            if (navigate)
                carousel.Position = index;

            var totalWidth = BarContainer.Width;
            switch (index)
            {
                case 0:
                   
                    btnContests.TextColor = Color.FromHex("#000000");
                    btnactive.TextColor = Color.FromHex("#000000");
                    var animateall = new Animation(d => SelectionBar.WidthRequest = d, 49, 29, Easing.SpringIn);
                    animateall.Commit(SelectionBar, "BarGraph", 10, 200);
                    await SelectionBar.TranslateTo((parentPos+childPos)-5, 0, 200, Easing.Linear);
                    btnPosts.TextColor = Color.FromHex("#232396");
                    break;
                case 1:
                    btnPosts.TextColor = Color.FromHex("#000000");
                    btnactive.TextColor = Color.FromHex("#000000");
                    var animatepending = new Animation(d => SelectionBar.WidthRequest = d+16, 29, 49, Easing.SpringIn);
                    animatepending.Commit(SelectionBar, "BarGraph", 10, 200);
                    Console.WriteLine(""+ btnContests.TranslationX);
                    await SelectionBar.TranslateTo((parentPos+childPos)-4, 0, 200, Easing.Linear);
                   
                    btnContests.TextColor = Color.FromHex("#232396");
                    break;

                case 2:
                    btnPosts.TextColor = Color.FromHex("#000000");
                    btnContests.TextColor = Color.FromHex("#000000");
                    var animateactive = new Animation(d => SelectionBar.WidthRequest = d + 5, 29, 49, Easing.SpringIn);
                    animateactive.Commit(SelectionBar, "BarGraph", 10, 200);
                    Console.WriteLine("" + btnContests.TranslationX);
                    await SelectionBar.TranslateTo((parentPos + childPos) - 5, 0, 200, Easing.Linear);
                    btnactive.TextColor = Color.FromHex("#232396");
                    break;

            }
        }
        #endregion

        #region CarouselView
        private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {

            HomePageListModel homePage = (HomePageListModel)e.CurrentItem;
            if (homePage.IsPending == true)
            {
                double childPos = (btnPendinglayout).Children[0].X;
                double parentPos = (btnPendinglayout).X;
                NagivateTabs(1, true, parentPos, childPos);
                
            }
            else if(homePage.IsAll==true)
            {
                double childPos = (btnAlllayout).Children[0].X;
                double parentPos = (btnAlllayout).X;
                NagivateTabs(0, true, parentPos, childPos);
            }
            else 
            {
                double childPos = (btnActiveLayout).Children[0].X;
                double parentPos = (btnActiveLayout).X;
                NagivateTabs(2, true, parentPos, childPos);
            }
        }
        #endregion


    }
}