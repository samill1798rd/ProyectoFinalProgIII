using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Configuration
{
    class IglesiaConfiguration: ConfiguractionBase<Model.Entities.Iglesia, int>
    {
        public IglesiaConfiguration(): base()
        {
            ToTable("Iglesia");

            Property(x=>x.Id).HasColumnName("Id_Iglesia");
            Property(x => x.Sexo_DP).HasColumnName("Sexo_DP");
            Property(x => x.Apellidos_DP).HasColumnName("Apellidos_DP");
            Property(x => x.Nombres_DP).HasColumnName("Nombres_DP");
            Property(x => x.FechaNacimiento_DP).HasColumnName("FechaNacimiento_DP");
            Property(x => x.PaisNacimiento_DP).HasColumnName("PaisNacimiento_DP");
            Property(x => x.CiudadNacimiento_DP).HasColumnName("CiudadNacimiento_DP");
            Property(x => x.PaisResidenciaActual_DP).HasColumnName("PaisResidenciaActual_DP");
            Property(x => x.CiudadResidneciaActual_DP).HasColumnName("CiudadResidneciaActual_DP");
            Property(x => x.Direccion_DP).HasColumnName("Direccion_DP");
            Property(x => x.Telefono_DP).HasColumnName("Telefono_DP");
            Property(x => x.Celular_DP).HasColumnName("Celular_DP");
            Property(x => x.TipoIdentidad_DP).HasColumnName("TipoIdentidad_DP");
            Property(x => x.DocumentoIdentidad_DP).HasColumnName("DocumentoIdentidad_DP");


            Property(x => x.EstadoCivil_DF).HasColumnName("EstadoCivil_DF");
            Property(x => x.NombrePareja_DF).HasColumnName("NombrePareja_DF");
            Property(x => x.Hijos_DF).HasColumnName("Hijos_DF");
            Property(x => x.NoHijos_DF).HasColumnName("NoHijos_DF");

            Property(x => x.Profesion_DL).HasColumnName("Profesion_DL");
            Property(x => x.OcupacionActual_DL).HasColumnName("OcupacionActual_DL");
            Property(x => x.NombreEmpresa_DL).HasColumnName("NombreEmpresa_DL");
            Property(x => x.EmpresaTelefono_DL).HasColumnName("EmpresaTelefono_DL");

            Property(x => x.FechaConvencion_DE).HasColumnName("FechaConvencion_DE");
            Property(x => x.FechaBautismo_DE).HasColumnName("FechaBautismo_DE");
            Property(x => x.FechaAceptado_DE).HasColumnName("FechaAceptado_DE");
            Property(x => x.Denominacion_DE).HasColumnName("Denominacion_DE");
            Property(x => x.NombreIglesiaActual_DE).HasColumnName("NombreIglesiaActual_DE");
            Property(x => x.IglesiaMenorTiempo_DE).HasColumnName("IglesiaMenorTiempo_DE");
            Property(x => x.IglesiaAnterior_DE).HasColumnName("IglesiaAnterior_DE");
            Property(x => x.PastorActual_DE).HasColumnName("PastorActual_DE");
            Property(x => x.SidoDisciplenado_DE).HasColumnName("SidoDisciplenado_DE");
            Property(x => x.DisciplinaCausas_DE).HasColumnName("DisciplinaCausas_DE");
            Property(x => x.DisciplinaVeces_DE).HasColumnName("DisciplinaVeces_DE");
            Property(x => x.FuncionesOcupadaActural_DE).HasColumnName("FuncionesOcupadaActural_DE");
            Property(x => x.MinisteriosAnteriores_DE).HasColumnName("MinisteriosAnteriores_DE");
            Property(x => x.MinisteriosMayorFruto_DE).HasColumnName("MinisteriosMayorFruto_DE");
            Property(x => x.MinisteriosMayorFrutoPorque_DE).HasColumnName("MinisteriosMayorFrutoPorque_DE");
            Property(x => x.MinisterioLlamado_DE).HasColumnName("MinisterioLlamado_DE");
            Property(x => x.MetasVida_DE).HasColumnName("MetasVida_DE");
            Property(x => x.RespaldoIglesia_DE).HasColumnName("RespaldoIglesia_DE");

            Property(x => x.NivelEstudio_DA).HasColumnName("NivelEstudio_DA");
            Property(x => x.VezEspulsado_DA).HasColumnName("VezEspulsado_DA");
            Property(x => x.VezEspulsadoPorque_DA).HasColumnName("VezEspulsadoPorque_DA");

            Property(x => x.Usuario_Id).HasColumnName("Usuario_Id").IsRequired();

     













        }

    }
}
