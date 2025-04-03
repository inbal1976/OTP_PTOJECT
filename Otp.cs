using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTPProject
{
    public class Otp
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime ExpirationTime { get; set; }
    }
}
