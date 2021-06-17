using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace WebApplication9.Data.Models
{
    public class JsConsoleService
    {
        private readonly IJSRuntime JsRuntime;
        public JsConsoleService(IJSRuntime jSRuntime)
        {
            this.JsRuntime = jSRuntime;
        }

        public async Task LogAsync(string message)
        {
            await this.JsRuntime.InvokeVoidAsync("console.log", message);
        }

        public async Task Test()
        {
            await JsRuntime.InvokeAsync<string>("changeLanguage", "en");
        }
    }
}
