namespace WebApp.Core
{
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// The configuration extensions
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Gets the connection string
        /// </summary>
        /// <param name="configuration">
        /// The configuration
        /// </param>
        public static string GetConnectionString(this IConfiguration configuration)
        {
            return configuration.GetConnectionString("persons_db");
        }

    }
}
