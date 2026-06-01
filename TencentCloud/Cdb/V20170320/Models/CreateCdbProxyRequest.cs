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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCdbProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VPC ID. Obtain through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Private subnet ID. Obtain through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Node specification configuration.
        /// Parameter description in the example.
        /// NodeCount: Number of nodes.
        /// Region: Node region.
        /// Zone: Node availability zone.
        /// Cpu: Number of cores per proxy node (unit: core).
        /// Mem: Memory size of each proxy node (unit: MB).
        /// Remarks:
        /// 1. Database proxy supported node specifications are: 2C4000MB, 4C8000MB, 8C16000MB.
        /// 2. The above parameters (such as number of nodes, availability zone) are required. When calling the API, if incomplete, creation may fail.
        /// </summary>
        [JsonProperty("ProxyNodeCustom")]
        public ProxyNodeCustom[] ProxyNodeCustom{ get; set; }

        /// <summary>
        /// Security group
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Connection pool threshold
        /// Note: If you need to use the database proxy connection pool capability, the kernel minor version of the MySQL 8.0 primary instance must be equal to or greater than MySQL 8.0 20230630.
        /// </summary>
        [JsonProperty("ConnectionPoolLimit")]
        public ulong? ConnectionPoolLimit{ get; set; }

        /// <summary>
        /// Specify the Linux kernel version of the purchased proxy. Leave it blank to ship the latest version by default.
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamArrayObj(map, prefix + "ProxyNodeCustom.", this.ProxyNodeCustom);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ConnectionPoolLimit", this.ConnectionPoolLimit);
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
        }
    }
}

