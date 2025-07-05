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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachedPolicyOfRole : AbstractModel
    {
        
        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Time of association
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Policy type. `User` indicates custom policy; `QCS` indicates preset policy
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// Policy creation method. 1: indicates the policy was created based on product function or item permission; other values indicate the policy was created based on the policy syntax
        /// </summary>
        [JsonProperty("CreateMode")]
        public ulong? CreateMode{ get; set; }

        /// <summary>
        /// Whether the product has been deprecated (0: no; 1: yes)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Deactived")]
        public ulong? Deactived{ get; set; }

        /// <summary>
        /// List of deprecated products
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeactivedDetail")]
        public string[] DeactivedDetail{ get; set; }

        /// <summary>
        /// Policy description
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "CreateMode", this.CreateMode);
            this.SetParamSimple(map, prefix + "Deactived", this.Deactived);
            this.SetParamArraySimple(map, prefix + "DeactivedDetail.", this.DeactivedDetail);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

