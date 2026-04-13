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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SharedCNAMEInfo : AbstractModel
    {
        
        /// <summary>
        /// Shared CNAME type: Value ranges from...to...
        /// <li>custom: User-created custom shared CNAME</li>
        /// <li>ip-ssl: Shared CNAME of IP SSL type</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Shared CNAME name.
        /// </summary>
        [JsonProperty("SharedCNAME")]
        public string SharedCNAME{ get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// When type is ip-ssl, show the associated IP SSL configuration message of the shared CNAME.
        /// </summary>
        [JsonProperty("IPSSLConfig")]
        public IPSSLConfig IPSSLConfig{ get; set; }

        /// <summary>
        /// Number of acceleration domain names bound to the shared CNAME.
        /// </summary>
        [JsonProperty("BindDomainCount")]
        public long? BindDomainCount{ get; set; }

        /// <summary>
        /// List of acceleration domain names added to the shared CNAME. When the number of domains exceeds 100, only return the first 100 acceleration domain names.
        /// </summary>
        [JsonProperty("AccelerationDomains")]
        public ReferenceHolder[] AccelerationDomains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SharedCNAME", this.SharedCNAME);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "IPSSLConfig.", this.IPSSLConfig);
            this.SetParamSimple(map, prefix + "BindDomainCount", this.BindDomainCount);
            this.SetParamArrayObj(map, prefix + "AccelerationDomains.", this.AccelerationDomains);
        }
    }
}

