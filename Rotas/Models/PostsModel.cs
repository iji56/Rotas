using System;
using Rotas.ViewModels;

namespace Rotas.Models
{
    public class PostsModel : BaseViewModel
    {
        private bool _IsPlaying;
        public string _ImageSource { get; set; }
        private bool _IsLottieVisible;
        private bool _IsButtonVisible;

        public int Id { get; set; }

        public bool IsLottieVisible
        {
            get { return _IsLottieVisible; }
            set { _IsLottieVisible = value; OnPropertyChanged(nameof(IsLottieVisible)); }
        }
        public bool IsButtonVisible
        {
            get { return _IsButtonVisible; }
            set { _IsButtonVisible = value; OnPropertyChanged(nameof(IsButtonVisible)); }
        }
    }
}

