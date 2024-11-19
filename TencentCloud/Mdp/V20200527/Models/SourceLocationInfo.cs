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

    public class SourceLocationInfo : AbstractModel
    {
        
        /// <summary>
        /// ID, unique identification.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// SourceLocation name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// area.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// BaseUrl information.
        /// </summary>
        [JsonProperty("BaseUrl")]
        public string BaseUrl{ get; set; }

        /// <summary>
        /// Whether to enable patching.
        /// </summary>
        [JsonProperty("SegmentDeliverEnable")]
        public bool? SegmentDeliverEnable{ get; set; }

        /// <summary>
        /// Patch configuration.
        /// </summary>
        [JsonProperty("SegmentDeliverConf")]
        public SegmentDeliverInfo SegmentDeliverConf{ get; set; }

        /// <summary>
        /// List of bound live broadcast source ids.
        /// </summary>
        [JsonProperty("AttachedLiveSources")]
        public string[] AttachedLiveSources{ get; set; }

        /// <summary>
        /// List of bound on-demand source ids.
        /// </summary>
        [JsonProperty("AttachedVodSources")]
        public string[] AttachedVodSources{ get; set; }

        /// <summary>
        /// Source location creation time, Unix timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Source location last modified time, Unix timestamp.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// Whether to enable package distribution sharding, it is enabled by default.
        /// </summary>
        [JsonProperty("SegmentDeliverUsePackageEnable")]
        public bool? SegmentDeliverUsePackageEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BaseUrl", this.BaseUrl);
            this.SetParamSimple(map, prefix + "SegmentDeliverEnable", this.SegmentDeliverEnable);
            this.SetParamObj(map, prefix + "SegmentDeliverConf.", this.SegmentDeliverConf);
            this.SetParamArraySimple(map, prefix + "AttachedLiveSources.", this.AttachedLiveSources);
            this.SetParamArraySimple(map, prefix + "AttachedVodSources.", this.AttachedVodSources);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SegmentDeliverUsePackageEnable", this.SegmentDeliverUsePackageEnable);
        }
    }
}

