using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCarrera.Dominio
{
    public class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get;set; }

        public Asignatura()
        {
            IdAsignatura = 0;
            NombreAsignatura = string.Empty;
        }
        public Asignatura(int idAsignatura, string nombreAsignatura)
        {
            IdAsignatura = idAsignatura;
            NombreAsignatura = nombreAsignatura;
        }
        public override string ToString()
        {
            return NombreAsignatura;
        }
    }
}
