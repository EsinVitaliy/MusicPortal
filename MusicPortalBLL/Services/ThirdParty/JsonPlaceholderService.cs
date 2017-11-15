using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using MusicPortalBLL.Models.JsonPlaceholder;
using Newtonsoft.Json;



namespace MusicPortalBLL.Services.ThirdParty
{
    public class JsonPlaceholderService
    {
        public async Task<List<Post>> GetPostsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            using (var replyStream = await httpClient.GetStreamAsync("https://jsonplaceholder.typicode.com/posts"))
            using (var streamReader = new StreamReader(replyStream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<List<Post>>(jsonTextReader);
            }
        }
    }
}
