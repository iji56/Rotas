using System;
using System.Drawing;

namespace Rotas.Models
{
    public class MemberModel
    {

        public Rota Rota { get; set; }
        public Member Member { get; set; }
        public Color BackgroundColor { get; set; }
        public MemberModel()
        {
        }
    }
}
