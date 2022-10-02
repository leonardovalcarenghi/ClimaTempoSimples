using ClimaTempoSimples.DTO;
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
    public class Weather
    {

        private static readonly string _connectionString = "Data Source=localhost; Initial Catalog=ClimaTempoSimples; Integrated Security=True";

        public List<WeatherDTO> Get(int cityId)
        {
            List<WeatherDTO> list = _dataBaseResponse(Queries.Weather.Get, cityId);
            return list;
        }

        public List<WeatherDTO> GetHottestCities(int total)
        {
            List<WeatherDTO> list = _dataBaseResponse(Queries.Weather.GetHottestCities, total);          
            return list;
        }

        public List<WeatherDTO> GetColderCities(int total)
        {
            List<WeatherDTO> list = _dataBaseResponse(Queries.Weather.GetColderCities, total);
            return list;
        }


        #region Métodos Privados

        private List<WeatherDTO> _dataBaseResponse(string query, int parameter)
        {
            List<WeatherDTO> list = null;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                command.InsertParameter("parameter", parameter);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (list is null) { list = new List<WeatherDTO>(); }
                        list.Add(new WeatherDTO
                        {
                            ID = reader.Response<int>("Id"),
                            Description = reader.Response<string>("Clima"),
                            Date = reader.Response<DateTime>("DataPrevisao"),
                            Max = reader.Response<double>("TemperaturaMaxima"),
                            Min = reader.Response<double>("TemperaturaMinima"),
                            StateAbbreviation = reader.Response<string>("UF"),
                            State = reader.Response<string>("Estado"),
                            City = reader.Response<string>("Cidade")
                        }); ;
                    }
                    reader.Close();
                }
                return list;
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }

        #endregion

    }
}
