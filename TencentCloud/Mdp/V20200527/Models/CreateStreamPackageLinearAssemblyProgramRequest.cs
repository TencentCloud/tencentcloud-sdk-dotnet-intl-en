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

    public class CreateStreamPackageLinearAssemblyProgramRequest : AbstractModel
    {
        
        /// <summary>
        /// Program name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The bound channel.
        /// </summary>
        [JsonProperty("AttachedChannel")]
        public string AttachedChannel{ get; set; }

        /// <summary>
        /// The type of arrangement target source is divided into live broadcast and on-demand VOD.
        /// Optional values: Live, VOD.
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// The associated source location.
        /// </summary>
        [JsonProperty("SourceLocationId")]
        public string SourceLocationId{ get; set; }

        /// <summary>
        /// The associated live broadcast or on-demand broadcast, source name, and location are globally unique.
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// PlaybackConf.
        /// </summary>
        [JsonProperty("PlaybackConf")]
        public PlaybackInfoReq PlaybackConf{ get; set; }

        /// <summary>
        /// AdBreaks is only valid when the source type is Vod.
        /// </summary>
        [JsonProperty("AdBreaks")]
        public AdBreakInfo[] AdBreaks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AttachedChannel", this.AttachedChannel);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceLocationId", this.SourceLocationId);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamObj(map, prefix + "PlaybackConf.", this.PlaybackConf);
            this.SetParamArrayObj(map, prefix + "AdBreaks.", this.AdBreaks);
        }
    }
}

