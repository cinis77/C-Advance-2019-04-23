using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokiniuVidurkiai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, List<int>> Dienynas = new Dictionary<string, List<int>>();

            Dienynas.Add("Povilas", new List<int>() { 10, 9, 8, 7, 8, 6 });
            Dienynas.Add("Tomas", new List<int>() { 6, 5, 4, 4, 4, 7 });
            Dienynas.Add("Rokas", new List<int>() { 4, 4, 7, 7, 7, 6 });
            Dienynas.Add("Austeja", new List<int>() { 10, 9, 8, 8, 9, 9 });
            Dienynas.Add("Silvija", new List<int>() { 7, 7, 6, 7, 8, 6 });
            Dienynas.Add("Svetlana", new List<int>() { 9, 9, 8, 7, 8, 6 });
            List<double> rikiavimas = new List<double>();
            foreach (var item in Dienynas)
            {
                Console.WriteLine(item.Key + " " + item.Value.Average().ToString("F2"));
                rikiavimas.Add(item.Value.Average());
            }

            rikiavimas = rikiavimas.OrderByDescending(x => x).ToList();
            Console.WriteLine("------------------------------------------------------");
            foreach (var item in rikiavimas)
            {
                Console.Write(Dienynas.Where(x => x.Value.Average() == item).First().Key + " "); //Lambda Operacija
                Console.WriteLine(item.ToString("F3"));
            }
        }
    }
}