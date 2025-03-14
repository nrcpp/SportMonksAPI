namespace SportMonksSDK.API.Core.Entities
{
    public class Country
    {
        public int id { get; set; }
        public int continent_id { get; set; }
        public string name { get; set; }
        public string official_name { get; set; }
        public string fifa_name { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public List<string> borders { get; set; }
        public string image_path { get; set; }

        public override string ToString() => name;
    }
}
