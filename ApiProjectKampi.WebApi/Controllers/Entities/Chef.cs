﻿namespace ApiProjectKampi.WebApi.Controllers.Entities
{
    public class Chef
    {

        public int ChefId { get; set; }
        public string NameSurname   { get; set; }
        public string Title { get; set; }   

        public string Description { get; set; }
        public string ImageURl { get; set; }
    }
}
