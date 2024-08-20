using _04_01_Adapter.Service;
using _04_01_Adapter.Service.Concrate;
using _04_01_Adapter.Service.Contract;

INewPaymentSystem newPaymentSystem = new NewPaymentSystem();

// ایجاد یک آداپتر برای استفاده از سیستم پرداخت جدید با رابط قدیمی
IOldPaymentSystem paymentAdapter = new PaymentAdapter(newPaymentSystem);

// پردازش پرداخت با استفاده از آداپتر
paymentAdapter.ProcessPayment("100 dollars");
