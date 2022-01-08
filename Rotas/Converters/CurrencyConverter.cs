using System;
using System.Collections.ObjectModel;
using System.Globalization;
using Rotas.Models;
using Xamarin.Forms;

namespace Rotas.Converters
{
    public class CurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
         ReferenceData referenceData=   App.referenceData;
            if (value is MemberModel)
            {
                var allmember = value as MemberModel;
                foreach (var cur in referenceData.Currencies)
                {
                    if (allmember.Rota.CurrencyId.Equals(cur.Id))
                    {
                        if (allmember.Member != null)
                        {
                            return cur.Symbol + allmember.Member.MonthlyPayInAmount;
                        }

                    }
                }

            } else if (value is RotasPendingMemeber) {

                var pendingmember = value as RotasPendingMemeber;
                foreach (var cur in referenceData.Currencies)
                {
                    if (pendingmember.Rota.CurrencyId.Equals(cur.Id))
                    {
                        if (pendingmember.Member != null)
                        {
                            return cur.Symbol + pendingmember.Member.MonthlyPayInAmount;
                        }

                    }
                }
            }
            else if(value is RotasMember)
            {
                var activemember = value as RotasMember;
                foreach (var cur in referenceData.Currencies)
                {
                    if (activemember.Rota.CurrencyId.Equals(cur.Id))
                    {
                        if (activemember.Member != null)
                        {
                            return cur.Symbol + activemember.Member.MonthlyPayInAmount;
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