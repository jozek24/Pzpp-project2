using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components.Model
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
