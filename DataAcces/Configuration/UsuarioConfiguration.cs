using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Configuration
{
    class UsuarioConfiguration : ConfiguractionBase<Model.Entities.Usuario, int>
    {
        public UsuarioConfiguration() : base()
        {
            ToTable("Usuario");

            Property(x => x.Id_Usuario).HasColumnName("Id_Usuario");
            Property(x => x.Nombre).HasColumnName("Nombre");
            Property(x => x.Apellido).HasColumnName("Apellido");
            Property(x => x.Correo).HasColumnName("Correo");
            Property(x => x.Clave).HasColumnName("Clave");
       
        















        }

    }
}
