using System;
using System.Collections.Generic;
using System.Drawing;

namespace Rotas.Models
{
    public class UserRotas
    {
        public string UserId { get; set; }
        public List<RotasMember> RotasMember { get; set; }
        public List<RotasPendingMemeber> RotasPendingMemeber { get; set; }
        public List<RotasGhostAdmin> RotasGhostAdmin { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Rota
    {
        public string Name { get; set; }
        public string UserCreatorId { get; set; }
        public string RotaStateId { get; set; }
        public double MonthlyFullShareAmount { get; set; }
        public string CurrencyId { get; set; }
        public string Id { get; set; }
    }

    public class MemberType
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Member
    {
        public string Id { get; set; }
        public MemberType MemberType { get; set; }
        public string UserId { get; set; }
        public double MonthlyPayInAmount { get; set; }
    }

    public class RotasMember
    {
        public Rota Rota { get; set; }
        public Member Member { get; set; }
        public Color BackgroundColor { get; set; }
    }

    public class RotasPendingMemeber
    {
        public Rota Rota { get; set; }
        public Member Member { get; set; }
        public Color BackgroundColor { get; set; }
    }

    public class RotasGhostAdmin
    {
        public Rota Rota { get; set; }
        public Member Member { get; set; }
    }



    public class ReferenceData
    {
        public List<MemberType> MemberTypes { get; set; }
        public List<RotaState> RotaStates { get; set; }
        public List<Currency> Currencies { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
    }


    

    public class RotaState
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public bool Enabled { get; set; }
        public string Id { get; set; }
    }



}
