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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateJustInTimeTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Just in time transcoding template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Template description information. The length cannot exceed 256 characters. Empty by default.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Video stream switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>Default value: on.
        /// </summary>
        [JsonProperty("VideoStreamSwitch")]
        public string VideoStreamSwitch{ get; set; }

        /// <summary>
        /// Enable audio stream switch. Value:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>Default value: on.
        /// </summary>
        [JsonProperty("AudioStreamSwitch")]
        public string AudioStreamSwitch{ get; set; }

        /// <summary>
        /// Video stream configuration parameters. This field is required when VideoStreamSwitch is on.
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfo VideoTemplate{ get; set; }

        /// <summary>
        /// Audio stream configuration parameters. This field is required when AudioStreamSwitch is on.
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfo AudioTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "VideoStreamSwitch", this.VideoStreamSwitch);
            this.SetParamSimple(map, prefix + "AudioStreamSwitch", this.AudioStreamSwitch);
            this.SetParamObj(map, prefix + "VideoTemplate.", this.VideoTemplate);
            this.SetParamObj(map, prefix + "AudioTemplate.", this.AudioTemplate);
        }
    }
}

