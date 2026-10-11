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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Audit : AbstractModel
    {
        
        /// <summary>
        /// Creator. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Creation Timestamp
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Last modifier. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastModifier")]
        public string LastModifier{ get; set; }

        /// <summary>
        /// Last modification timestamp
        /// </summary>
        [JsonProperty("LastModifiedAt")]
        public string LastModifiedAt{ get; set; }

        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty("CreatorName")]
        public string CreatorName{ get; set; }

        /// <summary>
        /// Name of the last modifier
        /// </summary>
        [JsonProperty("LastModifierName")]
        public string LastModifierName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "LastModifier", this.LastModifier);
            this.SetParamSimple(map, prefix + "LastModifiedAt", this.LastModifiedAt);
            this.SetParamSimple(map, prefix + "CreatorName", this.CreatorName);
            this.SetParamSimple(map, prefix + "LastModifierName", this.LastModifierName);
        }
    }
}

