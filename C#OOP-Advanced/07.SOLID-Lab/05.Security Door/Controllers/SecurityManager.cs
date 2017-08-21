using _05.Security_Door.Interfaces;

namespace _05.Security_Door.Controllers
{
    public class SecurityManager
    {
        private IAccessProvider accessProvider;

        public SecurityManager(IAccessProvider accessProvider)
        {
            this.accessProvider = accessProvider;
        }

        public void Check()
        {
            this.accessProvider.ValidateUser();
        }
    }
}