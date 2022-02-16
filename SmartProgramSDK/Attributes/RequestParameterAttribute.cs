using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartProgramSDK.Attributes
{
    public sealed class RequestParameterAttribute : Attribute
    {
        public ParameterType ParameterType { get; private set; }

        public RequestParameterAttribute(ParameterType parameterType)
        {
            this.ParameterType = parameterType;
        }

    }
}
