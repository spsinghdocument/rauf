using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DAL;
using System.Data.SqlClient;
namespace BAL
{
    public class Login : IProductRepository
    {
      private IRepository<ADDTARIF> _repository = null;
      public Login()
      {
          this._repository = new Repository<ADDTARIF>();

      }

      public long getdata(int v)
      {
         // var employees = _repository.GetAll();

          Sp df = new Sp();
     //var w=  df.spi();
          long a = 0;
          SqlParameter sp = new SqlParameter("sp", "e");
          var idParam = new SqlParameter
          {
              ParameterName = "sp",
              Value = v
          };

          object[] parameters = new object[] { idParam };
       // df.SQLQuery<mayank_Result>("exec mayank @sp ", parameters);

          var employees = _repository.SQLQuery<mayank_Result>("exec mayank @sp ", parameters);
          foreach (mayank_Result cs in employees)
          {
              a = cs.SNO;
          }
          return a;
      }

    }
}
