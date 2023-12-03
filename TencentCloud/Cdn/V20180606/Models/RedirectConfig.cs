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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RedirectConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the custom origin-pull request to follow the host when a 302 code is returned. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The custom host header that is sent when the primary origin server follows 302 redirects
        /// </summary>
        [JsonProperty("FollowRedirectHost")]
        public string FollowRedirectHost{ get; set; }

        /// <summary>
        /// The custom host header that is sent when the secondary origin server follows 302 redirects
        /// </summary>
        [JsonProperty("FollowRedirectBackupHost")]
        public string FollowRedirectBackupHost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "FollowRedirectHost", this.FollowRedirectHost);
            this.SetParamSimple(map, prefix + "FollowRedirectBackupHost", this.FollowRedirectBackupHost);
        }
    }
}

