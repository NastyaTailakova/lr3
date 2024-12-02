using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class OrOperation : Interface1
    {
        public string GetOperationName() => "Логическое ИЛИ";

        public string GetOperationSign() => "OR";

        public bool Execute(bool a, bool b) => a || b;
    }

    public class AndOperation : Interface1
    {
        public string GetOperationName() => "Логическое И";

        public string GetOperationSign() => "AND";

        public bool Execute(bool a, bool b) => a && b;
    }

    public class XorOperation : Interface1
    {
        public string GetOperationName() => "Логическое ИСКЛЮЧАЮЩЕЕ ИЛИ";

        public string GetOperationSign() => "XOR";

        public bool Execute(bool a, bool b) => a ^ b;
    }

}
