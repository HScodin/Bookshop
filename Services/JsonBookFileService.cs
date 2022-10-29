using Bookshop.Modals;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bookshop.Services
{
    public class JsonBookFileService
    {
        public JsonBookFileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment;

        public string jsonfilepath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "books.json");
            } 
        }

        public IEnumerable<Book> getBookRecord()
        {
            using (var json_file = File.OpenText(jsonfilepath))
            return JsonSerializer.Deserialize<Book[]>(json_file.ReadToEnd());
        }
    }
}
