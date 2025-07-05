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

    public class ModifyStreamPackageSourceLocationRequest : AbstractModel
    {
        
        /// <summary>
        /// SourceLocation Id.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Modified name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// BaseUrl.
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
            this.SetParamSimple(map, prefix + "BaseUrl", this.BaseUrl);
            this.SetParamSimple(map, prefix + "SegmentDeliverEnable", this.SegmentDeliverEnable);
            this.SetParamObj(map, prefix + "SegmentDeliverConf.", this.SegmentDeliverConf);
            this.SetParamSimple(map, prefix + "SegmentDeliverUsePackageEnable", this.SegmentDeliverUsePackageEnable);
        }
    }
}

