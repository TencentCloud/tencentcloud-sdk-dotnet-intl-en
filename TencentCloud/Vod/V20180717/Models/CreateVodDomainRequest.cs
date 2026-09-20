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

    public class CreateVodDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain name for on-demand acceleration. Note: Filling in wildcard domains is not supported.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Regions where CDN acceleration needs to be enabled:
        /// <li>Chinese Mainland: within the Chinese mainland (excluding Hong Kong (China), Macao (China), and Taiwan (China)).</li>
        /// <li>Outside Chinese Mainland: outside the Chinese mainland.</li>
        /// <li>Global: around the world.</li>
        /// If AccelerateArea is not set, VOD will automatically activate CDN acceleration within or outside the Chinese mainland based on the regional information set by the user in Tencent Cloud Settings.
        /// </summary>
        [JsonProperty("AccelerateArea")]
        public string AccelerateArea{ get; set; }

        /// <summary>
        /// Domain type. Valid values: <li>VOD: domain name that uses VOD for distribution;</li> <li>EdgeOne: domain name that uses EdgeOne for distribution.</li>Default value: VOD.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AccelerateArea", this.AccelerateArea);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

