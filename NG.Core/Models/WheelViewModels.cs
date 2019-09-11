using System;
using System.Collections.Generic;
using System.Text;

namespace NG.Core.Models
{
    public class WheelViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }

    public class WheelQuestionTypeViewModel
    {
        public Guid WheelId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }

    public class WheelQuestionViewModel
    {
        public Guid WheelQuestionTypeId { get; set; }

        public string Title { get; set; }

        public int OrderBy { get; set; }
    }

    public class WheelAnswerViewModel
    {
        public Guid WheelQuestionId { get; set; }

        public Guid CreatedUserId { get; set; }

        public int Mark { get; set; }
    }
}
