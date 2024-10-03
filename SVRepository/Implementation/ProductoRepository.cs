﻿
using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System.Data;

namespace SVRepository.Implementation
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;

        public ProductoRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Producto>> lista(string buscar = "")
        {
            List<Producto> lista = new List<Producto>();

            using (var con = _conexion.ObtenerSqlConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaProducto", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            RefCategoria = new Categoria
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Nombre = dr["NombreCategoria"].ToString()!
                            },
                            Codigo = dr["Codigo"].ToString()!,
                            Descripcion = dr["Descripcion"].ToString()!,
                            PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            PrecioVenta = Convert.ToInt32(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Activo = Convert.ToInt32(dr["Activo"])
                        });

                    }
                }
            }
            return lista;
        }
        public async Task<string> Crear(Producto objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqlConexion())
            {
                con.Open();

                var cmd = new SqlCommand("sp_crearProducto", con);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rp): No se pudo procesar";
                }
            }
            return respuesta;
        }

        public async Task<string> Editar(Producto objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqlConexion())
            {
                con.Open();

                var cmd = new SqlCommand("sp_editarProducto", con);
                cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(rp): No se pudo procesar";
                }
            }
            return respuesta;
        }


    }
}
