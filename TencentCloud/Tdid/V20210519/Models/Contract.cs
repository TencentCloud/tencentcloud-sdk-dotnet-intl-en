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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Contract : AbstractModel
    {
        
        /// <summary>
        /// The application name.
        /// </summary>
        [JsonProperty("ApplyName")]
        public string ApplyName{ get; set; }

        /// <summary>
        /// The contract status. `true`: Enabled; `false`: Not enabled.
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// The CNS address of the contract.
        /// </summary>
        [JsonProperty("Hash")]
        public string Hash{ get; set; }

        /// <summary>
        /// The desensitized CNS address.
        /// </summary>
        [JsonProperty("HashShow")]
        public string HashShow{ get; set; }

        /// <summary>
        /// The DID of the organization that deployed the contract.
        /// </summary>
        [JsonProperty("WeId")]
        public string WeId{ get; set; }

        /// <summary>
        /// The name of the organization that deployed the contract.
        /// </summary>
        [JsonProperty("DeployName")]
        public string DeployName{ get; set; }

        /// <summary>
        /// The group.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// The deployment time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyName", this.ApplyName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Hash", this.Hash);
            this.SetParamSimple(map, prefix + "HashShow", this.HashShow);
            this.SetParamSimple(map, prefix + "WeId", this.WeId);
            this.SetParamSimple(map, prefix + "DeployName", this.DeployName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

