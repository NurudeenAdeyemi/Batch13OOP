using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13OOP
{
    public class RechargeCard
    {
        private string serialNumber;
        private string cardType;
        private int cardPin;
        private decimal cardAmount;
        private string companyName;
        private DateTime dateCreated;

        public RechargeCard(string serialNumber, string cardType, int cardPin, decimal cardAmount, string companyName, DateTime dateCreated)
        {
            this.serialNumber = serialNumber;
            this.cardType = cardType;
            this.cardPin = cardPin;
            this.cardAmount = cardAmount;
            this.companyName = companyName;
            this.dateCreated = dateCreated;
        }

        public RechargeCard(string serialNumber, string cardType)
        {
            this.serialNumber = serialNumber;
            this.cardType = cardType;
        }

        public void SetSerialNumber(string serialNumber)
        {
            // "this" is a reference keyword
            this.serialNumber = serialNumber; 
        }

        public string GetSerialNumber()
        {
            return serialNumber;
        }

        public void SetCardType(string cardType)
        {
            // "this" is a reference keyword
            this.cardType = cardType;
        }

        public string GetCardType()
        {
            return cardType;
        }
    }
}
