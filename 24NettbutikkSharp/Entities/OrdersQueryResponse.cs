using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _24NettbutikkSharp.Entities
{
    public class OrdersQueryResponse
    {
        [JsonProperty("data")]
        public List<Order> Orders { get; set; }

        [JsonConverter(typeof(CustomAttributeObjectValueNetbutikk))]
        [JsonProperty("paging", NullValueHandling = NullValueHandling.Ignore)]
        public Paging Paging { get; set; }
    }

    public class Order
    {
        /// <summary>
        /// The order number
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// The ID of the customer who has placed this order
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The comment the customer has attached to the order
        /// </summary>
        [JsonProperty("customer_comment")]
        public string CustomerComment { get; set; }

        /// <summary>
        /// The order status 
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The order fraud status 
        /// </summary>
        [JsonProperty("fraud_status")]
        public string FraudStatus { get; set; }

        /// <summary>
        /// The date the order was placed. Format YYYY-MM-DD
        /// </summary>
        [JsonProperty("order_date")]
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// The time the order was placed. Format HH:MM:SS (24-hour notation)
        /// </summary>
        [JsonProperty("order_time")]
        public DateTimeOffset? OrderTime { get; set; }

        //The date the order was sent. Format YYYY-MM-DD
        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The ID of the payment method
        /// </summary>
        [JsonProperty("payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// The payment method. Norwegian names, customized to Norwegian circumstances
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// he amount of an addition to the payment. Two decimals precision
        /// </summary>
        [JsonProperty("payment_addition")]
        public string PaymentAddition { get; set; }

        /// <summary>
        /// 	The shipping method ID
        /// </summary>
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// The shipping method as plain text. May be defined and altered by the shop owner
        /// </summary>
        [JsonProperty("shipping_method_text")]
        public string ShippingMethodText { get; set; }

        /// <summary>
        /// 	The shipping costs. Two decimals precision
        /// </summary>
        [JsonProperty("shipping_costs")]
        public string ShippingCosts { get; set; }

        /// <summary>
        /// The costs for shipping to Svalbard. Two decimals precision
        /// </summary>
        [JsonProperty("shipping_svalbard")]
        public string ShippingSvalbard { get; set; }

        /// <summary>
        /// 	The percentage of value added tax. Two decimals precision
        /// </summary>
        [JsonProperty("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// The percentage of value added tax for the addition to the payment. Two decimals precision
        /// </summary>
        [JsonProperty("addition_vat")]
        public string AdditionVat { get; set; }

        /// <summary>
        /// 	Whether or not the order has been effected
        /// </summary>
        [JsonProperty("effected")]
        public string Effected { get; set; }

        /// <summary>
        /// The transaction number to identify the payment in some payment methods
        /// </summary>
        [JsonProperty("transaction_no")]
        public string TransactionNo { get; set; }

        /// <summary>
        /// 	The invoice number
        /// </summary>
        [JsonProperty("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Whether or not the order has been completely paid
        /// </summary>
        [JsonProperty("paid")]
        public string Paid { get; set; }

        /// <summary>
        /// Whether or not the order has been deleted
        /// </summary>
        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        /// <summary>
        /// The date when the order was deleted. Format YYYY-MM-DD
        /// </summary>
        [JsonProperty("deletion_date")]
        public string DeletionDate { get; set; }

        /// <summary>
        /// The person who has deleted the order. "customer" or some name
        /// </summary>
        [JsonProperty("deleted_by")]
        public string DeletedBy { get; set; }

        /// <summary>
        /// The date when the order has been effected. Format YYYY-MM-DD
        /// </summary>
        [JsonProperty("effecting_date")]
        public string EffectingDate { get; set; }

        /// <summary>
        /// Whether or not a gift card is used in the payment of the order
        /// </summary>
        [JsonProperty("gift_card")]
        public string GiftCard { get; set; }

        /// <summary>
        /// The comment the shop has attached to the order
        /// </summary>
        [JsonProperty("shop_comment")]
        public string ShopComment { get; set; }

        /// <summary>
        /// Whether or not the order is blocked
        /// </summary>
        [JsonProperty("blocked")]
        public string Blocked { get; set; }

        /// <summary>
        /// Whether or not the order has been sent to the Tripletex accounting software
        /// </summary>
        [JsonProperty("tripletex_sent")]
        public string TripletexSent { get; set; }

        /// <summary>
        /// Whether or not the order has been ly sent
        /// </summary>
        [JsonProperty("rest")]
        public string Rest { get; set; }

        /// <summary>
        /// The currency the order’s amounts are given in. Three letter code (ISO 4217)
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The exchange rate of the order’s currency in relation to NOK, at the time the order was placed. Two decimals precision
        /// </summary>
        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// The gross total amount of the order. Two decimals precision
        /// </summary>
        [JsonProperty("total_amount_gross")]
        public string TotalAmountGross { get; set; }

        /// <summary>
        /// The total value added tax due. Two decimals precision
        /// </summary>
        [JsonProperty("total_vat")]
        public string TotalVat { get; set; }

        [JsonProperty("pickuppoint")]
        public string PickupPoint { get; set; }

        /// <summary>
        /// The timestamp when this order has been modified the last time
        /// </summary>
        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        /// <summary>
        ///  An array of order line items belonging to this order
        /// </summary>
        [JsonProperty("order_lines")]
        public List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        /// <summary>
        /// 	The order line ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The number of the order this order line is contained in
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The product ID. All variants (i.e. attribute combinations) share the same product ID
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// The unique product ID. Each variant (i.e. attribute combination) is determined by a distinct unique product ID.
        /// </summary>
        [JsonProperty("unique_product_id")]
        public string UniqueProductId { get; set; }

        /// <summary>
        /// The product name
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// The quantity that has been ordered – the number of items, amounts, lengths
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// The price for one item or one unit
        /// </summary>
        [JsonProperty("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Whether or not this order line has been sent
        /// </summary>
        [JsonProperty("sent")]
        public string Sent { get; set; }

        /// <summary>
        /// The quantity that actually has been sent
        /// </summary>
        [JsonProperty("quantity_sent")]
        public string QuantitySent { get; set; }

        /// <summary>
        /// The date when this order line has been sent. Format YYYY-MM-DD
        /// </summary>
        [JsonProperty("sent_date")]
        public string SentDate { get; set; }

        /// <summary>
        /// The tracking number for the shipment which contains this order line
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The VAT percentage, 2 decimals
        /// </summary>
        [JsonProperty("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// Whether or not the order line is blocked
        /// </summary>
        [JsonProperty("blocked")]
        public string Blocked { get; set; }

        /// <summary>
        /// Extra information about the product
        /// </summary>
        [JsonProperty("extra_field")]
        public string ExtraField { get; set; }

        /// <summary>
        /// The amount of possible extra costs, 2 decimals
        /// </summary>
        [JsonProperty("extra_price")]
        public string ExtraPrice { get; set; }

        /// <summary>
        /// The absolute amount of discount, 2 decimals
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// The gross total amount this order line costs, 2 decimals
        /// </summary>
        [JsonProperty("total_amount_gross")]
        public string TotalAmountGross { get; set; }

        /// <summary>
        /// he total VAT amount for this order line, 2 decimals
        /// </summary>
        [JsonProperty("total_vat")]
        public string TotalVat { get; set; }

        /// <summary>
        /// An associative array of attributes with the attribute name as key and the actual quality as value. E.g. {"Size": "M", "Colour": "Black"}
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Attributes { get; set; }
    }
}
