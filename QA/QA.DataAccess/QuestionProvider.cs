using QA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QA.DataAccess
{
    public class QuestionProvider: IQuestionProvider
    {
        public List<Common.Question> GetQuestions()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                return db.Query<Common.Question>("Select * From Questions").ToList();
            }
        }
    }
}
