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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullStreamTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// The task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// The source type. Valid values:
        /// PullLivePushLive: Live streaming
        /// PullVodPushLive: Video files
        /// PullPicPushLive: Images
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// The source URL(s).
        /// If `SourceType` is `PullLiveToLive`, there can be only one source URL.
        /// If `SourceType` is `PullVodToLive`, there can be at most 10 source URLs.
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// The push domain name.
        /// The pulled stream is pushed to this domain.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// The application to push to.
        /// The pulled stream is pushed to this application.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// The stream name.
        /// The pulled stream is pushed under this name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// The push parameter.
        /// A custom push parameter.
        /// </summary>
        [JsonProperty("PushArgs")]
        public string PushArgs{ get; set; }

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
        /// The region where the task was created.
        /// `ap-beijing`: North China (Beijing)
        /// `ap-shanghai`: East China (Shanghai)
        /// `ap-guangzhou`: South China (Guangzhou)
        /// `ap-mumbai`: India
        /// `ap-hongkong`: Hong Kong
        /// `eu-frankfurt`: Germany
        /// `ap-seoul`: Korea
        /// `ap-bangkok`: Thailand
        /// `ap-singapore`: Singapore
        /// `na-siliconvalley`: Western US
        /// `na-ashburn`: Eastern US
        /// `ap-tokyo`: Japan
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

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
        /// 
        /// This parameter is valid only if the source is video files.
        /// </summary>
        [JsonProperty("VodRefreshType")]
        public string VodRefreshType{ get; set; }

        /// <summary>
        /// The task creation time.
        /// It must be in UTC format.
        /// Example: 2019-01-08T10:00:00Z.
        /// Note: Beijing time is 8 hours ahead of UTC. The [ISO 8601 format](https://intl.cloud.tencent.com/document/product/266/11732#iso-date-format) is used.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The last updated time.
        /// It must be in UTC format.
        /// Example: 2019-01-08T10:00:00Z.
        /// Note: Beijing time is 8 hours ahead of UTC. The [ISO 8601 format](https://intl.cloud.tencent.com/document/product/266/11732#iso-date-format) is used.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The task creator.
        /// </summary>
        [JsonProperty("CreateBy")]
        public string CreateBy{ get; set; }

        /// <summary>
        /// The operator of the last update.
        /// </summary>
        [JsonProperty("UpdateBy")]
        public string UpdateBy{ get; set; }

        /// <summary>
        /// The callback URL.
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// The events to listen for.
        /// TaskStart: Callback for starting a task
        /// TaskExit: Callback for ending a task
        /// VodSourceFileStart: Callback for starting to pull from video files
        /// VodSourceFileFinish: Callback for stopping pulling from video files
        /// ResetTaskConfig: Callback for modifying a task
        /// </summary>
        [JsonProperty("CallbackEvents")]
        public string[] CallbackEvents{ get; set; }

        /// <summary>
        /// Note: This parameter is not returned currently.
        /// The information of the last callback.
        /// </summary>
        [JsonProperty("CallbackInfo")]
        public string CallbackInfo{ get; set; }

        /// <summary>
        /// Note: This parameter is not returned currently.
        /// Error message.
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// The task status.
        /// enable: Enabled
        /// pause: Paused
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Note: This parameter is returned only if one task is queried.
        /// The latest pull information.
        /// The information includes the source URL, offset, and report time.
        /// </summary>
        [JsonProperty("RecentPullInfo")]
        public RecentPullInfo RecentPullInfo{ get; set; }

        /// <summary>
        /// The remarks for the task.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// The backup source type. Valid values:
        /// PullLivePushLive: Live streaming
        /// PullVodPushLive: Video files
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupSourceType")]
        public string BackupSourceType{ get; set; }

        /// <summary>
        /// The URL of the backup source.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupSourceUrl")]
        public string BackupSourceUrl{ get; set; }

        /// <summary>
        /// The information of watermarks to add.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WatermarkList")]
        public PullPushWatermarkInfo[] WatermarkList{ get; set; }

        /// <summary>
        /// Whether to use local mode when the source type is video files. The default is `0`.
        /// 0: Do not use local mode
        /// 1: Use local mode
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VodLocalMode")]
        public long? VodLocalMode{ get; set; }

        /// <summary>
        ///  Recording template ID.
        /// </summary>
        [JsonProperty("RecordTemplateId")]
        public string RecordTemplateId{ get; set; }

        /// <summary>
        /// Newly added streaming address. Used for the scenario of pushing two streams with a single task.
        /// </summary>
        [JsonProperty("BackupToUrl")]
        public string BackupToUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArraySimple(map, prefix + "SourceUrls.", this.SourceUrls);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "PushArgs", this.PushArgs);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VodLoopTimes", this.VodLoopTimes);
            this.SetParamSimple(map, prefix + "VodRefreshType", this.VodRefreshType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateBy", this.CreateBy);
            this.SetParamSimple(map, prefix + "UpdateBy", this.UpdateBy);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArraySimple(map, prefix + "CallbackEvents.", this.CallbackEvents);
            this.SetParamSimple(map, prefix + "CallbackInfo", this.CallbackInfo);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "RecentPullInfo.", this.RecentPullInfo);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "BackupSourceType", this.BackupSourceType);
            this.SetParamSimple(map, prefix + "BackupSourceUrl", this.BackupSourceUrl);
            this.SetParamArrayObj(map, prefix + "WatermarkList.", this.WatermarkList);
            this.SetParamSimple(map, prefix + "VodLocalMode", this.VodLocalMode);
            this.SetParamSimple(map, prefix + "RecordTemplateId", this.RecordTemplateId);
            this.SetParamSimple(map, prefix + "BackupToUrl", this.BackupToUrl);
        }
    }
}

