using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary
{
    public class ImportanceInfo
    {
        private int _importanceID = 0;
        private string _importanceName = "";

        public int ImportanceID
        {
            get
            {
                return _importanceID;
            }
            set
            {
                _importanceID = value;
            }
        }

        public string ImportanceName
        {
            get
            {
                return _importanceName;
            }
            set
            {
                _importanceName = value;
            }
        }
    }
}
