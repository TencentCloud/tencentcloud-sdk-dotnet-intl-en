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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceScalingDownRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka cluster instance Id. can be obtained through the [DescribeInstances](https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Shrink mode. 1: stable mode. 
        /// 2. specifies high-speed configuration change.
        /// </summary>
        [JsonProperty("UpgradeStrategy")]
        public long? UpgradeStrategy{ get; set; }

        /// <summary>
        /// Specifies the disk capacity in GB. value range: maximum value 500000, step length 100.
        /// The specifications and limitations can be viewed through the following link: https://www.tencentcloud.com/document/product/597/122562.?from_cn_redirect=1
        /// 
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Peak bandwidth in MB/s.
        /// Specifies the url (https://www.tencentcloud.com/document/product/597/11745?from_cn_redirect=1) to view specification limits and corresponding step length.
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// Partition upper limit maximum value of 40000, step length 100.
        /// Specification limits can be viewed through the following link: https://www.tencentcloud.com/document/product/597/122563.?from_cn_redirect=1
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpgradeStrategy", this.UpgradeStrategy);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
        }
    }
}

