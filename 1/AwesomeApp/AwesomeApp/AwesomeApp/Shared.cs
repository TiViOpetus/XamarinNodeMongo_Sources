using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwesomeApp
{
    public class ListEntry
    {
        public string _id { get; set; }
        public string testidata { get; set; }
    }

    public interface IAuthAPI
    {
        [Get("/helloworld")]
        Task<string> HelloWorld();

        [Get("/add")]
        Task<string> Add();

        [Get("/list")]
        Task<List<ListEntry>> List();
    }
}
