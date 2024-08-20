using _04_01_Adapter.Service.Contract;

namespace _04_01_Adapter.Service
{
    // کلاس آداپتر که رابط قدیمی را به رابط جدید ترجمه می‌کند
    public class PaymentAdapter : IOldPaymentSystem
    {
        private readonly INewPaymentSystem _newPaymentSystem;

        public PaymentAdapter(INewPaymentSystem newPaymentSystem)
        {
            _newPaymentSystem = newPaymentSystem;
        }

        public void ProcessPayment(string paymentInfo)
        {
            // ترجمه اطلاعات و فراخوانی متد جدید
            _newPaymentSystem.MakePayment(paymentInfo);
        }
    }
}
