/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubdomainAnalyticsRequest : AbstractModel
    {
        
        /// <summary>
        /// The domain of the DNS query volume to be queried
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Query start date in the format of `YYYY-MM-DD`
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// Query end date in the format of `YYYY-MM-DD`
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// The subdomain of the DNS query volume to be queried
        /// </summary>
        [JsonProperty("Subdomain")]
        public string Subdomain{ get; set; }

        /// <summary>
        /// `DATE`: Daily. `HOUR`: Hourly
        /// </summary>
        [JsonProperty("DnsFormat")]
        public string DnsFormat{ get; set; }

        /// <summary>
        /// The domain ID. `DomainId` takes priority over `Domain`. If `DomainId` is passed in, `Domain` is ignored. You can view all `Domain` and `DomainId` values via the `DescribeDomainList` API.
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "Subdomain", this.Subdomain);
            this.SetParamSimple(map, prefix + "DnsFormat", this.DnsFormat);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
        }
    }
}

