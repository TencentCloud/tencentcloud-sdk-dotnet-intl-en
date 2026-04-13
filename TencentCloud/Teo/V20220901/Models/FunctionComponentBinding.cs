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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FunctionComponentBinding : AbstractModel
    {
        
        /// <summary>
        /// Bound component type. Valid values:
        /// <li>kv_namespace: KV namespace.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Variable name for binding. Limited to 1-50 characters. Allowed characters are letters, digits, and underscores. Digits cannot be at the beginning. Access the bound component via this variable name in the edge function code. Based on the Type value, the usage is as follows:
        /// <li>When Type is kv_namespace: In code, you can access the KV namespace through the variable name, for example, when setting it to "MY_KV", you can perform read-write operations via MY_KV.get("key").</li>
        /// </summary>
        [JsonProperty("VariableName")]
        public string VariableName{ get; set; }

        /// <summary>
        /// KV namespace configuration parameter. Used for designated binding namespace details. Required when Type is kv_namespace.
        /// 
        /// 
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("KVNamespaceParameters")]
        public KVNamespaceParameters KVNamespaceParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "VariableName", this.VariableName);
            this.SetParamObj(map, prefix + "KVNamespaceParameters.", this.KVNamespaceParameters);
        }
    }
}

