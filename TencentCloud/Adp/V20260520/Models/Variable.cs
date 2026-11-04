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

    public class Variable : AbstractModel
    {
        
        /// <summary>
        /// <p>Default file name.</p>
        /// </summary>
        [JsonProperty("DefaultFileName")]
        public string DefaultFileName{ get; set; }

        /// <summary>
        /// <p>Default value.</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>Variable description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Variable module type</p><p>Enumeration values:</p><ul><li>0: API parameter</li><li>1: environment parameter</li><li>2: application parameter</li><li>3: system parameter</li></ul>
        /// </summary>
        [JsonProperty("ModuleType")]
        public long? ModuleType{ get; set; }

        /// <summary>
        /// <p>Variable name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Variable type</p><p>Enumeration values:</p><ul><li>0: string</li><li>1: integer</li><li>2: floating-point number</li><li>3: boolean value</li><li>4: object</li><li>5: array of strings</li><li>6: array of integers</li><li>7: array of floating-point numbers</li><li>8: array of boolean values</li><li>9: object array</li><li>10: file</li><li>11: document</li><li>12: image</li><li>13: audio</li><li>14: video</li><li>15: file array</li><li>16: document array</li><li>17: image array</li><li>18: audio array</li><li>19: video array</li><li>20: array of arrays</li><li>21: key</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Variable ID</p>
        /// </summary>
        [JsonProperty("VariableId")]
        public string VariableId{ get; set; }

        /// <summary>
        /// <p>Whether to enable network policy (only effective for environment variables)</p>
        /// </summary>
        [JsonProperty("EnableEndpoints")]
        public bool? EnableEndpoints{ get; set; }

        /// <summary>
        /// <p>Network policy list (Supported: precise domain name, *.wildcard domain, with optional protocol/port/path prefix)</p>
        /// </summary>
        [JsonProperty("EndpointList")]
        public string[] EndpointList{ get; set; }

        /// <summary>
        /// <p>Whether it is a built-in variable.</p>
        /// </summary>
        [JsonProperty("IsBuiltin")]
        public bool? IsBuiltin{ get; set; }

        /// <summary>
        /// <p>Whether it can be injected into the sandbox environment.</p>
        /// </summary>
        [JsonProperty("EnableSandbox")]
        public bool? EnableSandbox{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefaultFileName", this.DefaultFileName);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ModuleType", this.ModuleType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "VariableId", this.VariableId);
            this.SetParamSimple(map, prefix + "EnableEndpoints", this.EnableEndpoints);
            this.SetParamArraySimple(map, prefix + "EndpointList.", this.EndpointList);
            this.SetParamSimple(map, prefix + "IsBuiltin", this.IsBuiltin);
            this.SetParamSimple(map, prefix + "EnableSandbox", this.EnableSandbox);
        }
    }
}

