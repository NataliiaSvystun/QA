﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.DataAccess
{
   public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
    }
}
