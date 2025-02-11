namespace ApiProjectKampi.WebApi.Controllers.Entities
{
    public class Contact
    {

        public int ContactID { get; set; }
        public string MapLocation { get; set; }
        public string Adrres { get; set; }
        public string  Phone { get; set; }
        public string  Email { get; set; }

        public string OpenHours { get; set; }
    }
}
