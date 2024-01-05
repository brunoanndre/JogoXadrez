using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.tabuleiro
{
    internal class TabuleiroException : Exception
    {

        public TabuleiroException(string message) :base(message) { }
    }
}
