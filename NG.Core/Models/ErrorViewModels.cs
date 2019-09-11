using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Core.Models
{
    public class ErrorViewModels
    {
        public Dictionary<string, List<string>> errors { get; set; }

        public string title { get; set; }

        public int status { get; set; }

        public string traceId { get; set; }
    }
}
