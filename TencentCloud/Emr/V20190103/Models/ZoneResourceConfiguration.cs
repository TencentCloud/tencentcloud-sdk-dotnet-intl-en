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
        /// The VPC configuration information. This parameter is used to specify the VPC ID, subnet ID and other information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// The instance location. This parameter is used to specify the AZ, project, and other attributes of the instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// The specs of all nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllNodeResourceSpec")]
        public AllNodeResourceSpec AllNodeResourceSpec{ get; set; }

        /// <summary>
        /// Leave ZoneTag empty in the case of a single availability zone. In the case of a dual-AZ deployment, select master for the first availability zone's ZoneTag and standby for the second. In the case of a three-AZ deployment, select master for the first availability zone's ZoneTag, standby for the second, and third-party for the third. Valid values.
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

