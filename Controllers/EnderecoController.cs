using EnderecoApi.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace EnderecoApi.Controllers
{
    public class EnderecoController : ApiController
    {
        [Route("api/BuscarCEP/{cep}"), HttpGet]
        public async Task<Endereco> Get(string cep)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync("http://viacep.com.br/ws/" + cep + "/json/");
                var endereco = JsonConvert.DeserializeObject<Endereco>(response);
                return endereco;
            }
        }

            //asyb await  
    }
}