using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Extensao
{
    public static class ListExtensao
    {   
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens) // Este é um método de extensão genérico. Pode ser usado com qualquer tipo
                                                                                    // não é possível criar um método de extensão em uma classe genérica
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
