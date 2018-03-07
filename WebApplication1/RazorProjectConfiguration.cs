using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface IRazorProjectConfiguration
    {
        string[] Paths { get; set; }
    }
    public class RazorProjectConfiguration : IRazorProjectConfiguration
    {
        public string[] Paths { get; set; } = new string[1];
        public RazorProjectConfiguration() { }
        public RazorProjectConfiguration(params string[] paths)
        {
            if (paths.Length > 0)
            {
                Paths = paths;
            }
        }
    }
}
