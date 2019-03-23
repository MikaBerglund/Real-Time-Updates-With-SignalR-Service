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
                return $"Endpoing=https://{this.HostName};AccessKey={this.Key}";
            }
        }

        public string Key { get; set; }

        public string HostName { get; set; }

    }
}
