namespace E_Commerce.NotificationService.MailMessages
{
    public static class OrderMessage
    {
        public static string OrderFailedMessage(string FullName, string OrderNumber, string ErrorMessage)
        {
            return $"Merhabalar sayın {FullName}, <br/> " +
                $"{OrderNumber} numaralı siparişiniz";
        }
    }
}
