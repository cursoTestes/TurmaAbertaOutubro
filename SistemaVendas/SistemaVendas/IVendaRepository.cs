using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public interface IVendaRepository
    {
        List<decimal> selectVendasPorMes(int mes, int ano);
    }
    
}
