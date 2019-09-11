using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace NG.Data.Models
{
    public class NataGermanUser : IdentityUser<Guid>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime CreatedAt { get; set; }



        public virtual List<Wheel> Wheels { get; set; }
        public virtual List<WheelQuestionType> WheelQuestionTypes { get; set; }
        public virtual List<WheelQuestion> WheelQuestions { get; set; }
        public virtual List<WheelAnswer> WheelAnswers { get; set; }
    }
}
