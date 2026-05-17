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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompanyInfo : AbstractModel
    {
        
        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// company ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// Country of residence
        /// </summary>
        [JsonProperty("CompanyCountry")]
        public string CompanyCountry{ get; set; }

        /// <summary>
        /// Company province
        /// </summary>
        [JsonProperty("CompanyProvince")]
        public string CompanyProvince{ get; set; }

        /// <summary>
        /// Company located city
        /// </summary>
        [JsonProperty("CompanyCity")]
        public string CompanyCity{ get; set; }

        /// <summary>
        /// Company's detailed address
        /// </summary>
        [JsonProperty("CompanyAddress")]
        public string CompanyAddress{ get; set; }

        /// <summary>
        /// company phone number
        /// </summary>
        [JsonProperty("CompanyPhone")]
        public string CompanyPhone{ get; set; }

        /// <summary>
        /// Company document type. Valid values:
        /// TYDMZ (unified social credit code): This field is required only for CFCA certs and not required for other types.
        /// OTHERS
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// Company identification number, value ranges from...to...
        /// TYDMZ (unified social credit code): 11532xxxxxxxx24820
        /// </summary>
        [JsonProperty("IdNumber")]
        public string IdNumber{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "CompanyCountry", this.CompanyCountry);
            this.SetParamSimple(map, prefix + "CompanyProvince", this.CompanyProvince);
            this.SetParamSimple(map, prefix + "CompanyCity", this.CompanyCity);
            this.SetParamSimple(map, prefix + "CompanyAddress", this.CompanyAddress);
            this.SetParamSimple(map, prefix + "CompanyPhone", this.CompanyPhone);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "IdNumber", this.IdNumber);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

