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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeListBGPInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Starting offset of the page. Value: (number of pages – 1) * items per page.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of items per page. The default value is 20 when `Limit = 0`. The maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filters by IP.
        /// </summary>
        [JsonProperty("FilterIp")]
        public string FilterIp{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID filter. For example, `bgp-00000001`.
        /// </summary>
        [JsonProperty("FilterInstanceId")]
        public string FilterInstanceId{ get; set; }

        /// <summary>
        /// Filters by region. For example, `ap-guangzhou`.
        /// </summary>
        [JsonProperty("FilterRegion")]
        public string FilterRegion{ get; set; }

        /// <summary>
        /// Filters by name.
        /// </summary>
        [JsonProperty("FilterName")]
        public string FilterName{ get; set; }

        /// <summary>
        /// Line filter. Valid values: 1: BGP; 2: Non-BGP.
        /// </summary>
        [JsonProperty("FilterLine")]
        public ulong? FilterLine{ get; set; }

        /// <summary>
        /// Filters by instance status. `idle`: Running; `attacking`: Being attacked; `blocking`: Being blocked.
        /// </summary>
        [JsonProperty("FilterStatus")]
        public string FilterStatus{ get; set; }

        /// <summary>
        /// Filters by binding status. `bounding`: The instance is bound; `failed`: The binding failed.
        /// </summary>
        [JsonProperty("FilterBoundStatus")]
        public string FilterBoundStatus{ get; set; }

        /// <summary>
        /// Array of instance IDs
        /// </summary>
        [JsonProperty("FilterInstanceIdList")]
        public string[] FilterInstanceIdList{ get; set; }

        /// <summary>
        /// Filters by Enterprise edition
        /// </summary>
        [JsonProperty("FilterEnterpriseFlag")]
        public ulong? FilterEnterpriseFlag{ get; set; }

        /// <summary>
        /// Whether it’s a Lighthouse edition
        /// </summary>
        [JsonProperty("FilterLightFlag")]
        public ulong? FilterLightFlag{ get; set; }

        /// <summary>
        /// Whether it’s a Channel edition
        /// </summary>
        [JsonProperty("FilterChannelFlag")]
        public ulong? FilterChannelFlag{ get; set; }

        /// <summary>
        /// Filters by tag
        /// </summary>
        [JsonProperty("FilterTag")]
        public TagFilter FilterTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterIp", this.FilterIp);
            this.SetParamSimple(map, prefix + "FilterInstanceId", this.FilterInstanceId);
            this.SetParamSimple(map, prefix + "FilterRegion", this.FilterRegion);
            this.SetParamSimple(map, prefix + "FilterName", this.FilterName);
            this.SetParamSimple(map, prefix + "FilterLine", this.FilterLine);
            this.SetParamSimple(map, prefix + "FilterStatus", this.FilterStatus);
            this.SetParamSimple(map, prefix + "FilterBoundStatus", this.FilterBoundStatus);
            this.SetParamArraySimple(map, prefix + "FilterInstanceIdList.", this.FilterInstanceIdList);
            this.SetParamSimple(map, prefix + "FilterEnterpriseFlag", this.FilterEnterpriseFlag);
            this.SetParamSimple(map, prefix + "FilterLightFlag", this.FilterLightFlag);
            this.SetParamSimple(map, prefix + "FilterChannelFlag", this.FilterChannelFlag);
            this.SetParamObj(map, prefix + "FilterTag.", this.FilterTag);
        }
    }
}

