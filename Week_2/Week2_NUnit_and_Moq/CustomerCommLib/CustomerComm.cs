namespace CustomerCommLib
{
    public class CustomerCommService
    {
        private readonly IMailSender _mailSender;

        public CustomerCommService(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("cust123@abc.com", "Some Message");
            return true;
        }
    }
}
