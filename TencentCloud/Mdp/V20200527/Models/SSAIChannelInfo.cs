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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSAIChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// SSAI configuration ID, globally unique identifier
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// Configuration name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Content source stream prefix
        /// </summary>
        [JsonProperty("ContentSource")]
        public string ContentSource{ get; set; }

        /// <summary>
        /// Generated playback address prefix
        /// </summary>
        [JsonProperty("PlaybackPrefix")]
        public string PlaybackPrefix{ get; set; }

        /// <summary>
        /// SSAI configuration info
        /// </summary>
        [JsonProperty("SSAIInfo")]
        public SSAIConf SSAIInfo{ get; set; }

        /// <summary>
        /// Region info
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ContentSource", this.ContentSource);
            this.SetParamSimple(map, prefix + "PlaybackPrefix", this.PlaybackPrefix);
            this.SetParamObj(map, prefix + "SSAIInfo.", this.SSAIInfo);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

