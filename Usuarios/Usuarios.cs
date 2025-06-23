namespace EspacioClases
{
    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }

    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

        public override string ToString()
        {
            string addressInfo = address != null ? $"Street: {address.street}, City: {address.city}" : "N/A";
            string companyInfo = company != null ? $"Company: {company.name}" : "N/A";

        return $"User ID: {id}, Name: {name} ({username}), Email: {email}\n" +
               $"  Address: [{addressInfo}]\n" +
               $"  Phone: {phone}, Website: {website}\n" +
               $"  Company: [{companyInfo}]";
        }
    }
}

