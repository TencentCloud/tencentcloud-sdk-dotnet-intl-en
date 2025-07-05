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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExtensionRequest : AbstractModel
    {
        
        /// <summary>
        /// Application id (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Extension.
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// Extension name.
        /// </summary>
        [JsonProperty("ExtensionName")]
        public string ExtensionName{ get; set; }

        /// <summary>
        /// Bound skill group list.
        /// </summary>
        [JsonProperty("SkillGroupIds")]
        public ulong?[] SkillGroupIds{ get; set; }

        /// <summary>
        /// Bound agent email.
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "ExtensionName", this.ExtensionName);
            this.SetParamArraySimple(map, prefix + "SkillGroupIds.", this.SkillGroupIds);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
        }
    }
}

