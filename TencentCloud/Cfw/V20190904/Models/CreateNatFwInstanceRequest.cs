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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNatFwInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Firewall instance name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Bandwidth
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Mode. 1: use existing; 0: create new
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// Parameter passed for the Create New mode. Either NewModeItems or NatgwList is required.
        /// </summary>
        [JsonProperty("NewModeItems")]
        public NewModeItems NewModeItems{ get; set; }

        /// <summary>
        /// NAT gateway list for the Using Existing mode. Either NewModeItems or NatgwList is required.
        /// </summary>
        [JsonProperty("NatGwList")]
        public string[] NatGwList{ get; set; }

        /// <summary>
        /// Primary zone. The default zone is selected if it is empty.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Secondary zone. The default zone is selected if it is empty.
        /// </summary>
        [JsonProperty("ZoneBak")]
        public string ZoneBak{ get; set; }

        /// <summary>
        /// Remote disaster recovery. 1: enable; 0: disable; empty: disable by default
        /// </summary>
        [JsonProperty("CrossAZone")]
        public long? CrossAZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "NewModeItems.", this.NewModeItems);
            this.SetParamArraySimple(map, prefix + "NatGwList.", this.NatGwList);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneBak", this.ZoneBak);
            this.SetParamSimple(map, prefix + "CrossAZone", this.CrossAZone);
        }
    }
}

