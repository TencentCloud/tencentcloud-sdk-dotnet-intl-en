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

    public class DescribeDailyMostPlayedStatRequest : AbstractModel
    {
        
        /// <summary>
        /// Query date, in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I). This parameter is only valid for the date part.
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Domain name. Query playback stats of the Top 100 media files for that domain name. Query playback stats of all domain names by default.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Statistical metrics for Top data. Valid values:
        /// <li>Traffic: playback traffic. The data of Top 100 is collected by playback traffic.</li>
        /// <li>PlayTimes: number of plays, the data of the Top 100 by playback count.</li>
        /// Default value: Traffic.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// <b>ID of the on-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1). For customers who activate on-demand services after December 25, 2023, this field must be filled with the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

