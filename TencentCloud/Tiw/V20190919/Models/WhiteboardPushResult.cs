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

    public class WhiteboardPushResult : AbstractModel
    {
        
        /// <summary>
        /// `AUTO`: Pushing automatically stops. `USER_CALL`: The API for stopping pushing is called.
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// Number of exceptions.
        /// </summary>
        [JsonProperty("ExceptionCnt")]
        public long? ExceptionCnt{ get; set; }

        /// <summary>
        /// Room ID.
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// IM group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Actual push start time.
        /// </summary>
        [JsonProperty("PushStartTime")]
        public long? PushStartTime{ get; set; }

        /// <summary>
        /// Push end time.
        /// </summary>
        [JsonProperty("PushStopTime")]
        public long? PushStopTime{ get; set; }

        /// <summary>
        /// IM timestamp corresponding to the first frame of the whiteboard push video. The timestamp is used for time synchronization between IM messages and the whiteboard push video during playback.
        /// </summary>
        [JsonProperty("IMSyncTime")]
        public long? IMSyncTime{ get; set; }

        /// <summary>
        /// Task execution error code.
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "ExceptionCnt", this.ExceptionCnt);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PushStartTime", this.PushStartTime);
            this.SetParamSimple(map, prefix + "PushStopTime", this.PushStopTime);
            this.SetParamSimple(map, prefix + "IMSyncTime", this.IMSyncTime);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
        }
    }
}

