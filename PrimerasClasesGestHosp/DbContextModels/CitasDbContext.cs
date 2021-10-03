using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PrimerasClasesGestHosp.Models;

namespace PrimerasClasesGestHosp.DbContextModels
{
    class CitasContext
    {
        private readonly string _connectionString;

        public CitasContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Cita> List()
        {
            var data = new List<Cita>();

            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT * FROM [Cita]", con);
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    data.Add(new Cita
                    {
                        Id = (Guid)dr["Id"],
                        PacienteId = (Guid)dr["PacienteId"],
                        Estatus = Convert.ToInt32(dr["Estatus"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"])
                        
                    });
                }
                return data;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
     
        public Cita Details(Guid id)
        {
            var data = new Cita();

            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT * FROM [Cita] WHERE [Id] = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    data.Id = (Guid)dr["Id"];
                    data.PacienteId = (Guid)dr["PacienteId"];
                    data.Estatus = Convert.ToInt32(dr["Estatus"]);
                    data.Fecha = Convert.ToDateTime(dr["Fecha"]);
                }
                return data;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Create(Cita data)
        {
            var res = 0;
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO [Cita] VALUES (@id,@pacienteId,@estatus,@fecha)", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
            cmd.Parameters.Add("pacienteId", SqlDbType.UniqueIdentifier, 128).Value = data.PacienteId;
            cmd.Parameters.Add("estatus", SqlDbType.SmallInt, 512).Value = data.Estatus;
            cmd.Parameters.Add("fecha", SqlDbType.DateTime).Value = data.Fecha;
            
            try
            {
                con.Open();
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return res > 0;
        }
        
        public bool Edit(Cita data)
        {
            var res = 0;
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("UPDATE [Cita] SET [PacienteId] = @pacienteId, Estatus = @estatus, Fecha = @fecha WHERE [Id] = @id", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
            cmd.Parameters.Add("pacienteId", SqlDbType.UniqueIdentifier, 128).Value = data.PacienteId;
            cmd.Parameters.Add("estatus", SqlDbType.SmallInt, 512).Value = data.Estatus;
            cmd.Parameters.Add("fecha", SqlDbType.DateTime).Value = data.Fecha;


            try
            {
                con.Open();
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return res > 0;
        }
        
        public bool Delete(Guid id)
        {
            var res = 0;
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("DELETE FROM [Cita] WHERE [Id] = @id", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = id;
            try
            {
                con.Open();
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return res > 0;
        }
    }
        
}
