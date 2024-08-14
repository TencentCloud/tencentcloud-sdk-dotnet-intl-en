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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartStreamIngestRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC's [SdkAppId](https://intl.cloud.tencent.com/document/product/647/46351?from_cn_redirect=1#sdkappid), the same as the SdkAppId corresponding to the Record room.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC's [RoomId](https://intl.cloud.tencent.com/document/product/647/46351?from_cn_redirect=1#roomid), the RoomId corresponding to the Record TRTC room.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Type of TRTC RoomId. [*Note] Must be the same as the RoomId type corresponding to the Record room: 0: String type RoomId 1: 32-bit Integer type RoomId (default)
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// UserId of the Pull stream Relay Robot, used to enter the room and initiate the Pull stream Relay Task.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// UserSig corresponding to the Pull stream Relay Robot UserId, i.e., UserId and UserSig are equivalent to the Robot's Login password for entering the room. For the specific Calculation method, please refer to the TRTC [UserSig](https://www.tencentcloud.com/zh/document/product/647/39074) Scheme.
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// The Url of the media resource.
        /// </summary>
        [JsonProperty("StreamUrl")]
        public string StreamUrl{ get; set; }

        /// <summary>
        /// TRTC room permission Encryption ticket, only needed when advanced permission control is enabled in the Console. After enabling advanced permission control in the TRTC Console, TRTC's backend service system will verify a so-called [PrivateMapKey] 'Permission ticket', which contains an encrypted RoomId and an encrypted 'Permission bit list'. Since PrivateMapKey contains RoomId, providing only UserSig without PrivateMapKey does not allow entry into the specified room.
        /// </summary>
        [JsonProperty("PrivateMapKey")]
        public string PrivateMapKey{ get; set; }

        /// <summary>
        /// Video Codec Parameters. Optional, if not filled, Keep original stream Parameters.
        /// </summary>
        [JsonProperty("VideoEncodeParams")]
        [System.Obsolete]
        public VideoEncodeParams VideoEncodeParams{ get; set; }

        /// <summary>
        /// Audio Codec Parameters. Optional, if not filled, Keep original stream Parameters.
        /// </summary>
        [JsonProperty("AudioEncodeParams")]
        [System.Obsolete]
        public AudioEncodeParams AudioEncodeParams{ get; set; }

        /// <summary>
        /// 	
        /// Source URL. Example value: https://a.b/test.mp4
        /// </summary>
        [JsonProperty("SourceUrl")]
        [System.Obsolete]
        public string[] SourceUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SeekSecond")]
        public long? SeekSecond{ get; set; }

        /// <summary>
        /// Enable auto relay to cdn, please make sure that this feature has been enabled in the console.
        /// </summary>
        [JsonProperty("AutoPush")]
        public bool? AutoPush{ get; set; }

        /// <summary>
        /// Loop playback count, value range: [-1, 1000], default is 1 time. - 0 is an invalid value - -1 is for loop playback, task termination requires actively calling the stop interface or setting MaxDuration.
        /// </summary>
        [JsonProperty("RepeatNum")]
        public long? RepeatNum{ get; set; }

        /// <summary>
        /// Loop playback maximum duration, only effective when RepeatNum is set to -1, valid value range: [1, 10080], unit: minutes
        /// </summary>
        [JsonProperty("MaxDuration")]
        public long? MaxDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamSimple(map, prefix + "StreamUrl", this.StreamUrl);
            this.SetParamSimple(map, prefix + "PrivateMapKey", this.PrivateMapKey);
            this.SetParamObj(map, prefix + "VideoEncodeParams.", this.VideoEncodeParams);
            this.SetParamObj(map, prefix + "AudioEncodeParams.", this.AudioEncodeParams);
            this.SetParamArraySimple(map, prefix + "SourceUrl.", this.SourceUrl);
            this.SetParamSimple(map, prefix + "SeekSecond", this.SeekSecond);
            this.SetParamSimple(map, prefix + "AutoPush", this.AutoPush);
            this.SetParamSimple(map, prefix + "RepeatNum", this.RepeatNum);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
        }
    }
}

