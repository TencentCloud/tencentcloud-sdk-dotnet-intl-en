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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputInfo : AbstractModel
    {
        
        /// <summary>
        /// HLS DASH.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The output group name can be associated with the source group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// The file name output by the channel program after scheduling.
        /// </summary>
        [JsonProperty("ManifestName")]
        public string ManifestName{ get; set; }

        /// <summary>
        /// Advertisement configuration.
        /// </summary>
        [JsonProperty("ManifestConf")]
        public ManifestInfo ManifestConf{ get; set; }

        /// <summary>
        /// Playback address.
        /// </summary>
        [JsonProperty("PlaybackURL")]
        public string PlaybackURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ManifestName", this.ManifestName);
            this.SetParamObj(map, prefix + "ManifestConf.", this.ManifestConf);
            this.SetParamSimple(map, prefix + "PlaybackURL", this.PlaybackURL);
        }
    }
}

