using System;

namespace AnguloRelogio;

class Program
{
    static void Main(string[] args)
    {
        float hora = 0;
        float minuto = 0;
        float hAngle;
        float mAngle;
        float angle;

        InputData(ref hora, ref minuto);

        hAngle = 0.5f * (hora * 60 + minuto);
        mAngle = 6 * minuto;
        angle = Math.Abs(hAngle - mAngle);
        angle = Math.Abs(Math.Min(angle, 360 - angle));

        ShowResult(angle);

        static void InputData(ref float hora, ref float minuto)
        {
            Console.WriteLine("Informe o valor da hora desejada: ");
            hora = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor dos minutos desejados: ");
            minuto = float.Parse(Console.ReadLine());
        }

        if (hora > 12)
        {
            hora = hora - 12;

        }

        static void ShowResult(float ang)
        {
            Console.WriteLine($"O ângulo entre os ponteiros é: {ang:F2}");

        }


    }
}