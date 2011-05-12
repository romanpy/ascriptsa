using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.web.core.stubs
{
    public static class StubFactory
    {
        public static StubType CreateStub<StubType>()
        {
            return (StubType)Activator.CreateInstance(typeof(StubType));

        }
    }
   
}
