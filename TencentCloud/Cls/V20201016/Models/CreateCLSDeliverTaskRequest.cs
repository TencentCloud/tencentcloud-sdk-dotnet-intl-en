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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCLSDeliverTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Task name</p><p>Parameter format: <code>^[a-zA-Z0-9_-]{1,64}$</code></p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Source topic information</p>
        /// </summary>
        [JsonProperty("SourceTopicConfig")]
        public SourceTopicConfig SourceTopicConfig{ get; set; }

        /// <summary>
        /// <p>Target topic information</p>
        /// </summary>
        [JsonProperty("TargetTopicConfig")]
        public TargetTopicConfig TargetTopicConfig{ get; set; }

        /// <summary>
        /// <p>Shipping Rule</p>
        /// </summary>
        [JsonProperty("DeliverRule")]
        public DeliverRule DeliverRule{ get; set; }

        /// <summary>
        /// <p>Compliance commitment.</p><p>Enumeration values:</p><ul><li>1: Agree to the cross-border data transmission clause</li></ul>
        /// </summary>
        [JsonProperty("Compliance")]
        public ulong? Compliance{ get; set; }

        /// <summary>
        /// <p>Whether to enable delivery service log.</p><p>Enumeration values:</p><ul><li>1: Disabled</li><li>2: Enabled</li></ul><p>Default value: 2</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "SourceTopicConfig.", this.SourceTopicConfig);
            this.SetParamObj(map, prefix + "TargetTopicConfig.", this.TargetTopicConfig);
            this.SetParamObj(map, prefix + "DeliverRule.", this.DeliverRule);
            this.SetParamSimple(map, prefix + "Compliance", this.Compliance);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

