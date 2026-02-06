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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies multi-az deployment with three azs, for example [200002,200003,200004].
        /// 
        /// Single-AZ deployment selects an availability zone. example: [200002].
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Cluster specification code.
        /// Refers to professional cluster specifications (https://www.tencentcloud.com/document/product/1179/83705?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Specifies the storage specification.
        /// Refers to professional cluster specifications (https://www.tencentcloud.com/document/product/1179/83705?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// `1`: true. enables automatic monthly renewal.
        /// 
        /// false. disables automatic monthly renewal.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Purchase duration. value range: 1–50.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Specifies the cluster name, which does not support chinese characters and special characters other than hyphens and underscores, with a length of no more than 64 characters.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Whether to automatically select voucher. valid values: 1 (yes), 0 (no). default is 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Specifies the vpc network tag.
        /// </summary>
        [JsonProperty("Vpc")]
        public VpcInfo Vpc{ get; set; }

        /// <summary>
        /// Tag list of the cluster (abandoned).
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamObj(map, prefix + "Vpc.", this.Vpc);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

