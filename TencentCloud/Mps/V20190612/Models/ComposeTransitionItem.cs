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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeTransitionItem : AbstractModel
    {
        
        /// <summary>
        /// The element duration. <li>The value of this parameter ends with `s`, which means seconds. For example, `3s` indicates 3 seconds. </li>
        /// Default value: `1s`.
        /// Note
        /// <li>The number before `s` must be an integer. Non-integers will be rounded down to the nearest integer. </li>
        /// <li>The transition element must be between two non-empty elements. </li>
        /// <li>The duration of the transition element must be shorter than that of the preceding element and the following element. </li>
        /// u200c<li>The start time of the following element on the track will be automatically changed to the end time of the preceding element minus the duration of the transition element. </li>
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// The transition effects.
        /// The default transition effect is fade.
        /// Note: You can add at most one image transition and one audio transition.
        /// </summary>
        [JsonProperty("Transitions")]
        public ComposeTransitionOperation[] Transitions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArrayObj(map, prefix + "Transitions.", this.Transitions);
        }
    }
}

