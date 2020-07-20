namespace Types.Interfaces
{
    public class Shop
    {
        public void CompleteOrder()
        {
            IDatabase database = new Database();
            IEmailSender emailSender = new EmailSender();

            //IOrderProcessor orderProcessor = new OrderProcessor(database, emailSender);
        }
    }
}