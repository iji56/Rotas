using System;
using System.Collections.ObjectModel;
using Rotas.ViewModels;
using Xamarin.Forms;

namespace Rotas.Models
{ 
    public class HomePageListModel : BaseViewModel
    {
        int count = 1;
        public HomePageListModel()
        {
            ListMembers = new ObservableCollection<MemberModel>();
            
            ListPendingMembers = new ObservableCollection<RotasPendingMemeber>();

            ListActiveMembers = new ObservableCollection<RotasMember>();
            GetAllMembers();
            GetAllPendingMembers();
            GetAllActiveMembers();
        }

        private void GetAllActiveMembers()
        {
            count = 1;
            foreach (var members in App.userRotas.RotasMember)
            {
                ListActiveMembers.Add(new RotasMember() { Member = members.Member, Rota = members.Rota, BackgroundColor = count % 2 == 0 ? Color.FromHex("#ffffff") : Color.FromHex("#E5E5E5") });
                count++;
            }
        }

        private void GetAllPendingMembers()
        {
            count = 1;
            foreach(var members in App.userRotas.RotasPendingMemeber)
            {
                ListPendingMembers.Add(new RotasPendingMemeber() { Member = members.Member, Rota = members.Rota, BackgroundColor=count % 2==0? Color.FromHex("#ffffff") : Color.FromHex("#E5E5E5")  });
                count++;
            }
        }

        private void GetAllMembers()
        {
            foreach (var members in App.userRotas.RotasMember) {
                
                ListMembers.Add(new MemberModel() {Member=members.Member, Rota=members.Rota, BackgroundColor=count % 2==0? Color.FromHex("#ffffff") : Color.FromHex("#E5E5E5") });
                count++;
            }
           
            foreach (var members in App.userRotas.RotasPendingMemeber)
            {
                ListMembers.Add(new MemberModel() { Member = members.Member, Rota = members.Rota, BackgroundColor = count % 2 == 0 ? Color.FromHex("#ffffff") : Color.FromHex("#E5E5E5") } );
                count++;
            }
        
            foreach (var members in App.userRotas.RotasGhostAdmin)
            {
                ListMembers.Add(new MemberModel() { Member = members.Member, Rota = members.Rota, BackgroundColor = count % 2 == 0 ? Color.FromHex("#ffffff") : Color.FromHex("#E5E5E5")
    });
                count++;
            }


        }

        public bool IsAll { get; set; }
        public bool IsPending { get; set; }
        public bool IsActive { get; set; }
        private bool _IsPostsEnabled = true;
        private bool _IsContestsEnabled = true;
        private ObservableCollection<MemberModel> _ListMembers;
        private ObservableCollection<RotasPendingMemeber> _ListPendingMembers;
        private ObservableCollection<RotasMember> _ListActiveMembers;
        public ObservableCollection<MemberModel> ListMembers
        {
            get { return _ListMembers; }
            set { _ListMembers = value; OnPropertyChanged(nameof(ListMembers)); }
        }
        public ObservableCollection<RotasPendingMemeber> ListPendingMembers
        {
            get { return _ListPendingMembers; }
            set { _ListPendingMembers = value; OnPropertyChanged(nameof(ListPendingMembers)); }
        }

        public ObservableCollection<RotasMember> ListActiveMembers
        {
            get { return _ListActiveMembers; }
            set { _ListActiveMembers = value; OnPropertyChanged(nameof(ListActiveMembers)); }
        }
        public bool IsPostsEnabled
        {
            get { return _IsPostsEnabled; }
            set { _IsPostsEnabled = value; OnPropertyChanged(nameof(IsPostsEnabled)); }
        }
        public bool IsContestsEnabled
        {
            get { return _IsContestsEnabled; }
            set { _IsContestsEnabled = value; OnPropertyChanged(nameof(IsContestsEnabled)); }
        }
    }
}
