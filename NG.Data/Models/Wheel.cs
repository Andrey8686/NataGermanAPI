using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Data.Models
{
    public class Wheel : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid CreatedUserId { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Guid? UpdatedUserId { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Guid? DeletedUserId { get; set; }

        public virtual NataGermanUser User { get; set; }
        public virtual List<WheelQuestionType> WheelQuestionTypes { get; set; }
    }
}
