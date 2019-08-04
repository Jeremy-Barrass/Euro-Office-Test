using System;
using System.Collections.Generic;

namespace TheCatApi.ViewModels
{
    public class CategoriesViewModel
    {
        private List<string> _categories;

        public CategoriesViewModel()
        {
            _categories = new List<string>()
            {
                "planes",
                "trains",
                "automobiles"
            };
        }

        public List<string> Categories => _categories;
    }
}
