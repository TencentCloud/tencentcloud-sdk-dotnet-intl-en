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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeletionProtectionConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable deletion protection. Once enabled, instances can be prevented from being deleted accidentally.
        /// - true: enable deletion protection
        /// - false: disable deletion protection
        /// </summary>
        [JsonProperty("DeletionProtectionEnabled")]
        public bool? DeletionProtectionEnabled{ get; set; }

        /// <summary>
        /// Reason explanation for enabling modification protection.
        /// Length: 1 to 255 characters. It must contain Chinese and characters from harmless strings. It can contain Chinese, letters, digits, hyphens (-), forward slashes (/), half-width periods (.), and underscores (_).
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeletionProtectionEnabled", this.DeletionProtectionEnabled);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

