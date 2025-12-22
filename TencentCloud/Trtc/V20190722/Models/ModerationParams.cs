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

    public class ModerationParams : AbstractModel
    {
        
        /// <summary>
        /// Moderation task type. 1: audio slicing moderation; 2: video frame extraction moderation; 3: audio slicing moderation + video frame extraction moderation; 4: audio stream moderation; 5: audio stream moderation + video frame extraction moderation. The default value is 1. (Support from suppliers is required for stream moderation to take effect.)
        /// </summary>
        [JsonProperty("ModerationType")]
        public ulong? ModerationType{ get; set; }

        /// <summary>
        /// Slicing is stopped automatically when there is no user (anchor) performing upstream push in the room for more than MaxIdleTime. Unit: seconds. Default value: 30 seconds. This value needs to be greater than or equal to 5 seconds and less than or equal to 1800 seconds (0.5 hours). Example value: 30.
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// Audio slicing duration. Default value: 15s. Example value: 15.
        /// </summary>
        [JsonProperty("SliceAudio")]
        public ulong? SliceAudio{ get; set; }

        /// <summary>
        /// Interval for video frame extraction. Default value: 5s.
        /// </summary>
        [JsonProperty("SliceVideo")]
        public ulong? SliceVideo{ get; set; }

        /// <summary>
        /// Enumeration values for suppliers.
        /// tianyu: Tencent Tianyu content security. (Valid values: 1: audio slicing moderation; 2: video frame extraction moderation; 3: audio-visual slicing moderation + video frame extraction moderation.)
        /// ace: ACE content security. (Valid values: 1: audio slicing moderation; 2: video frame extraction moderation; 3: audio-visual slicing moderation + video frame extraction moderation.)
        /// shumei: shumei moderation. (Valid values: 1: audio slicing moderation; 2: video frame extraction moderation; 3: audio-visual slicing moderation + video frame extraction moderation.)
        /// Yidun: NetEase Yidun moderation. (Valid values: 1: audio slicing moderation; 2: video frame extraction moderation; 3: audio-visual slicing moderation + video frame extraction moderation.)
        /// </summary>
        [JsonProperty("ModerationSupplier")]
        public string ModerationSupplier{ get; set; }

        /// <summary>
        /// Configuration information required for submitting content to the third-party moderation supplier.
        /// </summary>
        [JsonProperty("ModerationSupplierParam")]
        public ModerationSupplierParam ModerationSupplierParam{ get; set; }

        /// <summary>
        /// Whether to save file. 0: not save by default; 1: save; 2 save the hit file.
        /// </summary>
        [JsonProperty("SaveModerationFile")]
        public ulong? SaveModerationFile{ get; set; }

        /// <summary>
        /// Whether to call back all moderation results: 
        /// 0: call back all results by default; 
        /// 1: only call back hit results.
        /// </summary>
        [JsonProperty("CallbackAllResults")]
        public ulong? CallbackAllResults{ get; set; }

        /// <summary>
        /// Specifies the allowlist or blocklist for the subscription stream.
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeModerationUserIds SubscribeStreamUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModerationType", this.ModerationType);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SliceAudio", this.SliceAudio);
            this.SetParamSimple(map, prefix + "SliceVideo", this.SliceVideo);
            this.SetParamSimple(map, prefix + "ModerationSupplier", this.ModerationSupplier);
            this.SetParamObj(map, prefix + "ModerationSupplierParam.", this.ModerationSupplierParam);
            this.SetParamSimple(map, prefix + "SaveModerationFile", this.SaveModerationFile);
            this.SetParamSimple(map, prefix + "CallbackAllResults", this.CallbackAllResults);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
        }
    }
}

