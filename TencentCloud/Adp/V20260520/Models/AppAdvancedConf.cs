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

    public class AppAdvancedConf : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to enable context rewrite</p>
        /// </summary>
        [JsonProperty("EnableContextRewrite")]
        public bool? EnableContextRewrite{ get; set; }

        /// <summary>
        /// <p>Whether to enable image and text retrieval.</p>
        /// </summary>
        [JsonProperty("EnableImageTextRetrieval")]
        public bool? EnableImageTextRetrieval{ get; set; }

        /// <summary>
        /// <p>Reply flexibility</p>
        /// </summary>
        [JsonProperty("ReplyFlexibility")]
        public ulong? ReplyFlexibility{ get; set; }

        /// <summary>
        /// <p>Custom configuration on the dialogue side (shared across all modes, with permission to modify configuration dynamically during a dialogue)</p>
        /// </summary>
        [JsonProperty("DialogCustomConfig")]
        public DialogCustomConfig DialogCustomConfig{ get; set; }

        /// <summary>
        /// <p>Intent attainment priority</p>
        /// </summary>
        [JsonProperty("IntentAchievement")]
        public IntentAchievementInfo[] IntentAchievement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableContextRewrite", this.EnableContextRewrite);
            this.SetParamSimple(map, prefix + "EnableImageTextRetrieval", this.EnableImageTextRetrieval);
            this.SetParamSimple(map, prefix + "ReplyFlexibility", this.ReplyFlexibility);
            this.SetParamObj(map, prefix + "DialogCustomConfig.", this.DialogCustomConfig);
            this.SetParamArrayObj(map, prefix + "IntentAchievement.", this.IntentAchievement);
        }
    }
}

