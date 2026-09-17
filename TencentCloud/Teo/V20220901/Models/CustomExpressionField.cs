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

    public class CustomExpressionField : AbstractModel
    {
        
        /// <summary>
        /// <p>Custom log field name. Enter 1-100 characters. Allowed characters are letters, digits, and _. It must start with a letter. This name must be unique.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>The value expression of a custom log field. The maximum length of the expression is 4KB. For syntax explanation, see <a href="">Custom Log Field Expression</a>.</p>
        /// </summary>
        [JsonProperty("Expression")]
        public string Expression{ get; set; }

        /// <summary>
        /// <p>Whether to deliver this field. If left blank, it means not to deliver this field.</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Expression", this.Expression);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

