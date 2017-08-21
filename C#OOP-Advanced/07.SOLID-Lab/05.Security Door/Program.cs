using _05.Security_Door.Controllers;
using _05.Security_Door.Interfaces;
using _05.Security_Door.Models;

namespace _05.Security_Door
{
    public class Program
    {
        public static void Main()
        {
            ScannerUI scannerUi = new ScannerUI();
            IAccessProvider keyCardCheck = new KeyCardCheck(scannerUi);
            SecurityManager manager = new SecurityManager(keyCardCheck);
            manager.Check();
        }
    }
}
