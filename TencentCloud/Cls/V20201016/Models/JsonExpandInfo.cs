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

    public class JsonExpandInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to enable the JSON nested unfold functionality. Once enabled, it will flatten and process the specified JSON field.</p><p>Default value: None (Required parameter)</p>
        /// </summary>
        [JsonProperty("Switch")]
        public bool? Switch{ get; set; }

        /// <summary>
        /// <p>List of JSON field names to be unfolded, supporting 1 to 3 fields. Field names cannot be empty strings and cannot be repeated.</p><p>Input parameter limits: 1. Number of fields: 1 to 3. 2. Length of each field name not exceeding 128 characters. 3. Field names cannot be empty strings. 4. Field names cannot be repeated.</p><p>Default value: None (required parameter)</p><p>Value for reference: Value: message; Description: Example field name</p><p>Example: ["message", "data", "content"]</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>Whether to discard the original nested field after unfolding. true: discard the original field and keep only the flattened field after unfolding; false: keep the original field and add the flattened field after unfolding.</p><p>Enumeration value:</p><ul><li>true / false: discard the original field / keep the original field</li></ul><p>Default value: true</p><p>Optional. Default is true if not provided.</p>
        /// </summary>
        [JsonProperty("DropOriginal")]
        public bool? DropOriginal{ get; set; }

        /// <summary>
        /// <p>Processing policy when the unfolded field conflicts with an existing field</p><p>Enumeration value:</p><ul><li>keep_outer / keep_inner: Keep the outer (existing) field / Keep the inner (newly unfolded) field</li></ul><p>Default value: keep_outer</p><p>Optional. Defaults to keep_outer if not passed.</p>
        /// </summary>
        [JsonProperty("ConflictPolicy")]
        public string ConflictPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "DropOriginal", this.DropOriginal);
            this.SetParamSimple(map, prefix + "ConflictPolicy", this.ConflictPolicy);
        }
    }
}

