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

    public class GetPolicyResponse : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy description
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 1: Custom policy; 2: Preset policy
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Time created
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Time of latest update
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Policy document
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PolicyDocument")]
        public string PolicyDocument{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PresetAlias")]
        public string PresetAlias{ get; set; }

        /// <summary>
        /// Whether it is a service-linked policy
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsServiceLinkedRolePolicy")]
        public ulong? IsServiceLinkedRolePolicy{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "PolicyDocument", this.PolicyDocument);
            this.SetParamSimple(map, prefix + "PresetAlias", this.PresetAlias);
            this.SetParamSimple(map, prefix + "IsServiceLinkedRolePolicy", this.IsServiceLinkedRolePolicy);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

