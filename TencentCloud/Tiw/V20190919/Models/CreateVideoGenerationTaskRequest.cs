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

    public class CreateVideoGenerationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the recording task.
        /// </summary>
        [JsonProperty("OnlineRecordTaskId")]
        public string OnlineRecordTaskId{ get; set; }

        /// <summary>
        /// SdkAppId of the whiteboard application.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Whiteboard parameters of the recording video generation task, such as the width and height of the whiteboard.
        /// 
        /// This parameter conflicts with the Whiteboard parameter in the API for starting a recording task. If the two Whiteboard parameters are both specified, the Whiteboard parameter in this API takes priority for recording video generation. If the Whiteboard parameter in this API is not specified, the Whiteboard parameter specified in the API for starting a recording task is used for recording video generation.
        /// </summary>
        [JsonProperty("Whiteboard")]
        public Whiteboard Whiteboard{ get; set; }

        /// <summary>
        /// Video splicing parameters.
        /// 
        /// This parameter conflicts with the Concat parameter in the API for starting a recording task. If the two Concat parameters are both specified, the Concat parameter in this API takes priority for video splicing. If the Concat parameter in this API is not specified, the Concat parameter specified in the API for starting a recording task is used for video splicing.
        /// </summary>
        [JsonProperty("Concat")]
        public Concat Concat{ get; set; }

        /// <summary>
        /// Video stream mixing parameters.
        /// 
        /// This parameter conflicts with the MixStream parameter in the API for starting a recording task. If the two MixStream parameters are both specified, the MixStream parameter in this API takes priority for video stream mixing. If the MixStream parameter in this API is not specified, the MixStream parameter specified in the API for starting a recording task is used for video stream mixing.
        /// </summary>
        [JsonProperty("MixStream")]
        public MixStream MixStream{ get; set; }

        /// <summary>
        /// A group of video generation parameters. It specifies the streams to be generated, whether to disable audio recording for a stream, and whether to record only low-resolution videos, etc.
        /// 
        /// This parameter conflicts with the RecordControl parameter in the API for starting a recording task. If the two RecordControl parameters are both specified, the RecordControl parameter in this API takes priority for video generation control. If the RecordControl parameter in this API is not specified, the RecordControl parameter specified in the API for starting a recording task is used for video generation control.
        /// </summary>
        [JsonProperty("RecordControl")]
        public RecordControl RecordControl{ get; set; }

        /// <summary>
        /// Internal parameter.
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OnlineRecordTaskId", this.OnlineRecordTaskId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamObj(map, prefix + "Whiteboard.", this.Whiteboard);
            this.SetParamObj(map, prefix + "Concat.", this.Concat);
            this.SetParamObj(map, prefix + "MixStream.", this.MixStream);
            this.SetParamObj(map, prefix + "RecordControl.", this.RecordControl);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
        }
    }
}

