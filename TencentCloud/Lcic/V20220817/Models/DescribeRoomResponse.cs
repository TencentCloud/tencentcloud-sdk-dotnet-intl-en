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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRoomResponse : AbstractModel
    {
        
        /// <summary>
        /// Room name	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Reserved room start time, in UNIX timestamp format	
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// Reserved room end time, in UNIX timestamp format	
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Teacher ID	
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// LCIC SdkAppId	
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        ///  Watch type. Can have the following values: 1 interactive viewing 2 standard viewing
        /// </summary>
        [JsonProperty("AudienceType")]
        public ulong? AudienceType{ get; set; }

        /// <summary>
        /// Resolution. Valid values: 1: SD; 2: HD; 3: FHD
        /// </summary>
        [JsonProperty("Resolution")]
        public ulong? Resolution{ get; set; }

        /// <summary>
        /// Maximum number of mic-on users (excluding teachers). Value range: [0, 16]
        /// </summary>
        [JsonProperty("MaxMicNumber")]
        public ulong? MaxMicNumber{ get; set; }

        /// <summary>
        /// Whether to automatically turn the mic on when the user enters a room. Valid values: 0: No (default value); 1: Yes.
        /// </summary>
        [JsonProperty("AutoMic")]
        public ulong? AutoMic{ get; set; }

        /// <summary>
        /// Whether to enable the high audio quality mode. Valid values: 0: No (default value); 1: Yes.
        /// </summary>
        [JsonProperty("AudioQuality")]
        public ulong? AudioQuality{ get; set; }

        /// <summary>
        /// The room subtype. Valid values: videodoc: Document + Video; video: Video only.
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// Whether to disable auto recording. Valid values: 0: No (default); 1: Yes. If this parameter is 0, recording will start when the class starts and stops when the class ends.
        /// </summary>
        [JsonProperty("DisableRecord")]
        public ulong? DisableRecord{ get; set; }

        /// <summary>
        /// Assistant ID list Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Assistants")]
        public string[] Assistants{ get; set; }

        /// <summary>
        /// Recording URL. This parameter exists only after a room is ended. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// The class status. 0: The class has not started. 1: The class has started. 2: The class ended. 3: The class expired. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Whether the students' consent is required to control their cameras/microphones.
        /// </summary>
        [JsonProperty("EnableDirectControl")]
        public ulong? EnableDirectControl{ get; set; }

        /// <summary>
        /// Turn on focus mode. 0 Watch all character audio and video (default) 1 Watch only teachers and teaching assistants
        /// </summary>
        [JsonProperty("InteractionMode")]
        public long? InteractionMode{ get; set; }

        /// <summary>
        /// Horizontal and vertical screen. 0: Horizontal screen to open broadcast (default); 1: Vertical screen to open broadcast, currently only support mobile pure video type
        /// </summary>
        [JsonProperty("VideoOrientation")]
        public ulong? VideoOrientation{ get; set; }

        /// <summary>
        /// Whether the room is enabled for grading after the lesson. 0: not enabled 1: enabled
        /// </summary>
        [JsonProperty("IsGradingRequiredPostClass")]
        public long? IsGradingRequiredPostClass{ get; set; }

        /// <summary>
        /// Room Type: 0 Small Classroom(default); 1 Lecture Hall(public class)
        /// </summary>
        [JsonProperty("RoomType")]
        public long? RoomType{ get; set; }

        /// <summary>
        /// Recording Duration
        /// </summary>
        [JsonProperty("VideoDuration")]
        public ulong? VideoDuration{ get; set; }

        /// <summary>
        /// Drag class time: unit minutes, 0 is unlimited (default), -1 is can't drag the class, greater than 0 is the time of dragging the class, the maximum value of 120 minutes
        /// </summary>
        [JsonProperty("EndDelayTime")]
        public long? EndDelayTime{ get; set; }

        /// <summary>
        /// Live type: 0 regular (default) 1 Simulated Live
        /// </summary>
        [JsonProperty("LiveType")]
        public ulong? LiveType{ get; set; }

        /// <summary>
        /// Simulated Live link
        /// </summary>
        [JsonProperty("RecordLiveUrl")]
        public string RecordLiveUrl{ get; set; }

        /// <summary>
        /// Whether to start the lesson automatically: 0 not automatic lesson (default) 1 automatic lesson live_type=1 is valid
        /// </summary>
        [JsonProperty("EnableAutoStart")]
        public ulong? EnableAutoStart{ get; set; }

        /// <summary>
        /// Recorded file background image, support png, jpg, jpeg, bmp format, does not support transparent channel for the time being
        /// </summary>
        [JsonProperty("RecordBackground")]
        public string RecordBackground{ get; set; }

        /// <summary>
        /// RTMP  stream link
        /// </summary>
        [JsonProperty("RTMPStreamingURL")]
        public string RTMPStreamingURL{ get; set; }

        /// <summary>
        /// Record customized scene, only recordlayout=9 this parameter is valid
        /// </summary>
        [JsonProperty("RecordScene")]
        public string RecordScene{ get; set; }

        /// <summary>
        /// Record customized language, only when recordlayout=9, this parameter is valid
        /// </summary>
        [JsonProperty("RecordLang")]
        public string RecordLang{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "AudienceType", this.AudienceType);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MaxMicNumber", this.MaxMicNumber);
            this.SetParamSimple(map, prefix + "AutoMic", this.AutoMic);
            this.SetParamSimple(map, prefix + "AudioQuality", this.AudioQuality);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamArraySimple(map, prefix + "Assistants.", this.Assistants);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EnableDirectControl", this.EnableDirectControl);
            this.SetParamSimple(map, prefix + "InteractionMode", this.InteractionMode);
            this.SetParamSimple(map, prefix + "VideoOrientation", this.VideoOrientation);
            this.SetParamSimple(map, prefix + "IsGradingRequiredPostClass", this.IsGradingRequiredPostClass);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
            this.SetParamSimple(map, prefix + "VideoDuration", this.VideoDuration);
            this.SetParamSimple(map, prefix + "EndDelayTime", this.EndDelayTime);
            this.SetParamSimple(map, prefix + "LiveType", this.LiveType);
            this.SetParamSimple(map, prefix + "RecordLiveUrl", this.RecordLiveUrl);
            this.SetParamSimple(map, prefix + "EnableAutoStart", this.EnableAutoStart);
            this.SetParamSimple(map, prefix + "RecordBackground", this.RecordBackground);
            this.SetParamSimple(map, prefix + "RTMPStreamingURL", this.RTMPStreamingURL);
            this.SetParamSimple(map, prefix + "RecordScene", this.RecordScene);
            this.SetParamSimple(map, prefix + "RecordLang", this.RecordLang);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

