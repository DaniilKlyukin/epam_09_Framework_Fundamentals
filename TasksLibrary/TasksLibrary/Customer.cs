using System;
using System.Text;

namespace TasksLibrary
{
    public enum CustomerInfo
    {
        Name,
        Phone,
        Revenue,
        None
    }

    public class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public override string ToString()
        {
            return ToString(CustomerInfo.Name, CustomerInfo.Revenue, CustomerInfo.Phone);
        }

        public string ToString(CustomerInfo firstField, CustomerInfo secondField, CustomerInfo thirdField)
        {
            var first = CustomerInfoToString(firstField);
            var second = CustomerInfoToString(secondField);
            var third = CustomerInfoToString(thirdField);

            if (first != string.Empty && (second != string.Empty || third != string.Empty))
                first += ", ";
            if (second != string.Empty && third != string.Empty)
                second += ", ";

            return $"{first}{second}{third}";
        }

        private string CustomerInfoToString(CustomerInfo info)
        {
            if (info == CustomerInfo.Name)
                return Name;
            else if (info == CustomerInfo.Phone)
                return ContactPhone;
            else if (info == CustomerInfo.Revenue)
            {
                var decimals = Math.Abs(Revenue) - (int)Math.Abs(Revenue);
                var revenueString = ((int)Revenue).ToString();
                var builder = new StringBuilder();

                for (int i = 0; i< revenueString.Length; i++)
                {
                    if ((revenueString.Length - i) % 3 == 0)
                        builder.Append(",");
                    builder.Append(revenueString[i]);
                }

                builder.Append($"{decimals:.00}");

                return builder.ToString();
            }
            else
                return string.Empty;
        }
    }
}
