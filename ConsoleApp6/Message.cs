namespace ConsoleApp6
{
    abstract class Message
    {
        public Message(string message, int? mobile)
        {
            this.message = message;
            this.mobile = mobile;

        }
        public Message(string message, string? email)
        {
            this.message = message;
            this.email = email;
        }

        public string message { get; set; }
        public int? mobile { get; set; }
        public string? email { get; set; }

        public abstract string Send(string message, int? mobile, string? email);
    }
}