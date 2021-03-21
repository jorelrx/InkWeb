using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Cliente : Usuario
    {
        public List<Pedido> Pedidos { get; set; }
    }
}