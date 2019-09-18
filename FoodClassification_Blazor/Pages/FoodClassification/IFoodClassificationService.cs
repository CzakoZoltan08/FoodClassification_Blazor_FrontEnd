using System.Threading.Tasks;

namespace FoodClassification_Blazor.Pages.FoodClassification
{
    public interface IFoodClassificationService
    {
        Task SetPicture(string inputId, string selectedImageId, FoodClassificationPageCode foodClassificationPageCode);
    }
}
