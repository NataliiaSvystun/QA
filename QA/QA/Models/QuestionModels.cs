using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Models
{
   public class QuestionModels
    {
        int Id { get; set; }
        string Text { get; set; }
        int Rating { get; set; }
        string UserId { get; set; }
    }
}
