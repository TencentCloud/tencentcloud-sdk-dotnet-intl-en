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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MasterInfo : AbstractModel
    {
        
        /// <summary>
        /// Region information
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// AZ ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// AZ information
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Long instance ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Instance status
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance type
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// Task status
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// Memory capacity
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Disk capacity
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// Instance model
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Queries per second
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// Dedicated cluster ID
        /// </summary>
        [JsonProperty("ExClusterId")]
        public string ExClusterId{ get; set; }

        /// <summary>
        /// Dedicated cluster name
        /// </summary>
        [JsonProperty("ExClusterName")]
        public string ExClusterName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ExClusterId", this.ExClusterId);
            this.SetParamSimple(map, prefix + "ExClusterName", this.ExClusterName);
        }
    }
}

