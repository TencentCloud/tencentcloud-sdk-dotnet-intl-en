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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenClusterPasswordComplexityRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Password length
        /// </summary>
        [JsonProperty("ValidatePasswordLength")]
        public long? ValidatePasswordLength{ get; set; }

        /// <summary>
        /// Number of letters
        /// </summary>
        [JsonProperty("ValidatePasswordMixedCaseCount")]
        public long? ValidatePasswordMixedCaseCount{ get; set; }

        /// <summary>
        /// Number of symbols
        /// </summary>
        [JsonProperty("ValidatePasswordSpecialCharCount")]
        public long? ValidatePasswordSpecialCharCount{ get; set; }

        /// <summary>
        /// Number of digits
        /// </summary>
        [JsonProperty("ValidatePasswordNumberCount")]
        public long? ValidatePasswordNumberCount{ get; set; }

        /// <summary>
        /// Password strength. Valid values: `MEDIUM`, `STRONG`.
        /// </summary>
        [JsonProperty("ValidatePasswordPolicy")]
        public string ValidatePasswordPolicy{ get; set; }

        /// <summary>
        /// Data dictionary
        /// </summary>
        [JsonProperty("ValidatePasswordDictionary")]
        public string[] ValidatePasswordDictionary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ValidatePasswordLength", this.ValidatePasswordLength);
            this.SetParamSimple(map, prefix + "ValidatePasswordMixedCaseCount", this.ValidatePasswordMixedCaseCount);
            this.SetParamSimple(map, prefix + "ValidatePasswordSpecialCharCount", this.ValidatePasswordSpecialCharCount);
            this.SetParamSimple(map, prefix + "ValidatePasswordNumberCount", this.ValidatePasswordNumberCount);
            this.SetParamSimple(map, prefix + "ValidatePasswordPolicy", this.ValidatePasswordPolicy);
            this.SetParamArraySimple(map, prefix + "ValidatePasswordDictionary.", this.ValidatePasswordDictionary);
        }
    }
}

