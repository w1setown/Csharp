using NAudio.Wave;
using System;
using System.IO;

namespace Musikalisches_Würfelspiel
{
    public class TerningKaster
    {
        private Random _tilfældig;

        public TerningKaster()
        {
            _tilfældig = new Random();
        }

        public int Kast()
        {
            return _tilfældig.Next(1, 7);
        }

        public int KastToTerninger()
        {
            int førsteKast = Kast();
            int andetKast = Kast();
            return førsteKast + andetKast;
        }
    }

    public class MusikGenerator
    {
        private string _instrument;
        private TerningKaster _terningKaster;

        public MusikGenerator(string instrument)
        {
            _instrument = instrument;
            _terningKaster = new TerningKaster();
        }

        public void SpilWienervals()
        {
            SpilMenuet();
            SpilTrio();
        }

        private void SpilMenuet()
        {
            for (int i = 0; i < 16; i++)
            {
                int sum = _terningKaster.KastToTerninger();
                string filnavn = _instrument + "\\" + "menuet" + i + "-" + sum + ".wav";
                AfspilFil(filnavn);
            }
        }

        private void SpilTrio()
        {
            for (int i = 0; i < 16; i++)
            {
                int sum = _terningKaster.Kast();
                string filnavn = _instrument + "\\" + "trio" + i + "-" + sum + ".wav";
                AfspilFil(filnavn);
            }
        }

        private void AfspilFil(string filnavn)
        {
            Console.WriteLine("Attempting to play file: " + filnavn);
            if (File.Exists(filnavn))
            {
                var audioFile = new AudioFileReader(filnavn);
                var outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
                audioFile.Dispose();
                outputDevice.Dispose();
            }
            else
            {
                Console.WriteLine(filnavn + " kunne ikke findes.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg instrument (piano, kalimba, klarinet, harp): ");
            string instrument = Console.ReadLine();

            if (string.IsNullOrEmpty(instrument) || (instrument != "piano" && instrument != "kalimba" && instrument != "klarinet" && instrument != "harp"))
            {
                Console.WriteLine("Ugyldigt instrumentvalg. Standard er piano.");
                instrument = "piano";
            }

            MusikGenerator musikGenerator = new MusikGenerator(instrument);
            musikGenerator.SpilWienervals();
        }
    }
}
