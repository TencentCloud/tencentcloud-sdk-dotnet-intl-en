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
        /// <p>Multi-AZ deployment selects three AZs, example [200002,200003,200004]<br>Single-AZ deployment selects one availability zone, example [200002]</p><p>When PULSAR.P2.MINI1 is selected, it only supports two AZs. Other models support three AZs.</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>Cluster specification code<br>See <a href="https://www.tencentcloud.com/document/product/1179/83705?from_cn_redirect=1">professional cluster specifications</a></p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>1: true, enable automatic monthly renewal</p><p>0: false, disable automatic monthly renewal</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>Purchase period, value ranges from 1 to 50</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Cluster name cannot be empty. It supports numbers, letters, Chinese, and symbols "-_=:.", with length not exceeding 64 characters.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Whether to automatically select voucher 1 Yes 0 No Default is 0</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>Storage specification<br>See <a href="https://www.tencentcloud.com/document/product/1179/83705?from_cn_redirect=1">professional cluster specifications</a></p>
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// <p>vpc network tag</p>
        /// </summary>
        [JsonProperty("Vpc")]
        public VpcInfo Vpc{ get; set; }

        /// <summary>
        /// <p>Tag list of the cluster (abandoned)</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Cluster version information</p>
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamObj(map, prefix + "Vpc.", this.Vpc);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
        }
    }
}

