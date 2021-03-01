using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Git.Entities.Enums
{
    enum OderStatus : int
    {
        PendingPayment = 0,//pagamnto pendente
        Processing = 1, //processando
        Shiped = 2,//enviado
        Delivered = 3 // entregue
    }
}
