using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Infraestructure.Repository
{
    public static class InsertDefault
    {

        private static readonly string _connectionString = "Data Source=localhost; Initial Catalog=ClimaTempoSimples; Integrated Security=True";

        public static void PrepararBancoDeDados(bool reset = true)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(Queries.Insert_Default.Preparar_Banco, connection) { CommandType = CommandType.Text };
            try
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@Reset", reset));
                command.ExecuteNonQuery();
            }
            catch (SqlException sqlEx) { throw; }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }


        public static void AdicionarClimas()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = null;
            connection.Open();

            try
            {
                _adicionarClimasRS(connection, command);
                _adicionarClimasSP(connection, command);
                _adicionarClimasRJ(connection, command);
            }
            finally
            {
                connection.Close();
            }

        }

        #region Métodos Privados


        static void _adicionarClimasRS(SqlConnection connection, SqlCommand command)
        {
            // Porto Alegre 
            try
            {
                command = new SqlCommand(Queries.Insert_Default.Porto_Alegre, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            // Gramado
            try
            {
                command = new SqlCommand(Queries.Insert_Default.Gramado, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            // São José dos Ausentes
            try
            {
                command = new SqlCommand(Queries.Insert_Default.São_José_dos_Ausentes, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

        }


        static void _adicionarClimasSP(SqlConnection connection, SqlCommand command)
        {
            // São Paulo
            try
            {
                command = new SqlCommand(Queries.Insert_Default.São_Paulo, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            // Guarulhos
            try
            {
                command = new SqlCommand(Queries.Insert_Default.Guarulhos, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            // São Bernardo do Campo
            try
            {
                command = new SqlCommand(Queries.Insert_Default.São_Bernardo_do_Campo, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
        }

        static void _adicionarClimasRJ(SqlConnection connection, SqlCommand command)
        {

            // Rio de Janeiro
            try
            {
                command = new SqlCommand(Queries.Insert_Default.Rio_de_Janeiro, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            // Petrópolis
            try
            {
                command = new SqlCommand(Queries.Insert_Default.Petrópolis, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }

            // Niterói
            try
            {
                command = new SqlCommand(Queries.Insert_Default.Niterói, connection) { CommandType = CommandType.Text };
                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }


        }


        #endregion


    }
}
