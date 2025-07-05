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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Project id for modifying permission configuration.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Remote device id for modifying permission configuration.
        /// </summary>
        [JsonProperty("RemoteDeviceId")]
        public string RemoteDeviceId{ get; set; }

        /// <summary>
        /// Array of on-site device ids involved in permission modification.
        /// </summary>
        [JsonProperty("FieldDeviceIds")]
        public string[] FieldDeviceIds{ get; set; }

        /// <summary>
        /// The target permission mode to modify, black for blocklist, white for allowlist.
        /// </summary>
        [JsonProperty("PolicyMode")]
        public string PolicyMode{ get; set; }

        /// <summary>
        /// Modification mode, add for adding (associating on-site devices), remove for deletion (dissociating on-site devices), set for setting (updating on-site device association).
        /// </summary>
        [JsonProperty("ModifyMode")]
        public string ModifyMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RemoteDeviceId", this.RemoteDeviceId);
            this.SetParamArraySimple(map, prefix + "FieldDeviceIds.", this.FieldDeviceIds);
            this.SetParamSimple(map, prefix + "PolicyMode", this.PolicyMode);
            this.SetParamSimple(map, prefix + "ModifyMode", this.ModifyMode);
        }
    }
}

