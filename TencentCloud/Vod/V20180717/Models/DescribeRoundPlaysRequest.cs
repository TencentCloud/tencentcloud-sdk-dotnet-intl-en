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

    public class DescribeRoundPlaysRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>On-demand <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Filter criteria: carousel playlist identifier. The array can contain up to 100 identifiers.</p>
        /// </summary>
        [JsonProperty("RoundPlayIds")]
        public string[] RoundPlayIds{ get; set; }

        /// <summary>
        /// <p>Filter criteria. Carousel playlist status. Available values: <li>Enabled: Running state;</li> <li>Disabled: Stopped status.</li></p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Filter criteria: Carousel Playlist Creation Time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// <p>Filter criteria: carousel playlist update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public TimeRange UpdateTime{ get; set; }

        /// <summary>
        /// <p>Scrolling identifier which is used for pulling in batches. If a single request cannot pull all the data entries, the API will return `ScrollToken`, and if the next request carries it, the next pull will start from the next entry.</p>
        /// </summary>
        [JsonProperty("ScrollToken")]
        public string ScrollToken{ get; set; }

        /// <summary>
        /// <p>Paging offset. Default value: 0. Deprecated. Perform batch query according to the ScrollToken parameter.</p>
        /// </summary>
        [JsonProperty("Offset")]
        [System.Obsolete]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of returned entries. Default value: 10. Maximum value: 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "RoundPlayIds.", this.RoundPlayIds);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamObj(map, prefix + "UpdateTime.", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ScrollToken", this.ScrollToken);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

