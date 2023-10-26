using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCarrera2.Dominio
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public List<DetalleCarrera> lDetalle { get; set; }
        public Carrera(int idCarrera, string nomCarrera, List<DetalleCarrera> lDetalle)
        {
            IdCarrera = idCarrera;
            NombreCarrera = nomCarrera;
            lDetalle = new List<DetalleCarrera>();
        }

        public Carrera()
        {
            IdCarrera = 0;
            NombreCarrera = string.Empty;
             lDetalle = new List<DetalleCarrera>();
        }
        public void AgregarDetalle(DetalleCarrera detalle)
        {
            lDetalle.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            lDetalle.RemoveAt(indice);
        }
    }
}
