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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID, which is the `AppID` obtained when you create an application in [Console > Service Management](https://console.cloud.tencent.com/gamegme)
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// Speech detection scenario. The value of this parameter is currently required to be `default`. Preset scenarios: abusive, pornographic, politically sensitive, advertising, terrorism, and prohibited scenarios. For specific values, please see the <a href="#Label_Value">Label description</a> above.
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// Whether it is a live stream. false: audio file detection, true: audio stream detection.
        /// </summary>
        [JsonProperty("Live")]
        public bool? Live{ get; set; }

        /// <summary>
        /// Speech detection task list. Up to 100 tasks can be added in the list. The structure contains:
        /// <li>DataId: unique data ID</li>
        /// <li>Url: URL-encoded data file URL, which is a pull address if the detected speech is a stream</li>
        /// </summary>
        [JsonProperty("Tasks")]
        public Task[] Tasks{ get; set; }

        /// <summary>
        /// Async callback address for detection result. For more information, please see the <a href="#Callback_Declare">callback description</a> above. (Note: if this field is empty, the detection result can only be obtained by calling the `DescribeScanResultList` API.)
        /// </summary>
        [JsonProperty("Callback")]
        public string Callback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "Live", this.Live);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Callback", this.Callback);
        }
    }
}

