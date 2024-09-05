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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceCreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// Network type of the CLB to query. `OPEN`: Public network; `INTERNAL`: Private network is intranet type
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// The billing mode to query. `POSTPAID`:Pay as you go
        /// </summary>
        [JsonProperty("LoadBalancerChargeType")]
        public string LoadBalancerChargeType{ get; set; }

        /// <summary>
        /// Reserved field
        /// </summary>
        [JsonProperty("LoadBalancerChargePrepaid")]
        public LBChargePrepaid LoadBalancerChargePrepaid{ get; set; }

        /// <summary>
        /// The network billing mode to query 
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// Number of CLB instances to query. Default value: 1.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// Availability zone in the format of "ap-guangzhou-1"
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Specification of the LCU-supported instance, which is input to query the monthly subscription price. Valid values: <li>clb.c2.medium: Standard</li><li>clb.c3.small: Advanced 1</li><li>clb.c3.medium: Advanced 2</li><li>clb.c4.small: Super Large 1</li><li>clb.c4.medium: Super Large 2</li><li>clb.c4.large: Super Large 3</li><li>clb.c4.xlarge: Super Large 4</li>SLA is input to query the pay-as-you-go price.
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// IP version. Valid values: `IPV4` (default), `IPV6` (IPV6 NAT64 version) or `IPv6FullChain` (IPv6 version). 
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// It only applies to public CLB. Currently, the static single-line IP type is supported only for the regions of Guangzhou, Shanghai, Nanjing, Jinan, Hangzhou, Fuzhou, Beijing, Shijiazhuang, Wuhan, Changsha, Chengdu, and Chongqing. If you need to experience it, contact your business manager. After approval, you can select the ISP type as China Mobile (CMCC), China Unicom (CUCC), or China Telecom (CTCC). The network billing mode should be selected as billing by bandwidth package (BANDWIDTH_PACKAGE). If this parameter is not specified, BGP is used by default. You can use the DescribeResources API to query ISPs supported for a region.
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "LoadBalancerChargeType", this.LoadBalancerChargeType);
            this.SetParamObj(map, prefix + "LoadBalancerChargePrepaid.", this.LoadBalancerChargePrepaid);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
        }
    }
}

