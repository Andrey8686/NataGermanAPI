using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Data.Models
{
    public class WheelQuestionType : BaseModel
    {
        public Guid WheelId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int OrderBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid CreatedUserId { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Guid? UpdatedUserId { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Guid? DeletedUserId { get; set; }

        public virtual NataGermanUser User { get; set; }

        public virtual Wheel Wheel { get; set; }
        public virtual List<WheelQuestion> WheelQuestions { get; set; }
    }
}
