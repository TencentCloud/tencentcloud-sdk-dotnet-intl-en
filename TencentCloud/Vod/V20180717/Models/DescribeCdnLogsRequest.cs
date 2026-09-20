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

    public class DescribeCdnLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p>Get log start time point, use <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p><p>Parameter format: YYYY-MM-DDThh:MM:ssZ</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time must be greater than start time; use the <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p><p>Parameter format: YYYY-MM-DDThh:mm:ssZ.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services from December 25, 2023, when accessing resources in on-demand applications (whether the default application or a newly created application), this field must be filled in as the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Maximum number of results returned for pagination pull. Default value: 100; maximum value: 1000.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Starting offset for pagination pull. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

