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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDNUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start date in [ISO date format](https://cloud.tencent.com/document/product/266/11732#I).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date in [ISO date format](https://cloud.tencent.com/document/product/266/11732#I). The end date must be after the start date.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// CDN statistics type. Valid values:
        /// <li>Flux: traffic in bytes.</li>
        /// <li>Bandwidth: bandwidth in bps.</li>
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// Time granularity of usage data in minutes. Valid values:
        /// <li>5: 5-minute granularity, which returns the details at the 5-minute granularity within the specified time range.</li>
        /// <li>60: 1-hour granularity, which returns the details at the 1-hour granularity within the specified time range.</li>
        /// <li>1440: 1-day granularity, which returns the details at the 1-day granularity within the specified time range.</li>
        /// Default value: 1440. Data at the 1-day granularity will be returned.
        /// When the value of this field is 1, the total usage of all subapplications (including primary application) are queried by an admin.
        /// </summary>
        [JsonProperty("DataInterval")]
        public ulong? DataInterval{ get; set; }

        /// <summary>
        /// List of domain names. The usage data of up to 20 domain names can be queried at a time. You can specify multiple domain names and query their combined usage data. The usage data of all domain names will be returned by default.
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// ID of a [subapplication](/document/product/266/14574) in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// When the value of this field is 1, the total usage of all subapplications (including primary application) are queried by an admin. In this case, only 1-day granularity is supported.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "DataInterval", this.DataInterval);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

