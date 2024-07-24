using _01_01_Decorator;
Console.WriteLine("Send Sms :");
SendSms sendSms = new SendSms();
sendSms.Send();

Console.WriteLine("---------------------------"); 

Console.WriteLine("Send Sms Decorator :");
SendSms sendSms1 = new SendSms();
SendSmsDecorator sendSmsDecorator = new SendSmsDecorator(sendSms1);
sendSmsDecorator.Send();
