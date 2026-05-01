using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPasswordVault.Models
{
    public class PasswordVersion
    {
        public int VersionNumber { get; set; }
        public string Password { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Comment { get; set; } = "";
    }
}
