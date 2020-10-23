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

    public class StreamControl : AbstractModel
    {
        
        /// <summary>
        /// Video stream ID
        /// Description of the possible video stream ID values:
        /// 1. `tic_record_user`: the whiteboard video stream
        /// 2. `tic_substream`: the auxiliary video stream
        /// 3. Specific user ID: the video stream of the specified user
        /// 
        /// The actual recording uses the prefix match of the video stream ID. The real stream becomes the specified stream once its ID prefix matches with the stream ID.
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Whether to disable recording over the stream.
        /// 
        /// true: does not record this stream. This stream will not be included in the final recording file.
        /// false: records this stream. This stream will be included in the final recording file.
        /// 
        /// Default value: false
        /// </summary>
        [JsonProperty("DisableRecord")]
        public bool? DisableRecord{ get; set; }

        /// <summary>
        /// Whether to disable the audio recording of the stream.
        /// 
        /// true: does not record the audio of the stream. In the final recording file, this stream will be soundless.
        /// false: the stream has both video and audio recording.
        /// 
        /// Default value: false
        /// </summary>
        [JsonProperty("DisableAudio")]
        public bool? DisableAudio{ get; set; }

        /// <summary>
        /// Whether to only record low-resolution stream videos.
        /// 
        /// true: records only low-resolution videos. In this case, please make sure that the client pushes low-resolution videos upstream. Otherwise, the recorded video may be black. 
        /// false: records only high-resolution videos.
        /// 
        /// Default value: false
        /// </summary>
        [JsonProperty("PullSmallVideo")]
        public bool? PullSmallVideo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamSimple(map, prefix + "DisableAudio", this.DisableAudio);
            this.SetParamSimple(map, prefix + "PullSmallVideo", this.PullSmallVideo);
        }
    }
}

