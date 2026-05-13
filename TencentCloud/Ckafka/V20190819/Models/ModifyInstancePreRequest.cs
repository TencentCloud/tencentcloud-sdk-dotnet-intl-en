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

    public class ModifyInstancePreRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id, which can be obtained through the <a href="https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1">DescribeInstances</a> API</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Disk size in GB. Maximum value is 500000 with a step length of 100. View specification limits through the following url: https://www.tencentcloud.com/document/product/597/122562?from_cn_redirect=1</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>Peak bandwidth in MB/s can be accessed through the following link to view specifications limit and corresponding step length: https://www.tencentcloud.com/document/product/597/11745?from_cn_redirect=1</p>
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// <p>Partition upper limit maximum value: 40000, step length: 100. View specification limits through the following URL: https://www.tencentcloud.com/document/product/597/122563?from_cn_redirect=1</p>
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
        }
    }
}

