using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    [Serializable]
    public abstract class AEntity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int Draw { get; set; }
        public virtual int Start { get; set; }
        public virtual int Length { get; set; } = 5;
        public virtual Dictionary<string, string> Search { get; set; }


    }
}
