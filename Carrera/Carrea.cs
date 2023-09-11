using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCarrera
{
    public class Carrea
    {
        public int IdCarrera { get; set; }
        public string NomCarrera { get; set; }
        public List<DetalleCarrera> ListaDetalles { get; set; }

        public Carrea()
        {
            ListaDetalles = new List<DetalleCarrera>();
        }
        public Carrea(int idCarrera,string nomCarrera)
        {
            IdCarrera = idCarrera;
            NomCarrera = nomCarrera;
            ListaDetalles = new List<DetalleCarrera>();
        }

        public void AgregarCarrera(DetalleCarrera detalleCarrera)
        {
            ListaDetalles.Add(detalleCarrera);
        }

        public void AgregarDetalle(DetalleCarrera detalleCarrra)
        {
            ListaDetalles.Add(detalleCarrra);
        }

        public void QuitarDetalle(int indice)
        {
            ListaDetalles.RemoveAt(indice);
        }
    }
}
