namespace AdvancedFeatues.Subclasses
{
    internal class Program
    {
        private static void Main (string[] args)
        {
            var oild = true;
            var instType = "Trumpet";
            var clean = false;

            _ = new Trumpet(oild, instType, clean);

            _ = Console.ReadLine();
        }
    }

    public class Instument
    {
        private string type;
        private bool clean;

        public Instument (bool clean, string type)
        {
            this.type = type;
            this.clean = clean;
        }
    }

    public class Trumpet : Instument
    {
        private bool oiled;

        public Trumpet () : base(false, "String Type")
        {

        }

        public Trumpet (bool oiled, string type, bool clean) : base(clean, type)
        {
            this.oiled = oiled;
        }
    }

    public class TrampetName : Trumpet
    {
        public TrampetName ()
        {
        }

        public TrampetName (bool oiled, string type, bool clean) : base(oiled, type, clean)
        {
        }
    }

    public class TrampetName2 : Trumpet
    {
        public TrampetName2 (bool oiled, string type, bool clean) : base()
        {

        }
    }
}