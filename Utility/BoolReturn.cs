using CustomMessage;
using ElasticCollection.Domain;

namespace ElasticCollection.Utility
{
    public class BoolReturn
    {
        public static bool IfStatementToReturnBooleanValue(string answer)
        {
           if (answer.Trim().ToUpper() == "YES")
            {
                return true;
            }
            else if (answer.Trim().ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Message.Error("Please choose [YES/NO]");
                Collection.SelectProductSpecsToView();
            }
            return true;
        }
    }
}
