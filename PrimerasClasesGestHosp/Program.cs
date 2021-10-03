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
            var strCon1 = "Data Source=DESKTOP-GUSKUDA;Initial Catalog=GESTIONHOSP;User ID=Alfredo;Password=1007;";
            //var strCon1 = "Data Source=unitec-db.database.windows.net;Initial Catalog=im;User ID=AdminDB;Password=P@$$w0rd;";

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
            Console.WriteLine(eliminado ? "El producto se eliminó correctamente" : "No se pudo eliminar de forma correcta");



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
            Console.WriteLine(editar ? "El producto se actualizó correctamente" : "No se pudo actualizar de forma correcta");


            foreach (var pro in con.List())
            {
                Console.WriteLine(pro.Id);
                Console.WriteLine(pro.Nombre);
            }*/

            ///////////////////////////////////Producto

            //////////////////////////////////Cita

            /*var citaCon = new CitasContext(strCon1);


            foreach (var cita in citaCon.List())
            {
                Console.WriteLine($"{cita.Id} - {cita.PacienteId} - {cita.Estatus} - {cita.Fecha}");
            }

            var  citaDe = citaCon.Details(new Guid("B3661065-95F6-46CB-B6F8-0D913AB9F077"));

            Console.WriteLine($"{citaDe.Id} - {citaDe.PacienteId} - {citaDe.Estatus} - {citaDe.Fecha}");

            var resCitaCre = citaCon.Create(new Cita() { PacienteId = new Guid("AF348C89-71E6-44A7-9EF2-59144E1F38B4"), Fecha = DateTime.Now, Estatus = 0 });

            foreach (var cita in citaCon.List())
            {
                Console.WriteLine($"{cita.Id} - {cita.PacienteId} - {cita.Estatus} - {cita.Fecha}");
            }

            var resCitaEdi = citaCon.Edit(new Cita() { Id= new Guid("33E285C9-CF45-404F-A3F6-DC1B174CF26B"), PacienteId = new Guid("AF348C89-71E6-44A7-9EF2-59144E1F38B4"), Fecha = DateTime.Now, Estatus = 1 });


            var resCitaDel = citaCon.Delete(new Guid("33E285C9-CF45-404F-A3F6-DC1B174CF26B"));

            */


            //////////////////////////////////Cita


        }
    }
}

