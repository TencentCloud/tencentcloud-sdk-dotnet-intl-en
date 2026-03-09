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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRegisterCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// Describes the registration code. maximum length is 128 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Prefix of the registered instance name. maximum length is 32 characters.
        /// </summary>
        [JsonProperty("InstanceNamePrefix")]
        public string InstanceNamePrefix{ get; set; }

        /// <summary>
        /// Number of instances allowed by the registration code. default value is 10, minimum value is 1, maximum value is 10000.
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public long? RegisterLimit{ get; set; }

        /// <summary>
        /// The validity time of the registration code is measured in hours. default value is 4.
        /// 
        /// -If the input value is less than or equal to 99999, the time is deemed valid in hours.
        /// -If the input value is more than 99999, it is set to permanently valid.
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public long? EffectiveTime{ get; set; }

        /// <summary>
        /// Restrict the registration code to register only from the public outbound ip described by IpAddressRange.
        /// 
        /// Empty by default, meaning no restrictions.
        /// 
        /// The value should be in standard IPv4 or CIDRv4 format, such as 192.168.1.1 or 192.168.0.0/16.
        /// </summary>
        [JsonProperty("IpAddressRange")]
        public string IpAddressRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InstanceNamePrefix", this.InstanceNamePrefix);
            this.SetParamSimple(map, prefix + "RegisterLimit", this.RegisterLimit);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "IpAddressRange", this.IpAddressRange);
        }
    }
}

