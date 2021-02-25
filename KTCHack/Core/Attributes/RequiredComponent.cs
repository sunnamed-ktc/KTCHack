using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCHack.Core.Attributes
{
    /// <summary>
    /// This attribute for the auto adding into KTCHack class component, if it not be added its can`t be work.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RequiredComponent : Attribute
    {

    }
}
