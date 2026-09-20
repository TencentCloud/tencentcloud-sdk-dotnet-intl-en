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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Company : AbstractModel
    {
        
        /// <summary>
        /// <p>Enterprise name (required)</p>
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// <p>Enterprise registration number / unified social credit code (Option)</p>
        /// </summary>
        [JsonProperty("CompanyCertNumber")]
        public string CompanyCertNumber{ get; set; }

        /// <summary>
        /// <p>Enterprise registration country, ISO 3166-1 alpha-2 country code (optional)</p>
        /// </summary>
        [JsonProperty("CompanyCountry")]
        public string CompanyCountry{ get; set; }

        /// <summary>
        /// <p>Company address (optional)</p>
        /// </summary>
        [JsonProperty("CompanyAddress")]
        public string CompanyAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyCertNumber", this.CompanyCertNumber);
            this.SetParamSimple(map, prefix + "CompanyCountry", this.CompanyCountry);
            this.SetParamSimple(map, prefix + "CompanyAddress", this.CompanyAddress);
        }
    }
}

