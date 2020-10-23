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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// Channel ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Channel status.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Information of associated input.
        /// </summary>
        [JsonProperty("AttachedInputs")]
        public AttachedInputInfo[] AttachedInputs{ get; set; }

        /// <summary>
        /// Information of output group.
        /// </summary>
        [JsonProperty("OutputGroups")]
        public OutputGroupsInfo[] OutputGroups{ get; set; }

        /// <summary>
        /// Channel name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Audio transcoding template array.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioTemplates")]
        public AudioTemplateInfo[] AudioTemplates{ get; set; }

        /// <summary>
        /// Video transcoding template array.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoTemplates")]
        public VideoTemplateInfo[] VideoTemplates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "AttachedInputs.", this.AttachedInputs);
            this.SetParamArrayObj(map, prefix + "OutputGroups.", this.OutputGroups);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "AudioTemplates.", this.AudioTemplates);
            this.SetParamArrayObj(map, prefix + "VideoTemplates.", this.VideoTemplates);
        }
    }
}

