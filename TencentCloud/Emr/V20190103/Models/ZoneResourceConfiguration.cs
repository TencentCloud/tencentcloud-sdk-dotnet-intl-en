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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneResourceConfiguration : AbstractModel
    {
        
        /// <summary>
        /// VPC-related information configuration. This parameter can be used to specify the VPC ID and subnet ID.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// Location of the instance. This parameter can be used to specify attributes such as the AZ and associated project of the instance.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Specifications of all node resources.
        /// </summary>
        [JsonProperty("AllNodeResourceSpec")]
        public AllNodeResourceSpec AllNodeResourceSpec{ get; set; }

        /// <summary>
        /// In single-AZ deployment, ZoneTag can be left empty. In dual-AZ deployment mode, select master for the first AZ's ZoneTag and standby for the second. In three-AZ deployment mode, select master for the first AZ's ZoneTag, standby for the second, and third-party for the third. Valid values:
        ///   <li>master</li>
        ///   <li>standby</li>
        ///   <li>third-party</li>
        /// </summary>
        [JsonProperty("ZoneTag")]
        public string ZoneTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "AllNodeResourceSpec.", this.AllNodeResourceSpec);
            this.SetParamSimple(map, prefix + "ZoneTag", this.ZoneTag);
        }
    }
}

