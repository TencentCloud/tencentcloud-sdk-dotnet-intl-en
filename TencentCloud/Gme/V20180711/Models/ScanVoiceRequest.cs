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
        /// Application ID, which is obtained when you create an application in the [GME console - Service Management](https://console.cloud.tencent.com/gamegme).
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// Voice detection scenario. It must be `default`. See the <a href="#Label_Value">Label description</a> as the result.
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// Whether it is a live stream. Values: `false` (voice file), `true` (live stream).
        /// </summary>
        [JsonProperty("Live")]
        public bool? Live{ get; set; }

        /// <summary>
        /// Voice detection task list. Up to 100 tasks can be added in the list. 
        /// <li>`DataId`: Unique data ID</li>
        /// <li>`Url`: URL-encoded data file URL, which is a pull address if the detected voice is a stream</li>
        /// </summary>
        [JsonProperty("Tasks")]
        public Task[] Tasks{ get; set; }

        /// <summary>
        /// Async callback address for detection result. For more information, please see the <a href="#Callback_Declare">Callback description</a> above. (Note: If this field is empty, the detection result can only be queried by calling the `DescribeScanResultList` API.)
        /// </summary>
        [JsonProperty("Callback")]
        public string Callback{ get; set; }

        /// <summary>
        /// Language. `jp`: Japanese
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "Live", this.Live);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Callback", this.Callback);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
        }
    }
}

