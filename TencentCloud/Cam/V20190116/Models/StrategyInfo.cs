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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyInfo : AbstractModel
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
        /// Time policy created
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Policy type. 1: Custom policy; 2: Preset policy
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Policy description
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// How the policy was created: 1: Via console; 2: Via syntax
        /// </summary>
        [JsonProperty("CreateMode")]
        public ulong? CreateMode{ get; set; }

        /// <summary>
        /// Number of associated users
        /// </summary>
        [JsonProperty("Attachments")]
        public ulong? Attachments{ get; set; }

        /// <summary>
        /// Product associated with the policy
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// This value should not be null when querying whether a marked entity has been associated with a policy. 0 indicates that no policy has been associated, while 1 indicates that a policy has been associated
        /// </summary>
        [JsonProperty("IsAttached")]
        public ulong? IsAttached{ get; set; }

        /// <summary>
        /// Queries if the policy has been deactivated
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
        /// The deletion task identifier used to check the deletion status of the service-linked role
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsServiceLinkedPolicy")]
        public ulong? IsServiceLinkedPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateMode", this.CreateMode);
            this.SetParamSimple(map, prefix + "Attachments", this.Attachments);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "IsAttached", this.IsAttached);
            this.SetParamSimple(map, prefix + "Deactived", this.Deactived);
            this.SetParamArraySimple(map, prefix + "DeactivedDetail.", this.DeactivedDetail);
            this.SetParamSimple(map, prefix + "IsServiceLinkedPolicy", this.IsServiceLinkedPolicy);
        }
    }
}

