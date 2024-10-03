using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System.Data;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace SVRepository.Implementation
{
    public class NegocioRepository : INegocioRepository
    {
        private readonly Conexion _conexion;

        public NegocioRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<Negocio> Obtener()
        {
            Negocio objeto = new Negocio();

            using (var con = _conexion.ObtenerSqlConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerNegocio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (dr.Read())
                    {
                        objeto = new Negocio()
                        {
                            RazonSocial = dr["RazonSocial"].ToString()!,
                            RUC = dr["RUC"].ToString()!,
                            Direccion = dr["Direccion"].ToString()!,
                            Celular = dr["Celular"].ToString()!,
                            Correo = dr["Correo"].ToString()!,
                            NombreLogo = dr["NombreLogo"].ToString()!,
                            UrlLogo = dr["UrlLogo"].ToString()!
                        };
                    }
                   
                   
                }
            }
            return objeto;
        }
        public async Task Edtiar(Negocio objeto)
        {

            using (var con = _conexion.ObtenerSqlConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);
                cmd.Parameters.AddWithValue("@RazonSocial", objeto.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", objeto.RUC);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Celular", objeto.Celular);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@SimboloMoneda", objeto.SimboloMoneda);
                cmd.Parameters.AddWithValue("@NombreLogo", objeto.NombreLogo);
                cmd.Parameters.AddWithValue("@UrlLogo", objeto.UrlLogo);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }
            }
        }

        
    }
}
