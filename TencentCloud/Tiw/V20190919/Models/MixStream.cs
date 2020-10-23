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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MixStream : AbstractModel
    {
        
        /// <summary>
        /// Whether stream mixing is enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Whether audio stream mixing is disabled
        /// </summary>
        [JsonProperty("DisableAudio")]
        public bool? DisableAudio{ get; set; }

        /// <summary>
        /// ID of the embedded mixed stream layout template. Valid values: 1 and 2. For more information on the differences of both values, see the sample embedded mixed stream layout template.
        /// If the Custom field is not specified, ModelId is required.
        /// </summary>
        [JsonProperty("ModelId")]
        public long? ModelId{ get; set; }

        /// <summary>
        /// ID of a teacher account
        /// This field is valid only when ModelId is specified.
        /// If you specify TeacherID for a user, the user's video stream will be displayed in the first image of the embedded template.
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// Custom mixed stream layout parameter
        /// If this parameter is available, the ModelId and TeacherId fields will be ignored.
        /// </summary>
        [JsonProperty("Custom")]
        public CustomLayout Custom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DisableAudio", this.DisableAudio);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamObj(map, prefix + "Custom.", this.Custom);
        }
    }
}

