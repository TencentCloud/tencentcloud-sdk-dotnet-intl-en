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

    public class CreateRoomRequest : AbstractModel
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
        /// LCIC SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 	Resolution. Valid values: 1: SD; 2: HD; 3: FHD
        /// </summary>
        [JsonProperty("Resolution")]
        public ulong? Resolution{ get; set; }

        /// <summary>
        /// Maximum number of mic-on users (excluding teachers). Value range: [0, 16]. This value affects billing, please set it according to the actual business situation. For billing rules, see "Billing Overview" under "Purchase Guide". Example:
        /// 1: Billing based on the 1v1 rule;
        /// 10: Billing based on the 1v7-12 rule.
        /// </summary>
        [JsonProperty("MaxMicNumber")]
        public ulong? MaxMicNumber{ get; set; }

        /// <summary>
        /// The room subtype. Valid values: videodoc: Document + Video; video: Video only.
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// The user ID of the teacher. User IDs are returned by the user registration APIs. The user specified will have teacher permissions in the room created.
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// Whether to automatically turn the mic on when the user enters a room. Valid values: 0: No (default value); 1: Yes.
        /// </summary>
        [JsonProperty("AutoMic")]
        public ulong? AutoMic{ get; set; }

        /// <summary>
        /// Whether to disconnect communication after audio/video permissions are revoked. Valid values: `0` (default): Yes; `1`: No.
        /// </summary>
        [JsonProperty("TurnOffMic")]
        public ulong? TurnOffMic{ get; set; }

        /// <summary>
        /// Whether to enable the high audio quality mode. Valid values: 0: No (default value); 1: Yes.
        /// </summary>
        [JsonProperty("AudioQuality")]
        public ulong? AudioQuality{ get; set; }

        /// <summary>
        /// Whether to disable auto recording. Valid values: 0: No (default); 1: Yes. If this parameter is 0, recording will start when the class starts and stops when the class ends.
        /// </summary>
        [JsonProperty("DisableRecord")]
        public ulong? DisableRecord{ get; set; }

        /// <summary>
        /// The user IDs of the teaching assistants. User IDs are returned by the user registration APIs. The users specified will have teaching assistant permissions in the room created.
        /// </summary>
        [JsonProperty("Assistants")]
        public string[] Assistants{ get; set; }

        /// <summary>
        /// The number of RTC users.
        /// </summary>
        [JsonProperty("RTCAudienceNumber")]
        public ulong? RTCAudienceNumber{ get; set; }

        /// <summary>
        /// The audience type.
        /// </summary>
        [JsonProperty("AudienceType")]
        public ulong? AudienceType{ get; set; }

        /// <summary>
        /// Recording layout
        /// </summary>
        [JsonProperty("RecordLayout")]
        public ulong? RecordLayout{ get; set; }

        /// <summary>
        /// The ID of the group to bind. If you specify this parameter, only members of the group can enter this room.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Whether the teacher/teaching assistant can control students' cameras/microphones without the students' consent. Valid values: 
        /// `0` (default): No (consent required)
        /// `1`: Yes (no consent required)
        /// </summary>
        [JsonProperty("EnableDirectControl")]
        public ulong? EnableDirectControl{ get; set; }

        /// <summary>
        /// Turn on focus mode. 0 Watch all character audio and video (default) 1 Watch only teachers and assistants
        /// </summary>
        [JsonProperty("InteractionMode")]
        public long? InteractionMode{ get; set; }

        /// <summary>
        /// Horizontal and vertical screen. 0: Horizontal screen  (default); 1: Vertical screen , currently only support mobile video type
        /// </summary>
        [JsonProperty("VideoOrientation")]
        public ulong? VideoOrientation{ get; set; }

        /// <summary>
        /// Enable after-class grading. 0: not on (default) 1: on
        /// </summary>
        [JsonProperty("IsGradingRequiredPostClass")]
        public long? IsGradingRequiredPostClass{ get; set; }

        /// <summary>
        /// Room Type: 0 Small Classroom(default); 1 Lecture Hall(public class)
        /// </summary>
        [JsonProperty("RoomType")]
        public long? RoomType{ get; set; }

        /// <summary>
        /// Drag class time: unit: minutes. 0: no limit (default), -1: can't drag class, greater than 0: the time of dragging class. maximum value: 120 minutes.
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
        /// Whether to start the lesson automatically: 0 not automatic lesson (default) 1 automatic lesson live_type=1 is valid when
        /// </summary>
        [JsonProperty("EnableAutoStart")]
        public ulong? EnableAutoStart{ get; set; }

        /// <summary>
        /// Recorded file background image, support png, jpg, jpeg, bmp format, does not support transparent channel for the time being
        /// </summary>
        [JsonProperty("RecordBackground")]
        public string RecordBackground{ get; set; }

        /// <summary>
        /// Record customized scene, only recordlayout=9 this parameter is valid, the data content for the user-defined scene parameters, data format for the json key-value pairs, where the key-value pairs of the value for the string type.
        /// </summary>
        [JsonProperty("RecordScene")]
        public string RecordScene{ get; set; }

        /// <summary>
        /// Record customized language, only when recordlayout=9, this parameter is valid.
        /// </summary>
        [JsonProperty("RecordLang")]
        [System.Obsolete]
        public string RecordLang{ get; set; }

        /// <summary>
        /// Recording type. 0: Records only mixed streams (default); 1: Records mixed streams and single streams. In this mode, in addition to the mixed streams, the audio and video streams of the teacher and students on stage are recorded separately. Each recording incurs corresponding recording fees. Example: 0.
        /// </summary>
        [JsonProperty("RecordStream")]
        public ulong? RecordStream{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MaxMicNumber", this.MaxMicNumber);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamSimple(map, prefix + "AutoMic", this.AutoMic);
            this.SetParamSimple(map, prefix + "TurnOffMic", this.TurnOffMic);
            this.SetParamSimple(map, prefix + "AudioQuality", this.AudioQuality);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamArraySimple(map, prefix + "Assistants.", this.Assistants);
            this.SetParamSimple(map, prefix + "RTCAudienceNumber", this.RTCAudienceNumber);
            this.SetParamSimple(map, prefix + "AudienceType", this.AudienceType);
            this.SetParamSimple(map, prefix + "RecordLayout", this.RecordLayout);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EnableDirectControl", this.EnableDirectControl);
            this.SetParamSimple(map, prefix + "InteractionMode", this.InteractionMode);
            this.SetParamSimple(map, prefix + "VideoOrientation", this.VideoOrientation);
            this.SetParamSimple(map, prefix + "IsGradingRequiredPostClass", this.IsGradingRequiredPostClass);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
            this.SetParamSimple(map, prefix + "EndDelayTime", this.EndDelayTime);
            this.SetParamSimple(map, prefix + "LiveType", this.LiveType);
            this.SetParamSimple(map, prefix + "RecordLiveUrl", this.RecordLiveUrl);
            this.SetParamSimple(map, prefix + "EnableAutoStart", this.EnableAutoStart);
            this.SetParamSimple(map, prefix + "RecordBackground", this.RecordBackground);
            this.SetParamSimple(map, prefix + "RecordScene", this.RecordScene);
            this.SetParamSimple(map, prefix + "RecordLang", this.RecordLang);
            this.SetParamSimple(map, prefix + "RecordStream", this.RecordStream);
        }
    }
}

