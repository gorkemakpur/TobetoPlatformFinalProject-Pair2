using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Language : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public Guid LanguageLevelId { get; set; }
        public Guid LanguageTypeId { get; set; }

        public LanguageLevel? LanguageLevel { get; set; }
        public LanguageType? LanguageType { get; set; }
        public Student? Student { get; set; }


    }
}
