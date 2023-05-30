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

    public class DescribeWhiteboardPushResponse : AbstractModel
    {
        
        /// <summary>
        /// Reason for push stop.
        /// - AUTO: Pushing automatically stops because no upstream audio/video or whiteboard operation occurs in the room for a long time.
        /// - USER_CALL: The API for stopping pushing is called.
        /// - EXCEPTION: An exception occurred.
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// ID of the whiteboard push task.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Status of the push task.
        /// - PREPARED: Push in preparation (including entering the room and starting the push service).
        /// - PUSHING: Pushing in progress.
        /// - STOPPED: Pushing stopped.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Room ID.
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// Group ID of the whiteboard.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// User ID of the push task.
        /// </summary>
        [JsonProperty("PushUserId")]
        public string PushUserId{ get; set; }

        /// <summary>
        /// Actual push start time, which is a Unix timestamp in seconds.
        /// </summary>
        [JsonProperty("PushStartTime")]
        public long? PushStartTime{ get; set; }

        /// <summary>
        /// Actual push stop time, which is a Unix timestamp in seconds.
        /// </summary>
        [JsonProperty("PushStopTime")]
        public long? PushStopTime{ get; set; }

        /// <summary>
        /// Number of exceptions during push.
        /// </summary>
        [JsonProperty("ExceptionCnt")]
        public long? ExceptionCnt{ get; set; }

        /// <summary>
        /// IM timestamp corresponding to the first frame of the whiteboard push video. The timestamp is used for time synchronization between IM messages and the whiteboard push video during playback.
        /// </summary>
        [JsonProperty("IMSyncTime")]
        public long? IMSyncTime{ get; set; }

        /// <summary>
        /// Result information of the backup push task.
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Backup")]
        public string Backup{ get; set; }

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
            this.SetParamSimple(map, prefix + "PushUserId", this.PushUserId);
            this.SetParamSimple(map, prefix + "PushStartTime", this.PushStartTime);
            this.SetParamSimple(map, prefix + "PushStopTime", this.PushStopTime);
            this.SetParamSimple(map, prefix + "ExceptionCnt", this.ExceptionCnt);
            this.SetParamSimple(map, prefix + "IMSyncTime", this.IMSyncTime);
            this.SetParamSimple(map, prefix + "Backup", this.Backup);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

