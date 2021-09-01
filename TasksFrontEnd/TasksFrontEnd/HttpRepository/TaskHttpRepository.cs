using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TasksFrontEnd.models;

namespace TasksFrontEnd.HttpRepository
{
    public class TaskHttpRepository :ITaskHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        public TaskHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<List<TaskReq>> GetTasks(string s)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["keyword"] = s
            };
            var response = await _client.GetAsync(QueryHelpers.AddQueryString("TaskReq/get", queryStringParam));            
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var products = JsonSerializer.Deserialize<List<TaskReq>>(content, _options);
            return products;
        }
        public async Task CreateTask(TaskReq product)
        {
            var content = JsonSerializer.Serialize(product);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var postResult = await _client.PostAsync("TaskReq/add", bodyContent);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
        }
        public async Task<string> UploadProductImage(MultipartFormDataContent content)
        {
            var postResult = await _client.PostAsync("http://localhost:8000/api/upload", content);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
            else
            {
                var imgUrl = Path.Combine("http://localhost:8000/", postContent);
                return imgUrl;
            }
        }
        public async Task DeleteProduct(int id)
        {
            var url = Path.Combine("TaskReq/delete/", id.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            var deleteContent = await deleteResult.Content.ReadAsStringAsync();
            if (!deleteResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(deleteContent);
            }
        }
        public async Task CheckTask(int id)
        {
            var content = JsonSerializer.Serialize("asdasd");
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var url = Path.Combine("TaskReq/check/", id.ToString());
            var putResult = await _client.PutAsync(url, bodyContent);
            var putContent = await putResult.Content.ReadAsStringAsync();
            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }
        }
        public async Task AddComment(int id, string comment)
        {
            var content = JsonSerializer.Serialize(comment);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var url = Path.Combine("TaskReq/addcomment/", id.ToString());
            var putResult = await _client.PutAsync(url, bodyContent);
            var putContent = await putResult.Content.ReadAsStringAsync();
            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }
        }

    }

}
