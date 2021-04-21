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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceListRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgp`: Anti-DDoS Pro (single IP), `bgp-multip`: Anti-DDoS Pro (multi-IP), `bgpip`: Anti-DDoS Advanced, `net`: Anti-DDoS Ultimate)
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Region code search, which is optional. If no regions are to be specified, enter an empty array. If a region is to be specified, enter a region code, such as ["gz", "sh"]
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// Line search. This field can be optionally entered only when getting the list of Anti-DDoS Advanced resources. Valid values: [1 (BGP line), 2 (Nanjing Telecom), 3 (Nanjing Unicom), 99 (third-party partner line)]. Please enter an empty array when getting other products;
        /// </summary>
        [JsonProperty("Line")]
        public ulong?[] Line{ get; set; }

        /// <summary>
        /// Resource ID search, which is optional. If this field is not an empty array, it means to get the resource list of a specified resource;
        /// </summary>
        [JsonProperty("IdList")]
        public string[] IdList{ get; set; }

        /// <summary>
        /// Resource name search, which is optional. If this field is not an empty string, it means to search for resources by name;
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// IP query list, which is optional. Resources will be queried by IP if the list is not empty.
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// Resource status search list, which is optional. Valid values: [0 (running), 1 (cleansing), 2 (blocking)]. No status search will be performed if an empty array is entered;
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }

        /// <summary>
        /// Expiring resource search, which is optional. Valid values: [0 (no search), 1 (search for expiring resources)]
        /// </summary>
        [JsonProperty("Expire")]
        public ulong? Expire{ get; set; }

        /// <summary>
        /// Sort by field, which is optional
        /// </summary>
        [JsonProperty("OderBy")]
        public OrderBy[] OderBy{ get; set; }

        /// <summary>
        /// Number of entries per page. A value of 0 means no pagination
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Page start offset, whose value is (page number - 1) * number of entries per page
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// CNAME of Anti-DDoS Ultimate resource, which is optional and only valid for the Anti-DDoS Ultimate resource list;
        /// </summary>
        [JsonProperty("CName")]
        public string CName{ get; set; }

        /// <summary>
        /// Domain name of Anti-DDoS Ultimate resource, which is optional and only valid for the Anti-DDoS Ultimate resource list;
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArraySimple(map, prefix + "Line.", this.Line);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamArrayObj(map, prefix + "OderBy.", this.OderBy);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "CName", this.CName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

