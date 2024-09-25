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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// Protection domain. If a specific protection domain is to be queried, this parameter should be input. It requires an accurate domain and does not support fuzzy search.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Protection domain ID. If it is to query a specific protection domain, this parameter is input, requiring the accurate domain ID. This parameter does not support fuzzy search.
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// Searching criteria, fuzzy search on domain based on this parameter
        /// </summary>
        [JsonProperty("Search")]
        public string Search{ get; set; }

        /// <summary>
        /// Complex search criteria
        /// </summary>
        [JsonProperty("Item")]
        public SearchItem Item{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Search", this.Search);
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

