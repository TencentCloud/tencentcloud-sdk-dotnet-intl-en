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
        /// Group ID. Enter `0`.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// IP group content, supports ip and ip range.
        /// </summary>
        [JsonProperty("Content")]
        public string[] Content{ get; set; }

        /// <summary>
        /// Number of ips or ranges in effect in the IP group. valid as an output parameter, no need to specify this field as an input parameter.
        /// </summary>
        [JsonProperty("IPTotalCount")]
        public long? IPTotalCount{ get; set; }

        /// <summary>
        /// Specifies the scheduled expiration information of the IP.
        /// Specifies the IP address or IP range configuration with scheduled expiration time as an input parameter.
        /// As an output parameter, contains the following two categories of information.
        /// <Li>Currently not expired scheduled expiration information: expiration configuration not triggered.</li>.
        /// <Li>Scheduled expiration information expired within a week: cache expiration configuration has been triggered.</li>.
        /// </summary>
        [JsonProperty("IPExpireInfo")]
        public IPExpireInfo[] IPExpireInfo{ get; set; }


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
        }
    }
}

