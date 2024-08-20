using _04_01_Adapter.Service.Contract;

namespace _04_01_Adapter.Service.Concrate
{
    // کلاس قدیمی سیستم پرداخت که از رابط قدیمی استفاده می‌کند
    public class OldPaymentSystem : IOldPaymentSystem
    {
        public void ProcessPayment(string paymentInfo)
        {
            Console.WriteLine($"Processing payment with old system: {paymentInfo}");
        }
    }
}
