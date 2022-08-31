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

    public class CreateLivePullStreamTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// The source type. Valid values:
        /// PullLivePushLive: Live streaming
        /// PullVodPushLive: Video files
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// The source URL(s).
        /// If `SourceType` is `PullLivePushLive`, you can specify only one source URL.
        /// If `SourceType` is `PullVodPushLive`, you can specify at most 30 source URLs.
        /// Supported file formats: FLV, MP4, HLS.
        /// Supported protocols: HTTP, HTTPS, RTMP, RTMPS, RTSP, SRT.
        /// Notes:
        /// 1. We recommend you use FLV files as the source. Poorly interleaved MP4 files may result in playback stuttering. You can also re-interleave your MP4 files before adding them as the source.
        /// 2. Do not use private network domains or malicious URLs. CSS will block accounts that do.
        /// 3. To avoid push and playback issues, make sure the source files are properly interleaved.
        /// 4. Supported video coding formats: H.264, H.265.
        /// 5. Supported audio coding format: AAC.
        /// 6. Use small video files, preferably not longer than one hour. Large files may take a long time to load or resume after pause. Relay may fail if the time consumed exceeds 15 seconds.
        /// </summary>
        [JsonProperty("SourceUrls")]
        public string[] SourceUrls{ get; set; }

        /// <summary>
        /// The push domain name.
        /// The pulled stream is pushed to this domain.
        /// Note: If the destination is not a CSS address and its format is different from that of CSS addresses, pass the full address to `ToUrl`. For details, see the description of the `ToUrl` parameter.
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
        /// The operator.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// The push parameter.
        /// This is a custom parameter carried during push.
        /// Example:
        /// bak=1&test=2
        /// </summary>
        [JsonProperty("PushArgs")]
        public string PushArgs{ get; set; }

        /// <summary>
        /// The events to listen for. If you do not pass this parameter, all events will be listened for.
        /// TaskStart: Callback for starting a task
        /// TaskExit: Callback for ending a task
        /// VodSourceFileStart: Callback for starting to pull from video files
        /// VodSourceFileFinish: Callback for stopping pulling from video files
        /// ResetTaskConfig: Callback for modifying a task
        /// 
        /// `TaskAlarm` indicates a warning event. `AlarmType` examples:
        /// PullFileUnstable: Pull from video files is unstable.
        /// PushStreamUnstable: Push is unstable.
        /// PullFileFailed: Error pulling from video files.
        /// PushStreamFailed: Push error.
        /// FileEndEarly: The video file ended prematurely.
        /// </summary>
        [JsonProperty("CallbackEvents")]
        public string[] CallbackEvents{ get; set; }

        /// <summary>
        /// The number of times to loop video files. Default value: -1.
        /// -1: Loop indefinitely
        /// 0: Do not loop
        /// > 0: The number of loop times. A task will end either when the videos are looped for the specified number of times or at the specified task end time, whichever is earlier.
        /// This parameter is valid only when the source is video files.
        /// </summary>
        [JsonProperty("VodLoopTimes")]
        public string VodLoopTimes{ get; set; }

        /// <summary>
        /// The behavior after the source video files (`SourceUrls`) are changed.
        /// ImmediateNewSource: Play the new videos immediately
        /// ContinueBreakPoint: Play the new videos after the current video is finished playing (the remaining videos in the old playlist will not be played).
        /// 
        /// This parameter is valid only if the source before the change is video files.
        /// </summary>
        [JsonProperty("VodRefreshType")]
        public string VodRefreshType{ get; set; }

        /// <summary>
        /// A custom callback URL.
        /// Callbacks about pull and relay events will be sent to this URL.
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// Other parameters.
        /// For example, you can use `ignore_region` to ignore the region passed in and assign a region based on load distribution.
        /// </summary>
        [JsonProperty("ExtraCmd")]
        public string ExtraCmd{ get; set; }

        /// <summary>
        /// The remarks for a task, not longer than 512 bytes.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// The complete destination URL.
        /// If you specify this parameter, make sure you pass in an empty string for `DomainName`, `AppName`, and `StreamName`.
        /// 
        /// Note: Make sure that the expiration time of the signature is later than the task end time.
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

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
        /// The information of watermarks to add.
        /// Notes:
        /// 1. You can add up to four watermarks to different locations of the video.
        /// 2. Make sure you use publicly accessible URLs for the watermark images.
        /// 3. Supported image formats include PNG, JPG, and GIF.
        /// </summary>
        [JsonProperty("WatermarkList")]
        public PullPushWatermarkInfo[] WatermarkList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArraySimple(map, prefix + "SourceUrls.", this.SourceUrls);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "PushArgs", this.PushArgs);
            this.SetParamArraySimple(map, prefix + "CallbackEvents.", this.CallbackEvents);
            this.SetParamSimple(map, prefix + "VodLoopTimes", this.VodLoopTimes);
            this.SetParamSimple(map, prefix + "VodRefreshType", this.VodRefreshType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "ExtraCmd", this.ExtraCmd);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "BackupSourceType", this.BackupSourceType);
            this.SetParamSimple(map, prefix + "BackupSourceUrl", this.BackupSourceUrl);
            this.SetParamArrayObj(map, prefix + "WatermarkList.", this.WatermarkList);
        }
    }
}

