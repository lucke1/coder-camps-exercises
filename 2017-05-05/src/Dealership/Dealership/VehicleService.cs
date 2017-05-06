using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dealership
{
    class VehicleService
    {
        public IList<Vehicle> GetVehicles()
        {
            var result = new List<Vehicle>();

            try
            {
                using (var sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dealership;Integrated Security=True"))
                {
                    using (var sqlCommand = new SqlCommand("[dbo].[GetVehicles]", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlConnection.Open();

                        using (var sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.HasRows && sqlDataReader.Read())
                            {
                                result.Add(new Vehicle
                                {
                                    VehicleId = Convert.ToInt32(sqlDataReader["VehicleId"]),
                                    Make = sqlDataReader["Make"].ToString(),
                                    Model = sqlDataReader["Model"].ToString(),
                                    Year = Convert.ToDateTime(sqlDataReader["Year"]),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return result;
        }
    }
}
