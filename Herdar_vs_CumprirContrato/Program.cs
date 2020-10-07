using Herdar_vs_CumprirContrato.Model.Entities;
using Herdar_vs_CumprirContrato.Model.Enums;
using System;

namespace Herdar_vs_CumprirContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * ASPECTOS EM COMUM ENTRE HERANÇA E INTERFACES:
            - Relação é-um
            - Generalização/especialização
            - Polimorfismo

            * DIFERENÇA FUNDAMENTAL ENTRE HERANÇA E INTERFACE:
            - Herança = Reuso
            - Interface = Contrato a ser cumprido

            Obs. E se eu precisar implementar Shape como interface, porém também quiser definir uma estrutura comum reutilizável para todas figuras? É possível
             */

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Heigth = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
