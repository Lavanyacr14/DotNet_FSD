using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace BLL
{
    public class DependencyResolver
    {
        public static object GetInstance(string type)
        {
            switch(type)
            {
                case "IFinanceTeam":
                    {
                        return new FinanceTeam();
                    }
                case "IITTeam":
                    {
                        return new ITTeam();
                    }
            }
            return null;
        }
    }
}
