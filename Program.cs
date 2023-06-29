using System.Reflection;

namespace Veshion_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Updater updater = new Updater();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            Console.WriteLine(version);
            updater.CheckUpdate();
        }
    }
}