using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPasswordVault.Models
{
    public class PasswordEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public string Username { get; set; } = "";
        public string Url { get; set; } = "";
        public string Notes { get; set; } = "";
        public List<PasswordVersion> Versions { get; set; } = new List<PasswordVersion>();
    }
}
