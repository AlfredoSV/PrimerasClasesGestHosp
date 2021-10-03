using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PrimerasClasesGestHosp.Models;

namespace PrimerasClasesGestHosp.DbContextModels
{
    class PacientesDbContext
    {
        private readonly string _connectionString;

        public PacientesDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Paciente> List()
        {
            var data = new List<Paciente>();

            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT * FROM [Paciente]", con);
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    data.Add(new Paciente
                    {
                        Id = (Guid)dr["Id"],
                        Nombre = (string)dr["Nombre"],
                        Edad = (int)dr["Edad"],
                        Direccion =(string)dr["Direccion"],
                        Telefono = (string)dr["Telefono"],
                        Correo = (string)dr["Correo"],
                        Expediente = (string)dr["Expediente"],
                        Foto = (string)dr["Foto"],
                    });
                }
                
            }
            catch (Exception e)
            {
                data = null;
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public Paciente Details(Guid id)
        {
            var data = new Paciente();

            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT * FROM [Paciente] WHERE [Id] = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    data.Id = (Guid)dr["Id"];
                    data.Nombre = (string)dr["Nombre"];
                    data.Edad = (int)dr["Edad"];
                    data.Direccion = (string)dr["Direccion"];
                    data.Telefono = (string)dr["Telefono"];
                    data.Correo = (string)dr["Correo"];
                    data.Expediente = (string)dr["Expediente"];
                    data.Foto = (string)dr["Foto"];
                }
                
            }
            catch (Exception)
            {

                data = null;
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public bool Create(Paciente data)
        {
            var res = 0;
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO [Paciente] VALUES (@id,@nombre,@edad,@direc,@tele,@correo,@exp,@foto)", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
            cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 128).Value = data.Nombre;
            cmd.Parameters.Add("edad", SqlDbType.Int).Value = data.Edad;
            cmd.Parameters.Add("direc", SqlDbType.NVarChar,512).Value = data.Direccion;
            cmd.Parameters.Add("tele", SqlDbType.NVarChar,128).Value = data.Telefono;
            cmd.Parameters.Add("correo", SqlDbType.NVarChar,256).Value = data.Correo;
            cmd.Parameters.Add("exp", SqlDbType.VarChar).Value = data.Expediente;
            cmd.Parameters.Add("foto", SqlDbType.VarChar).Value = data.Foto;

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
        
        public bool Edit(Paciente data)
        {
            var res = 0;
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("UPDATE [Paciente] SET [Nombre] = @nombre, Edad = @edad, Direccion = @direc, Telefono = @tele, Correo = @correo, Expediente = @exp ,Foto = @foto WHERE [Id] = @id", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
            cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 128).Value = data.Nombre;
            cmd.Parameters.Add("edad", SqlDbType.Int).Value = data.Edad;
            cmd.Parameters.Add("direc", SqlDbType.NVarChar, 512).Value = data.Direccion;
            cmd.Parameters.Add("tele", SqlDbType.NVarChar, 128).Value = data.Telefono;
            cmd.Parameters.Add("correo", SqlDbType.NVarChar, 256).Value = data.Correo;
            cmd.Parameters.Add("exp", SqlDbType.VarChar).Value = data.Expediente;
            cmd.Parameters.Add("foto", SqlDbType.VarChar).Value = data.Foto;
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

            new CitasContext(this._connectionString).DeleteCitaPacienteId(id);
            


                var cmd = new SqlCommand("DELETE FROM [Paciente] WHERE [Id] = @id", con);

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
