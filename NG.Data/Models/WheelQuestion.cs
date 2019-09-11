using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Data.Models
{
    public class WheelQuestion : BaseModel
    {
        public Guid WheelQuestionTypeId { get; set; }

        public string Title { get; set; }

        public int OrderBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid CreatedUserId { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Guid? UpdatedUserId { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Guid? DeletedUserId { get; set; }

        public virtual NataGermanUser User { get; set; }
        public virtual WheelQuestionType WheelQuestionType { get; set; }
        public virtual List<WheelAnswer> WheelAnswers { get; set; }
    }
}
