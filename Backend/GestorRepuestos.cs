using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class GestorRepuestos
    {
        private List<Repuesto> lista = new List<Repuesto>();
        private string archivo = "repuestos.txt";
        public void Agregar(Repuesto repuesto)
        {
            lista.Add(repuesto);
        }

        public Repuesto Buscar(string codigo)
        {
            return lista.FirstOrDefault(r => r.Codigo == codigo);
        }
        public List<Repuesto> ObtenerTodos()
        {
            return lista;
        }
public void GuardarArchivo()
        {
            StreamWriter sw = new StreamWriter(archivo);

            foreach (Repuesto r in lista)
            {
                sw.WriteLine(r.Codigo + ";" +
                             r.Nombre + ";" +
                             r.Stock + ";" +
                             r.Precio);
            }

            sw.Close();
        }
    public void CargarArchivo()
        {
            if (File.Exists(archivo))
            {
                StreamReader sr = new StreamReader(archivo);

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();

                    string[] datos = linea.Split(';');

                    Repuesto r = new Repuesto();

                    r.Codigo = datos[0];
                    r.Nombre = datos[1];
                    r.Stock = int.Parse(datos[2]);
                    r.Precio = decimal.Parse(datos[3]);

                    lista.Add(r);
                }
                sr.Close();
            }
        }
        public void Eliminar(string codigo)
        {
            Repuesto repuestoEliminar =
                lista.FirstOrDefault(r => r.Codigo == codigo);

            if (repuestoEliminar != null)
            {
                lista.Remove(repuestoEliminar);
                GuardarArchivo();
            }
        }
    }
}
