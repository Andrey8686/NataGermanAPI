using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Data.Models
{
    public class WheelAnswer : BaseModel
    {
        public Guid WheelQuestionId { get; set; }

        public int Mark { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid CreatedUserId { get; set; }

        public virtual NataGermanUser User { get; set; }
        public virtual WheelQuestion WheelQuestion { get; set; }
    }
}
