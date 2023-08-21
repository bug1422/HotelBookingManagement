using Dropbox.Api.Files;
using Dropbox.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Services.Tools
{
    public class UploadImage
    {
        public static async Task Upload()
        {
            string accessToken = "YOUR_ACCESS_TOKEN"; // Replace with your access token
            string filePath = "C:\\Path\\To\\Your\\File.txt"; // Replace with the path to your local file

            using (var client = new DropboxClient(accessToken))
            {
                string fileName = Path.GetFileName(filePath);
                using (var fileStream = File.OpenRead(filePath))
                {
                    var uploadResult = await client.Files.UploadAsync(
                        "/" + fileName,
                        WriteMode.Overwrite.Instance,
                        body: fileStream);

                    Console.WriteLine("File uploaded successfully. File Id: " + uploadResult.Id);
                }
            }
        }

    }
}
