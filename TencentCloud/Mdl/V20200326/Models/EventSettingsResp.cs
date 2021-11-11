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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventSettingsResp : AbstractModel
    {
        
        /// <summary>
        /// Only `INPUT_SWITCH` is supported currently.
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// ID of the input attached, which is not empty if `EventType` is `INPUT_SWITCH`
        /// </summary>
        [JsonProperty("InputAttachment")]
        public string InputAttachment{ get; set; }

        /// <summary>
        /// Name of the output group attached. This parameter is not empty if `EventType` is `TIMED_RECORD`.
        /// </summary>
        [JsonProperty("OutputGroupName")]
        public string OutputGroupName{ get; set; }

        /// <summary>
        /// Name of the manifest file for timed recording, which ends with `.m3u8` for HLS and `.mpd` for DASH. This parameter is not empty if `EventType` is `TIMED_RECORD`.
        /// </summary>
        [JsonProperty("ManifestName")]
        public string ManifestName{ get; set; }

        /// <summary>
        /// URL of the COS bucket where recording files are saved. This parameter is not empty if `EventType` is `TIMED_RECORD`. It may contain 1 or 2 URLs. The first URL corresponds to pipeline 0 and the second pipeline 1.
        /// </summary>
        [JsonProperty("Destinations")]
        public EventSettingsDestinationResp[] Destinations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "InputAttachment", this.InputAttachment);
            this.SetParamSimple(map, prefix + "OutputGroupName", this.OutputGroupName);
            this.SetParamSimple(map, prefix + "ManifestName", this.ManifestName);
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
        }
    }
}

