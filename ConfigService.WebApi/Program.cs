using CommonLibraries.Web;

namespace ConfigService.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProgramUtils.RunWebhost<Startup>(args);
        }
    }
}
