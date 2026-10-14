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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Trigger : AbstractModel
    {
        
        /// <summary>
        /// Last modification time of the trigger
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// Trigger type
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Trigger detailed configuration
        /// </summary>
        [JsonProperty("TriggerDesc")]
        public string TriggerDesc{ get; set; }

        /// <summary>
        /// Trigger name.
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// Trigger creation time
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Enable switch
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Customer custom parameter
        /// </summary>
        [JsonProperty("CustomArgument")]
        public string CustomArgument{ get; set; }

        /// <summary>
        /// Trigger status
        /// </summary>
        [JsonProperty("AvailableStatus")]
        public string AvailableStatus{ get; set; }

        /// <summary>
        /// Minimum resource ID of the trigger
        /// </summary>
        [JsonProperty("ResourceId")]
        [System.Obsolete]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Binding status of the trigger and SCF
        /// </summary>
        [JsonProperty("BindStatus")]
        [System.Obsolete]
        public string BindStatus{ get; set; }

        /// <summary>
        /// Trigger type. Two-way means both the left and right consoles can operate. One-way means only the SCF console can create.
        /// </summary>
        [JsonProperty("TriggerAttribute")]
        [System.Obsolete]
        public string TriggerAttribute{ get; set; }

        /// <summary>
        /// Alias name or version bound to the trigger
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// Trigger description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TriggerDesc", this.TriggerDesc);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CustomArgument", this.CustomArgument);
            this.SetParamSimple(map, prefix + "AvailableStatus", this.AvailableStatus);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "TriggerAttribute", this.TriggerAttribute);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

