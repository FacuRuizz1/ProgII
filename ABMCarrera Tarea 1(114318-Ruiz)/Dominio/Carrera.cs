using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCarrera.Dominio
{
    public class Carrera
    {
        public int IdCarrera {  get; set; }
        public string NombreCarrera { get; set; }
        public List<DetalleCarrera> lDetalle { get; set; }

        public Carrera()
        {
            IdCarrera = 0;
            NombreCarrera = string.Empty;
            lDetalle = new List<DetalleCarrera>();
        }
        public Carrera(int idCarrera, string nombreCarrera, List<DetalleCarrera> lDetalle)
        {
            IdCarrera = idCarrera;
            NombreCarrera = nombreCarrera;
            this.lDetalle = lDetalle;
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
