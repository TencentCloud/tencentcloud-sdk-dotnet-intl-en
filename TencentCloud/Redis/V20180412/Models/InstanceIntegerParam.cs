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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceIntegerParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Parameter name</p>
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// <p>Parameter type: integer</p>
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// <p>Whether restart is required after modification: true, false</p>
        /// </summary>
        [JsonProperty("NeedRestart")]
        public string NeedRestart{ get; set; }

        /// <summary>
        /// <p>Default parameter value</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>Current running parameter value</p>
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// <p>Parameter description</p>
        /// </summary>
        [JsonProperty("Tips")]
        public string Tips{ get; set; }

        /// <summary>
        /// <p>Minimum parameter value</p>
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// <p>Maximum parameter value</p>
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// <p>Parameter status. 1: modifying, 2: modified</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Parameter unit</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>Parameter type</p><p>Enumeration values:</p><ul><li>redis: parameters supported by cache nodes</li><li>redis-interface: parameters supported by proxy</li><li>tendis: parameters supported by tendis</li></ul>
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// <p>Whether the current instance supports this feature</p>
        /// </summary>
        [JsonProperty("FeatureSupported")]
        public bool? FeatureSupported{ get; set; }

        /// <summary>
        /// <p>New feature launch date</p><p>Parameter format: time format YYYY-MM-DD</p>
        /// </summary>
        [JsonProperty("NewFeatureOnlineTime")]
        public string NewFeatureOnlineTime{ get; set; }

        /// <summary>
        /// <p>Regular expression validation rule</p>
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// <p>Input format description</p>
        /// </summary>
        [JsonProperty("InputDescription")]
        public string InputDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Tips", this.Tips);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "FeatureSupported", this.FeatureSupported);
            this.SetParamSimple(map, prefix + "NewFeatureOnlineTime", this.NewFeatureOnlineTime);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "InputDescription", this.InputDescription);
        }
    }
}

