using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__ArrayList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList playlist = new ArrayList();

            playlist.Add("TWO TONE");
            playlist.Add("30 Shoooter");
            playlist.Add("Downers At Dusk");
            playlist.Add("KATTAR KARACHI");
            playlist.Add("Overseas Connect");


            playlist.Insert(1, "Heartbreak Kid");

            playlist.Remove("Overseas Connect");


            playlist.RemoveAt(3);

            Console.WriteLine("Playlist:");
            foreach (object song in playlist)
            {
                Console.WriteLine(song);
            }
            Console.ReadLine();
        }
    }
}