using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.ConstrainedExecution;
using System.Web.UI.WebControls;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var crmService = new Conexao().ObterConexao();
            DataModel model = new DataModel();
            model.FetchXML(crmService);
        }

        
    }
}
