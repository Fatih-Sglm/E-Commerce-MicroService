namespace E_Commerce.NotificationService.MailModels
{
    public class MailOptions
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string SenderFullName { get; set; }
        public string SenderEmail { get; set; }
        public string Password { get; set; }
    }
}
