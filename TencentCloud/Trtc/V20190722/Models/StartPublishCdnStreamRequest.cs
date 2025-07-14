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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartPublishCdnStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// The [SDKAppID](https://intl.cloud.tencent.com/document/product/647/37714) of the TRTC room whose streams are relayed.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// The ID of the room whose streams are relayed (the main room).
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// The type of the `RoomId` parameter, which must be the same as the ID type of the room whose streams are relayed. 0: integer; 1: string.
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// The information of the relaying robot in the room.
        /// </summary>
        [JsonProperty("AgentParams")]
        public AgentParams AgentParams{ get; set; }

        /// <summary>
        /// Whether to transcode the streams. `0`: No. `1`: Yes. This parameter determines whether transcoding fees are charged. If it is `0`, streams will only be relayed, and no transcoding fees will be incurred. If it is `1`, streams will be transcoded before being relayed, and transcoding fees will be incurred.
        /// </summary>
        [JsonProperty("WithTranscoding")]
        public ulong? WithTranscoding{ get; set; }

        /// <summary>
        /// The audio encoding parameters. Because audio is always transcoded (no fees are incurred), this parameter is required when you start a relay task.
        /// </summary>
        [JsonProperty("AudioParams")]
        public McuAudioParams AudioParams{ get; set; }

        /// <summary>
        /// The video encoding parameters for relaying. If you do not pass this parameter, only audio will be relayed.
        /// </summary>
        [JsonProperty("VideoParams")]
        public McuVideoParams VideoParams{ get; set; }

        /// <summary>
        /// The information of a single stream relayed. When you relay a single stream, set `WithTranscoding` to 0.
        /// </summary>
        [JsonProperty("SingleSubscribeParams")]
        public SingleSubscribeParams SingleSubscribeParams{ get; set; }

        /// <summary>
        /// The information of the CDNs to relay to. You need to specify at least one between this parameter and `FeedBackRoomParams.N`.
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// The stream mixing SEI parameters.
        /// </summary>
        [JsonProperty("SeiParams")]
        public McuSeiParams SeiParams{ get; set; }

        /// <summary>
        /// The information of the room to which streams are relayed. Between this parameter and `PublishCdnParams`, you must specify at least one. Please note that relaying to a TRTC room is only supported in some SDK versions. For details, please contact technical support.
        /// </summary>
        [JsonProperty("FeedBackRoomParams")]
        public McuFeedBackRoomParams[] FeedBackRoomParams{ get; set; }

        /// <summary>
        /// Relay Recording Parameters.
        /// Example value:{"UniRecord":1,"RecordKey": "test_recore_key_a"}
        /// </summary>
        [JsonProperty("RecordParams")]
        public McuRecordParams RecordParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "AgentParams.", this.AgentParams);
            this.SetParamSimple(map, prefix + "WithTranscoding", this.WithTranscoding);
            this.SetParamObj(map, prefix + "AudioParams.", this.AudioParams);
            this.SetParamObj(map, prefix + "VideoParams.", this.VideoParams);
            this.SetParamObj(map, prefix + "SingleSubscribeParams.", this.SingleSubscribeParams);
            this.SetParamArrayObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
            this.SetParamObj(map, prefix + "SeiParams.", this.SeiParams);
            this.SetParamArrayObj(map, prefix + "FeedBackRoomParams.", this.FeedBackRoomParams);
            this.SetParamObj(map, prefix + "RecordParams.", this.RecordParams);
        }
    }
}

