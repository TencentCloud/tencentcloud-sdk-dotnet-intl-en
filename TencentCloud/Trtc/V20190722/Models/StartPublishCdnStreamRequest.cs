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
        /// [SdkAppId](https://www.tencentcloud.comom/document/product/647/46351?from_cn_redirect=1#SdkAppId) of TRTC, which is the same as the SdkAppId corresponding to the relayed room.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Main room information RoomId, the RoomId corresponding to the TRTC room for relay.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Main room information RoomType must be the same as the RoomId type of the relayed room. 0 indicates integer type room id, and 1 indicates string room number.
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// Relay service bot parameters for joining TRTC room.
        /// </summary>
        [JsonProperty("AgentParams")]
        public AgentParams AgentParams{ get; set; }

        /// <summary>
        /// Whether to transcode. 0 indicates no need to transcode, 1 indicates requirement to transcode. whether to charge transcoding fee is determined by the WithTranscoding parameter. WithTranscoding set to 0 means bypass forwarding and no transcoding costs will be incurred. WithTranscoding set to 1 means mixed-stream relay and transcoding costs will be charged.
        /// Note: transcoding is required for stream mixing, and this parameter must be set to 1.
        /// </summary>
        [JsonProperty("WithTranscoding")]
        public ulong? WithTranscoding{ get; set; }

        /// <summary>
        /// Audio encoding parameters for stream retransmission. since audio must be transcoded (no transcoding costs will be incurred), this field is required when starting a task.
        /// </summary>
        [JsonProperty("AudioParams")]
        public McuAudioParams AudioParams{ get; set; }

        /// <summary>
        /// Video encoding parameters for the relay stream. leave blank for audio-only relay.
        /// </summary>
        [JsonProperty("VideoParams")]
        public McuVideoParams VideoParams{ get; set; }

        /// <summary>
        /// The user uplink parameters require single stream bypass forwarding. WithTranscoding needs to be set to 0 for single stream bypass forwarding.
        /// </summary>
        [JsonProperty("SingleSubscribeParams")]
        public SingleSubscribeParams SingleSubscribeParams{ get; set; }

        /// <summary>
        /// The CDN parameters for relay push support up to 10 push urls for a task. there must be one pushback room parameter.
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// Stream mixing SEI parameter.
        /// </summary>
        [JsonProperty("SeiParams")]
        public McuSeiParams SeiParams{ get; set; }

        /// <summary>
        /// Push back room information. a task supports up to 10 push rooms, and there must be one forward CDN parameter. note: use SDK version 10.4 or higher to push room. if you need assistance, contact tencent cloud technical support.
        /// </summary>
        [JsonProperty("FeedBackRoomParams")]
        public McuFeedBackRoomParams[] FeedBackRoomParams{ get; set; }

        /// <summary>
        /// Relay recording parameters. refer to the reference document (https://www.tencentcloud.comom/document/product/647/111748?from_cn_redirect=1).
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

