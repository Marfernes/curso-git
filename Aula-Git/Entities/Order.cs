using System;
using Aula_Git.Entities.Enums;

namespace Aula_Git.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ","
                + Moment
                + ","
                + Status;
        }
    }
}
