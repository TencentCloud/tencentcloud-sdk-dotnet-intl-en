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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordControl : AbstractModel
    {
        
        /// <summary>
        /// It specifies whether to enable RecordControl. Valid values: true (yes); false (no).
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// A global parameter generally used in conjunction with `StreamControls` that specifies whether to disable recording. Valid values:
        /// 
        /// true: no stream is recorded.
        /// false: all streams are recorded. Default value: false.
        /// 
        /// The setting in this parameter is applied to all streams. However, if `StreamControls` is passed in, the parameters in `StreamControls` will take precedence.
        /// </summary>
        [JsonProperty("DisableRecord")]
        public bool? DisableRecord{ get; set; }

        /// <summary>
        /// A global parameter generally used in conjunction with `StreamControls` that specifies whether to disable audio recording over all streams. Valid values:
        /// 
        /// true: no audio recording of any streams.
        /// false: audio recording of all streams. Default value: false.
        /// 
        /// The setting in this parameter is applied to all streams. However, if `StreamControls` is passed in, the parameters in `StreamControls` will take precedence.
        /// </summary>
        [JsonProperty("DisableAudio")]
        public bool? DisableAudio{ get; set; }

        /// <summary>
        /// A global parameter generally used in conjunction with `StreamControls` that specifies whether to record low-resolution videos only. Valid values:
        /// 
        /// true: only records low-resolution videos for all streams. Please ensure that the up-streaming end pushes the low-resolution videos. Otherwise, the recorded video may be black.
        /// false: high-resolution video recording of all streams. Default value: false.
        /// 
        /// The setting in this parameter is applied to all streams. However, if `StreamControls` is passed in, the parameters in `StreamControls` will take precedence.
        /// </summary>
        [JsonProperty("PullSmallVideo")]
        public bool? PullSmallVideo{ get; set; }

        /// <summary>
        /// Parameters over specific streams, which take priority over global configurations. If it’s empty, all streams are recorded according to the global configurations. 
        /// </summary>
        [JsonProperty("StreamControls")]
        public StreamControl[] StreamControls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamSimple(map, prefix + "DisableAudio", this.DisableAudio);
            this.SetParamSimple(map, prefix + "PullSmallVideo", this.PullSmallVideo);
            this.SetParamArrayObj(map, prefix + "StreamControls.", this.StreamControls);
        }
    }
}

