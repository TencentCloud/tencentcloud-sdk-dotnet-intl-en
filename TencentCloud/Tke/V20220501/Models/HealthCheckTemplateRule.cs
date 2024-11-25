/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheckTemplateRule : AbstractModel
    {
        
        /// <summary>
        /// Health check item name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of health check rules
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Fix action
        /// </summary>
        [JsonProperty("RepairAction")]
        public string RepairAction{ get; set; }

        /// <summary>
        /// Fix impact
        /// </summary>
        [JsonProperty("RepairEffect")]
        public string RepairEffect{ get; set; }

        /// <summary>
        /// Whether it is recommended to enable check
        /// </summary>
        [JsonProperty("ShouldEnable")]
        public bool? ShouldEnable{ get; set; }

        /// <summary>
        /// Whether repair is suggested.
        /// </summary>
        [JsonProperty("ShouldRepair")]
        public bool? ShouldRepair{ get; set; }

        /// <summary>
        /// Severity
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RepairAction", this.RepairAction);
            this.SetParamSimple(map, prefix + "RepairEffect", this.RepairEffect);
            this.SetParamSimple(map, prefix + "ShouldEnable", this.ShouldEnable);
            this.SetParamSimple(map, prefix + "ShouldRepair", this.ShouldRepair);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
        }
    }
}

