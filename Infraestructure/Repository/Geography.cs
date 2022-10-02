using ClimaTempoSimples.DTO.Geography;
using ClimaTempoSimples.Utils.ExtensionMethods.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Infraestructure.Repository
{
    public class Geography
    {

        private static readonly string _connectionString = "Data Source=localhost; Initial Catalog=ClimaTempoSimples; Integrated Security=True";

        public List<StateDTO> GetStates()
        {
            List<StateDTO> list = null;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(Queries.Geography.GetStates, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (list is null) { list = new List<StateDTO>(); }
                        list.Add(new StateDTO
                        {
                            ID = reader.Response<int>("ID"),
                            Name = reader.Response<string>("Name"),
                            Initials = reader.Response<string>("Initials")
                        });
                    }
                    reader.Close();
                }
                return list;
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }



        public List<CityDTO> GetCities(int? stateID = null)
        {
            List<CityDTO> list = null;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(Queries.Geography.GetCities, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                command.InsertParameter("StateID", stateID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (list is null) { list = new List<CityDTO>(); }
                        list.Add(new CityDTO
                        {
                            ID = reader.Response<int>("ID"),
                            StateID = reader.Response<int>("StateID"),
                            Name = reader.Response<string>("Name")
                        });
                    }
                    reader.Close();
                }
                return list;
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }

        public CityDTO GetCity(int id)
        {
            CityDTO city = null;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(Queries.Geography.GetCity, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                command.InsertParameter("CityID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        city = new CityDTO
                        {
                            ID = reader.Response<int>("ID"),
                            StateID = reader.Response<int>("StateID"),
                            Name = reader.Response<string>("Name")
                        };
                    }
                    reader.Close();
                }
                return city;
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }

        public StateDTO GetState(int id)
        {
            StateDTO state = null;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(Queries.Geography.GetState, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                command.InsertParameter("StateID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        state = new StateDTO
                        {
                            ID = reader.Response<int>("ID"),
                            Name = reader.Response<string>("Name"),
                            Initials = reader.Response<string>("Initials")
                        };
                    }
                    reader.Close();
                }
                return state;
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }


    }
}
