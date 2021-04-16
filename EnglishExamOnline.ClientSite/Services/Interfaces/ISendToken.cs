using System.Net.Http;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface ISendToken
    {
        Task<HttpClient> SendAccessToken();
    }
}
