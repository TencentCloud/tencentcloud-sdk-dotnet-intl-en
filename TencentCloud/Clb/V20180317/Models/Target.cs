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

    public class Target : AbstractModel
    {
        
        /// <summary>
        /// Specifies the listening port of the backend service.
        /// Note: this parameter must be specified when binding to CVM (cloud virtual machine) or ENI (elastic network interface).
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Specifies the backend service type. valid values: CVM (cloud virtual machine), ENI (elastic network interface). as an input parameter, this parameter does not take effect currently.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// This parameter must be passed in when binding to CVM. it represents the unique ID of the CVM and can be obtained from the InstanceId field in the response of the DescribeInstances api. indicates binding the primary IPv4 address of the primary network interface. the InstanceId cannot be specified in the following scenarios: binding to non-CVM resources, binding to auxiliary network interface ips on CVM, binding to CVM through cross-domain 2.0, and binding to IPv6 addresses of CVM.
        /// Note: you can only input one of the InstanceId parameter or the EniIp parameter.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The new forwarding weight of the real server. Value range: [0, 100]. Default: 10. This parameter takes priority over `Weight` in [`RsWeightRule`](https://intl.cloud.tencent.com/document/api/214/30694?from_cn_redirect=1#RsWeightRule). If it’s left empty, the value of `Weight` in `RsWeightRule` will be used.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// This parameter must be passed in for IP binding. it supports eni ips and other private IP addresses. if it is an eni, it must first be bound to a CVM before binding to a cloud load balancer instance.
        /// Note: only one of the InstanceId parameter and EniIp parameter can be passed. if binding a dual-stack IPV6 instance, this parameter must be passed. if it is a cross-region binding, the parameter must be passed and the InstanceId parameter is not supported.
        /// </summary>
        [JsonProperty("EniIp")]
        public string EniIp{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "EniIp", this.EniIp);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

