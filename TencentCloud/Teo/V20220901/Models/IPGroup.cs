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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>IP group Id. Enter 0 upon creation.</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>IP group name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>IP group content. Only IP and IP range are supported.</p>
        /// </summary>
        [JsonProperty("Content")]
        public string[] Content{ get; set; }

        /// <summary>
        /// <p>Number of IPs or IP ranges currently effective in the IP group. Valid as an output parameter. As an input parameter, no need to specify this field.</p>
        /// </summary>
        [JsonProperty("IPTotalCount")]
        public long? IPTotalCount{ get; set; }

        /// <summary>
        /// <p>IP scheduled expiration info.<br>As an input parameter, it is used to specify a scheduled expiration time for an IP address or IP range.<br>As an output parameter, it includes the following two categories of info:</p><li>Current scheduled expiration info that has not expired: expiration configuration that has not been triggered.</li><li>Scheduled expiration info that has expired within a week: expiration configuration that has been triggered.</li>
        /// </summary>
        [JsonProperty("IPExpireInfo")]
        public IPExpireInfo[] IPExpireInfo{ get; set; }

        /// <summary>
        /// <p>The number of times the IP group is referenced.</p>
        /// </summary>
        [JsonProperty("RefCount")]
        public long? RefCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "IPTotalCount", this.IPTotalCount);
            this.SetParamArrayObj(map, prefix + "IPExpireInfo.", this.IPExpireInfo);
            this.SetParamSimple(map, prefix + "RefCount", this.RefCount);
        }
    }
}

