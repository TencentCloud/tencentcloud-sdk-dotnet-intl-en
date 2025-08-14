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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instances : AbstractModel
    {
        
        /// <summary>
        /// User APPID, which is the unique application ID that matches an account. Some Tencent Cloud products use this APPID.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Region ID. <ul><li>1: Guangzhou;</li> <li>4: Shanghai;</li> <li>5: Hong Kong (China);</li> <li>7: Shanghai Finance;</li> <li>8: Beijing;</li> <li>9: Singapore;</li> <li>11: Shenzhen Finance;</li> <li>15: Western United States (Silicon Valley).</li></ul>
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Number of replicas
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public ulong? RedisReplicasNum{ get; set; }

        /// <summary>
        /// Number of shards
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// Shard memory size.
        /// </summary>
        [JsonProperty("RedisShardSize")]
        public long? RedisShardSize{ get; set; }

        /// <summary>
        /// Instance disk size.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Engine: Redis Community Edition, Tencent Cloud CKV.
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// Read-write permission of the instance. <ul><li>`rw`: Read/Write. </li><li>`r`: Read-only. </li></ul>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Instance VIP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// This parameter encounters a naming issue. It is recommended to use the parameter IPv6 instead. It is an internal parameter and can be ignored.
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// Internal parameter, which can be ignored.
        /// </summary>
        [JsonProperty("IPv6")]
        public string IPv6{ get; set; }

        /// <summary>
        /// VPC ID, such as `75101`.
        /// </summary>
        [JsonProperty("VpcID")]
        public long? VpcID{ get; set; }

        /// <summary>
        /// Instance port
        /// </summary>
        [JsonProperty("VPort")]
        public long? VPort{ get; set; }

        /// <summary>
        /// Instance status. <ul><li>`0`: Uninitialized. </li><li>`1`: In the process. </li><li>`2`: Running. </li><li>`-2`: Isolated. </li><li>`-3`: To be deleted. </li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Repository ID
        /// </summary>
        [JsonProperty("GrocerySysId")]
        public long? GrocerySysId{ get; set; }

        /// <summary>
        /// Instance type
        /// - `2`: Redis 2.8 Memory Edition (Standard Architecture).
        /// - `3`: CKV 3.2 Memory Edition (Standard Architecture).
        /// - `4`: CKV 3.2 Memory Edition (Cluster Architecture)
        /// - `5`: Redis 2.8 Memory Edition (Standalone)
        /// - `6`: Redis 4.0 Memory Edition (Standard Architecture).
        /// - `7`: Redis 4.0 Memory Edition (Cluster Architecture)
        /// - `8`: Redis 5.0 Memory Edition (Standard Architecture).
        /// - `9`: Redis 5.0 Memory Edition (Cluster Architecture)
        /// - `15`: Redis 6.2 Memory Edition (Standard Architecture).
        /// - `16`: Redis 6.2 Memory Edition (Cluster Architecture)
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// The time when the instance was added to the replication group.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The time when instances in the replication group were updated.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisShardSize", this.RedisShardSize);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "IPv6", this.IPv6);
            this.SetParamSimple(map, prefix + "VpcID", this.VpcID);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GrocerySysId", this.GrocerySysId);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

