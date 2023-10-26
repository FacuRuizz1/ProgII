using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCarrera2.Dominio
{
    public class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; }

        public Asignatura()
        {
            IdAsignatura = 0;
            NombreAsignatura = string.Empty;
        }
        public Asignatura(int idAsignatura, string nomAsignatura)
        {
            IdAsignatura = idAsignatura;
            NombreAsignatura = nomAsignatura;
        }
        public override string ToString()
        {
            return NombreAsignatura;
        }
    }
}
