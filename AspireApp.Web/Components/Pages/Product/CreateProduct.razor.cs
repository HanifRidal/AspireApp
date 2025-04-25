using AspireApp.Model.Entities;
using AspireApp.Model.Models;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;

namespace AspireApp.Web.Components.Pages.Product
{
    public partial class CreateProduct
    {
        public ProductModel Model { get; set; } = new();
        [Inject]
        public ApiClient ApiClient { get; set; }
        [Inject]
        private IToastService ToastService { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        public async Task Submit()
        {
            var res = await ApiClient.PostAsync<BaseResponseModel, ProductModel>("/api/Product", Model);
            if (res != null && res.Success)
            {
                ToastService.ShowSuccess("Create Product Successfully");
                NavigationManager.NavigateTo("/product");
            }
            else
            {
                ToastService.ShowError(res?.ErrorMessage ?? "An unexpected error occurred.");
            }

            //var res = await ApiClient.PostAsync<BaseResponseModel<ProductModel>, ProductModel>("/api/Product", Model);
            //if (res?.IsValid == true)
            //{
            //    ToastService.ShowSuccess("Create Product Successfully");
            //    NavigationManager.NavigateTo("/product");
            //}
            //else
            //{
            //    ToastService.ShowError(res?.ErrorMessage ?? "An unexpected error occurred.");
            //}
        }
    }

}

