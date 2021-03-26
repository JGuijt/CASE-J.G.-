using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Reader
{
    public class FileReader
    {
        
        public async Task<string> ReadFile(IFormFile file)
        {

        
        StringBuilder result = new StringBuilder();
        using(StreamReader reader = new StreamReader(file.OpenReadStream()))
        {
        while (reader.Peek() >= 0)
            { result.AppendLine(await reader.ReadLineAsync()); }
        }
        return result.ToString();
        }








    }
}
