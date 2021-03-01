using Aula_Git.Entities;
using Aula_Git.Entities.Enums;
using System;

namespace Aula_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OderStatus os = Enum.Parse<OderStatus>("Processing");

            Console.WriteLine(os);
        }
    }
}
