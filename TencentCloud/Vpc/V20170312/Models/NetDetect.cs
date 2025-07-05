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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetDetect : AbstractModel
    {
        
        /// <summary>
        /// The ID of a VPC instance, such as `vpc-12345678`.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The name of a VPC instance.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// The ID of a subnet instance, such as subnet-12345678.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// The name of a subnet instance.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// The ID of a network detection instance, such as netd-12345678.
        /// </summary>
        [JsonProperty("NetDetectId")]
        public string NetDetectId{ get; set; }

        /// <summary>
        /// The name of a network detection instance. The maximum length is 60 characters.
        /// </summary>
        [JsonProperty("NetDetectName")]
        public string NetDetectName{ get; set; }

        /// <summary>
        /// The array of detection destination IPv4 addresses, which contains at most two IP addresses.
        /// </summary>
        [JsonProperty("DetectDestinationIp")]
        public string[] DetectDestinationIp{ get; set; }

        /// <summary>
        /// The array of detection source IPv4 addresses automatically allocated by the system. The length is 2.
        /// </summary>
        [JsonProperty("DetectSourceIp")]
        public string[] DetectSourceIp{ get; set; }

        /// <summary>
        /// Type of the next hop. Currently supported types are:
        /// VPN: VPN gateway;
        /// `DIRECTCONNECT`: Direct connect gateway;
        /// `PEERCONNECTION`: Peering connection;
        /// `NAT`: NAT gateway;
        /// `NORMAL_CVM`: CVM instance;
        /// `CCN`: CCN instance;
        /// `NONEXTHOP`: No next hop.
        /// </summary>
        [JsonProperty("NextHopType")]
        public string NextHopType{ get; set; }

        /// <summary>
        /// ID of the next-hop gateway.
        /// If NextHopType is set to VPN, the value of this parameter is the VPN gateway ID, such as vpngw-12345678.
        /// `NextHopType` = `DIRECTCONNECT`: Direct connect gateway ID, such as `dcg-12345678`.
        /// `NextHopType` = `PEERCONNECTION`: Peering connection ID, such as `pcx-12345678`.
        /// `NextHopType` = `NAT`: NAT gateway ID, such as `nat-12345678`.
        /// If NextHopType is set to NORMAL_CVM, the value of this parameter is the IPv4 address of the CVM, such as 10.0.0.12.
        /// `NextHopType` = `CCN`: CCN instance ID, such as `ccn-12345678`.
        /// `NextHopType` = `NONEXTHOP`: No next hop.
        /// </summary>
        [JsonProperty("NextHopDestination")]
        public string NextHopDestination{ get; set; }

        /// <summary>
        /// The name of the next-hop gateway.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NextHopName")]
        public string NextHopName{ get; set; }

        /// <summary>
        /// Network detection description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetDetectDescription")]
        public string NetDetectDescription{ get; set; }

        /// <summary>
        /// The creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "NetDetectId", this.NetDetectId);
            this.SetParamSimple(map, prefix + "NetDetectName", this.NetDetectName);
            this.SetParamArraySimple(map, prefix + "DetectDestinationIp.", this.DetectDestinationIp);
            this.SetParamArraySimple(map, prefix + "DetectSourceIp.", this.DetectSourceIp);
            this.SetParamSimple(map, prefix + "NextHopType", this.NextHopType);
            this.SetParamSimple(map, prefix + "NextHopDestination", this.NextHopDestination);
            this.SetParamSimple(map, prefix + "NextHopName", this.NextHopName);
            this.SetParamSimple(map, prefix + "NetDetectDescription", this.NetDetectDescription);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

