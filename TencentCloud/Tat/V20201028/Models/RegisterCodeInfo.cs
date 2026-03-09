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

    public class RegisterCodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Registration code ID.
        /// </summary>
        [JsonProperty("RegisterCodeId")]
        public string RegisterCodeId{ get; set; }

        /// <summary>
        /// Describes the registration code.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Prefix of the registered instance name.
        /// </summary>
        [JsonProperty("InstanceNamePrefix")]
        public string InstanceNamePrefix{ get; set; }

        /// <summary>
        /// The number of instances the registration code allows.
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public long? RegisterLimit{ get; set; }

        /// <summary>
        /// The expiry date of the registration code is in ISO8601 standard representation and uses UTC time. 
        /// The format is YYYY-MM-DDThh:MM:ssZ.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// The registration code limits tat_agent to register only from the public outbound ip described by IpAddressRange.
        /// </summary>
        [JsonProperty("IpAddressRange")]
        public string IpAddressRange{ get; set; }

        /// <summary>
        /// Is the registration code available.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// The number of registered registration codes.
        /// </summary>
        [JsonProperty("RegisteredCount")]
        public long? RegisteredCount{ get; set; }

        /// <summary>
        /// Registration code creation time, represented as ISO8601 standard and using UTC time. 
        /// The format is YYYY-MM-DDThh:MM:ssZ.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Last update time of the registration code, as ISO8601 standard representation and using UTC time. 
        /// The format is YYYY-MM-DDThh:MM:ssZ.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegisterCodeId", this.RegisterCodeId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InstanceNamePrefix", this.InstanceNamePrefix);
            this.SetParamSimple(map, prefix + "RegisterLimit", this.RegisterLimit);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "IpAddressRange", this.IpAddressRange);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RegisteredCount", this.RegisteredCount);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
        }
    }
}

