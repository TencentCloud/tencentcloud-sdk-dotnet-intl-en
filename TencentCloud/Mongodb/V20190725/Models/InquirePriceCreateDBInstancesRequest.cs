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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceCreateDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance region name in the format of ap-guangzhou-2.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        ///  - Specifies the number of primary and secondary nodes for each replica set during replica set instance creation. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain the maximum and minimum number of nodes supported for each replica set.
        ///  - Specifies the number of primary and secondary nodes for each shard during sharded cluster instance creation. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to obtain the maximum and minimum number of nodes supported for each shard.
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// Instance memory size.
        /// 
        ///  - Unit: GB.
        ///  - For the value range, call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API. The CPU and Memory parameters in the returned data structure SpecItems correspond to the number of CPU cores and the memory specification, respectively.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance disk size.
        ///  - Unit: GB.
        ///  - For the value range, call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API. The MinStorage and MaxStorage parameters in the returned data structure SpecItems correspond to the minimum and maximum disk specifications, respectively.
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// Instance version information. For specific supported versions, call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API. The MongoVersionCode parameter in the returned data structure SpecItems indicates the information on versions supported for instances. The correspondence between version information and version number is as follows:
        ///  - MONGO_36_WT: version of the MongoDB 3.6 WiredTiger storage engine.
        ///  - MONGO_40_WT: version of the MongoDB 4.0 WiredTiger storage engine.
        ///  - MONGO_42_WT: version of the MongoDB 4.2 WiredTiger storage engine.
        ///  - MONGO_44_WT: version of the MongoDB 4.4 WiredTiger storage engine.
        ///  - MONGO_50_WT: version of the MongoDB 5.0 WiredTiger storage engine.
        ///  - MONGO_60_WT: version of the MongoDB 6.0 WiredTiger storage engine.
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// Product specification type.
        ///  - HIO10G: general high-I/O 10GE type.
        ///  - HCD: cloud disk.
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// Number of instances. Minimum value: 1. Maximum value: 10.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// Instance type.
        /// 
        ///  - REPLSET: replica set.
        ///  - SHARD: sharded cluster.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        ///  - Specifies the number of replica sets during replica set instance creation. This parameter can only be set to 1.
        ///  - Specifies the number of shards during sharded cluster instance creation. Call the [DescribeSpecInfo](https://intl.cloud.tencent.com/document/product/240/38567?from_cn_redirect=1) API to query the range of shard quantity. The parameters MinReplicateSetNum and MaxReplicateSetNum in the returned data structure SpecItems correspond to the minimum value and maximum value, respectively.
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public long? ReplicateSetNum{ get; set; }

        /// <summary>
        ///  - When the monthly subscription mode is selected, that is, when <b>InstanceChargeType</b> is set to <b>PREPAID</b>, this parameter is required for specifying the purchase duration of instances. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, and 36. Unit: months.
        ///  - When pay-as-you-go is selected, that is, when <b>InstanceChargeType</b> is set to **POSTPAID_BY_HOUR**, this parameter only can be set to 1.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Instance payment method.
        ///  - PREPAID: monthly subscription.
        ///  - POSTPAID_BY_HOUR: pay-as-you-go.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Number of Mongos node CPU cores. Valid values: 1, 2, 4, 8, and 16. This parameter is required during sharded cluster instance purchase. If this parameter is left blank, the default value 2 is used.
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// Mongos node memory size. - This parameter is required during sharded cluster instance purchase. - Unit: GB. Valid values: 2 (for 1 core), 4 (for 2 cores), 8 (for 4 cores), 16 (for 8 cores), and 32 (for 16 cores). If this parameter is left blank, the default value 4 is used.
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// Specifies the number of Mongos nodes. Value range: [3,32]. For querying the price of sharded cluster instances, this parameter is required. If it is left blank, the default value 3 is used.
        /// </summary>
        [JsonProperty("MongosNum")]
        public ulong? MongosNum{ get; set; }

        /// <summary>
        /// Specifies the number of ConfigServer CPU cores. The value is fixed as 1.
        /// </summary>
        [JsonProperty("ConfigServerCpu")]
        public ulong? ConfigServerCpu{ get; set; }

        /// <summary>
        /// Specifies the ConfigServer memory size. The value is fixed as 2. Unit: GB. This parameter can be left blank.
        /// </summary>
        [JsonProperty("ConfigServerMemory")]
        public ulong? ConfigServerMemory{ get; set; }

        /// <summary>
        /// Specifies the ConfigServer disk size. The value is fixed as 20. Unit: GB. This parameter can be left blank.
        /// </summary>
        [JsonProperty("ConfigServerVolume")]
        public ulong? ConfigServerVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "MongosCpu", this.MongosCpu);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamSimple(map, prefix + "MongosNum", this.MongosNum);
            this.SetParamSimple(map, prefix + "ConfigServerCpu", this.ConfigServerCpu);
            this.SetParamSimple(map, prefix + "ConfigServerMemory", this.ConfigServerMemory);
            this.SetParamSimple(map, prefix + "ConfigServerVolume", this.ConfigServerVolume);
        }
    }
}

