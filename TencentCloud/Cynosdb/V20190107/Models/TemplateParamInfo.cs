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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateParamInfo : AbstractModel
    {
        
        /// <summary>
        /// Current value
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// The collection of valid value types when parameter type is `enum`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// Maximum value when parameter type is `float` or `integer`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// Minimum value when parameter type is `float` or `integer`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// Parameter name
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// Whether to restart the instance for the parameter to take effect
        /// </summary>
        [JsonProperty("NeedReboot")]
        public long? NeedReboot{ get; set; }

        /// <summary>
        /// Parameter description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Parameter type. Valid value: `integer`, `float`, `string`, `enum`.
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
        }
    }
}

