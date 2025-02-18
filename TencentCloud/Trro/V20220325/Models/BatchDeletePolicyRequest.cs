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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchDeletePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Project id of the deleted permission configuration.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Remote device id list of the deleted permission configuration.
        /// </summary>
        [JsonProperty("RemoteDeviceIds")]
        public string[] RemoteDeviceIds{ get; set; }

        /// <summary>
        /// Permission mode of the deleted permission configuration, black for blocklist, white for allowlist.
        /// </summary>
        [JsonProperty("PolicyMode")]
        public string PolicyMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "RemoteDeviceIds.", this.RemoteDeviceIds);
            this.SetParamSimple(map, prefix + "PolicyMode", this.PolicyMode);
        }
    }
}

