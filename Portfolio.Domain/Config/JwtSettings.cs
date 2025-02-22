using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Config
{
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Secret { get; set; }
        public int TokenLifetime { get; set; }
        public int RefreshTokenLifetime { get; set; }
        public string Separator { get; set; }
        public string Format { get; set; }
        public string LoginProvider { get; set; }
    }

}
