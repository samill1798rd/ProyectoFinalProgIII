using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class IEntity<TPrimaryKey> 
    {
        TPrimaryKey Id { get; set; }
        bool IsActive { get; set; }
        int Draw { get; set; }
        int Start { get; set; }
        int Length { get; set; }
        Dictionary<string, string> Search { get; set; }
    }
}
