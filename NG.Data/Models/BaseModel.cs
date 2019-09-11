using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Data.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
