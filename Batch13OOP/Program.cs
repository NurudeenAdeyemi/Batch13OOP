// See https://aka.ms/new-console-template for more information
using Batch13OOP;


RechargeCard card1 = new RechargeCard("ghgdfg","GLO", 123456, 500.00M, "CLH COMP", DateTime.Now);
//card1.SetCardType("MTN");
//card1.SetSerialNumber("asdfgjfkdj345");
RechargeCard card2 = new RechargeCard("tyuighj", "Etisalat");

Console.WriteLine($"SerialNumber: {card1.GetSerialNumber()}, CardType: {card1.GetCardType()}");