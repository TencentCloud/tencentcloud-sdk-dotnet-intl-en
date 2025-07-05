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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWarningHostConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm type
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Alarm Host Range Type. 0: All Hosts; 1: By Project; 2: By Tencent Cloud Tag; 3: By Host Security Tag; 4: Custom Hosts
        /// </summary>
        [JsonProperty("HostRange")]
        public long? HostRange{ get; set; }

        /// <summary>
        /// List of Project or Tag Names, empty for custom hosts
        /// </summary>
        [JsonProperty("ItemLabels")]
        public string[] ItemLabels{ get; set; }

        /// <summary>
        /// Machine list
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// List of Project or Tag IDs, empty for custom hosts
        /// </summary>
        [JsonProperty("ItemLabelIds")]
        public string[] ItemLabelIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExcludedQuuids")]
        public string[] ExcludedQuuids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "HostRange", this.HostRange);
            this.SetParamArraySimple(map, prefix + "ItemLabels.", this.ItemLabels);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ItemLabelIds.", this.ItemLabelIds);
            this.SetParamArraySimple(map, prefix + "ExcludedQuuids.", this.ExcludedQuuids);
        }
    }
}

