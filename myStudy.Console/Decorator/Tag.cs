using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.Decorator
{
    class TagComponent : IComponent
    {
        IComponent _component = null;

        public TagComponent(IComponent component)
        {
            _component = component;
        }

        public string GetContent()
        {
           return _component.GetContent()+ " and some additional feature";                       
        }
    }
}
