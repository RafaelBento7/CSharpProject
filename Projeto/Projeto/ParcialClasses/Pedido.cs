﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Pedido
    {
        public override string ToString()
        {
            return $"Pedido: {IdPedido} - Cliente:{Cliente.Nome} - Valor do Pedido {ValorTotal}€";
        }
    }
}
