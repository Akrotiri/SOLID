﻿namespace Bad.Radio
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var badRadio = new BadRadio();

            badRadio.VolumeUp();
            badRadio.VolumeUp();
            badRadio.VolumeUp();
            badRadio.VolumeUp();
            badRadio.VolumeUp();

            Console.Write("Volume is: {0}", badRadio.CurrentVolume);
        }
    }
}
