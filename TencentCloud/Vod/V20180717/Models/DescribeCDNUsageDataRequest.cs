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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDNUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start date. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date, which must be greater than the start date. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// CDN statistics data type. Valid value:
        /// <li>Flux: Traffic volume, unit: byte.</li>
        /// <li>Bandwidth: bandwidth, in bps.</li>
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Time granularity of usage data, unit: minute. Valid values:
        /// <li>5: 5 minutes, return detailed data at a minute granularity for the specified query time.</li>
        /// <li>60: Hourly granularity. Returns the data of 1-hour granularity within the specified query time.</li>
        /// <li>1440: Day granularity. Returns data with day granularity within the specified query time.</li>
        /// The default value is 1440, which returns data with day granularity.
        /// </summary>
        [JsonProperty("DataInterval")]
        public ulong? DataInterval{ get; set; }

        /// <summary>
        /// Domain name list. Up to 20 domain names can be queried for usage data. Multiple values can be specified to query the superimposed usage data of these domains. Default returns the overlaid usage data of all domains.
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "DataInterval", this.DataInterval);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
        }
    }
}

