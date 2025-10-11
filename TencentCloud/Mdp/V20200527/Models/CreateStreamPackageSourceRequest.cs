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

    public class CreateStreamPackageSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// The location id to which this source belongs is required and uniquely bound to one location.
        /// </summary>
        [JsonProperty("AttachedLocation")]
        public string AttachedLocation{ get; set; }

        /// <summary>
        /// Source name, globally unique under location.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Distinguish between live broadcast and on-demand VOD source types. Optional values: Live, VOD.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// source specific configuration.
        /// </summary>
        [JsonProperty("PackageConfs")]
        public SourcePackageConf[] PackageConfs{ get; set; }

        /// <summary>
        /// The sourcetag allows ADS to deliver more precise ads based on the Source Tag information
        /// </summary>
        [JsonProperty("SourceTags")]
        public SourceTag[] SourceTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttachedLocation", this.AttachedLocation);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "PackageConfs.", this.PackageConfs);
            this.SetParamArrayObj(map, prefix + "SourceTags.", this.SourceTags);
        }
    }
}

