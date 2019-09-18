using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace FoodClassification_Blazor.Pages.FoodClassification
{
    public class FoodClassificationService : IFoodClassificationService
    {
        private readonly IJSRuntime _jsRuntime;

        private const string BaseUrl = "http://127.0.0.1:8080";
        private readonly string ClassificationUrl = $"{BaseUrl}/predict";

        private const string JsLibraryName = "methods";
        private readonly string ReadFileJsFunctionName = $"{JsLibraryName}.readFileAsBase64";

        public FoodClassificationService(IJSRuntime jsRuntime)
        {
            this._jsRuntime = jsRuntime;
        }

        public async Task SetPicture(string inputId, string selectedImageId, FoodClassificationPageCode foodClassificationPageCode)
        {
            await _jsRuntime.InvokeAsync<string>(ReadFileJsFunctionName, inputId, selectedImageId, ClassificationUrl, DotNetObjectRef.Create(foodClassificationPageCode));
        }
    }
}
