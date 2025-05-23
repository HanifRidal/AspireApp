﻿using AspireApp.Model.Entities;
using AspireApp.Model.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace AspireApp.Web.Components.Pages.Product
{
    public partial class IndexProduct
    {
        [Inject]
        public ApiClient ApiClient { get; set; }
        public List<ProductModel> ProductModels { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var res = await ApiClient.GetFromJsonAsync<BaseResponseModel>("/api/Product");
            if (res != null && res.Success)
            {
                ProductModels = JsonConvert.DeserializeObject<List<ProductModel>>(res.Data.ToString());
            }
            await base.OnInitializedAsync();
        }
    }
}
