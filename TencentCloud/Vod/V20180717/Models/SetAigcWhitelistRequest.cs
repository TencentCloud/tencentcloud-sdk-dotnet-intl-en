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

    public class SetAigcWhitelistRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>VOD <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate VOD after December 25, 2023, this field must be set to the application ID when accessing resources in a VOD application (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>AIGC task type</p><p>Valid values:</p><ul><li>Image: AIGC image generation task</li><li>Video: AIGC video generation task</li></ul>
        /// </summary>
        [JsonProperty("AigcType")]
        public string AigcType{ get; set; }

        /// <summary>
        /// <p>Model allowlist switch</p><p>Valid values:</p><ul><li>ON: Enabled. Only models listed in ModelWhitelist can be called.</li><li>OFF: Disabled. All models can be called.</li></ul>
        /// </summary>
        [JsonProperty("ModelWhitelistSwitch")]
        public string ModelWhitelistSwitch{ get; set; }

        /// <summary>
        /// <p>IP allowlist switch</p><p>Valid values:</p><ul><li>ON: Enabled. Only IP ranges listed in IpWhitelist are allowed to call.</li><li>OFF: Disabled. All IPs are allowed to call.</li></ul>
        /// </summary>
        [JsonProperty("IpWhitelistSwitch")]
        public string IpWhitelistSwitch{ get; set; }

        /// <summary>
        /// <p>Model allowlist</p>
        /// </summary>
        [JsonProperty("ModelWhitelist")]
        public AigcWhitelistModel[] ModelWhitelist{ get; set; }

        /// <summary>
        /// <p>CIDR list of the IP allowlist</p>
        /// </summary>
        [JsonProperty("IpWhitelist")]
        public string[] IpWhitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AigcType", this.AigcType);
            this.SetParamSimple(map, prefix + "ModelWhitelistSwitch", this.ModelWhitelistSwitch);
            this.SetParamSimple(map, prefix + "IpWhitelistSwitch", this.IpWhitelistSwitch);
            this.SetParamArrayObj(map, prefix + "ModelWhitelist.", this.ModelWhitelist);
            this.SetParamArraySimple(map, prefix + "IpWhitelist.", this.IpWhitelist);
        }
    }
}

