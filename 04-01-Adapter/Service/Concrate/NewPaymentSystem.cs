using _04_01_Adapter.Service.Contract;

namespace _04_01_Adapter.Service.Concrate
{
    public class NewPaymentSystem : INewPaymentSystem
    {
        public void MakePayment(string paymentDetails)
        {
            Console.WriteLine($"Processing payment with new system: {paymentDetails}");
        }
    }
}
