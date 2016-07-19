using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mattermost_WPF
{
    public class MattermostServer
    {
        private String name;
        private String url;
        private String prefix;
        private uint port;

        public MattermostServer(String name, String url, String prefix, uint port)
        {
            this.name = name;
            this.url = url;
            this.prefix = prefix;
            this.port = port;
        }

        public Uri GetUri()
        {
            return new Uri(prefix + url + ":" + port);
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetUrl(String url)
        {
            this.url = url;
        }

        public void SetPrefix(String prefix)
        {
            this.prefix = prefix;
        }

        public void SetPort(uint port)
        {
            this.port = port;
        }

        public bool Equals(MattermostServer server)
        {
            if (server.GetUri().Equals(this.GetUri())) {
                return true;
            }

            return false;
        }

        public bool isValid()
        {
            if (!prefix.Equals("http://") && !prefix.Equals("https://"))
            {
                return false;
            }
            else if (port < 1 || port > 65535)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
