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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLivePullStreamTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// The task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// The operator.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// The source URL(s).
        /// If `SourceType` is `PullLivePushLive`, you can specify only one source URL.
        /// If `SourceType` is `PullVodPushLive`, you can specify at most 30 source URLs.
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// The start time.
        /// It must be in UTC format.
        /// Example: 2019-01-08T10:00:00Z.
        /// Note: Beijing time is 8 hours ahead of UTC. The [ISO 8601 format](https://intl.cloud.tencent.com/document/product/266/11732#iso-date-format) is used.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time. Notes:
        /// 1. The end time must be later than the start time.
        /// 2. The end time and start time must be later than the current time.
        /// 3. The end time and start time must be less than seven days apart.
        /// It must be in UTC format.
        /// Example: 2019-01-08T10:00:00Z.
        /// Note: Beijing time is 8 hours ahead of UTC. The [ISO 8601 format](https://intl.cloud.tencent.com/document/product/266/11732#iso-date-format) is used.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// The number of times to loop video files.
        /// -1: Loop indefinitely
        /// 0: Do not loop
        /// > 0: The number of loop times. A task will end either when the videos are looped for the specified number of times or at the specified task end time, whichever is earlier.
        /// This parameter is valid only if the source is video files.
        /// </summary>
        [JsonProperty("VodLoopTimes")]
        public long? VodLoopTimes{ get; set; }

        /// <summary>
        /// The behavior after the source video files (`SourceUrls`) are changed.
        /// ImmediateNewSource: Play the new videos immediately
        /// ContinueBreakPoint: Finish the current video first and then pull from the new source.
        /// This parameter is valid only if the source is video files.
        /// </summary>
        [JsonProperty("VodRefreshType")]
        public string VodRefreshType{ get; set; }

        /// <summary>
        /// Whether to enable or pause the task. Valid values:
        /// enable
        /// pause
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The events to listen for. If you do not pass this parameter, all events will be listened for.
        /// TaskStart: Callback for starting a task
        /// TaskExit: Callback for ending a task
        /// VodSourceFileStart: Callback for starting to pull from video files
        /// VodSourceFileFinish: Callback for stopping pulling from video files
        /// ResetTaskConfig: Callback for modifying a task
        /// </summary>
        [JsonProperty("CallbackEvents")]
        public string[] CallbackEvents{ get; set; }

        /// <summary>
        /// A custom callback URL.
        /// Callbacks will be sent to this URL.
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// The index of the video to start from.
        /// The value of this parameter cannot be smaller than 1 or larger than the number of elements in `SourceUrls`.
        /// </summary>
        [JsonProperty("FileIndex")]
        public long? FileIndex{ get; set; }

        /// <summary>
        /// The playback offset (seconds).
        /// Notes:
        /// 1. This parameter should be used together with `FileIndex`.
        /// </summary>
        [JsonProperty("OffsetTime")]
        public long? OffsetTime{ get; set; }

        /// <summary>
        /// The remarks for the task.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// The backup source type.
        /// PullLivePushLive: Live streaming
        /// PullVodPushLive: Video files
        /// Notes:
        /// 1. Backup sources are supported only if the primary source type is live streaming.
        /// 2. When pull from the primary source is interrupted, the system will pull from the backup source.
        /// 3. If the backup source is a video file, each time the video is finished, the system will check if the primary source is recovered and will switch back if it is.
        /// </summary>
        [JsonProperty("BackupSourceType")]
        public string BackupSourceType{ get; set; }

        /// <summary>
        /// The URL of the backup source.
        /// You can specify only one backup source URL.
        /// </summary>
        [JsonProperty("BackupSourceUrl")]
        public string BackupSourceUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArraySimple(map, prefix + "SourceUrls.", this.SourceUrls);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "VodLoopTimes", this.VodLoopTimes);
            this.SetParamSimple(map, prefix + "VodRefreshType", this.VodRefreshType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "CallbackEvents.", this.CallbackEvents);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "BackupSourceType", this.BackupSourceType);
            this.SetParamSimple(map, prefix + "BackupSourceUrl", this.BackupSourceUrl);
        }
    }
}

