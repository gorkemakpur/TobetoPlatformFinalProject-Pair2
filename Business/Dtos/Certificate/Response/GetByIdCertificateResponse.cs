﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Certificate.Response
{
    public class GetByIdCertificateResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
    }
}
