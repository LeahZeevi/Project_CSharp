using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer

    {
        public int CustomerId { get; init; }
        public string CustomerName { get; set; }
        public string Adress { get; set; }
        public int CustomerPhone { get; set; }

        public Customer(int cutomerId, string custometName, string adress, int custometPhone)
        {
            CustomerId = cutomerId;
            CustomerName = custometName;
            Adress = adress;
            CustomerPhone = custometPhone;
        }
        public override string ToString()
        {
            return $"תעודת זהות: {CustomerId}\n שם: {CustomerName}\n כתובת: {Adress}\n טלפון: {CustomerPhone}";
        }
    }
}
