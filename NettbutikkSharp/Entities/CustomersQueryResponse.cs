using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace _NettbutikkSharp.Entities
{
    public  class CustomersQueryResponse
    {
        [JsonProperty("data")]
        public List<NetbutikkCustomer> Customers { get; set; }
    }

    public  class NetbutikkCustomer
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_person")]
        public string ContactPerson { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("organisation_no")]
        public string OrganisationNo { get; set; }

        [JsonProperty("e_mail")]
        public string EMail { get; set; }

        [JsonProperty("use_delivery_address")]
        public string UseDeliveryAddress { get; set; }

        [JsonProperty("delivery_name")]
        public string DeliveryName { get; set; }

        [JsonProperty("delivery_address_1")]
        public string DeliveryAddress1 { get; set; }

        [JsonProperty("delivery_address_2")]
        public string DeliveryAddress2 { get; set; }

        [JsonProperty("delivery_postcode")]
        public string DeliveryPostcode { get; set; }

        [JsonProperty("delivery_city")]
        public string DeliveryCity { get; set; }

        [JsonProperty("registration_date")]
        public string RegistrationDate { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }
    }
}
