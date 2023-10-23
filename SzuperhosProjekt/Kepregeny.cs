using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

        public static void Szereplok(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    int kutyutKeszit = int.Parse(line[1]);
                    if (line[0] == "Vasember")
                    {
                        Vasember vasember = new Vasember();
                        for (int i = 0; i < kutyutKeszit; i++)
                        {
                            vasember.KutyutKeszit();
                        }
                        szuperhosok.Add(vasember);
                    }
                    else
                    {
                        Batman batman = new Batman();
                        for (int i = 0; i < kutyutKeszit; i++)
                        {
                            batman.KutyutKeszit();
                        }
                        szuperhosok.Add(batman);
                    }
                }
            }
        }

        public static void Szuperhosok()
        {
            foreach (ISzuperhos item in szuperhosok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
