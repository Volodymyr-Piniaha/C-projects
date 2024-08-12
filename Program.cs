using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Working_with_JSON_files
{
    class Program
    {

        static async Task Main(string[] args)
        {

            string url = @"C:\\Users\\user\\Desktop\file.json";

            HttpClient httpClient = new HttpClient();
            string information = File.ReadAllText(url);
            string endfile = @"C:\Users\user\Desktop\date.txt";
            //var dateToCheck = DateTime.Parse(File.ReadAllText(endfile));
            JArray data = JArray.Parse(information);

            var docs = JsonConvert.DeserializeObject<List<Root>>(information).Select(_ => );



            try
            {
                var httpResponseMessage = await httpClient.GetAsync(json);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);


                //Deaserialize the JSON response into a C# array of type Post[]
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                foreach (var post in myPosts)
                {
                    Console.WriteLine($"{post.Id} {post.Title}");
                }

            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
            }
            //finally
            //{
            //    httpClient.Dispose();
            //}
        }
    }
}
