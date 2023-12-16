using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class LanguageType : Entity<Guid>
    {
        public string Name { get; set; }

        public List<Language>? Languages { get; set; }
    }
}
