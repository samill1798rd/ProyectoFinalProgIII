using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public  class Usuario
    {
        public Usuario()
        {
            this.Iglesias = new HashSet<Iglesia>();
        }

        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public virtual ICollection<Iglesia> Iglesias { get; set; }
    }
}
