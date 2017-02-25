using System.Web.Script.Serialization;

namespace DotNetPet
{
    public class Pet
    {
        public string name;
        public string avatar;
        public int sleepiness;
        public int hunger;
        public int thirst;
        public int boredom;
        public int needingnessToPee;
        public int needingnessToPoop;

        public Pet(string name, string avatar)
        {
            this.name = name;
            this.avatar = avatar;
            this.sleepiness = 0;
            this.hunger = 0;
            this.thirst = 0;
            this.boredom = 0;
            this.needingnessToPee = 0;
            this.needingnessToPoop = 0;
        }

        public string ToJson()
        {
            return new JavaScriptSerializer().Serialize(this);
        }
    }
}