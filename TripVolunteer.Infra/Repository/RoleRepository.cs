using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripVolunteer.Core.Common;
using TripVolunteer.Core.Data;

namespace TripVolunteer.Infra.Repository
{
    public class RoleRepository
    {
        private readonly IDBContext dBContext;





        public RoleRepository(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }


        public void CreateRole(Role role)
        {
            var p = new DynamicParameters();

            //p.Add("COURSENAME", course.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            //p.Add("CATID", course.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            //p.Add("image", course.Imagename, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContext.Connection.Execute("CreateRole", p, commandType: CommandType.StoredProcedure);

        }



    }

}



