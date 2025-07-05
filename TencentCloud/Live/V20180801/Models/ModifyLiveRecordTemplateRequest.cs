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

    public class ModifyLiveRecordTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template ID obtained through the `DescribeRecordTemplates` API.
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// Template name.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Message description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// FLV recording parameter, which is set when FLV recording is enabled.
        /// </summary>
        [JsonProperty("FlvParam")]
        public RecordParam FlvParam{ get; set; }

        /// <summary>
        /// HLS recording parameter, which is set when HLS recording is enabled.
        /// </summary>
        [JsonProperty("HlsParam")]
        public RecordParam HlsParam{ get; set; }

        /// <summary>
        /// MP4 recording parameter, which is set when MP4 recording is enabled.
        /// </summary>
        [JsonProperty("Mp4Param")]
        public RecordParam Mp4Param{ get; set; }

        /// <summary>
        /// AAC recording parameter, which is set when AAC recording is enabled.
        /// </summary>
        [JsonProperty("AacParam")]
        public RecordParam AacParam{ get; set; }

        /// <summary>
        /// Custom HLS recording parameter.
        /// </summary>
        [JsonProperty("HlsSpecialParam")]
        public HlsSpecialParam HlsSpecialParam{ get; set; }

        /// <summary>
        /// MP3 recording parameter, which is set when MP3 recording is enabled.
        /// </summary>
        [JsonProperty("Mp3Param")]
        public RecordParam Mp3Param{ get; set; }

        /// <summary>
        /// Whether to remove the watermark. This parameter is invalid if `IsDelayLive` is `1`.
        /// </summary>
        [JsonProperty("RemoveWatermark")]
        public bool? RemoveWatermark{ get; set; }

        /// <summary>
        /// A special parameter for FLV recording.
        /// </summary>
        [JsonProperty("FlvSpecialParam")]
        public FlvSpecialParam FlvSpecialParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "FlvParam.", this.FlvParam);
            this.SetParamObj(map, prefix + "HlsParam.", this.HlsParam);
            this.SetParamObj(map, prefix + "Mp4Param.", this.Mp4Param);
            this.SetParamObj(map, prefix + "AacParam.", this.AacParam);
            this.SetParamObj(map, prefix + "HlsSpecialParam.", this.HlsSpecialParam);
            this.SetParamObj(map, prefix + "Mp3Param.", this.Mp3Param);
            this.SetParamSimple(map, prefix + "RemoveWatermark", this.RemoveWatermark);
            this.SetParamObj(map, prefix + "FlvSpecialParam.", this.FlvSpecialParam);
        }
    }
}

