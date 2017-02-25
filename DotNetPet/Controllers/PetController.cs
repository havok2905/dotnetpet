using System.Web.Http;

namespace DotNetPet
{
    public class PetController : ApiController
    {
        // GET /Pet
        public string Get()
        {
            Pet myPet = new Pet("Mr. Goops", "mrgoops.png");
            string json = myPet.ToJson();
            return json;
        }

    }
}
