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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppModel : AbstractModel
    {
        
        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Model description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// The round referenced by the context.
        /// </summary>
        [JsonProperty("ContextLimit")]
        public ulong? ContextLimit{ get; set; }

        /// <summary>
        /// Model alias.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Remaining token quota.
        /// </summary>
        [JsonProperty("TokenBalance")]
        public float? TokenBalance{ get; set; }

        /// <summary>
        /// Whether to use the round referenced by the context.
        /// </summary>
        [JsonProperty("IsUseContext")]
        public bool? IsUseContext{ get; set; }

        /// <summary>
        /// The number of context memory rounds.
        /// </summary>
        [JsonProperty("HistoryLimit")]
        public ulong? HistoryLimit{ get; set; }

        /// <summary>
        /// Usage type.
        /// </summary>
        [JsonProperty("UsageType")]
        public string UsageType{ get; set; }

        /// <summary>
        /// Model temperature.
        /// </summary>
        [JsonProperty("Temperature")]
        public string Temperature{ get; set; }

        /// <summary>
        /// Model TopP.
        /// </summary>
        [JsonProperty("TopP")]
        public string TopP{ get; set; }

        /// <summary>
        /// Model resource status: 1: available; 2: exhausted.
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ContextLimit", this.ContextLimit);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "TokenBalance", this.TokenBalance);
            this.SetParamSimple(map, prefix + "IsUseContext", this.IsUseContext);
            this.SetParamSimple(map, prefix + "HistoryLimit", this.HistoryLimit);
            this.SetParamSimple(map, prefix + "UsageType", this.UsageType);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
        }
    }
}

