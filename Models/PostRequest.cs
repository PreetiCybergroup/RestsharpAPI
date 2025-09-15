using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestsharpAPI_Automation.Models
{
    public class PostRequest
    {
        public int userId {  get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
