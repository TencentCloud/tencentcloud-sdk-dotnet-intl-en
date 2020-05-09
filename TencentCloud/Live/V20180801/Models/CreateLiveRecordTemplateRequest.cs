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

    public class CreateLiveRecordTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name. Only letters, digits, underscores, and hyphens can be contained.
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
        /// Mp4 recording parameter, which is set when Mp4 recording is enabled.
        /// </summary>
        [JsonProperty("Mp4Param")]
        public RecordParam Mp4Param{ get; set; }

        /// <summary>
        /// AAC recording parameter, which is set when AAC recording is enabled.
        /// </summary>
        [JsonProperty("AacParam")]
        public RecordParam AacParam{ get; set; }

        /// <summary>
        /// LVB type. Default value: 0.
        /// 0: LVB.
        /// 1: LCB.
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }

        /// <summary>
        /// HLS-specific recording parameter.
        /// </summary>
        [JsonProperty("HlsSpecialParam")]
        public HlsSpecialParam HlsSpecialParam{ get; set; }

        /// <summary>
        /// Mp3 recording parameter, which is set when Mp3 recording is enabled.
        /// </summary>
        [JsonProperty("Mp3Param")]
        public RecordParam Mp3Param{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "FlvParam.", this.FlvParam);
            this.SetParamObj(map, prefix + "HlsParam.", this.HlsParam);
            this.SetParamObj(map, prefix + "Mp4Param.", this.Mp4Param);
            this.SetParamObj(map, prefix + "AacParam.", this.AacParam);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
            this.SetParamObj(map, prefix + "HlsSpecialParam.", this.HlsSpecialParam);
            this.SetParamObj(map, prefix + "Mp3Param.", this.Mp3Param);
        }
    }
}

