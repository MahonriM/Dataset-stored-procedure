using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int IdMunicipio;
            var taa = new MiDataSetTableAdapters.SPREPORTE6TableAdapter();
            Console.WriteLine("Ingresa el Id del municipio");
            IdMunicipio = int.Parse(Console.ReadLine());
            var df = taa.GetData(IdMunicipio);
            foreach (MiDataSet.SPREPORTE6Row row in df.Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}",row.camiones,row.chofer,row.turnomatutino,
                    row.turnovespertino,row.turnonocturno);
            }
             
            
            Console.ReadKey();
        }
        void obtenermunicicipios()
        {
            var ta = new MiDataSetTableAdapters.spMunicipioConsultarTodoTableAdapter();
            var dt = ta.GetData();
            foreach (MiDataSet.spMunicipioConsultarTodoRow row in dt.Rows)
            {
                Console.WriteLine("{0},{1}", row.idMunicipio, row.nombre);
            }
            ta.Dispose();
            dt.Dispose();

        }
    }
}  
