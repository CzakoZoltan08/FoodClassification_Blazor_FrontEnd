using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace FoodClassification_Blazor.Pages.FoodClassification
{
    public class FoodClassificationPageCode : ComponentBase
    {
        [Inject]
        protected IFoodClassificationService FoodClassificationService { get; set; }

        public FoodClassificationResponse FoodClassificationResponse;

        public string InputId = "image-file";
        public string ResultId = "result";
        public string SelectedImageId = "selected-image";

        [JSInvokable("SetResult")]
        public void SetResult(FoodClassificationResponse foodClassification)
        {
            this.FoodClassificationResponse = foodClassification;
            StateHasChanged();
        }

        public async Task SetPicture()
        {
            await this.FoodClassificationService.SetPicture(InputId, SelectedImageId, this);
        }
    }
}
