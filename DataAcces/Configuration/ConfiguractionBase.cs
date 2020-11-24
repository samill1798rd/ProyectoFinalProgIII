using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataAcces.Configuration
{
    public abstract class ConfiguractionBase<TEntity, TPrimaryKey> : EntityTypeConfiguration<TEntity> where TEntity : AEntity<TPrimaryKey>
    {
        protected ConfiguractionBase()
        {
            HasKey(t => t.Id);
            Ignore(t => t.IsActive);
            Ignore(t => t.Draw);
            Ignore(t => t.Start);
            Ignore(t => t.Length);
        }
    }
}
