namespace ConsoleApp6
{
    class ContactInfo
    {
        public ContactInfo(string? city, string? address, long? mobile)
        {
            City = city;
            Address = address;
            Mobile = mobile;
        }
        public string? City { get; set; }
        public string? Address { get; set; }
        public long? Mobile { get; set; } = 0;

    }
}