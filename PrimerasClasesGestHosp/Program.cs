using System;
using PrimerasClasesGestHosp.DbContextModels;
using System.Collections.Generic;
using PrimerasClasesGestHosp.Models;


namespace PrimerasClasesGestHosp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var strCon1 = "Data Source=DESKTOP-GUSKUDA;Initial Catalog=GESTIONHOSP;User ID=Alfredo;Password=1007;";
            var strCon1 = "Data Source=unitec-db.database.windows.net;Initial Catalog=im;User ID=AdminDB;Password=P@$$w0rd;";

            ///////////////////////////////////Producto
            /*var con = new ProductosDbContext(strCon1);


            var creado = con.Create(new Producto() { Nombre = "Pro1", Cantidad = 23, Descripcion = "NA",
                Foto = "Base 64", Precio = 99.99f, Tipo = 7 });

            Console.WriteLine(creado ? "El producto se creo correctamente": "No se pudo crear de forma correcta");

            foreach (var pro in con.List())
            {
                Console.WriteLine(pro.Id);
                Console.WriteLine(pro.Nombre);
            }

            var eliminado = con.Delete(new Guid("D78EDD9D-9F06-4466-942D-A51E2358639E"));
            Console.WriteLine(eliminado ? "El producto se eliminó correctamente" : "No se pudo eliminar de forma correcta o no exiete");



            var editar = con.Edit(new Producto()
            {
                Id = new Guid("E3D8529F-8253-422F-A2BC-6713F965BF80"),
                Nombre = "Pro1",
                Cantidad = 23,
                Descripcion = "LALALALA",
                Foto = "Base 64",
                Precio = 99.99f,
                Tipo = 7
            });
            Console.WriteLine(editar ? "El producto se actualizó correctamente" : "No se pudo actualizar de forma correcta o no existe");


            foreach (var pro in con.List())
            {
                Console.WriteLine(pro.Id);
                Console.WriteLine(pro.Nombre);
            }
            
            */
            ///////////////////////////////////Producto

            //////////////////////////////////Cita

            /*var citaCon = new CitasContext(strCon1);


            foreach (var cita in citaCon.List())
            {
                Console.WriteLine($"{cita.Id} - {cita.PacienteId} - {cita.Estatus} - {cita.Fecha}");
            }

            var  citaDe = citaCon.Details(new Guid("880ca1a0-fbcb-45a9-b41b-92eb302887cc"));

            Console.WriteLine($"{citaDe.Id} - {citaDe.PacienteId} - {citaDe.Estatus} - {citaDe.Fecha}");

            var resCitaCre = citaCon.Create(new Cita() { PacienteId = new Guid("AF348C89-71E6-44A7-9EF2-59144E1F38B4"), Fecha = DateTime.Now, Estatus = 0 });

            foreach (var cita in citaCon.List())
            {
                Console.WriteLine($"{cita.Id} - {cita.PacienteId} - {cita.Estatus} - {cita.Fecha}");
            }

            var resCitaEdi = citaCon.Edit(new Cita() { Id= new Guid("880ca1a0-fbcb-45a9-b41b-92eb302887cc"), PacienteId = new Guid("21a79bf9-3bfb-4282-9cff-bf9628e7d175"), Fecha = DateTime.Now, Estatus = 0 });

            foreach (var cita in citaCon.List())
            {
                Console.WriteLine($"{cita.Id} - {cita.PacienteId} - {cita.Estatus} - {cita.Fecha}");
            }
            
            var resCitaDel = citaCon.Delete(new Guid("880ca1a0-fbcb-45a9-b41b-92eb302887cc"));

            foreach (var cita in citaCon.List())
            {
                Console.WriteLine($"{cita.Id} - {cita.PacienteId} - {cita.Estatus} - {cita.Fecha}");
            }

            */
            //////////////////////////////////Cita

            /////////////////////////////////Paciente

            /*var pacienCon = new PacientesDbContext(strCon1);

            foreach (var pa in pacienCon.List())
            {
                Console.WriteLine($"{pa.Id} - {pa.Nombre} - {pa.Foto}");

            }

            var eliPa = pacienCon.Delete(new Guid("AF348C89-71E6-44A7-9EF2-59144E1F38B4"));

            var resCre = pacienCon.Create(new Paciente() { Nombre = "Al", Edad = 08, Direccion = "", Telefono = "", Correo = "J", Expediente = "L", Foto = "base64" });

            var resDet = pacienCon.Details(new Guid("5813ED42-B0C8-4E4F-83B4-00955CD74948"));

            Console.WriteLine($"{resDet.Id} - {resDet.Nombre} - {resDet.Foto}");

            var resAct = pacienCon.Edit(new Paciente() {Id = new Guid("5813ED42-B0C8-4E4F-83B4-00955CD74948"), Nombre = "LALALAL", Edad = 3, Direccion = "", Telefono = "", Correo = "J", Expediente = "L", Foto = "base64" });

            foreach (var pa in pacienCon.List())
            {
                Console.WriteLine($"{pa.Id} - {pa.Nombre} - {pa.Foto}");

            }

            */


            /////////////////////////////////Paciente


        }
    }
}

