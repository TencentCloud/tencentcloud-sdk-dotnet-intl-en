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

    public class ModifyVodDomainAccelerateConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Domains requiring acceleration configuration.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Region. Available values:</p><li>Chinese Mainland: within the Chinese mainland (excluding Hong Kong (China), Macao (China), and Taiwan (China)).</li><li>Outside Chinese Mainland: outside the Chinese mainland.</li><li>Global: global.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Enable or disable domain name acceleration for the selected region. Available values:</p><li>Enabled: Turn on.</li><li>Disabled: Turn off.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

