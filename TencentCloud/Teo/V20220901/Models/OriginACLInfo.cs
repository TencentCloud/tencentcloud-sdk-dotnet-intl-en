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

    public class OriginACLInfo : AbstractModel
    {
        
        /// <summary>
        /// The list of L7 accelerated domains that enable the origin ACLs. This field is empty when origin protection is not enabled.
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// The list of L4 proxy instances that enable the origin ACLs. This field is empty when origin protection is not enabled.
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// Currently effective origin ACLs. This field is empty when origin protection is not enabled.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CurrentOriginACL")]
        public CurrentOriginACL CurrentOriginACL{ get; set; }

        /// <summary>
        /// When the origin ACLs are updated, this field will be returned with the next version's origin IP range to take effect, including a comparison with the current origin IP range. This field is empty if not updated or origin protection is not enabled.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("NextOriginACL")]
        public NextOriginACL NextOriginACL{ get; set; }

        /// <summary>
        /// Origin protection status. Vaild values:
        /// - online: in effect;
        /// - offline: disabled;
        /// - updating: configuration deployment in progress.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamObj(map, prefix + "CurrentOriginACL.", this.CurrentOriginACL);
            this.SetParamObj(map, prefix + "NextOriginACL.", this.NextOriginACL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

