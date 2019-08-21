﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBasket.Models
{
    public class ProductListModel
    {
        public string ProdName { get; set; }
        public string CatName { get; set; }
        public string ProdImageUrl { get; set; }

        public string ProdDescription { get; set; }

        public string Barcode { get; set; }
    }
}
