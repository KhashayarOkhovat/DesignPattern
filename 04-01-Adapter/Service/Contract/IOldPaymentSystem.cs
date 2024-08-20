namespace _04_01_Adapter.Service.Contract
{
    // رابط قدیمی سیستم پرداخت
    public interface IOldPaymentSystem
    {
        void ProcessPayment(string paymentInfo);
    }

}
