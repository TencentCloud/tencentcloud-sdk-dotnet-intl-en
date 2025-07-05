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

    public class ExtensionInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance id.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Extension full name.
        /// </summary>
        [JsonProperty("FullExtensionId")]
        public string FullExtensionId{ get; set; }

        /// <summary>
        /// Extension.
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// Affiliated skill group list.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public string SkillGroupId{ get; set; }

        /// <summary>
        /// Extension name.
        /// </summary>
        [JsonProperty("ExtensionName")]
        public string ExtensionName{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Last modification time.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public long? ModifyTime{ get; set; }

        /// <summary>
        /// Telephone status (0 offline, 100 free, 200 busy).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Whether to register.
        /// </summary>
        [JsonProperty("Register")]
        public bool? Register{ get; set; }

        /// <summary>
        /// Bind agent email.
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }

        /// <summary>
        /// Bind agent name.
        /// </summary>
        [JsonProperty("RelationName")]
        public string RelationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "FullExtensionId", this.FullExtensionId);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "ExtensionName", this.ExtensionName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Register", this.Register);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
            this.SetParamSimple(map, prefix + "RelationName", this.RelationName);
        }
    }
}

