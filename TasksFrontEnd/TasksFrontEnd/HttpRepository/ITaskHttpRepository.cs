using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TasksFrontEnd.models;

namespace TasksFrontEnd.HttpRepository
{
    public interface ITaskHttpRepository
    {
        Task<List<TaskReq>> GetTasks(string s);
        Task CreateTask(TaskReq taskreq);
        Task<string> UploadProductImage(MultipartFormDataContent content);
        Task DeleteProduct(int id);
        Task CheckTask(int id);
        Task AddComment(int id , string comment);

    }
}
