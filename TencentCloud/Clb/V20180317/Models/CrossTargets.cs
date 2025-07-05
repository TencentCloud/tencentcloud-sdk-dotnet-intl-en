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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrossTargets : AbstractModel
    {
        
        /// <summary>
        /// VPC ID of the CLB instance
        /// </summary>
        [JsonProperty("LocalVpcId")]
        public string LocalVpcId{ get; set; }

        /// <summary>
        /// VPC ID of the CVM or ENI instance
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// IP address of the CVM or ENI instance
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// VPC name of the CVM or ENI instance
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// ENI ID of the CVM instance
        /// </summary>
        [JsonProperty("EniId")]
        public string EniId{ get; set; }

        /// <summary>
        /// ID of the CVM instance
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Name of the CVM instance
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Region of the CVM or ENI instance
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalVpcId", this.LocalVpcId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "EniId", this.EniId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

