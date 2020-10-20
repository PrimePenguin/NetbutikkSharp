using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace NettbutikkSharp.Entities
{
    public class ProductsQueryResponse
    {
        [JsonProperty("data")]
        public List<Product> Data { get; set; }

        [JsonConverter(typeof(CustomAttributeObjectValueNetbutikk))]
        [JsonProperty("paging", NullValueHandling = NullValueHandling.Ignore)]
        public Paging Paging { get; set; }
    }

    public class Product
    {
        /// <summary>
        /// The product ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique product ID
        /// </summary>
        [JsonProperty("unique_product_id")]
        public string UniqueProductId { get; set; }

        /// <summary>
        /// The category name the product is sorted into
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A human readable string describing the variant (attribute combination), e.g. ‘Size: M, Colour: Red’
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }

        /// <summary>
        /// 	The article number
        /// </summary>
        [JsonProperty("article_no")]
        public string ArticleNo { get; set; }

        /// <summary>
        /// The EAN code
        /// </summary>
        [JsonProperty("ean_code")]
        public string EanCode { get; set; }

        /// <summary>
        /// A short description of the product
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// The long description of the product
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The buying price. Two decimals precision
        /// </summary>
        [JsonProperty("buying_price")]
        public string BuyingPrice { get; set; }

        /// <summary>
        /// The price to which the product normally is sold. Two decimals precision
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// The reduced price to which the product is sold at the sales. Two decimals precision
        /// </summary>
        [JsonProperty("sales_price")]
        public string SalesPrice { get; set; }

        /// <summary>
        /// 	The weight in kilograms. Three decimals precision
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// The length in centimeters
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; }

        /// <summary>
        /// 	The height in centimeters
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// The width in centimeters
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; }

        /// <summary>
        /// The volume in litres / cubic decimetres
        /// </summary>
        [JsonProperty("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// 	The URL to the product image
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// The URL to the product detail page
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// An additional text to the product description
        /// </summary>
        [JsonProperty("additional_text")]
        public string AdditionalText { get; set; }

        /// <summary>
        /// Whether or not this product is active in the shop
        /// </summary>
        [JsonProperty("active")]
        public string Active { get; set; }

        /// <summary>
        /// The quantity in the stock
        /// </summary>
        [JsonProperty("stock")]
        public string Stock { get; set; }

        /// <summary>
        /// 	The percentage of value added tax for this product. Two decimals precision
        /// </summary>
        [JsonProperty("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// The timestamp (YYYY-MM-DD HH:MM:SS) when this product has been modified the last time
        /// </summary>
        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        /// <summary>
        /// An associative array of attributes with the attribute name as key, and a list (array) of all possible qualities as value. E.g. {"Size": ["S", "M", "L", "XL"], "Colour": ["Black", "White", "Red"]}
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> Attributes { get; set; }
    }

    public class Paging
    {
        [JsonProperty("next",NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }
    }

    public class UpdateInventoryRequest
    {
        [JsonProperty("stock")]
        public int NewStock { get; set; }
    }

    public class CustomAttributeObjectValueNetbutikk : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if ((string)reader.Value == null)
            {
                try
                {
                    var jObject = JObject.Load(reader);
                    return jObject.ToObject(objectType);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return (string)reader.Value;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
