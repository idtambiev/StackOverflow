﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOwerflow.Models
{
    public class QuestionsDto
    {
        public int CountQuestions { get; set; }
        public IEnumerable<QuestionDto> QuestionsArray { get; set; }
    }
}
