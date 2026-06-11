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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Relabeling : AbstractModel
    {
        
        /// <summary>
        /// Action executed based on regular expression matching.
        /// -replace: Label replacement, required: SourceLabels, Separator, Regex, TargetLabel, Replacement
        /// -labeldrop: Discard Label, Required: Regex
        /// -labelkeep: Reserve Label, required: Regex
        /// -lowercase, required: SourceLabels, Separator, TargetLabel
        /// -Uppercase: uppercase, Required: SourceLabels, Separator, TargetLabel
        /// -dropequal: Drop metric - exact match, required: SourceLabels, Separator, TargetLabel
        /// -keepequal: retain metric - exact match, required: SourceLabels, Separator, TargetLabel
        /// -drop: Drop metric - Regular expression matching. Required: SourceLabels, Separator, Regex.
        /// -keep: Retain metric - Regular expression matching, Required: SourceLabels, Separator, Regex
        /// -hashmod: hash modulo, required: SourceLabels, Separator, TargetLabel, Modulus
        /// -labelmap: Label map, required: Regex, Replacement
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// original label
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceLabels")]
        public string[] SourceLabels{ get; set; }

        /// <summary>
        /// Original label delimiter. This parameter cannot be an empty string when it is required. Its length cannot exceed 256 characters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Separator")]
        public string Separator{ get; set; }

        /// <summary>
        /// Target label. This parameter cannot be an empty string when it is required. The verification format is ^[a-zA-Z_][a-zA-Z0-9_]*$, and its length cannot exceed 256 characters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetLabel")]
        public string TargetLabel{ get; set; }

        /// <summary>
        /// Replacement value. If regular expression matching is performed, execute the replacement operation.
        /// -Cannot be an empty string when required. Length cannot exceed 256.
        /// -When the action is LabelMap, check format for Replacement: `^(?:(?:[a-zA-Z_]|\$(?:\{\w+\}|\w+))+\w*)+$`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Replacement")]
        public string Replacement{ get; set; }

        /// <summary>
        /// Regular expression. The matching value is extracted. This parameter cannot be an empty string when it is required. The regular expression should be a valid RE2. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Regex")]
        public string Regex{ get; set; }

        /// <summary>
        /// Obtains the hash value of a label value. This parameter cannot be empty or 0 when it is required.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Modulus")]
        public ulong? Modulus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArraySimple(map, prefix + "SourceLabels.", this.SourceLabels);
            this.SetParamSimple(map, prefix + "Separator", this.Separator);
            this.SetParamSimple(map, prefix + "TargetLabel", this.TargetLabel);
            this.SetParamSimple(map, prefix + "Replacement", this.Replacement);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Modulus", this.Modulus);
        }
    }
}

