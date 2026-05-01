using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPasswordVault.Models
{
    public class VaultData
    {
        public new List<PasswordEntry> Entries { get; set; } = new List<PasswordEntry>();
    }
}
