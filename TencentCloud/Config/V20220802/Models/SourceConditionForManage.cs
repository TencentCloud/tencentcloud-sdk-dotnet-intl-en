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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceConditionForManage : AbstractModel
    {
        
        /// <summary>
        /// Compliance status when the condition is empty. Valid values: COMPLIANT, NON_COMPLIANT, and NOT_APPLICABLE.
        /// </summary>
        [JsonProperty("EmptyAs")]
        public string EmptyAs{ get; set; }

        /// <summary>
        /// Configuration path
        /// </summary>
        [JsonProperty("SelectPath")]
        public string SelectPath{ get; set; }

        /// <summary>
        /// Operator.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Whether it is mandatory.
        /// </summary>
        [JsonProperty("Required")]
        public bool? Required{ get; set; }

        /// <summary>
        /// Expected value
        /// </summary>
        [JsonProperty("DesiredValue")]
        public string DesiredValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EmptyAs", this.EmptyAs);
            this.SetParamSimple(map, prefix + "SelectPath", this.SelectPath);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "DesiredValue", this.DesiredValue);
        }
    }
}

