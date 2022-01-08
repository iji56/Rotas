using System;
using System.Globalization;
using Rotas.Models;
using Xamarin.Forms;

namespace Rotas.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ReferenceData referenceData = App.referenceData;
            if (value is MemberModel)
            {
                
                var allmember = value as MemberModel;
                foreach (var state in referenceData.RotaStates)
                {
                    if (allmember.Rota.RotaStateId.Equals(state.Id))
                    {
                        if (state.Name.Equals("Pending"))
                        {
                            return "#FF8C00";
                        }
                        else if (state.Name.Equals("Active"))
                        {
                            return "#00B400";
                        }
                        else
                        {
                            return "#FF8C00";
                        }

                    }
                }

            }
            else if (value is RotasPendingMemeber)
            {

                var pendingmember = value as RotasPendingMemeber;
                foreach (var state in referenceData.RotaStates)
                {
                    if (pendingmember.Rota.RotaStateId.Equals(state.Id))
                    {
                        if (state.Name.Equals("Pending"))
                        {
                            return "#FF8C00";
                        }
                        else if (state.Name.Equals("Active"))
                        {
                            return "#00B400";
                        }
                        else
                        {
                            return "#FF8C00";
                        }

                    }
                }
            }
            else if (value is RotasMember)
            {
                var activemember = value as RotasMember;
                foreach (var state in referenceData.RotaStates)
                {
                    if (activemember.Rota.RotaStateId.Equals(state.Id))
                    {
                        if (state.Name.Equals("Pending"))
                        {
                            return "#FF8C00";
                        }
                        else if (state.Name.Equals("Active"))
                        {
                            return "#00B400";
                        }
                        else
                        {
                            return "#FF8C00";
                        }

                    }
                }
            }

            return false;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}