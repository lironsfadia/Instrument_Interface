using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface Instrument
    {
        public string Pitch { set; get; }
        public string Sound { set; get; }
        public void Play();
        public void Listen();
    }

    class Guitar : Instrument
    {
        private string _pitch;
        private string _sound;
        public string Pitch
        {
            set => _pitch = value;
            get => _pitch;
        }

        public string Sound
        {
            set => _sound = value;
            get =>  _sound;
        }

        public void Play() => System.Console.WriteLine("play");
        public void Listen() => System.Console.WriteLine("Listen");
    }

    public class TestMusic
    {
        public static void Main()
        {
            List<Instrument> instruments = new List<Instrument>();
            Instrument instrument1 = new Guitar() { Pitch = "guitar", Sound = "baaa" };
            instruments.Add(instrument1);
            instruments.Add(new Guitar() { Pitch = "guitar1", Sound = "baaa1" });

            foreach (Instrument s in instruments)
            {
                s.Play();
            }

            Console.Read();
        }
    }
}
