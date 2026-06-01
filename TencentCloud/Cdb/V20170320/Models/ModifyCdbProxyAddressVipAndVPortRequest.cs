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

    public class ModifyCdbProxyAddressVipAndVPortRequest : AbstractModel
    {
        
        /// <summary>
        /// Proxy group ID. Obtain through the [DescribeCdbProxyInfo](https://www.tencentcloud.com/document/api/236/90585?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// Proxy group address ID. Obtain through the [DescribeCdbProxyInfo](https://www.tencentcloud.com/document/api/236/90585?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("ProxyAddressId")]
        public string ProxyAddressId{ get; set; }

        /// <summary>
        /// VPC ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Private subnet ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// IP. If not specified, the system will assign an available IP under subnet.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Port. Default value 3306, value ranges from 1024 to 65535.
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// Old IP valid hours. Measurement unit: hr, default value: 24, value ranges from 0 to 168.
        /// </summary>
        [JsonProperty("ReleaseDuration")]
        public ulong? ReleaseDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "ProxyAddressId", this.ProxyAddressId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "ReleaseDuration", this.ReleaseDuration);
        }
    }
}

