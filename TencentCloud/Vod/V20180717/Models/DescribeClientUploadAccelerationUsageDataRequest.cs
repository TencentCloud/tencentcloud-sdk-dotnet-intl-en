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

    public class DescribeClientUploadAccelerationUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start date. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date, which should be greater than or equal to the start date. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether in the default application or a newly created application.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Client upload acceleration type. Valid values:
        /// <li> AccelerationWithHTTP: Upload acceleration over HTTP transmission method.</li>
        /// <li> AccelerationWithQUIC: upload acceleration over QUIC transmission mode.</li>
        /// Default query for the amount of all acceleration types.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

