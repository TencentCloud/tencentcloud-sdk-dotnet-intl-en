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

    public class DescribeOnlineRecordResponse : AbstractModel
    {
        
        /// <summary>
        /// Recording stop reason
        /// - AUTO: Recording automatically stops because no upstream audio/video or whiteboard operation occurs in the room for a long time.
        /// - USER_CALL: The API for stopping recording is called.
        /// - EXCEPTION: An exception occurred.
        /// - FORCE_STOP: Recording is forcibly stopped, which is usually because the recording has been paused for more than 90 minutes or has lasted for more than 24 hours.
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// ID of the recording task to be queried.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Recording task status
        /// - PREPARED: preparing
        /// - RECORDING: recording
        /// - PAUSED: recording is paused.
        /// - STOPPED: recording is stopped, and the recorded video is being processed and uploaded.
        /// - FINISHED: the recorded video has been processed and uploaded, and the recording result is generated.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Room ID
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// Group ID of the whiteboard
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// ID of the recording user
        /// </summary>
        [JsonProperty("RecordUserId")]
        public string RecordUserId{ get; set; }

        /// <summary>
        /// Actual recording start time, which is a UNIX timestamp in seconds
        /// </summary>
        [JsonProperty("RecordStartTime")]
        public long? RecordStartTime{ get; set; }

        /// <summary>
        /// Actual recording stop time, which is a UNIX timestamp in seconds
        /// </summary>
        [JsonProperty("RecordStopTime")]
        public long? RecordStopTime{ get; set; }

        /// <summary>
        /// Total video playback duration, in milliseconds
        /// </summary>
        [JsonProperty("TotalTime")]
        public long? TotalTime{ get; set; }

        /// <summary>
        /// Number of exceptions during recording
        /// </summary>
        [JsonProperty("ExceptionCnt")]
        public long? ExceptionCnt{ get; set; }

        /// <summary>
        /// Duration to be deleted in the spliced video. This parameter is valid only when the video splicing feature is enabled.
        /// </summary>
        [JsonProperty("OmittedDurations")]
        public OmittedDuration[] OmittedDurations{ get; set; }

        /// <summary>
        /// List of recorded videos
        /// </summary>
        [JsonProperty("VideoInfos")]
        public VideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReplayUrl")]
        public string ReplayUrl{ get; set; }

        /// <summary>
        /// Number of video stream interruptions during recording.
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Interrupts")]
        public Interrupt[] Interrupts{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "RecordUserId", this.RecordUserId);
            this.SetParamSimple(map, prefix + "RecordStartTime", this.RecordStartTime);
            this.SetParamSimple(map, prefix + "RecordStopTime", this.RecordStopTime);
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "ExceptionCnt", this.ExceptionCnt);
            this.SetParamArrayObj(map, prefix + "OmittedDurations.", this.OmittedDurations);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamSimple(map, prefix + "ReplayUrl", this.ReplayUrl);
            this.SetParamArrayObj(map, prefix + "Interrupts.", this.Interrupts);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

