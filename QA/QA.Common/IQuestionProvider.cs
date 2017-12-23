using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Common
{
    public interface IQuestionProvider
    {
        List<Question> GetQuestions();
    }
}
