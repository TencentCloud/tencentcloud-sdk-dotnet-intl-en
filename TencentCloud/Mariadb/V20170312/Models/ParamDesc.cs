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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamDesc : AbstractModel
    {
        
        /// <summary>
        /// Parameter name
        /// </summary>
        [JsonProperty("Param")]
        public string Param{ get; set; }

        /// <summary>
        /// Current parameter value
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Previously set value, which is the same as `value` after the parameter takes effect.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SetValue")]
        public string SetValue{ get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// Parameter constraint
        /// </summary>
        [JsonProperty("Constraint")]
        public ParamConstraint Constraint{ get; set; }

        /// <summary>
        /// Whether a value has been set. false: no, true: yes
        /// </summary>
        [JsonProperty("HaveSetValue")]
        public bool? HaveSetValue{ get; set; }

        /// <summary>
        /// Whether restart is required. false: no;
        /// true: yes.
        /// </summary>
        [JsonProperty("NeedRestart")]
        public bool? NeedRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Param", this.Param);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "SetValue", this.SetValue);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamObj(map, prefix + "Constraint.", this.Constraint);
            this.SetParamSimple(map, prefix + "HaveSetValue", this.HaveSetValue);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
        }
    }
}

