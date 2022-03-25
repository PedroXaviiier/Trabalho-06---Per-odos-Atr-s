using System;

namespace Trabalho_06___Períodos_Atrás
{
    internal class Program
    {
        public static DateTime dataComparacao;
        static void Main(string[] args)
        {
            FazerComparacao();
        }

        public static void FazerComparacao()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Digite uma data ou horario de comparação: ");
            dataComparacao = Convert.ToDateTime(Console.ReadLine());

            int dias = Convert.ToInt32(DateTime.Now.Day - dataComparacao.Day);
            int meses = Convert.ToInt32(DateTime.Now.Month - dataComparacao.Month);
            int anos = Convert.ToInt32(DateTime.Now.Year - dataComparacao.Year);
            string diferenca = " ";

            if (dataComparacao.Day < DateTime.Now.Day && dataComparacao.Month == DateTime.Now.Month && dataComparacao.Year == DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {dias} dia(s) atrás.";
            }

            else if (dataComparacao.Day == DateTime.Now.Day && dataComparacao.Month < DateTime.Now.Month && dataComparacao.Year == DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {meses} mês(ses) atrás.";
            }

            else if (dataComparacao.Day == DateTime.Now.Day && dataComparacao.Month == DateTime.Now.Month && dataComparacao.Year < DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {anos} ano(s) atrás.";
            }

            else if (dataComparacao.Day > DateTime.Now.Day && dataComparacao.Month == DateTime.Now.Month && dataComparacao.Year == DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {dias} dias";
            }

            else if (dataComparacao.Day == DateTime.Now.Day && dataComparacao.Month > DateTime.Now.Month && dataComparacao.Year == DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {meses} meses";
            }

            else if (dataComparacao.Day == DateTime.Now.Day && dataComparacao.Month == DateTime.Now.Month && dataComparacao.Year > DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {anos} anos";
            }

            else if (dataComparacao.Day < DateTime.Now.Day && dataComparacao.Month < DateTime.Now.Month && dataComparacao.Year == DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {meses} meses e {dias} dias atrás.";
            }

            else if (dataComparacao.Day < DateTime.Now.Day && dataComparacao.Month == DateTime.Now.Month && dataComparacao.Year < DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {anos} meses e {dias} dias atrás.";
            }

            else if (dataComparacao.Day == DateTime.Now.Day && dataComparacao.Month < DateTime.Now.Month && dataComparacao.Year < DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {anos} anos e {meses} meses atrás";
            }

            else if (dataComparacao.Day > DateTime.Now.Day && dataComparacao.Month > DateTime.Now.Month && dataComparacao.Year == DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {meses} meses e {dias} dias.";
            }

            else if (dataComparacao.Day > DateTime.Now.Day && dataComparacao.Month == DateTime.Now.Month && dataComparacao.Year > DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {anos} meses e {dias} dias.";
            }

            else if (dataComparacao.Day == DateTime.Now.Day && dataComparacao.Month > DateTime.Now.Month && dataComparacao.Year > DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {anos} anos e {meses} meses atrás";
            }

            else if (dataComparacao.Day < DateTime.Now.Day && dataComparacao.Month < DateTime.Now.Month && dataComparacao.Year < DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Foi a {dias} dias, {meses} meses e {anos} anos atrás";
            }

            else if (dataComparacao.Day > DateTime.Now.Day && dataComparacao.Month > DateTime.Now.Month && dataComparacao.Year > DateTime.Now.Year)
            {
                diferenca = $"{dataComparacao} Sera daqui {dias} dias, {meses} meses e {anos} anos";
            }

            Console.WriteLine(diferenca);
        }




    }


}











