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

    public class SystemConfigRule : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule ID.</p>
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// <p>Rule name.</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Rule parameters</p>
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameterForManage[] InputParameter{ get; set; }

        /// <summary>
        /// <p>Rule trigger condition</p>
        /// </summary>
        [JsonProperty("SourceCondition")]
        public SourceConditionForManage[] SourceCondition{ get; set; }

        /// <summary>
        /// <p>Supported resource types.</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string[] ResourceType{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Label")]
        public string[] Label{ get; set; }

        /// <summary>
        /// <p>Risk level, 1, 2, 3</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// <p>Corresponding function</p>
        /// </summary>
        [JsonProperty("ServiceFunction")]
        public string ServiceFunction{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Trigger type.</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string[] TriggerType{ get; set; }

        /// <summary>
        /// <p>Description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Number of use</p>
        /// </summary>
        [JsonProperty("ReferenceCount")]
        public ulong? ReferenceCount{ get; set; }

        /// <summary>
        /// <p>Rule type.</p>
        /// </summary>
        [JsonProperty("IdentifierType")]
        public string IdentifierType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamArrayObj(map, prefix + "SourceCondition.", this.SourceCondition);
            this.SetParamArraySimple(map, prefix + "ResourceType.", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ServiceFunction", this.ServiceFunction);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "TriggerType.", this.TriggerType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ReferenceCount", this.ReferenceCount);
            this.SetParamSimple(map, prefix + "IdentifierType", this.IdentifierType);
        }
    }
}

