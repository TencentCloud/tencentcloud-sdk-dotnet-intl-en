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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Task name. Maximum 128 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Execute the prompt content. Maximum 2048 characters.</p>
        /// </summary>
        [JsonProperty("Prompts")]
        public string Prompts{ get; set; }

        /// <summary>
        /// <p>Trigger list. Multiple triggers have an "or" relationship, and any one of them triggers the action.</p>
        /// </summary>
        [JsonProperty("Triggers")]
        public AiScheduleTriggerInfo[] Triggers{ get; set; }

        /// <summary>
        /// <p>Maximum trigger count. 0 indicates unlimited.</p>
        /// </summary>
        [JsonProperty("MaxFireCount")]
        public long? MaxFireCount{ get; set; }

        /// <summary>
        /// <p>Start of effective time, Unix millisecond timestamp. 0 means effective immediately.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>Expiration time, Unix millisecond timestamp. 0 means never expires.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Prompts", this.Prompts);
            this.SetParamArrayObj(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "MaxFireCount", this.MaxFireCount);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

