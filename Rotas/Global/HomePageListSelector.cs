using System;
using Rotas.Models;
using Xamarin.Forms;

namespace Rotas.Global
{
    public class HomePageListSelector : DataTemplateSelector
    {
        public DataTemplate AllTemplate { get; set; }
        public DataTemplate PendingTemplate { get; set; }
        public DataTemplate ActiveTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (((HomePageListModel)item).IsAll)
            {
                return AllTemplate;
            }else if (((HomePageListModel)item).IsPending)
            {
                return PendingTemplate;
            }
            else
            {
                return ActiveTemplate;
            }
           
        }
    }
}
