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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionListDetail : AbstractModel
    {
        
        /// <summary>
        /// Machine type
        /// CVM, Tencent Cloud Virtual Machine
        /// LH, TencentCloud Lighthouse
        /// ECM, Tencent Cloud Edge Computing Machine
        /// BM, Tencent BM 1.0
        /// Other, Other servers (non-Tencent Cloud)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 0 Tencent Cloud
        /// 1 IDC
        /// 2 Alibaba Cloud
        /// 3 Huawei Cloud
        /// 4 Amazon
        /// 5 Microsoft
        /// 6 Google
        /// 7 Oracle
        /// 8 Digital Ocean
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloudFrom")]
        public ulong? CloudFrom{ get; set; }

        /// <summary>
        /// List of regions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionList")]
        public RegionInfo[] RegionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "CloudFrom", this.CloudFrom);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
        }
    }
}

