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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessLiveStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Live stream URL (must be a live streaming address, supporting rtmp, hls, flv, trtc, webrtc, srt, etc.).<br>The trtc address is as follows:<br> trtc://trtc.rtc.qq.com/mps/<code>&lt;roomid&gt;</code>?sdkappid=<code>&lt;sdkappid&gt;</code>&amp;userid=<code>&lt;userid&gt;</code>&amp;usersig=<code>&lt;usersig&gt;</code><br><code>&lt;roomid&gt;</code> is the TRTC room number ID<br><code>&lt;sdkappid&gt;</code> is the TRTC SDK app ID<br><code>&lt;userid&gt;</code> is the user ID for the service to enter the room, which can distinguish who is the robot<br><code>&lt;usersig&gt;</code> is the TRTC user signature</p><p>webrtc supports LEB live streams. For address retrieval, please <a href="https://www.tencentcloud.com/document/product/267/32720?from_cn_redirect=1">refer</a></p><p>For srt supported addresses, please <a href="https://ffmpeg.org/ffmpeg-protocols.html#srt">refer</a></p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public LiveStreamTaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AiQualityControlTask")]
        public AiQualityControlTaskInput AiQualityControlTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public LiveSmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiQualityControlTask.", this.AiQualityControlTask);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

