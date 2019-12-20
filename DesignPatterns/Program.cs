using System;
using DesignPatterns.Adaptor;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IphoneX iphoneX = new IphoneX();
            HeadphonesAdaptor adoptor = new HeadphonesAdaptor();
            iphoneX.setConverter(adoptor);
            iphoneX.playSong("Mobb Deep - Win or Lose");
        }
    }
}
