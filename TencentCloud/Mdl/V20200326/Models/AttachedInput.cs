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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachedInput : AbstractModel
    {
        
        /// <summary>
        /// Input ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Audio selector for the input. There can be 0 to 20 audio selectors.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AudioSelectors")]
        public AudioSelectorInfo[] AudioSelectors{ get; set; }

        /// <summary>
        /// Pull mode. If the input type is `HLS_PULL` or `MP4_PULL`, you can set this parameter to `LOOP` or `ONCE`. `LOOP` is the default value.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PullBehavior")]
        public string PullBehavior{ get; set; }

        /// <summary>
        /// Input failover configuration
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FailOverSettings")]
        public FailOverSettings FailOverSettings{ get; set; }

        /// <summary>
        /// Caption selector for the input. There can be 0 to 1 audio selectors.
        /// </summary>
        [JsonProperty("CaptionSelectors")]
        public CaptionSelector[] CaptionSelectors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "AudioSelectors.", this.AudioSelectors);
            this.SetParamSimple(map, prefix + "PullBehavior", this.PullBehavior);
            this.SetParamObj(map, prefix + "FailOverSettings.", this.FailOverSettings);
            this.SetParamArrayObj(map, prefix + "CaptionSelectors.", this.CaptionSelectors);
        }
    }
}

