using System;

namespace Automation
{
    public class ProductInfo
    {
        public int Id { get; set; }

        public string Customer { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}