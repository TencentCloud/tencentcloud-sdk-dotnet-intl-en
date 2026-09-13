/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Merchant : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the merchant</p>
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// <p>The name of the merchant</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Merchant registration time</p><p>Parameter format: Millisecond-level time with UTC time zone compliant with ISO 8601</p>
        /// </summary>
        [JsonProperty("RegisterTime")]
        public string RegisterTime{ get; set; }

        /// <summary>
        /// <p>Merchant category code</p><p>Parameter format: 4-digit No. compliant with ISO 18245</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>The phone number of the merchant</p><p>parameter format: format with "+", region code, and number that complies with the E.164 standard</p>
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// <p>The email of the merchant</p>
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// <p>The url of the merchant shop on the website</p>
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// <p>The address of the merchant</p>
        /// </summary>
        [JsonProperty("Address")]
        public Address Address{ get; set; }

        /// <summary>
        /// <p>The level of the merchant</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>The type of the merchant</p><p>Enumeration value:</p><ul><li>person: Person</li><li>company: Company</li></ul>
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// <p>The volume of goods on sale of the merchant</p>
        /// </summary>
        [JsonProperty("GoodsQuantity")]
        public long? GoodsQuantity{ get; set; }

        /// <summary>
        /// <p>The historical sales volume of the merchant</p>
        /// </summary>
        [JsonProperty("HistoricSalesQuantity")]
        public long? HistoricSalesQuantity{ get; set; }

        /// <summary>
        /// <p>The historical sales amount of the merchant</p>
        /// </summary>
        [JsonProperty("HistoricSalesAmount")]
        public Amount HistoricSalesAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RegisterTime", this.RegisterTime);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamSimple(map, prefix + "GoodsQuantity", this.GoodsQuantity);
            this.SetParamSimple(map, prefix + "HistoricSalesQuantity", this.HistoricSalesQuantity);
            this.SetParamObj(map, prefix + "HistoricSalesAmount.", this.HistoricSalesAmount);
        }
    }
}

