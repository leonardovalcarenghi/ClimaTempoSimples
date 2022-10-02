using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Utils.ExtensionMethods.DataBase
{
    public static class DataBaseMethods
    {
        /// <summary>
        /// Inserir parâmetro no comando SQL;
        /// </summary>
        /// <param name="command">SQL Command</param>
        /// <param name="name">Nome do parâmetro</param>
        /// <param name="value">Valor do parâmetro. (Se for 'null' é convertido para 'DBNull'.</param>
        public static void InsertParameter(this SqlCommand command, string name, object value)
        {
            name = name.Trim().Replace(" ", "").Replace("@", "");
            command.Parameters.Add(new SqlParameter("@" + name, value == null ? (object)DBNull.Value : value));
        }

        /// <summary>
        /// Inserir parâmetro utilizando o nome da propriedade como 'key' do parâmetro.
        /// </summary>
        /// <param name="command">SqlCommand</param>
        /// <param name="prop">Propriedade com valor para obter o nome.</param>
        public static void InsertParameter(this SqlCommand command, object prop)
        {
            string name = nameof(prop);
            name = name.Trim().Replace(" ", "").Replace("@", "");
            command.Parameters.Add(new SqlParameter("@" + name, prop == null ? (object)DBNull.Value : prop));
        }

        /// <summary>
        /// Obter retorno do banco de dados pelo SqlDataReader;
        /// </summary>
        /// <typeparam name="T">Tipo de variável</typeparam>
        /// <param name="reader">Leiter SQL</param>
        /// <param name="key">Chave</param>
        /// <returns></returns>
        public static T Response<T>(this SqlDataReader reader, string key)
        {
            try
            {
                if (reader is null) { return default; }

                Type type = typeof(T);
                string db = reader[key].ToString();
                object value = null;

                // Números:
                if (type == typeof(int)) { value = Convert.ToInt32(db); }
                if (type == typeof(decimal)) { value = decimal.Parse(db); }
                if (type == typeof(double)) { value = double.Parse(db); }
                if (type == typeof(float)) { value = float.Parse(db); }
                if (type == typeof(long)) { value = long.Parse(db); }

                // Texto:
                if (type == typeof(char)) { value = char.Parse(db); }
                if (type == typeof(string)) { value = db.ToString(); }

                // Data:
                if (type == typeof(DateTime?)) { value = DateTime.Parse(db); }
                if (type == typeof(DateTime)) { value = DateTime.Parse(db); }

                // Boleano:
                if (type == typeof(bool?)) { value = bool.Parse(db); }
                if (type == typeof(bool)) { value = bool.Parse(db); }

                // Enum:
                if (type.IsEnum) { value = Enum.Parse(type, db); }

                return (T)value;
            }
            catch { return default; }
        }



    }
}
