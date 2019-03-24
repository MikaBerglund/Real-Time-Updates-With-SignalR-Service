using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurationLib
{
    public class ServiceSection
    {

        public string ConnectionString
        {
            get
            {
                return $"endpoint=https://{this.HostName};accesskey={this.Key}";
            }
        }

        public string Key { get; set; }

        public string HostName { get; set; }

    }
}
