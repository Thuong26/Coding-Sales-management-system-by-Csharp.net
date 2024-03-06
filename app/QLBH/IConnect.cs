using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    internal interface IConnect
    {
        void openConnect();
        void closeConnect();
        DataTable Request(string cmd);

    }
}
