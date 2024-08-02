using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taqqos.Domain.Commons;

namespace Taqqos.Domain.Entitys.Commons
{
    public class Attachment : Auditable
    {
        public string Path { get; set; }
    }
}
