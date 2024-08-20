namespace _04_01_Adapter.Service.Contract
{

    // رابط جدید سیستم پرداخت که کتابخانه جدید از آن استفاده می‌کند
    public interface INewPaymentSystem
    {
        void MakePayment(string paymentDetails);
    }

}
