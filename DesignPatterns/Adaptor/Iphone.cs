using System;
namespace DesignPatterns.Adaptor
{
    // code that we already have
    public class AppleEarBuds
    {
        public void AuxInput(String song)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine(String.Format("****** {0} ******", song));
            Console.WriteLine("****************************************");
        }
    }

    public interface IOutput
    {
        void Input(String song);
    }

    public class HeadphonesAdaptor : IOutput
    {
        AppleEarBuds headphones = new AppleEarBuds();

        public void Input(String song)
        {
            headphones.AuxInput(song);
        }
    }

    // let's say we are given a pre-writem class that we cannot change the interface of.
    class IphoneX
    {
        private IOutput _output;

        public void setConverter(IOutput headphones)
        {
            this._output = headphones;
        }

        // there are 1000 dependencies on this method
        public void playSong(String song)
        {
            this._output.Input(song);
        }
    }

}
