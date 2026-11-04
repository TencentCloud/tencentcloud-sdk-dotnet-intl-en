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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTriggerParamBinding : AbstractModel
    {
        
        /// <summary>
        /// <p>Parameter name.</p>
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// <p>Parameter type</p><p>Enumeration values:</p><ul><li>0: string</li><li>1: integer</li><li>2: floating-point number</li><li>4: object</li><li>5: string array</li><li>6: integer array</li><li>7: floating-point number array</li><li>8: boolean value array</li><li>3: boolean value</li><li>9: object array</li><li>10: file</li><li>11: document</li><li>12: image</li><li>13: audio</li><li>14: video</li><li>15: file array</li><li>16: document array</li><li>17: image array</li><li>18: audio array</li><li>19: video array</li><li>20: nested array</li><li>22: key</li><li>99: null</li><li>100: unspecified type, for OneOf and AnyOf scenarios</li></ul>
        /// </summary>
        [JsonProperty("ParamType")]
        public long? ParamType{ get; set; }

        /// <summary>
        /// <p>Parameter value</p>
        /// </summary>
        [JsonProperty("Value")]
        public AppTriggerParamBindingValue Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamObj(map, prefix + "Value.", this.Value);
        }
    }
}

