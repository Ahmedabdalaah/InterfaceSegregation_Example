// See https://aka.ms/new-console-template for more information
using InterfaceSegregation_Example;

Customer customer = new Customer();
customer.name = " Ahmed";
customer.custom_id = "1";
Email email = new Email();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(email.SendEmail(customer.custom_id));
SMS sms = new SMS();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(sms.SendSMS(customer.custom_id));